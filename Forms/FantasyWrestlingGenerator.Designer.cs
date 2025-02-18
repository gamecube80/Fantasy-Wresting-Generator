
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
            tableLayoutPanel1 = new TableLayoutPanel();
            comboBoxWrestler2 = new ComboBox();
            comboBoxStage = new ComboBox();
            labelStage = new Label();
            labelWrestler1 = new Label();
            label1 = new Label();
            comboBoxWrestler1 = new ComboBox();
            buttonCreateNewStage = new Button();
            buttonFight = new Button();
            buttonNewWrestler = new Button();
            textBox1 = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel1.Controls.Add(comboBoxWrestler2, 2, 1);
            tableLayoutPanel1.Controls.Add(comboBoxStage, 1, 1);
            tableLayoutPanel1.Controls.Add(labelStage, 1, 0);
            tableLayoutPanel1.Controls.Add(labelWrestler1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 2, 0);
            tableLayoutPanel1.Controls.Add(comboBoxWrestler1, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonCreateNewStage, 0, 3);
            tableLayoutPanel1.Controls.Add(buttonFight, 1, 3);
            tableLayoutPanel1.Controls.Add(buttonNewWrestler, 2, 3);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 2);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(776, 426);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBoxWrestler2
            // 
            comboBoxWrestler2.FormattingEnabled = true;
            comboBoxWrestler2.Items.AddRange(new object[] { "- Select -" });
            comboBoxWrestler2.Location = new Point(519, 18);
            comboBoxWrestler2.Name = "comboBoxWrestler2";
            comboBoxWrestler2.Size = new Size(252, 23);
            comboBoxWrestler2.TabIndex = 5;
            // 
            // comboBoxStage
            // 
            comboBoxStage.FormattingEnabled = true;
            comboBoxStage.Items.AddRange(new object[] { "- Select -" });
            comboBoxStage.Location = new Point(261, 18);
            comboBoxStage.Name = "comboBoxStage";
            comboBoxStage.Size = new Size(252, 23);
            comboBoxStage.TabIndex = 4;
            // 
            // labelStage
            // 
            labelStage.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelStage.AutoSize = true;
            labelStage.Location = new Point(261, 0);
            labelStage.Name = "labelStage";
            labelStage.Size = new Size(252, 15);
            labelStage.TabIndex = 2;
            labelStage.Text = "Stage";
            labelStage.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelWrestler1
            // 
            labelWrestler1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelWrestler1.AutoSize = true;
            labelWrestler1.Location = new Point(3, 0);
            labelWrestler1.Name = "labelWrestler1";
            labelWrestler1.Size = new Size(252, 15);
            labelWrestler1.TabIndex = 0;
            labelWrestler1.Text = "Wrestler 1";
            labelWrestler1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(519, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 15);
            label1.TabIndex = 1;
            label1.Text = "Wrestler 2";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // comboBoxWrestler1
            // 
            comboBoxWrestler1.FormattingEnabled = true;
            comboBoxWrestler1.Items.AddRange(new object[] { "- Select -" });
            comboBoxWrestler1.Location = new Point(3, 18);
            comboBoxWrestler1.Name = "comboBoxWrestler1";
            comboBoxWrestler1.Size = new Size(252, 23);
            comboBoxWrestler1.TabIndex = 3;
            // 
            // buttonCreateNewStage
            // 
            buttonCreateNewStage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreateNewStage.Location = new Point(3, 398);
            buttonCreateNewStage.Name = "buttonCreateNewStage";
            buttonCreateNewStage.Size = new Size(100, 25);
            buttonCreateNewStage.TabIndex = 7;
            buttonCreateNewStage.Text = "New Stage";
            buttonCreateNewStage.UseVisualStyleBackColor = true;
            // 
            // buttonFight
            // 
            buttonFight.Anchor = AnchorStyles.Bottom;
            buttonFight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            buttonFight.Location = new Point(337, 398);
            buttonFight.Name = "buttonFight";
            buttonFight.Size = new Size(100, 25);
            buttonFight.TabIndex = 6;
            buttonFight.Text = "Fight";
            buttonFight.UseVisualStyleBackColor = true;
            // 
            // buttonNewWrestler
            // 
            buttonNewWrestler.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonNewWrestler.Location = new Point(673, 398);
            buttonNewWrestler.Name = "buttonNewWrestler";
            buttonNewWrestler.Size = new Size(100, 25);
            buttonNewWrestler.TabIndex = 8;
            buttonNewWrestler.Text = "New Wrestler";
            buttonNewWrestler.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            tableLayoutPanel1.SetColumnSpan(textBox1, 3);
            textBox1.Location = new Point(3, 47);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(768, 345);
            textBox1.TabIndex = 9;
            // 
            // FantasyWrestlingGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "FantasyWrestlingGenerator";
            Text = "Fantasy Wrestling Generator";
            Load += FantasyWrestlingGenerator_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox comboBoxWrestler2;
        private ComboBox comboBoxStage;
        private Label labelStage;
        private Label labelWrestler1;
        private Label label1;
        private ComboBox comboBoxWrestler1;
        private Button buttonFight;
        private Button buttonCreateNewStage;
        private Button buttonNewWrestler;
        private TextBox textBox1;
    }
}
