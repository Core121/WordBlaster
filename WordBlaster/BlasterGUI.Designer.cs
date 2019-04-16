namespace WordBlaster
{
    partial class WordBlasterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordBlasterForm));
            this.Lane1Panel = new System.Windows.Forms.Panel();
            this.Lane2Panel = new System.Windows.Forms.Panel();
            this.Lane3Panel = new System.Windows.Forms.Panel();
            this.Lane4Panel = new System.Windows.Forms.Panel();
            this.Lane5Panel = new System.Windows.Forms.Panel();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.IntScoreLabel = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.IntLevelLabel = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.StartGamebutton = new System.Windows.Forms.Button();
            this.RemoveLettercheckBox = new System.Windows.Forms.CheckBox();
            this.ReverseWordcheckBox = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.WarningLabel = new System.Windows.Forms.Label();
            this.LoadLevelbutton = new System.Windows.Forms.Button();
            this.StopGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumCharsPerMinlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lane1Panel
            // 
            this.Lane1Panel.BackColor = System.Drawing.SystemColors.ControlText;
            this.Lane1Panel.Location = new System.Drawing.Point(27, 28);
            this.Lane1Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lane1Panel.Name = "Lane1Panel";
            this.Lane1Panel.Size = new System.Drawing.Size(1017, 97);
            this.Lane1Panel.TabIndex = 0;
            this.Lane1Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Lane1Panel_Paint);
            // 
            // Lane2Panel
            // 
            this.Lane2Panel.BackColor = System.Drawing.SystemColors.InfoText;
            this.Lane2Panel.Location = new System.Drawing.Point(27, 130);
            this.Lane2Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lane2Panel.Name = "Lane2Panel";
            this.Lane2Panel.Size = new System.Drawing.Size(1017, 97);
            this.Lane2Panel.TabIndex = 1;
            // 
            // Lane3Panel
            // 
            this.Lane3Panel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Lane3Panel.Location = new System.Drawing.Point(27, 234);
            this.Lane3Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lane3Panel.Name = "Lane3Panel";
            this.Lane3Panel.Size = new System.Drawing.Size(1017, 97);
            this.Lane3Panel.TabIndex = 1;
            // 
            // Lane4Panel
            // 
            this.Lane4Panel.BackColor = System.Drawing.SystemColors.InfoText;
            this.Lane4Panel.Location = new System.Drawing.Point(27, 337);
            this.Lane4Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lane4Panel.Name = "Lane4Panel";
            this.Lane4Panel.Size = new System.Drawing.Size(1017, 97);
            this.Lane4Panel.TabIndex = 1;
            // 
            // Lane5Panel
            // 
            this.Lane5Panel.BackColor = System.Drawing.SystemColors.InfoText;
            this.Lane5Panel.Location = new System.Drawing.Point(27, 441);
            this.Lane5Panel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lane5Panel.Name = "Lane5Panel";
            this.Lane5Panel.Size = new System.Drawing.Size(1017, 97);
            this.Lane5Panel.TabIndex = 2;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.ScoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(1077, 96);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(74, 23);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "Score:";
            this.ScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IntScoreLabel
            // 
            this.IntScoreLabel.AutoSize = true;
            this.IntScoreLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.IntScoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntScoreLabel.Location = new System.Drawing.Point(1153, 96);
            this.IntScoreLabel.Name = "IntScoreLabel";
            this.IntScoreLabel.Size = new System.Drawing.Size(22, 23);
            this.IntScoreLabel.TabIndex = 4;
            this.IntScoreLabel.Text = "0";
            this.IntScoreLabel.Click += new System.EventHandler(this.IntScoreLabel_Click);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.LevelLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(1077, 130);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(68, 23);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "Level:";
            // 
            // IntLevelLabel
            // 
            this.IntLevelLabel.AutoSize = true;
            this.IntLevelLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.IntLevelLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntLevelLabel.Location = new System.Drawing.Point(1153, 130);
            this.IntLevelLabel.Name = "IntLevelLabel";
            this.IntLevelLabel.Size = new System.Drawing.Size(22, 23);
            this.IntLevelLabel.TabIndex = 6;
            this.IntLevelLabel.Text = "0";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(425, 585);
            this.InputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(212, 22);
            this.InputTextBox.TabIndex = 7;
            this.InputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.InputTextBox.TextChanged += new System.EventHandler(this.InputTextBox_TextChanged);
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.Info;
            this.EnterButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EnterButton.BackgroundImage")));
            this.EnterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterButton.Font = new System.Drawing.Font("Bauhaus 93", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(644, 575);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(103, 46);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // StartGamebutton
            // 
            this.StartGamebutton.BackColor = System.Drawing.SystemColors.ControlText;
            this.StartGamebutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartGamebutton.BackgroundImage")));
            this.StartGamebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGamebutton.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGamebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartGamebutton.Location = new System.Drawing.Point(1081, 366);
            this.StartGamebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartGamebutton.Name = "StartGamebutton";
            this.StartGamebutton.Size = new System.Drawing.Size(131, 69);
            this.StartGamebutton.TabIndex = 9;
            this.StartGamebutton.Text = "Start Game";
            this.StartGamebutton.UseVisualStyleBackColor = false;
            this.StartGamebutton.Click += new System.EventHandler(this.StartGamebutton_Click);
            // 
            // RemoveLettercheckBox
            // 
            this.RemoveLettercheckBox.AutoSize = true;
            this.RemoveLettercheckBox.BackColor = System.Drawing.Color.DarkOrange;
            this.RemoveLettercheckBox.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveLettercheckBox.Image = ((System.Drawing.Image)(resources.GetObject("RemoveLettercheckBox.Image")));
            this.RemoveLettercheckBox.Location = new System.Drawing.Point(1081, 500);
            this.RemoveLettercheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveLettercheckBox.Name = "RemoveLettercheckBox";
            this.RemoveLettercheckBox.Size = new System.Drawing.Size(124, 22);
            this.RemoveLettercheckBox.TabIndex = 10;
            this.RemoveLettercheckBox.Text = "Remove Letter";
            this.RemoveLettercheckBox.UseVisualStyleBackColor = false;
            this.RemoveLettercheckBox.CheckedChanged += new System.EventHandler(this.RemoveLettercheckBox_CheckedChanged);
            // 
            // ReverseWordcheckBox
            // 
            this.ReverseWordcheckBox.AutoSize = true;
            this.ReverseWordcheckBox.BackColor = System.Drawing.Color.DarkOrange;
            this.ReverseWordcheckBox.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReverseWordcheckBox.Image = ((System.Drawing.Image)(resources.GetObject("ReverseWordcheckBox.Image")));
            this.ReverseWordcheckBox.Location = new System.Drawing.Point(1081, 528);
            this.ReverseWordcheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReverseWordcheckBox.Name = "ReverseWordcheckBox";
            this.ReverseWordcheckBox.Size = new System.Drawing.Size(119, 22);
            this.ReverseWordcheckBox.TabIndex = 11;
            this.ReverseWordcheckBox.Text = "Reverse Word";
            this.ReverseWordcheckBox.UseVisualStyleBackColor = false;
            this.ReverseWordcheckBox.CheckedChanged += new System.EventHandler(this.ReverseWordcheckBox_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AllowDrop = true;
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.BackColor = System.Drawing.Color.DarkOrange;
            this.WarningLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.WarningLabel.Location = new System.Drawing.Point(820, 555);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(390, 19);
            this.WarningLabel.TabIndex = 13;
            this.WarningLabel.Text = "*If harder game modes are applied, type the ORIGINAL word";
            // 
            // LoadLevelbutton
            // 
            this.LoadLevelbutton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.LoadLevelbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadLevelbutton.BackgroundImage")));
            this.LoadLevelbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadLevelbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadLevelbutton.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadLevelbutton.Location = new System.Drawing.Point(1077, 28);
            this.LoadLevelbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadLevelbutton.Name = "LoadLevelbutton";
            this.LoadLevelbutton.Size = new System.Drawing.Size(135, 31);
            this.LoadLevelbutton.TabIndex = 14;
            this.LoadLevelbutton.Text = "Load Level";
            this.LoadLevelbutton.UseVisualStyleBackColor = false;
            this.LoadLevelbutton.Click += new System.EventHandler(this.LoadLevelbutton_Click);
            // 
            // StopGameButton
            // 
            this.StopGameButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StopGameButton.BackgroundImage")));
            this.StopGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StopGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StopGameButton.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopGameButton.Location = new System.Drawing.Point(1083, 441);
            this.StopGameButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopGameButton.Name = "StopGameButton";
            this.StopGameButton.Size = new System.Drawing.Size(129, 42);
            this.StopGameButton.TabIndex = 16;
            this.StopGameButton.Text = "Stop Game";
            this.StopGameButton.UseVisualStyleBackColor = true;
            this.StopGameButton.Click += new System.EventHandler(this.StopGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Words/Min:";
            // 
            // NumCharsPerMinlabel
            // 
            this.NumCharsPerMinlabel.AutoSize = true;
            this.NumCharsPerMinlabel.BackColor = System.Drawing.Color.DarkOrange;
            this.NumCharsPerMinlabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumCharsPerMinlabel.Location = new System.Drawing.Point(134, 578);
            this.NumCharsPerMinlabel.Name = "NumCharsPerMinlabel";
            this.NumCharsPerMinlabel.Size = new System.Drawing.Size(16, 16);
            this.NumCharsPerMinlabel.TabIndex = 18;
            this.NumCharsPerMinlabel.Text = "0";
            // 
            // WordBlasterForm
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1224, 658);
            this.Controls.Add(this.NumCharsPerMinlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StopGameButton);
            this.Controls.Add(this.LoadLevelbutton);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.ReverseWordcheckBox);
            this.Controls.Add(this.RemoveLettercheckBox);
            this.Controls.Add(this.StartGamebutton);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.InputTextBox);
            this.Controls.Add(this.IntLevelLabel);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.IntScoreLabel);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Lane5Panel);
            this.Controls.Add(this.Lane4Panel);
            this.Controls.Add(this.Lane3Panel);
            this.Controls.Add(this.Lane2Panel);
            this.Controls.Add(this.Lane1Panel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1242, 705);
            this.MinimumSize = new System.Drawing.Size(1242, 705);
            this.Name = "WordBlasterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Blaster";
            this.Load += new System.EventHandler(this.WordBlasterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Lane1Panel;
        private System.Windows.Forms.Panel Lane2Panel;
        private System.Windows.Forms.Panel Lane3Panel;
        private System.Windows.Forms.Panel Lane4Panel;
        private System.Windows.Forms.Panel Lane5Panel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label IntScoreLabel;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.Label IntLevelLabel;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.Button StartGamebutton;
        private System.Windows.Forms.CheckBox RemoveLettercheckBox;
        private System.Windows.Forms.CheckBox ReverseWordcheckBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Button LoadLevelbutton;
        private System.Windows.Forms.Button StopGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NumCharsPerMinlabel;
    }
}

