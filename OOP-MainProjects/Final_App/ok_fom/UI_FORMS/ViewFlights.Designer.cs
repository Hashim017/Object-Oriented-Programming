﻿
namespace ok_fom
{
    partial class ViewFlights
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
            this.listView_Flights = new System.Windows.Forms.ListView();
            this.btn_FlightAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.listView_Flights.Location = new System.Drawing.Point(79, 171);
            this.listView_Flights.Name = "listView_Flights";
            this.listView_Flights.Size = new System.Drawing.Size(772, 250);
            this.listView_Flights.TabIndex = 1;
            this.listView_Flights.UseCompatibleStateImageBehavior = false;
            this.listView_Flights.View = System.Windows.Forms.View.Details;
            this.listView_Flights.SelectedIndexChanged += new System.EventHandler(this.listView_Flights_SelectedIndexChanged);
            // 
            // btn_FlightAdd
            // 
            this.btn_FlightAdd.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_FlightAdd.Font = new System.Drawing.Font("Century", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_FlightAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btn_FlightAdd.Location = new System.Drawing.Point(586, 661);
            this.btn_FlightAdd.Name = "btn_FlightAdd";
            this.btn_FlightAdd.Size = new System.Drawing.Size(108, 39);
            this.btn_FlightAdd.TabIndex = 49;
            this.btn_FlightAdd.Text = "Add Flight";
            this.btn_FlightAdd.UseVisualStyleBackColor = false;
            this.btn_FlightAdd.Click += new System.EventHandler(this.btn_FlightAdd_Click);
            // 
            // ViewFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::ok_fom.Properties.Resources.airplane_lights_dark_wallpaper_preview3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.btn_FlightAdd);
            this.Controls.Add(this.listView_Flights);
            this.Name = "ViewFlights";
            this.Text = "ViewFlights";
            this.Load += new System.EventHandler(this.ViewFlights_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView_Flights;
        private System.Windows.Forms.Button btn_FlightAdd;
    }
}