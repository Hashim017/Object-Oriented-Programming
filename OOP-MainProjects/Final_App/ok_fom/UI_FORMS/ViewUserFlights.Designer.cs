
namespace ok_fom
{
    partial class ViewUserFlights
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
            this.listView_Flights.TabIndex = 2;
            this.listView_Flights.UseCompatibleStateImageBehavior = false;
            this.listView_Flights.View = System.Windows.Forms.View.Details;
            // 
            // ViewUserFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ok_fom.Properties.Resources.airplane_lights_dark_wallpaper_preview2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.listView_Flights);
            this.Name = "ViewUserFlights";
            this.Text = "ViewUserFlights";
            this.Load += new System.EventHandler(this.ViewUserFlights_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Flights;
    }
}