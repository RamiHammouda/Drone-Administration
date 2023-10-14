namespace BusSimulator
{
    partial class Pathinfo
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
            this.button_openFileDia = new System.Windows.Forms.Button();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_weiter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_openFileDia
            // 
            this.button_openFileDia.Location = new System.Drawing.Point(542, 38);
            this.button_openFileDia.Name = "button_openFileDia";
            this.button_openFileDia.Size = new System.Drawing.Size(123, 23);
            this.button_openFileDia.TabIndex = 0;
            this.button_openFileDia.Text = "Pfad wählen";
            this.button_openFileDia.UseVisualStyleBackColor = true;
            this.button_openFileDia.Click += new System.EventHandler(this.button_openFileDia_Click);
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(26, 38);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(510, 22);
            this.textBox_path.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(665, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bitte wählen Sie einen Ordner, in dem die simulierten Daten gespeichert werden so" +
    "llen. Diese Dateien müssen im Emulator später als Quelldateien ausgewählt werden" +
    ".";
            // 
            // button_weiter
            // 
            this.button_weiter.Location = new System.Drawing.Point(257, 155);
            this.button_weiter.Name = "button_weiter";
            this.button_weiter.Size = new System.Drawing.Size(165, 23);
            this.button_weiter.TabIndex = 3;
            this.button_weiter.Text = "Weiter >>";
            this.button_weiter.UseVisualStyleBackColor = true;
            this.button_weiter.Click += new System.EventHandler(this.button_weiter_Click);
            // 
            // Pathinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(706, 212);
            this.Controls.Add(this.button_weiter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_path);
            this.Controls.Add(this.button_openFileDia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Pathinfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pathinfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_openFileDia;
        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_weiter;
    }
}