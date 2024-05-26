
namespace ok_game
{
    partial class Level1
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
            this.GameLoop = new System.Windows.Forms.Timer(this.components);
            this.GhostTimer = new System.Windows.Forms.Timer(this.components);
            this.RestartButton = new System.Windows.Forms.Button();
            this.LivesBox = new System.Windows.Forms.TextBox();
            this.LivesLabel = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.TextBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.GameOverLabel = new System.Windows.Forms.Label();
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
            this.RestartButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestartButton.BackColor = System.Drawing.Color.Black;
            this.RestartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RestartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestartButton.ForeColor = System.Drawing.Color.Red;
            this.RestartButton.Location = new System.Drawing.Point(562, 568);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(2);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(85, 30);
            this.RestartButton.TabIndex = 12;
            this.RestartButton.Text = "Restart";
            this.RestartButton.UseVisualStyleBackColor = false;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click_1);
            // 
            // LivesBox
            // 
            this.LivesBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LivesBox.BackColor = System.Drawing.Color.Black;
            this.LivesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LivesBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesBox.ForeColor = System.Drawing.Color.Yellow;
            this.LivesBox.Location = new System.Drawing.Point(826, 569);
            this.LivesBox.Margin = new System.Windows.Forms.Padding(2);
            this.LivesBox.Name = "LivesBox";
            this.LivesBox.ReadOnly = true;
            this.LivesBox.Size = new System.Drawing.Size(67, 25);
            this.LivesBox.TabIndex = 11;
            this.LivesBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LivesBox.TextChanged += new System.EventHandler(this.LivesBox_TextChanged);
            // 
            // LivesLabel
            // 
            this.LivesLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LivesLabel.AutoSize = true;
            this.LivesLabel.BackColor = System.Drawing.Color.Transparent;
            this.LivesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesLabel.ForeColor = System.Drawing.Color.Yellow;
            this.LivesLabel.Location = new System.Drawing.Point(708, 568);
            this.LivesLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LivesLabel.Name = "LivesLabel";
            this.LivesLabel.Size = new System.Drawing.Size(80, 26);
            this.LivesLabel.TabIndex = 10;
            this.LivesLabel.Text = "LIVES";
            this.LivesLabel.Click += new System.EventHandler(this.LivesLabel_Click);
            // 
            // ScoreBox
            // 
            this.ScoreBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScoreBox.BackColor = System.Drawing.Color.Black;
            this.ScoreBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoreBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreBox.ForeColor = System.Drawing.Color.Yellow;
            this.ScoreBox.Location = new System.Drawing.Point(429, 569);
            this.ScoreBox.Margin = new System.Windows.Forms.Padding(2);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.ReadOnly = true;
            this.ScoreBox.Size = new System.Drawing.Size(67, 25);
            this.ScoreBox.TabIndex = 9;
            this.ScoreBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ScoreBox.TextChanged += new System.EventHandler(this.ScoreBox_TextChanged);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.Yellow;
            this.ScoreLabel.Location = new System.Drawing.Point(329, 568);
            this.ScoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(96, 26);
            this.ScoreLabel.TabIndex = 8;
            this.ScoreLabel.Text = "SCORE";
            this.ScoreLabel.Click += new System.EventHandler(this.ScoreLabel_Click);
            // 
            // GameOverLabel
            // 
            this.GameOverLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GameOverLabel.AutoSize = true;
            this.GameOverLabel.BackColor = System.Drawing.Color.Transparent;
            this.GameOverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverLabel.ForeColor = System.Drawing.Color.Red;
            this.GameOverLabel.Location = new System.Drawing.Point(290, 207);
            this.GameOverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GameOverLabel.Name = "GameOverLabel";
            this.GameOverLabel.Size = new System.Drawing.Size(186, 31);
            this.GameOverLabel.TabIndex = 7;
            this.GameOverLabel.Text = "GAME OVER";
            this.GameOverLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameOverLabel.Visible = false;
            this.GameOverLabel.Click += new System.EventHandler(this.GameOverLabel_Click);
            // 
            // Level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(1274, 610);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.LivesBox);
            this.Controls.Add(this.LivesLabel);
            this.Controls.Add(this.ScoreBox);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.GameOverLabel);
            this.Name = "Level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spelunker";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

