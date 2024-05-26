
namespace ok_game
{
    partial class LoadingPage
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
            this.pnl_LoadingContainer = new System.Windows.Forms.Panel();
            this.pnl_Loading = new System.Windows.Forms.Panel();
            this.lbl_Percentage = new System.Windows.Forms.Label();
            this.lbl_Intializing = new System.Windows.Forms.Label();
            this.timer_Loading = new System.Windows.Forms.Timer(this.components);
            this.pnl_LoadingContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_LoadingContainer
            // 
            this.pnl_LoadingContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnl_LoadingContainer.Controls.Add(this.pnl_Loading);
            this.pnl_LoadingContainer.Location = new System.Drawing.Point(632, 420);
            this.pnl_LoadingContainer.Name = "pnl_LoadingContainer";
            this.pnl_LoadingContainer.Size = new System.Drawing.Size(348, 41);
            this.pnl_LoadingContainer.TabIndex = 0;
            // 
            // pnl_Loading
            // 
            this.pnl_Loading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnl_Loading.Location = new System.Drawing.Point(16, 6);
            this.pnl_Loading.Name = "pnl_Loading";
            this.pnl_Loading.Size = new System.Drawing.Size(314, 29);
            this.pnl_Loading.TabIndex = 1;
            this.pnl_Loading.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Loading_Paint);
            // 
            // lbl_Percentage
            // 
            this.lbl_Percentage.AutoSize = true;
            this.lbl_Percentage.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Percentage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Percentage.Location = new System.Drawing.Point(766, 376);
            this.lbl_Percentage.Name = "lbl_Percentage";
            this.lbl_Percentage.Size = new System.Drawing.Size(40, 24);
            this.lbl_Percentage.TabIndex = 2;
            this.lbl_Percentage.Text = "0 %";
            // 
            // lbl_Intializing
            // 
            this.lbl_Intializing.AutoSize = true;
            this.lbl_Intializing.BackColor = System.Drawing.Color.Black;
            this.lbl_Intializing.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Intializing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_Intializing.Location = new System.Drawing.Point(704, 468);
            this.lbl_Intializing.Name = "lbl_Intializing";
            this.lbl_Intializing.Size = new System.Drawing.Size(207, 36);
            this.lbl_Intializing.TabIndex = 3;
            this.lbl_Intializing.Text = "Initializing .....";
            // 
            // timer_Loading
            // 
            this.timer_Loading.Enabled = true;
            this.timer_Loading.Tick += new System.EventHandler(this.timer_Loading_Tick);
            // 
            // LoadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ok_game.Properties.Resources.MainPage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 610);
            this.Controls.Add(this.lbl_Intializing);
            this.Controls.Add(this.lbl_Percentage);
            this.Controls.Add(this.pnl_LoadingContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "LoadingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingPage";
            this.Load += new System.EventHandler(this.LoadingPage_Load);
            this.pnl_LoadingContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_LoadingContainer;
        private System.Windows.Forms.Panel pnl_Loading;
        private System.Windows.Forms.Label lbl_Percentage;
        private System.Windows.Forms.Label lbl_Intializing;
        private System.Windows.Forms.Timer timer_Loading;
    }
}