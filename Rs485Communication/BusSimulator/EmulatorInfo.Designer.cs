namespace BusSimulator
{
    partial class EmulatorInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmulatorInfo));
            this.label_anweisungEins = new System.Windows.Forms.Label();
            this.label_AnweisungZwei = new System.Windows.Forms.Label();
            this.label_AnweisungDrei = new System.Windows.Forms.Label();
            this.button_fertig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_pfad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_anweisungEins
            // 
            this.label_anweisungEins.Location = new System.Drawing.Point(30, 72);
            this.label_anweisungEins.Name = "label_anweisungEins";
            this.label_anweisungEins.Size = new System.Drawing.Size(466, 53);
            this.label_anweisungEins.TabIndex = 5;
            this.label_anweisungEins.Text = "Schritt eins";
            // 
            // label_AnweisungZwei
            // 
            this.label_AnweisungZwei.Location = new System.Drawing.Point(514, 69);
            this.label_AnweisungZwei.Name = "label_AnweisungZwei";
            this.label_AnweisungZwei.Size = new System.Drawing.Size(467, 124);
            this.label_AnweisungZwei.TabIndex = 6;
            this.label_AnweisungZwei.Text = resources.GetString("label_AnweisungZwei.Text");
            // 
            // label_AnweisungDrei
            // 
            this.label_AnweisungDrei.Location = new System.Drawing.Point(1002, 72);
            this.label_AnweisungDrei.Name = "label_AnweisungDrei";
            this.label_AnweisungDrei.Size = new System.Drawing.Size(347, 121);
            this.label_AnweisungDrei.TabIndex = 7;
            this.label_AnweisungDrei.Text = resources.GetString("label_AnweisungDrei.Text");
            // 
            // button_fertig
            // 
            this.button_fertig.Location = new System.Drawing.Point(645, 644);
            this.button_fertig.Name = "button_fertig";
            this.button_fertig.Size = new System.Drawing.Size(199, 37);
            this.button_fertig.TabIndex = 8;
            this.button_fertig.Text = "Fertig >>";
            this.button_fertig.UseVisualStyleBackColor = true;
            this.button_fertig.Click += new System.EventHandler(this.button_fertig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Bitte die Einstellungen des Ports auf <<115200, 8, N, 1>> setzen.";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1005, 259);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(344, 366);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(517, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(464, 343);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 259);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(466, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_pfad
            // 
            this.textBox_pfad.Location = new System.Drawing.Point(517, 196);
            this.textBox_pfad.Name = "textBox_pfad";
            this.textBox_pfad.ReadOnly = true;
            this.textBox_pfad.Size = new System.Drawing.Size(464, 22);
            this.textBox_pfad.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(27, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1192, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "HINWEIS: Sollen mehrere Teilnehmer simuliert werden, bitte erneut mit Doppelklick" +
    " auf den <<COM Port Data Emulator>> auf dem Desktop klicken. Dies öffnet ein neu" +
    "es Emulationsfenster.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Filename: ";
            // 
            // textBox_filename
            // 
            this.textBox_filename.Location = new System.Drawing.Point(594, 221);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(387, 22);
            this.textBox_filename.TabIndex = 14;
            // 
            // EmulatorInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1374, 693);
            this.Controls.Add(this.textBox_filename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_pfad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_fertig);
            this.Controls.Add(this.label_AnweisungDrei);
            this.Controls.Add(this.label_AnweisungZwei);
            this.Controls.Add(this.label_anweisungEins);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmulatorInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emulatoranweisung";
            this.Load += new System.EventHandler(this.EmulatorInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_anweisungEins;
        private System.Windows.Forms.Label label_AnweisungZwei;
        private System.Windows.Forms.Label label_AnweisungDrei;
        private System.Windows.Forms.Button button_fertig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_pfad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_filename;
    }
}