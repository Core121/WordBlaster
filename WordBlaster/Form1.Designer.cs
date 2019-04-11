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
            this.SuspendLayout();
            // 
            // Lane1Panel
            // 
            this.Lane1Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Lane1Panel.Location = new System.Drawing.Point(26, 28);
            this.Lane1Panel.Name = "Lane1Panel";
            this.Lane1Panel.Size = new System.Drawing.Size(1017, 97);
            this.Lane1Panel.TabIndex = 0;
            this.Lane1Panel.Paint += new System.Windows.Forms.PaintEventHandler(this.Lane1Panel_Paint);
            // 
            // Lane2Panel
            // 
            this.Lane2Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Lane2Panel.Location = new System.Drawing.Point(26, 131);
            this.Lane2Panel.Name = "Lane2Panel";
            this.Lane2Panel.Size = new System.Drawing.Size(1017, 97);
            this.Lane2Panel.TabIndex = 1;
            // 
            // Lane3Panel
            // 
            this.Lane3Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Lane3Panel.Location = new System.Drawing.Point(26, 234);
            this.Lane3Panel.Name = "Lane3Panel";
            this.Lane3Panel.Size = new System.Drawing.Size(1017, 97);
            this.Lane3Panel.TabIndex = 1;
            // 
            // Lane4Panel
            // 
            this.Lane4Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Lane4Panel.Location = new System.Drawing.Point(26, 337);
            this.Lane4Panel.Name = "Lane4Panel";
            this.Lane4Panel.Size = new System.Drawing.Size(1017, 97);
            this.Lane4Panel.TabIndex = 1;
            // 
            // Lane5Panel
            // 
            this.Lane5Panel.BackColor = System.Drawing.SystemColors.Control;
            this.Lane5Panel.Location = new System.Drawing.Point(26, 440);
            this.Lane5Panel.Name = "Lane5Panel";
            this.Lane5Panel.Size = new System.Drawing.Size(1017, 97);
            this.Lane5Panel.TabIndex = 2;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(1073, 74);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(74, 23);
            this.ScoreLabel.TabIndex = 3;
            this.ScoreLabel.Text = "Score:";
            this.ScoreLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // IntScoreLabel
            // 
            this.IntScoreLabel.AutoSize = true;
            this.IntScoreLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntScoreLabel.Location = new System.Drawing.Point(1153, 74);
            this.IntScoreLabel.Name = "IntScoreLabel";
            this.IntScoreLabel.Size = new System.Drawing.Size(22, 23);
            this.IntScoreLabel.TabIndex = 4;
            this.IntScoreLabel.Text = "0";
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LevelLabel.Location = new System.Drawing.Point(1077, 131);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(68, 23);
            this.LevelLabel.TabIndex = 5;
            this.LevelLabel.Text = "Level:";
            // 
            // IntLevelLabel
            // 
            this.IntLevelLabel.AutoSize = true;
            this.IntLevelLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntLevelLabel.Location = new System.Drawing.Point(1153, 131);
            this.IntLevelLabel.Name = "IntLevelLabel";
            this.IntLevelLabel.Size = new System.Drawing.Size(22, 23);
            this.IntLevelLabel.TabIndex = 6;
            this.IntLevelLabel.Text = "0";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(425, 585);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(186, 22);
            this.InputTextBox.TabIndex = 7;
            this.InputTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnterButton
            // 
            this.EnterButton.BackColor = System.Drawing.SystemColors.Info;
            this.EnterButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterButton.Location = new System.Drawing.Point(644, 578);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(87, 37);
            this.EnterButton.TabIndex = 8;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = false;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // StartGamebutton
            // 
            this.StartGamebutton.BackColor = System.Drawing.SystemColors.Info;
            this.StartGamebutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGamebutton.Location = new System.Drawing.Point(1081, 386);
            this.StartGamebutton.Name = "StartGamebutton";
            this.StartGamebutton.Size = new System.Drawing.Size(94, 48);
            this.StartGamebutton.TabIndex = 9;
            this.StartGamebutton.Text = "Start Game";
            this.StartGamebutton.UseVisualStyleBackColor = false;
            this.StartGamebutton.Click += new System.EventHandler(this.StartGamebutton_Click);
            // 
            // WordBlasterForm
            // 
            this.AcceptButton = this.EnterButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1226, 661);
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
            this.MinimumSize = new System.Drawing.Size(1244, 708);
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
    }
}

