using Microsoft.Data.Sqlite;

namespace FantasyWrestlingGenerator {
    public partial class FantasyWrestlingGenerator: Form {
        private readonly string _dbPath;
        private readonly string _connectionString;

        public FantasyWrestlingGenerator() {
            _dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "FantasyWrestlers.db");
            _connectionString = $"Data Source={_dbPath};";

            InitializeComponent();
        }

        private static SqliteDataReader ExecuteReader(string query, SqliteConnection connection, Dictionary<string, object>? parameters = null) {
            var command = new SqliteCommand(query, connection);

            // Add parameters if provided
            if(parameters != null) {
                foreach(var param in parameters) {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }
            }

            return command.ExecuteReader();  // The caller is responsible for closing this reader
        }

        private void FantasyWrestlingGenerator_Load(object sender, EventArgs e) {
            LoadWrestlerNames();
            LoadStageNames();
        }

        private void LoadWrestlerNames() {
            List<string> wrestlerNames = [ "- Select -" ];

            using(var connection = new SqliteConnection(_connectionString)) {
                connection.Open();  // Open connection once

                string selectQuery = "SELECT Name, Nickname FROM Wrestlers WHERE IsAlive = 1;";

                using var reader = ExecuteReader(selectQuery, connection);
                while(reader.Read()) {
                    string nickname = reader.IsDBNull(1) ? "No Nickname" : reader.GetString(1);
                    wrestlerNames.Add($"\"{nickname}\" {reader.GetString(0)}");
                }
            }

            // Bind the list to the ComboBox
            comboBoxWrestler1.DataSource = new List<string>(wrestlerNames);
            comboBoxWrestler2.DataSource = new List<string>(wrestlerNames);
        }

        private void LoadStageNames() {
            List<string> stageNames = [ "- Select -" ];

            using(var connection = new SqliteConnection(_connectionString)) {
                connection.Open();  // Open connection once

                string selectQuery = "SELECT Name From Stages";

                using var reader = ExecuteReader(selectQuery, connection);
                while(reader.Read()) {
                    stageNames.Add($"{reader.GetString(0)}");
                }
            }

            comboBoxStage.DataSource = stageNames;
        }

    }
}
