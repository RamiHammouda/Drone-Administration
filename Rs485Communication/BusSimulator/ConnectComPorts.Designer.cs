namespace BusSimulator
{
    partial class ConnectComPorts
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_ddMc1Ports = new System.Windows.Forms.ComboBox();
            this.button_verbindenPorts = new System.Windows.Forms.Button();
            this.button_HilfeAnzeigenMc1 = new System.Windows.Forms.Button();
            this.comboBox_ddMc2Ports = new System.Windows.Forms.ComboBox();
            this.comboBox_ddBmsPorts = new System.Windows.Forms.ComboBox();
            this.button_HilfeAnzeigenMc2 = new System.Windows.Forms.Button();
            this.button_HilfeAnzeigenBms = new System.Windows.Forms.Button();
            this.label_PfadInfoFrontend = new System.Windows.Forms.Label();
            this.textBox_PfadFrontend = new System.Windows.Forms.TextBox();
            this.button_PfadFrontendWählen = new System.Windows.Forms.Button();
            this.button_PfadValidieren = new System.Windows.Forms.Button();
            this.serialPort_Mc01 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort_Mc02 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort_Bms = new System.IO.Ports.SerialPort(this.components);
            this.timer_Communication = new System.Windows.Forms.Timer(this.components);
            this.timer_Mc2 = new System.Windows.Forms.Timer(this.components);
            this.timer_Bms = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MC1 Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BMS Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MC2 Port:";
            // 
            // comboBox_ddMc1Ports
            // 
            this.comboBox_ddMc1Ports.FormattingEnabled = true;
            this.comboBox_ddMc1Ports.Location = new System.Drawing.Point(121, 202);
            this.comboBox_ddMc1Ports.Name = "comboBox_ddMc1Ports";
            this.comboBox_ddMc1Ports.Size = new System.Drawing.Size(169, 24);
            this.comboBox_ddMc1Ports.TabIndex = 3;
            // 
            // button_verbindenPorts
            // 
            this.button_verbindenPorts.Location = new System.Drawing.Point(47, 300);
            this.button_verbindenPorts.Name = "button_verbindenPorts";
            this.button_verbindenPorts.Size = new System.Drawing.Size(392, 24);
            this.button_verbindenPorts.TabIndex = 4;
            this.button_verbindenPorts.Text = "Verbinden";
            this.button_verbindenPorts.UseVisualStyleBackColor = true;
            this.button_verbindenPorts.Click += new System.EventHandler(this.button_verbindenPorts_Click);
            // 
            // button_HilfeAnzeigenMc1
            // 
            this.button_HilfeAnzeigenMc1.Location = new System.Drawing.Point(296, 202);
            this.button_HilfeAnzeigenMc1.Name = "button_HilfeAnzeigenMc1";
            this.button_HilfeAnzeigenMc1.Size = new System.Drawing.Size(143, 24);
            this.button_HilfeAnzeigenMc1.TabIndex = 5;
            this.button_HilfeAnzeigenMc1.Text = "Hilfe anzeigen";
            this.button_HilfeAnzeigenMc1.UseVisualStyleBackColor = true;
            this.button_HilfeAnzeigenMc1.Click += new System.EventHandler(this.button_HilfeAnzeigenMc1_Click);
            // 
            // comboBox_ddMc2Ports
            // 
            this.comboBox_ddMc2Ports.FormattingEnabled = true;
            this.comboBox_ddMc2Ports.Location = new System.Drawing.Point(121, 230);
            this.comboBox_ddMc2Ports.Name = "comboBox_ddMc2Ports";
            this.comboBox_ddMc2Ports.Size = new System.Drawing.Size(169, 24);
            this.comboBox_ddMc2Ports.TabIndex = 6;
            // 
            // comboBox_ddBmsPorts
            // 
            this.comboBox_ddBmsPorts.FormattingEnabled = true;
            this.comboBox_ddBmsPorts.Location = new System.Drawing.Point(121, 260);
            this.comboBox_ddBmsPorts.Name = "comboBox_ddBmsPorts";
            this.comboBox_ddBmsPorts.Size = new System.Drawing.Size(169, 24);
            this.comboBox_ddBmsPorts.TabIndex = 7;
            // 
            // button_HilfeAnzeigenMc2
            // 
            this.button_HilfeAnzeigenMc2.Location = new System.Drawing.Point(296, 230);
            this.button_HilfeAnzeigenMc2.Name = "button_HilfeAnzeigenMc2";
            this.button_HilfeAnzeigenMc2.Size = new System.Drawing.Size(143, 24);
            this.button_HilfeAnzeigenMc2.TabIndex = 8;
            this.button_HilfeAnzeigenMc2.Text = "Hilfe anzeigen";
            this.button_HilfeAnzeigenMc2.UseVisualStyleBackColor = true;
            this.button_HilfeAnzeigenMc2.Click += new System.EventHandler(this.button_HilfeAnzeigenMc2_Click);
            // 
            // button_HilfeAnzeigenBms
            // 
            this.button_HilfeAnzeigenBms.Location = new System.Drawing.Point(296, 260);
            this.button_HilfeAnzeigenBms.Name = "button_HilfeAnzeigenBms";
            this.button_HilfeAnzeigenBms.Size = new System.Drawing.Size(143, 24);
            this.button_HilfeAnzeigenBms.TabIndex = 9;
            this.button_HilfeAnzeigenBms.Text = "Hilfe anzeigen";
            this.button_HilfeAnzeigenBms.UseVisualStyleBackColor = true;
            this.button_HilfeAnzeigenBms.Click += new System.EventHandler(this.button_HilfeAnzeigenBms_Click);
            // 
            // label_PfadInfoFrontend
            // 
            this.label_PfadInfoFrontend.Location = new System.Drawing.Point(44, 45);
            this.label_PfadInfoFrontend.Name = "label_PfadInfoFrontend";
            this.label_PfadInfoFrontend.Size = new System.Drawing.Size(395, 85);
            this.label_PfadInfoFrontend.TabIndex = 11;
            this.label_PfadInfoFrontend.Text = "Bitte wählen Sie einen Ordner, in dem die simulierten Daten gespeichert werden so" +
    "llen. Diese Dateien müssen im Emulator später als Quelldateien ausgewählt werden" +
    ".\r\n\r\n";
            // 
            // textBox_PfadFrontend
            // 
            this.textBox_PfadFrontend.Location = new System.Drawing.Point(47, 134);
            this.textBox_PfadFrontend.Name = "textBox_PfadFrontend";
            this.textBox_PfadFrontend.Size = new System.Drawing.Size(243, 22);
            this.textBox_PfadFrontend.TabIndex = 12;
            // 
            // button_PfadFrontendWählen
            // 
            this.button_PfadFrontendWählen.Location = new System.Drawing.Point(296, 133);
            this.button_PfadFrontendWählen.Name = "button_PfadFrontendWählen";
            this.button_PfadFrontendWählen.Size = new System.Drawing.Size(143, 23);
            this.button_PfadFrontendWählen.TabIndex = 13;
            this.button_PfadFrontendWählen.Text = "Pfad wählen";
            this.button_PfadFrontendWählen.UseVisualStyleBackColor = true;
            this.button_PfadFrontendWählen.Click += new System.EventHandler(this.button_PfadFrontendWählen_Click);
            // 
            // button_PfadValidieren
            // 
            this.button_PfadValidieren.Location = new System.Drawing.Point(47, 163);
            this.button_PfadValidieren.Name = "button_PfadValidieren";
            this.button_PfadValidieren.Size = new System.Drawing.Size(392, 23);
            this.button_PfadValidieren.TabIndex = 14;
            this.button_PfadValidieren.Text = "Pfad validieren";
            this.button_PfadValidieren.UseVisualStyleBackColor = true;
            this.button_PfadValidieren.Click += new System.EventHandler(this.button_PfadValidieren_Click);
            // 
            // timer_Communication
            // 
            this.timer_Communication.Interval = 2000;
            this.timer_Communication.Tick += new System.EventHandler(this.timer_Communication_Tick_1);
            // 
            // timer_Mc2
            // 
            this.timer_Mc2.Interval = 2000;
            // 
            // timer_Bms
            // 
            this.timer_Bms.Interval = 2000;
            // 
            // ConnectComPorts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 442);
            this.Controls.Add(this.button_PfadValidieren);
            this.Controls.Add(this.button_PfadFrontendWählen);
            this.Controls.Add(this.textBox_PfadFrontend);
            this.Controls.Add(this.label_PfadInfoFrontend);
            this.Controls.Add(this.button_HilfeAnzeigenBms);
            this.Controls.Add(this.button_HilfeAnzeigenMc2);
            this.Controls.Add(this.comboBox_ddBmsPorts);
            this.Controls.Add(this.comboBox_ddMc2Ports);
            this.Controls.Add(this.button_HilfeAnzeigenMc1);
            this.Controls.Add(this.button_verbindenPorts);
            this.Controls.Add(this.comboBox_ddMc1Ports);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ConnectComPorts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COM Ports wählen";
            this.Load += new System.EventHandler(this.ConnectComPorts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_ddMc1Ports;
        private System.Windows.Forms.Button button_verbindenPorts;
        private System.Windows.Forms.Button button_HilfeAnzeigenMc1;
        private System.Windows.Forms.ComboBox comboBox_ddMc2Ports;
        private System.Windows.Forms.ComboBox comboBox_ddBmsPorts;
        private System.Windows.Forms.Button button_HilfeAnzeigenMc2;
        private System.Windows.Forms.Button button_HilfeAnzeigenBms;
        private System.Windows.Forms.Label label_PfadInfoFrontend;
        private System.Windows.Forms.TextBox textBox_PfadFrontend;
        private System.Windows.Forms.Button button_PfadFrontendWählen;
        private System.Windows.Forms.Button button_PfadValidieren;
        private System.IO.Ports.SerialPort serialPort_Mc01;
        private System.IO.Ports.SerialPort serialPort_Mc02;
        private System.IO.Ports.SerialPort serialPort_Bms;
        private System.Windows.Forms.Timer timer_Communication;
        private System.Windows.Forms.Timer timer_Mc2;
        private System.Windows.Forms.Timer timer_Bms;
    }
}