namespace WindowsFormsApp1
{
    partial class Simulation
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.Drone_Altitude = new System.Windows.Forms.TextBox();
            this.DroneAltitude = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.Drone;
            this.pictureBox1.Location = new System.Drawing.Point(280, 345);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Interval = 200;
            this.GameTimer.Tick += new System.EventHandler(this.MainTimerEvent);
            // 
            // Drone_Altitude
            // 
            this.Drone_Altitude.Location = new System.Drawing.Point(496, 36);
            this.Drone_Altitude.Name = "Drone_Altitude";
            this.Drone_Altitude.Size = new System.Drawing.Size(100, 20);
            this.Drone_Altitude.TabIndex = 2;
            // 
            // DroneAltitude
            // 
            this.DroneAltitude.AutoSize = true;
            this.DroneAltitude.Location = new System.Drawing.Point(496, 13);
            this.DroneAltitude.Name = "DroneAltitude";
            this.DroneAltitude.Size = new System.Drawing.Size(74, 13);
            this.DroneAltitude.TabIndex = 3;
            this.DroneAltitude.Text = "Drone Altitude";
            // 
            // Simulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.Scene;
            this.ClientSize = new System.Drawing.Size(627, 398);
            this.Controls.Add(this.DroneAltitude);
            this.Controls.Add(this.Drone_Altitude);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Simulation";
            this.Text = "Simulation";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.TextBox Drone_Altitude;
        private System.Windows.Forms.Label DroneAltitude;
    }
}