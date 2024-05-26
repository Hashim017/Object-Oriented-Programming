
namespace ok_fom
{
    partial class UpdateAdmin
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
            this.txtbx_Password = new System.Windows.Forms.RichTextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txtbx_Username = new System.Windows.Forms.RichTextBox();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
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
            this.listView_Admins.Location = new System.Drawing.Point(83, 123);
            this.listView_Admins.Name = "listView_Admins";
            this.listView_Admins.Size = new System.Drawing.Size(784, 250);
            this.listView_Admins.TabIndex = 60;
            this.listView_Admins.UseCompatibleStateImageBehavior = false;
            this.listView_Admins.View = System.Windows.Forms.View.Details;
            this.listView_Admins.Click += new System.EventHandler(this.listView_Admins_Click);
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtbx_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_Password.Location = new System.Drawing.Point(494, 441);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(142, 27);
            this.txtbx_Password.TabIndex = 71;
            this.txtbx_Password.Text = "";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(394, 446);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(86, 20);
            this.lbl_Password.TabIndex = 70;
            this.lbl_Password.Text = "Password";
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtbx_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_Username.Location = new System.Drawing.Point(213, 441);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(143, 27);
            this.txtbx_Username.TabIndex = 69;
            this.txtbx_Username.Text = "";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(111, 446);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(91, 20);
            this.lbl_Username.TabIndex = 68;
            this.lbl_Username.Text = "Username";
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Update.Location = new System.Drawing.Point(118, 497);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(81, 29);
            this.btn_Update.TabIndex = 72;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // UpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ok_fom.Properties.Resources.airplane_lights_dark_wallpaper_preview1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txtbx_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.txtbx_Username);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.listView_Admins);
            this.Name = "UpdateAdmin";
            this.Text = "UpdateAdmin";
            this.Load += new System.EventHandler(this.UpdateAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_Admins;
        private System.Windows.Forms.RichTextBox txtbx_Password;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.RichTextBox txtbx_Username;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btn_Update;
    }
}