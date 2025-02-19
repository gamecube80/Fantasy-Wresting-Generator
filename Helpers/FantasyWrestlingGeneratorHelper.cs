using FantasyWrestlingGenerator.Model;
using Microsoft.Data.Sqlite;

namespace FantasyWrestlingGenerator.Helpers {
    class FantasyWrestlingGeneratorHelper {
        private readonly string _dbPath;
        private readonly string _connectionString;

        internal FantasyWrestlingGeneratorHelper() {
            _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "FantasyWrestlers.db");
            _connectionString = $"Data Source={_dbPath};";
        }

        #region Database Functions
        internal static SqliteDataReader ExecuteReader(string query, SqliteConnection connection, Dictionary<string, object>? parameters = null) {
            var command = new SqliteCommand(query, connection);

            // Add parameters if provided
            if(parameters != null) {
                foreach(var param in parameters) {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            return command.ExecuteReader();  // The caller is responsible for closing this reader
        }
        #endregion

        #region Get Lists
        private List<T> GetData<T>(string query, Func<SqliteDataReader, T> mapFunction) {
            List<T> items = [];

            using(var connection = new SqliteConnection(_connectionString)) {
                connection.Open();
                using var reader = ExecuteReader(query, connection);
                while(reader.Read()) {
                    items.Add(mapFunction(reader));
                }
            }

            return items;
        }

        internal List<Wrestler> GetWrestlers() =>
    GetData("SELECT Id, Name, NickName, WeightClass, BaseStamina, IsAlive FROM Wrestlers",
        reader => new Wrestler {
            Id = reader.GetInt32(0),
            Name = reader.GetString(1),
            NickName = reader.IsDBNull(2) ? null : reader.GetString(2),
            WeightClass = reader.IsDBNull(3) ? null : reader.GetString(3),
            BaseStamina = reader.GetInt32(4),
            IsAlive = reader.GetBoolean(5)
        });

        internal List<Move> GetMoves() =>
            GetData("SELECT Id, Name, BaseWeight, Type, Damage, Wrestler_Id FROM Moves",
                reader => new Move {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    BaseWeight = reader.GetInt32(2),
                    Type = reader.GetString(3),
                    Damage = reader.GetInt32(4),
                    Wrestler_ID = reader.IsDBNull(5) ? null : reader.GetInt32(5)
                });

        internal List<Stage> GetStages() =>
            GetData("SELECT Id, Name, Description FROM Stages",
                reader => new Stage {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Description = reader.IsDBNull(2) ? null : reader.GetString(2)
                });
        #endregion

    }
}
