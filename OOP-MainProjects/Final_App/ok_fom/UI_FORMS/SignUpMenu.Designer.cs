
namespace ok_fom
{
    partial class SignUpMenu
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
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.pictureBox_Return = new System.Windows.Forms.PictureBox();
            this.btn_CLear = new System.Windows.Forms.Button();
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_LoginMenu = new System.Windows.Forms.Label();
            this.lbl_ConfirmPassword = new System.Windows.Forms.Label();
            this.txtbx_Password = new System.Windows.Forms.TextBox();
            this.txtbx_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.checkBox_showPassword = new System.Windows.Forms.CheckBox();
            this.txtbx_Username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Return)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SignIn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SignIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_SignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignIn.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignIn.ForeColor = System.Drawing.Color.Transparent;
            this.btn_SignIn.Location = new System.Drawing.Point(1168, 12);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(104, 51);
            this.btn_SignIn.TabIndex = 20;
            this.btn_SignIn.Text = "Sign In";
            this.btn_SignIn.UseVisualStyleBackColor = false;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // pictureBox_Return
            // 
            this.pictureBox_Return.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_Return.Image = global::ok_fom.Properties.Resources.back_icon_removebg_preview;
            this.pictureBox_Return.Location = new System.Drawing.Point(12, 12);
            this.pictureBox_Return.Name = "pictureBox_Return";
            this.pictureBox_Return.Size = new System.Drawing.Size(59, 51);
            this.pictureBox_Return.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Return.TabIndex = 28;
            this.pictureBox_Return.TabStop = false;
            this.pictureBox_Return.Click += new System.EventHandler(this.pictureBox_Return_Click);
            // 
            // btn_CLear
            // 
            this.btn_CLear.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_CLear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CLear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CLear.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CLear.ForeColor = System.Drawing.Color.Transparent;
            this.btn_CLear.Location = new System.Drawing.Point(710, 369);
            this.btn_CLear.Name = "btn_CLear";
            this.btn_CLear.Size = new System.Drawing.Size(77, 36);
            this.btn_CLear.TabIndex = 40;
            this.btn_CLear.Text = "Clear";
            this.btn_CLear.UseVisualStyleBackColor = false;
            this.btn_CLear.Click += new System.EventHandler(this.btn_CLear_Click_1);
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SignUp.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SignUp.ForeColor = System.Drawing.Color.Transparent;
            this.btn_SignUp.Location = new System.Drawing.Point(579, 475);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(97, 45);
            this.btn_SignUp.TabIndex = 39;
            this.btn_SignUp.Text = "Sign Up";
            this.btn_SignUp.UseVisualStyleBackColor = false;
            this.btn_SignUp.Click += new System.EventHandler(this.btn_SignUp_Click_1);
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(438, 264);
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
            this.lbl_Username.Location = new System.Drawing.Point(434, 210);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(110, 25);
            this.lbl_Username.TabIndex = 37;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_LoginMenu
            // 
            this.lbl_LoginMenu.AutoSize = true;
            this.lbl_LoginMenu.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_LoginMenu.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginMenu.Location = new System.Drawing.Point(535, 88);
            this.lbl_LoginMenu.Name = "lbl_LoginMenu";
            this.lbl_LoginMenu.Size = new System.Drawing.Size(165, 32);
            this.lbl_LoginMenu.TabIndex = 36;
            this.lbl_LoginMenu.Text = "Login Menu";
            // 
            // lbl_ConfirmPassword
            // 
            this.lbl_ConfirmPassword.AutoSize = true;
            this.lbl_ConfirmPassword.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ConfirmPassword.Location = new System.Drawing.Point(346, 315);
            this.lbl_ConfirmPassword.Name = "lbl_ConfirmPassword";
            this.lbl_ConfirmPassword.Size = new System.Drawing.Size(187, 25);
            this.lbl_ConfirmPassword.TabIndex = 43;
            this.lbl_ConfirmPassword.Text = "Confirm Password";
            // 
            // txtbx_Password
            // 
            this.txtbx_Password.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbx_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Password.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_Password.Location = new System.Drawing.Point(565, 261);
            this.txtbx_Password.Multiline = true;
            this.txtbx_Password.Name = "txtbx_Password";
            this.txtbx_Password.PasswordChar = '•';
            this.txtbx_Password.Size = new System.Drawing.Size(222, 35);
            this.txtbx_Password.TabIndex = 50;
            this.txtbx_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtbx_ConfirmPassword
            // 
            this.txtbx_ConfirmPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbx_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_ConfirmPassword.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_ConfirmPassword.Location = new System.Drawing.Point(565, 311);
            this.txtbx_ConfirmPassword.Multiline = true;
            this.txtbx_ConfirmPassword.Name = "txtbx_ConfirmPassword";
            this.txtbx_ConfirmPassword.PasswordChar = '•';
            this.txtbx_ConfirmPassword.Size = new System.Drawing.Size(222, 35);
            this.txtbx_ConfirmPassword.TabIndex = 49;
            this.txtbx_ConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox_showPassword
            // 
            this.checkBox_showPassword.AutoSize = true;
            this.checkBox_showPassword.BackColor = System.Drawing.Color.DimGray;
            this.checkBox_showPassword.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_showPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox_showPassword.Location = new System.Drawing.Point(565, 355);
            this.checkBox_showPassword.Name = "checkBox_showPassword";
            this.checkBox_showPassword.Size = new System.Drawing.Size(109, 21);
            this.checkBox_showPassword.TabIndex = 48;
            this.checkBox_showPassword.Text = "Show Password";
            this.checkBox_showPassword.UseVisualStyleBackColor = false;
            this.checkBox_showPassword.CheckedChanged += new System.EventHandler(this.checkBox_showPassword_CheckedChanged);
            // 
            // txtbx_Username
            // 
            this.txtbx_Username.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbx_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Username.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_Username.Location = new System.Drawing.Point(565, 204);
            this.txtbx_Username.Multiline = true;
            this.txtbx_Username.Name = "txtbx_Username";
            this.txtbx_Username.PasswordChar = '•';
            this.txtbx_Username.Size = new System.Drawing.Size(222, 35);
            this.txtbx_Username.TabIndex = 51;
            this.txtbx_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbx_Username.UseSystemPasswordChar = true;
            // 
            // SignUpMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ok_fom.Properties.Resources.aircraft_airplane_aviation_black2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1284, 677);
            this.Controls.Add(this.txtbx_Username);
            this.Controls.Add(this.txtbx_Password);
            this.Controls.Add(this.txtbx_ConfirmPassword);
            this.Controls.Add(this.checkBox_showPassword);
            this.Controls.Add(this.lbl_ConfirmPassword);
            this.Controls.Add(this.btn_CLear);
            this.Controls.Add(this.btn_SignUp);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_LoginMenu);
            this.Controls.Add(this.pictureBox_Return);
            this.Controls.Add(this.btn_SignIn);
            this.Name = "SignUpMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpMenu";
            this.Load += new System.EventHandler(this.SignUpMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Return)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.PictureBox pictureBox_Return;
        private System.Windows.Forms.Button btn_CLear;
        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_LoginMenu;
        private System.Windows.Forms.Label lbl_ConfirmPassword;
        private System.Windows.Forms.TextBox txtbx_Password;
        private System.Windows.Forms.TextBox txtbx_ConfirmPassword;
        private System.Windows.Forms.CheckBox checkBox_showPassword;
        private System.Windows.Forms.TextBox txtbx_Username;
    }
}