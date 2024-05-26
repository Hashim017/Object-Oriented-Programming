
namespace ok_fom
{
    partial class RefundTickets
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
            this.lbl_EnterTickets = new System.Windows.Forms.Label();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Amount = new System.Windows.Forms.Label();
            this.lbl_TotalAmount = new System.Windows.Forms.Label();
            this.lbl_Selection = new System.Windows.Forms.Label();
            this.btn_Proceed = new System.Windows.Forms.Button();
            this.txtbx_Quantity = new System.Windows.Forms.RichTextBox();
            this.listView_Flights = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lbl_EnterTickets
            // 
            this.lbl_EnterTickets.AutoSize = true;
            this.lbl_EnterTickets.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_EnterTickets.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnterTickets.Location = new System.Drawing.Point(113, 365);
            this.lbl_EnterTickets.Name = "lbl_EnterTickets";
            this.lbl_EnterTickets.Size = new System.Drawing.Size(135, 26);
            this.lbl_EnterTickets.TabIndex = 64;
            this.lbl_EnterTickets.Text = "Enter Tickets";
            this.lbl_EnterTickets.Click += new System.EventHandler(this.lbl_EnterTickets_Click);
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirm.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirm.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Confirm.Location = new System.Drawing.Point(533, 472);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(85, 33);
            this.btn_Confirm.TabIndex = 63;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Exit.Location = new System.Drawing.Point(639, 472);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(85, 33);
            this.btn_Exit.TabIndex = 62;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Amount
            // 
            this.lbl_Amount.AutoSize = true;
            this.lbl_Amount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Amount.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Amount.Location = new System.Drawing.Point(410, 474);
            this.lbl_Amount.Name = "lbl_Amount";
            this.lbl_Amount.Size = new System.Drawing.Size(32, 26);
            this.lbl_Amount.TabIndex = 61;
            this.lbl_Amount.Text = "\"\"";
            this.lbl_Amount.Click += new System.EventHandler(this.lbl_Amount_Click);
            // 
            // lbl_TotalAmount
            // 
            this.lbl_TotalAmount.AutoSize = true;
            this.lbl_TotalAmount.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_TotalAmount.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TotalAmount.Location = new System.Drawing.Point(129, 474);
            this.lbl_TotalAmount.Name = "lbl_TotalAmount";
            this.lbl_TotalAmount.Size = new System.Drawing.Size(281, 26);
            this.lbl_TotalAmount.TabIndex = 60;
            this.lbl_TotalAmount.Text = "Your Refundable Amount Is:";
            this.lbl_TotalAmount.Click += new System.EventHandler(this.lbl_TotalAmount_Click);
            // 
            // lbl_Selection
            // 
            this.lbl_Selection.AutoSize = true;
            this.lbl_Selection.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbl_Selection.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selection.Location = new System.Drawing.Point(113, 72);
            this.lbl_Selection.Name = "lbl_Selection";
            this.lbl_Selection.Size = new System.Drawing.Size(131, 26);
            this.lbl_Selection.TabIndex = 59;
            this.lbl_Selection.Text = "Select Flight";
            this.lbl_Selection.Click += new System.EventHandler(this.lbl_Selection_Click);
            // 
            // btn_Proceed
            // 
            this.btn_Proceed.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_Proceed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Proceed.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Proceed.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Proceed.Location = new System.Drawing.Point(383, 410);
            this.btn_Proceed.Name = "btn_Proceed";
            this.btn_Proceed.Size = new System.Drawing.Size(85, 33);
            this.btn_Proceed.TabIndex = 58;
            this.btn_Proceed.Text = "Proceed";
            this.btn_Proceed.UseVisualStyleBackColor = false;
            this.btn_Proceed.Click += new System.EventHandler(this.btn_Proceed_Click);
            // 
            // txtbx_Quantity
            // 
            this.txtbx_Quantity.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtbx_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbx_Quantity.ForeColor = System.Drawing.Color.Transparent;
            this.txtbx_Quantity.Location = new System.Drawing.Point(135, 409);
            this.txtbx_Quantity.Name = "txtbx_Quantity";
            this.txtbx_Quantity.Size = new System.Drawing.Size(222, 35);
            this.txtbx_Quantity.TabIndex = 57;
            this.txtbx_Quantity.Text = "";
            this.txtbx_Quantity.TextChanged += new System.EventHandler(this.txtbx_Quantity_TextChanged);
            // 
            // listView_Flights
            // 
            this.listView_Flights.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView_Flights.BackColor = System.Drawing.Color.DarkGray;
            this.listView_Flights.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_Flights.ForeColor = System.Drawing.SystemColors.Menu;
            this.listView_Flights.GridLines = true;
            this.listView_Flights.HideSelection = false;
            this.listView_Flights.Location = new System.Drawing.Point(89, 114);
            this.listView_Flights.Name = "listView_Flights";
            this.listView_Flights.Size = new System.Drawing.Size(772, 183);
            this.listView_Flights.TabIndex = 56;
            this.listView_Flights.UseCompatibleStateImageBehavior = false;
            this.listView_Flights.View = System.Windows.Forms.View.Details;
            this.listView_Flights.SelectedIndexChanged += new System.EventHandler(this.listView_Flights_SelectedIndexChanged);
            this.listView_Flights.Click += new System.EventHandler(this.listView_Flights_Click);
            // 
            // RefundTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ok_fom.Properties.Resources.customer_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.lbl_EnterTickets);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_Amount);
            this.Controls.Add(this.lbl_TotalAmount);
            this.Controls.Add(this.lbl_Selection);
            this.Controls.Add(this.btn_Proceed);
            this.Controls.Add(this.txtbx_Quantity);
            this.Controls.Add(this.listView_Flights);
            this.Name = "RefundTickets";
            this.Text = "RefundTickets";
            this.Load += new System.EventHandler(this.RefundTickets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_EnterTickets;
        private System.Windows.Forms.Button btn_Confirm;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Amount;
        private System.Windows.Forms.Label lbl_TotalAmount;
        private System.Windows.Forms.Label lbl_Selection;
        private System.Windows.Forms.Button btn_Proceed;
        private System.Windows.Forms.RichTextBox txtbx_Quantity;
        private System.Windows.Forms.ListView listView_Flights;
    }
}