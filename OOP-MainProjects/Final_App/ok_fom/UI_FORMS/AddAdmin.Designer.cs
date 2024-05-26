
namespace ok_fom
{
    partial class AddAdmin
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
            this.txtbx_Password = new System.Windows.Forms.RichTextBox();
            this.txtbx_Username = new System.Windows.Forms.RichTextBox();
            this.btn_CLear = new System.Windows.Forms.Button();
            this.btn_AddAdmin = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_LoginCredentials = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbx_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_Password.Location = new System.Drawing.Point(443, 324);
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.Size = new System.Drawing.Size(222, 35);
            this.txtbx_Password.TabIndex = 42;
            this.txtbx_Password.Text = "";
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbx_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_Username.Location = new System.Drawing.Point(443, 264);
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.Size = new System.Drawing.Size(222, 35);
            this.txtbx_Username.TabIndex = 41;
            this.txtbx_Username.Text = "";
            // 
            // btn_CLear
            // 
            this.btn_CLear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CLear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CLear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CLear.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CLear.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CLear.Location = new System.Drawing.Point(588, 373);
            this.btn_CLear.Name = "btn_CLear";
            this.btn_CLear.Size = new System.Drawing.Size(77, 36);
            this.btn_CLear.TabIndex = 40;
            this.btn_CLear.Text = "Clear";
            this.btn_CLear.UseVisualStyleBackColor = false;
            this.btn_CLear.Click += new System.EventHandler(this.btn_CLear_Click);
            // 
            // btn_AddAdmin
            // 
            this.btn_AddAdmin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_AddAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddAdmin.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddAdmin.ForeColor = System.Drawing.Color.Transparent;
            this.btn_AddAdmin.Location = new System.Drawing.Point(457, 441);
            this.btn_AddAdmin.Name = "btn_AddAdmin";
            this.btn_AddAdmin.Size = new System.Drawing.Size(97, 45);
            this.btn_AddAdmin.TabIndex = 39;
            this.btn_AddAdmin.Text = "Add";
            this.btn_AddAdmin.UseVisualStyleBackColor = false;
            this.btn_AddAdmin.Click += new System.EventHandler(this.btn_AddAdmin_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(316, 328);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(106, 25);
            this.lbl_Password.TabIndex = 38;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(312, 271);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(110, 25);
            this.lbl_Username.TabIndex = 37;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_LoginCredentials
            // 
            this.lbl_LoginCredentials.AutoSize = true;
            this.lbl_LoginCredentials.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_LoginCredentials.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginCredentials.Location = new System.Drawing.Point(339, 137);
            this.lbl_LoginCredentials.Name = "lbl_LoginCredentials";
            this.lbl_LoginCredentials.Size = new System.Drawing.Size(304, 32);
            this.lbl_LoginCredentials.TabIndex = 36;
            this.lbl_LoginCredentials.Text = "Add Login Credentials";
            // 
            // AddAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ok_fom.Properties.Resources.airplane_lights_dark_wallpaper_preview4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.txtbx_Password);
            this.Controls.Add(this.txtbx_Username);
            this.Controls.Add(this.btn_CLear);
            this.Controls.Add(this.btn_AddAdmin);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_LoginCredentials);
            this.Name = "AddAdmin";
            this.Text = "AddAdmin";
            this.Load += new System.EventHandler(this.AddAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtbx_Password;
        private System.Windows.Forms.RichTextBox txtbx_Username;
        private System.Windows.Forms.Button btn_CLear;
        private System.Windows.Forms.Button btn_AddAdmin;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_LoginCredentials;
    }
}