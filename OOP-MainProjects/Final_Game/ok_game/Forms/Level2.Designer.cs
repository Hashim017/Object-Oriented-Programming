
namespace ok_game
{
    partial class Level2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Level2));
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.GhostTimer = new System.Windows.Forms.Timer(this.components);
            this.RestartButton = new System.Windows.Forms.Button();
            this.LivesBox = new System.Windows.Forms.TextBox();
            this.LivesLabel = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
            this.lbl_won = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GameLoop
            // 
            this.GameLoop.Enabled = true;
            this.GameLoop.Tick += new System.EventHandler(this.GameLoop_Tick);
            // 
            // GhostTimer
            // 
            this.GhostTimer.Enabled = true;
            this.GhostTimer.Interval = 150;
            this.GhostTimer.Tick += new System.EventHandler(this.GhostTimer_Tick);
            // 
            // RestartButton
            // 
            resources.ApplyResources(this.RestartButton, "RestartButton");
            this.RestartButton.BackColor = System.Drawing.Color.Black;
            this.RestartButton.ForeColor = System.Drawing.Color.Red;
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // LivesBox
            // 
            resources.ApplyResources(this.LivesBox, "LivesBox");
            this.LivesBox.BackColor = System.Drawing.Color.Black;
            this.LivesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LivesBox.ForeColor = System.Drawing.Color.Yellow;
            this.LivesBox.Name = "LivesBox";
            this.LivesBox.ReadOnly = true;
            this.LivesBox.TextChanged += new System.EventHandler(this.LivesBox_TextChanged);
            // 
            // LivesLabel
            // 
            resources.ApplyResources(this.LivesLabel, "LivesLabel");
            this.LivesLabel.BackColor = System.Drawing.Color.Transparent;
            this.LivesLabel.ForeColor = System.Drawing.Color.Yellow;
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Click += new System.EventHandler(this.LivesLabel_Click);
            // 
            // ScoreBox
            // 
            resources.ApplyResources(this.ScoreBox, "ScoreBox");
            this.ScoreBox.BackColor = System.Drawing.Color.Black;
            this.ScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoreBox.ForeColor = System.Drawing.Color.Yellow;
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.TextChanged += new System.EventHandler(this.ScoreBox_TextChanged);
            // 
            // ScoreLabel
            // 
            resources.ApplyResources(this.ScoreLabel, "ScoreLabel");
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // GameOverLabel
            // 
            resources.ApplyResources(this.GameOverLabel, "GameOverLabel");
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.ForeColor = System.Drawing.Color.Magenta;
            this.GameOverLabel.Name = "GameOverLabel";
            // 
            // lbl_won
            // 
            resources.ApplyResources(this.lbl_won, "lbl_won");
            this.lbl_won.BackColor = System.Drawing.Color.Transparent;
            this.lbl_won.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_won.Name = "lbl_won";
            // 
            // Level2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.lbl_won);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.LivesBox);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameOverLabel);
            this.Name = "Level2";
            this.Load += new System.EventHandler(this.Level2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer GameLoop;
        private System.Windows.Forms.Timer GhostTimer;
        private System.Windows.Forms.Button RestartButton;
        private System.Windows.Forms.TextBox LivesBox;
        private System.Windows.Forms.Label LivesLabel;
        private System.Windows.Forms.TextBox ScoreBox;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label GameOverLabel;
        private System.Windows.Forms.Label lbl_won;
    }
}