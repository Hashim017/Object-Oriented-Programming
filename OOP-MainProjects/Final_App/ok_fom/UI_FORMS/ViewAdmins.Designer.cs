
namespace ok_fom
{
    partial class ViewAdmins
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
            this.listView_Admins = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listView_Admins
            // 
            this.listView_Admins.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Admins.BackColor = System.Drawing.Color.DarkGray;
            this.listView_Admins.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Admins.ForeColor = System.Drawing.SystemColors.Menu;
            this.listView_Admins.GridLines = true;
            this.listView_Admins.HideSelection = false;
            this.listView_Admins.Location = new System.Drawing.Point(83, 150);
            this.listView_Admins.Name = "listView_Admins";
            this.listView_Admins.Size = new System.Drawing.Size(784, 250);
            this.listView_Admins.TabIndex = 60;
            this.listView_Admins.UseCompatibleStateImageBehavior = false;
            this.listView_Admins.View = System.Windows.Forms.View.Details;
            // 
            // ViewAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ok_fom.Properties.Resources.airplane_lights_dark_wallpaper_preview4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.listView_Admins);
            this.Name = "ViewAdmins";
            this.Text = "ViewAdmins";
            this.Load += new System.EventHandler(this.ViewAdmins_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Admins;
    }
}