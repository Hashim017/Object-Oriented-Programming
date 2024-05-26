
namespace ok_fom
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
            this.timer_Loading = new System.Windows.Forms.Timer(this.components);
            this.lbl_Safari = new System.Windows.Forms.Label();
            this.lbl_Airways = new System.Windows.Forms.Label();
            this.label_Loading = new System.Windows.Forms.Label();
            this.pnl_Loading = new System.Windows.Forms.Panel();
            this.lbl_Initializing = new System.Windows.Forms.Label();
            this.pnl_LoadingPNLContainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_LoadingPNLContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_Loading
            // 
            this.timer_Loading.Enabled = true;
            this.timer_Loading.Tick += new System.EventHandler(this.timer_Loading_Tick);
            // 
            // lbl_Safari
            // 
            this.lbl_Safari.AutoSize = true;
            this.lbl_Safari.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Safari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Safari.Font = new System.Drawing.Font("Microsoft YaHei", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Safari.ForeColor = System.Drawing.Color.White;
            this.lbl_Safari.Location = new System.Drawing.Point(28, 25);
            this.lbl_Safari.Name = "lbl_Safari";
            this.lbl_Safari.Size = new System.Drawing.Size(286, 92);
            this.lbl_Safari.TabIndex = 0;
            this.lbl_Safari.Text = "SAFARI";
            // 
            // lbl_Airways
            // 
            this.lbl_Airways.AutoSize = true;
            this.lbl_Airways.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_Airways.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Airways.Font = new System.Drawing.Font("Microsoft Tai Le", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Airways.ForeColor = System.Drawing.Color.White;
            this.lbl_Airways.Location = new System.Drawing.Point(152, 112);
            this.lbl_Airways.Name = "lbl_Airways";
            this.lbl_Airways.Size = new System.Drawing.Size(143, 45);
            this.lbl_Airways.TabIndex = 1;
            this.lbl_Airways.Text = "Airways";
            // 
            // label_Loading
            // 
            this.label_Loading.AutoSize = true;
            this.label_Loading.BackColor = System.Drawing.Color.Transparent;
            this.label_Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Loading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_Loading.Location = new System.Drawing.Point(957, 405);
            this.label_Loading.Name = "label_Loading";
            this.label_Loading.Size = new System.Drawing.Size(63, 31);
            this.label_Loading.TabIndex = 2;
            this.label_Loading.Text = "0 %";
            // 
            // pnl_Loading
            // 
            this.pnl_Loading.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnl_Loading.Location = new System.Drawing.Point(20, 10);
            this.pnl_Loading.Name = "pnl_Loading";
            this.pnl_Loading.Size = new System.Drawing.Size(282, 21);
            this.pnl_Loading.TabIndex = 3;
            // 
            // lbl_Initializing
            // 
            this.lbl_Initializing.AutoSize = true;
            this.lbl_Initializing.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Initializing.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Initializing.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Initializing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Initializing.Location = new System.Drawing.Point(918, 502);
            this.lbl_Initializing.Name = "lbl_Initializing";
            this.lbl_Initializing.Size = new System.Drawing.Size(191, 27);
            this.lbl_Initializing.TabIndex = 4;
            this.lbl_Initializing.Text = "INITIALIZING .....";
            // 
            // pnl_LoadingPNLContainer
            // 
            this.pnl_LoadingPNLContainer.BackColor = System.Drawing.SystemColors.WindowText;
            this.pnl_LoadingPNLContainer.Controls.Add(this.pnl_Loading);
            this.pnl_LoadingPNLContainer.Location = new System.Drawing.Point(847, 442);
            this.pnl_LoadingPNLContainer.Name = "pnl_LoadingPNLContainer";
            this.pnl_LoadingPNLContainer.Size = new System.Drawing.Size(321, 41);
            this.pnl_LoadingPNLContainer.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.lbl_Safari);
            this.panel1.Controls.Add(this.lbl_Airways);
            this.panel1.Location = new System.Drawing.Point(807, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 169);
            this.panel1.TabIndex = 5;
            // 
            // LoadingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ok_fom.Properties.Resources.IMG_2163;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 677);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_LoadingPNLContainer);
            this.Controls.Add(this.lbl_Initializing);
            this.Controls.Add(this.label_Loading);
            this.Name = "LoadingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LodingPage";
            this.Load += new System.EventHandler(this.LoadingPage_Load);
            this.pnl_LoadingPNLContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer_Loading;
        private System.Windows.Forms.Label lbl_Safari;
        private System.Windows.Forms.Label lbl_Airways;
        private System.Windows.Forms.Label label_Loading;
        private System.Windows.Forms.Panel pnl_Loading;
        private System.Windows.Forms.Label lbl_Initializing;
        private System.Windows.Forms.Panel pnl_LoadingPNLContainer;
        private System.Windows.Forms.Panel panel1;
    }
}