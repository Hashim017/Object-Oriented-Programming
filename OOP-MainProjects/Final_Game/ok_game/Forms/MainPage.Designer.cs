
namespace ok_game
{
    partial class MainPage
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
            this.lbl_Spelunky = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_StartGame = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_LoadGame = new System.Windows.Forms.Button();
            this.btn_Instructions = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Spelunky
            // 
            this.lbl_Spelunky.AutoSize = true;
            this.lbl_Spelunky.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_Spelunky.Font = new System.Drawing.Font("Times New Roman", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Spelunky.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_Spelunky.Location = new System.Drawing.Point(18, 15);
            this.lbl_Spelunky.Name = "lbl_Spelunky";
            this.lbl_Spelunky.Size = new System.Drawing.Size(289, 68);
            this.lbl_Spelunky.TabIndex = 1;
            this.lbl_Spelunky.Text = "Spelunker";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Spelunky);
            this.panel1.Location = new System.Drawing.Point(738, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 100);
            this.panel1.TabIndex = 2;
            // 
            // btn_StartGame
            // 
            this.btn_StartGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_StartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_StartGame.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btn_StartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_StartGame.ForeColor = System.Drawing.Color.Yellow;
            this.btn_StartGame.Location = new System.Drawing.Point(820, 228);
            this.btn_StartGame.Name = "btn_StartGame";
            this.btn_StartGame.Size = new System.Drawing.Size(163, 43);
            this.btn_StartGame.TabIndex = 3;
            this.btn_StartGame.Text = "Start Game";
            this.btn_StartGame.UseVisualStyleBackColor = false;
            this.btn_StartGame.Click += new System.EventHandler(this.btn_StartGame_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Exit.Location = new System.Drawing.Point(910, 414);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(154, 43);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_LoadGame
            // 
            this.btn_LoadGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_LoadGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoadGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoadGame.ForeColor = System.Drawing.Color.Yellow;
            this.btn_LoadGame.Location = new System.Drawing.Point(916, 286);
            this.btn_LoadGame.Name = "btn_LoadGame";
            this.btn_LoadGame.Size = new System.Drawing.Size(165, 43);
            this.btn_LoadGame.TabIndex = 5;
            this.btn_LoadGame.Text = "Load Game";
            this.btn_LoadGame.UseVisualStyleBackColor = false;
            this.btn_LoadGame.Click += new System.EventHandler(this.btn_LoadGame_Click);
            // 
            // btn_Instructions
            // 
            this.btn_Instructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Instructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Instructions.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Instructions.Location = new System.Drawing.Point(820, 349);
            this.btn_Instructions.Name = "btn_Instructions";
            this.btn_Instructions.Size = new System.Drawing.Size(163, 43);
            this.btn_Instructions.TabIndex = 6;
            this.btn_Instructions.Text = "Instructions";
            this.btn_Instructions.UseVisualStyleBackColor = false;
            this.btn_Instructions.Click += new System.EventHandler(this.btn_Instructions_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ok_game.Properties.Resources.pl;
            this.pictureBox1.Location = new System.Drawing.Point(138, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 620);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1278, 614);
            this.Controls.Add(this.btn_Instructions);
            this.Controls.Add(this.btn_LoadGame);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_StartGame);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_Spelunky;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_StartGame;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_LoadGame;
        private System.Windows.Forms.Button btn_Instructions;
    }
}