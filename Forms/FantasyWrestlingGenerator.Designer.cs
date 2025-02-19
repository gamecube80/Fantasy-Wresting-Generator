
namespace FantasyWrestlingGenerator
{
    partial class FantasyWrestlingGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            comboBoxWrestler2 = new ComboBox();
            comboBoxStage = new ComboBox();
            labelStage = new Label();
            labelWrestler1 = new Label();
            label1 = new Label();
            comboBoxWrestler1 = new ComboBox();
            buttonCreateNewStage = new Button();
            buttonFight = new Button();
            buttonNewWrestler = new Button();
            textBoxFightDisplay = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // comboBoxWrestler2
            // 
            comboBoxWrestler2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxWrestler2.FormattingEnabled = true;
            comboBoxWrestler2.Items.AddRange(new object[] { "- Select -" });
            comboBoxWrestler2.Location = new Point(535, 23);
            comboBoxWrestler2.Name = "comboBoxWrestler2";
            comboBoxWrestler2.Size = new Size(262, 23);
            comboBoxWrestler2.TabIndex = 5;
            // 
            // comboBoxStage
            // 
            comboBoxStage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxStage.FormattingEnabled = true;
            comboBoxStage.Items.AddRange(new object[] { "- Select -" });
            comboBoxStage.Location = new Point(269, 23);
            comboBoxStage.Name = "comboBoxStage";
            comboBoxStage.Size = new Size(260, 23);
            comboBoxStage.TabIndex = 4;
            // 
            // labelStage
            // 
            labelStage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelStage.AutoSize = true;
            labelStage.Location = new Point(269, 0);
            labelStage.Name = "labelStage";
            labelStage.Size = new Size(260, 20);
            labelStage.TabIndex = 2;
            labelStage.Text = "Stage";
            labelStage.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelWrestler1
            // 
            labelWrestler1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelWrestler1.AutoSize = true;
            labelWrestler1.Location = new Point(3, 0);
            labelWrestler1.Name = "labelWrestler1";
            labelWrestler1.Size = new Size(260, 20);
            labelWrestler1.TabIndex = 0;
            labelWrestler1.Text = "Wrestler 1";
            labelWrestler1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(535, 0);
            label1.Name = "label1";
            label1.Size = new Size(262, 20);
            label1.TabIndex = 1;
            label1.Text = "Wrestler 2";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxWrestler1
            // 
            comboBoxWrestler1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBoxWrestler1.DisplayMember = "Name";
            comboBoxWrestler1.FormattingEnabled = true;
            comboBoxWrestler1.Items.AddRange(new object[] { "- Select -" });
            comboBoxWrestler1.Location = new Point(3, 23);
            comboBoxWrestler1.Name = "comboBoxWrestler1";
            comboBoxWrestler1.Size = new Size(260, 23);
            comboBoxWrestler1.TabIndex = 3;
            comboBoxWrestler1.ValueMember = "Id";
            // 
            // buttonCreateNewStage
            // 
            buttonCreateNewStage.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateNewStage.Location = new Point(3, 423);
            buttonCreateNewStage.Name = "buttonCreateNewStage";
            buttonCreateNewStage.Size = new Size(100, 24);
            buttonCreateNewStage.TabIndex = 7;
            buttonCreateNewStage.Text = "New Stage";
            buttonCreateNewStage.UseVisualStyleBackColor = true;
            // 
            // buttonFight
            // 
            buttonFight.Anchor = AnchorStyles.Bottom;
            buttonFight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonFight.Location = new Point(349, 423);
            buttonFight.Name = "buttonFight";
            buttonFight.Size = new Size(100, 24);
            buttonFight.TabIndex = 6;
            buttonFight.Text = "Fight";
            buttonFight.UseVisualStyleBackColor = true;
            buttonFight.Click += ButtonFight_Click;
            // 
            // buttonNewWrestler
            // 
            buttonNewWrestler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNewWrestler.Location = new Point(697, 423);
            buttonNewWrestler.Name = "buttonNewWrestler";
            buttonNewWrestler.Size = new Size(100, 24);
            buttonNewWrestler.TabIndex = 8;
            buttonNewWrestler.Text = "New Wrestler";
            buttonNewWrestler.UseVisualStyleBackColor = true;
            // 
            // textBoxFightDisplay
            // 
            tableLayoutPanel2.SetColumnSpan(textBoxFightDisplay, 3);
            textBoxFightDisplay.Dock = DockStyle.Fill;
            textBoxFightDisplay.Location = new Point(3, 53);
            textBoxFightDisplay.Multiline = true;
            textBoxFightDisplay.Name = "textBoxFightDisplay";
            textBoxFightDisplay.ReadOnly = true;
            textBoxFightDisplay.ScrollBars = ScrollBars.Vertical;
            textBoxFightDisplay.Size = new Size(794, 364);
            textBoxFightDisplay.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.Controls.Add(buttonNewWrestler, 2, 3);
            tableLayoutPanel2.Controls.Add(buttonFight, 1, 3);
            tableLayoutPanel2.Controls.Add(buttonCreateNewStage, 0, 3);
            tableLayoutPanel2.Controls.Add(comboBoxWrestler2, 2, 1);
            tableLayoutPanel2.Controls.Add(labelWrestler1, 0, 0);
            tableLayoutPanel2.Controls.Add(comboBoxStage, 1, 1);
            tableLayoutPanel2.Controls.Add(labelStage, 1, 0);
            tableLayoutPanel2.Controls.Add(comboBoxWrestler1, 0, 1);
            tableLayoutPanel2.Controls.Add(label1, 2, 0);
            tableLayoutPanel2.Controls.Add(textBoxFightDisplay, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(800, 450);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // FantasyWrestlingGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel2);
            Name = "FantasyWrestlingGenerator";
            Text = "Fantasy Wrestling Generator";
            Load += FantasyWrestlingGenerator_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox comboBoxWrestler2;
        private ComboBox comboBoxStage;
        private Label labelStage;
        private Label labelWrestler1;
        private Label label1;
        private ComboBox comboBoxWrestler1;
        private Button buttonCreateNewStage;
        private Button buttonFight;
        private Button buttonNewWrestler;
        private TextBox textBoxFightDisplay;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
