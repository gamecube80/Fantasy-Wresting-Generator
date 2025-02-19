using FantasyWrestlingGenerator.Model;
using FantasyWrestlingGenerator.Helpers;
using Microsoft.Data.Sqlite;
using System.ComponentModel;
using System.Text;

namespace FantasyWrestlingGenerator {
    public partial class FantasyWrestlingGenerator: Form {
        private readonly FantasyWrestlingGeneratorHelper _helper = new();

        private readonly List<Wrestler> _wrestlers;
        private readonly List<Move> _moves;
        private readonly List<Stage> _stages;

        public FantasyWrestlingGenerator() {
            _wrestlers = _helper.GetWrestlers();
            _moves = _helper.GetMoves();
            _stages = _helper.GetStages();
            
            InitializeComponent();
        }

        private void FantasyWrestlingGenerator_Load(object sender, EventArgs e) {
            LoadWrestlerNames();
            LoadStageNames();
        }

        private void LoadWrestlerNames() {
            // Create two separate lists for each combo box to avoid shared reference issues
            var wrestlerList1 = new List<object> { new { Id = -1, DisplayName = "- Select -" } };
            var wrestlerList2 = new List<object> { new { Id = -1, DisplayName = "- Select -" } };

            // Append wrestlers to each list
            wrestlerList1.AddRange(_wrestlers.Select(wrestler => new {
                wrestler.Id,
                DisplayName = wrestler.NickName != null
                    ? $"\"{wrestler.NickName}\" {wrestler.Name}"
                    : wrestler.Name
            }));

            wrestlerList2.AddRange(_wrestlers.Select(wrestler => new {
                wrestler.Id,
                DisplayName = wrestler.NickName != null
                    ? $"\"{wrestler.NickName}\" {wrestler.Name}"
                    : wrestler.Name
            }));

            // Bind each list to its respective ComboBox
            comboBoxWrestler1.DataSource = wrestlerList1;
            comboBoxWrestler2.DataSource = wrestlerList2;

            // Set DisplayMember and ValueMember for each ComboBox
            comboBoxWrestler1.DisplayMember = "DisplayName";
            comboBoxWrestler1.ValueMember = "Id";

            comboBoxWrestler2.DisplayMember = "DisplayName";
            comboBoxWrestler2.ValueMember = "Id";

            // Set default selection to "- Select -"
            comboBoxWrestler1.SelectedValue = -1;
            comboBoxWrestler2.SelectedValue = -1;
        }

        private void LoadStageNames() {
            var stageDisplayList = new List<object> { new { Id = -1, Name = "- Select -" } };

            stageDisplayList.AddRange(_stages
                .Select(stage => new {
                    stage.Id,
                    stage.Name
                }));

            comboBoxStage.DataSource = stageDisplayList;

            comboBoxStage.DisplayMember = "Name";
            comboBoxStage.ValueMember = "Id";
        }


        private void ButtonFight_Click(object sender, EventArgs e) {
            int wrestler1Id = Convert.ToInt32(comboBoxWrestler1.SelectedValue);
            int wrestler2Id = Convert.ToInt32(comboBoxWrestler2.SelectedValue);
            int stageId = Convert.ToInt32(comboBoxStage.SelectedValue);

            StringBuilder errorStrings = new();
            bool valid = true;
            valid = ValidateSelection(valid, errorStrings, wrestler1Id, wrestler2Id, stageId);

            if(!valid) {
                MessageBox.Show(errorStrings.ToString(), "Invalid selections");
                return;
            }

            Wrestler wrestler1 = _wrestlers.Single(w => w.Id == wrestler1Id);
            Wrestler wrestler2 = _wrestlers.Single(w => w.Id == wrestler2Id);


            Fight(wrestler1, wrestler2);
        }

        private static bool ValidateSelection(bool valid, StringBuilder errorStrings, int wrestler1Id, int wrestler2Id, int stageId) {
            if(wrestler1Id <= 0) {
                errorStrings.AppendLine("Please select a valid option for wrestler 1");
                valid = false;
            }
            if(wrestler2Id <= 0) {
                errorStrings.AppendLine("Please select a valid option for wrestler 2");
                valid = false;
            }
            if(stageId <= 0) {
                errorStrings.AppendLine("Please select a valid stage");
                valid = false;
            }

            return valid;
        }

        private void Fight(Wrestler wrestler1, Wrestler wrestler2) {
            bool fighting = true;
            int stamina1 = wrestler1.BaseStamina;
            int stamina2 = wrestler2.BaseStamina;

            int test = 0;

            textBoxFightDisplay.Text = string.Empty;

            while(fighting) {
                List<(int roll, Wrestler wrestler)> turnOrder = GetTurnOrder(wrestler1, wrestler2);

                // Process moves in order
                foreach(var (roll, wrestler) in turnOrder) {
                    textBoxFightDisplay.AppendText($"{(wrestler.NickName != null ? $"\"{wrestler.NickName}\" " : string.Empty)}{wrestler.Name} attacks with roll: {roll}{Environment.NewLine}");

                    // Implement move execution, stamina reduction, etc.
                }

                textBoxFightDisplay.AppendText(Environment.NewLine);

                Application.DoEvents();

                test++;
                if (test > 3) {
                    fighting = false;
                }
            }
        }

        private List<(int roll, Wrestler wrestler)> GetTurnOrder(Wrestler wrestler1, Wrestler wrestler2) {
            List<(int roll, Wrestler wrester)> turnOrder = [];

            int numberMoves = RollRNG(2, 4);
            textBoxFightDisplay.AppendText($"Rolled {numberMoves} moves for this turn.{Environment.NewLine}");

            // Each wrestler rolls for each move
            for(int i = 0; i < numberMoves; i++) {
                turnOrder.Add((RollRNG(), wrestler1)); // Roll between 1-100
                turnOrder.Add((RollRNG(), wrestler2));
            }

            // Sort moves in descending order (highest roll first)
            turnOrder.Sort((a, b) => b.roll.CompareTo(a.roll));

            return [.. turnOrder.Take(numberMoves)];
        }

        private static int RollRNG(int min = 1, int max = 100) {
            Random random = new();
            return random.Next(min, max + 1);
        }
    }
}
