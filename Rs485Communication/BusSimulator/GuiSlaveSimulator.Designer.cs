namespace BusSimulator
{
    partial class GuiSlaveSimulator
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort_Gui = new System.IO.Ports.SerialPort(this.components);
            this.label_ComPortDesc = new System.Windows.Forms.Label();
            this.comboBox_AllActivePorts = new System.Windows.Forms.ComboBox();
            this.button_Verbinden = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_automaticSendingActivated = new System.Windows.Forms.CheckBox();
            this.label_stetigesSenden = new System.Windows.Forms.Label();
            this.button_ManuellesSenden = new System.Windows.Forms.Button();
            this.textBox_DataToBeSend = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_binäresTelegram = new System.Windows.Forms.Label();
            this.progressBar_Verbinden = new System.Windows.Forms.ProgressBar();
            this.timer_SchreibenVonMcTelegramInTxt = new System.Windows.Forms.Timer(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox_dummyIFrontMc01 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_setTorqueMc01 = new System.Windows.Forms.TextBox();
            this.textBox_setSetPointMc01 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button_disconnectMc1 = new System.Windows.Forms.Button();
            this.progressBar_Verbinden02 = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_binaeresTelegramMc02 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_automaticSendingActivated02 = new System.Windows.Forms.CheckBox();
            this.label_stetigesSendenMc02 = new System.Windows.Forms.Label();
            this.button_ManuellesSenden02 = new System.Windows.Forms.Button();
            this.textBox_DataToBeSend02 = new System.Windows.Forms.TextBox();
            this.button_VerbindenMc2 = new System.Windows.Forms.Button();
            this.comboBox_AllActivePorts02 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button_disconnectMc2 = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_setTorqueMc02 = new System.Windows.Forms.TextBox();
            this.textBox_setSetPointMc02 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar_Verbinden03 = new System.Windows.Forms.ProgressBar();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label_binaeresTelegramBms = new System.Windows.Forms.Label();
            this.button_VerbindenBms = new System.Windows.Forms.Button();
            this.comboBox_AllActivePorts03 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button_disconnectBms = new System.Windows.Forms.Button();
            this.serialPort_GuiBms = new System.IO.Ports.SerialPort(this.components);
            this.serialPort_Gui02 = new System.IO.Ports.SerialPort(this.components);
            this.timer_SchreibenVonMcTelegramInTxt02 = new System.Windows.Forms.Timer(this.components);
            this.timer_SchreibenVonBmsTelegramInTxt = new System.Windows.Forms.Timer(this.components);
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.button_hilfeCom = new System.Windows.Forms.Button();
            this.button_hilfeError = new System.Windows.Forms.Button();
            this.button_ReturnErrorCom = new System.Windows.Forms.Button();
            this.comboBox_addressErrorCom = new System.Windows.Forms.ComboBox();
            this.comboBox_SlaveIdErrorCom = new System.Windows.Forms.ComboBox();
            this.label_returnErrorCom = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.button_ReturnIcom = new System.Windows.Forms.Button();
            this.comboBox_IComAddress = new System.Windows.Forms.ComboBox();
            this.comboBox_SlaveId = new System.Windows.Forms.ComboBox();
            this.label_RückgabewertICom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_pathFolderSimualtion = new System.Windows.Forms.Label();
            this.toolTip_dummyFrontMc01 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_dummyIFrontMc01.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_ComPortDesc
            // 
            this.label_ComPortDesc.AutoSize = true;
            this.label_ComPortDesc.Location = new System.Drawing.Point(23, 29);
            this.label_ComPortDesc.Name = "label_ComPortDesc";
            this.label_ComPortDesc.Size = new System.Drawing.Size(73, 17);
            this.label_ComPortDesc.TabIndex = 0;
            this.label_ComPortDesc.Text = "COM Port:";
            // 
            // comboBox_AllActivePorts
            // 
            this.comboBox_AllActivePorts.FormattingEnabled = true;
            this.comboBox_AllActivePorts.Location = new System.Drawing.Point(91, 21);
            this.comboBox_AllActivePorts.Name = "comboBox_AllActivePorts";
            this.comboBox_AllActivePorts.Size = new System.Drawing.Size(101, 24);
            this.comboBox_AllActivePorts.TabIndex = 1;
            // 
            // button_Verbinden
            // 
            this.button_Verbinden.Location = new System.Drawing.Point(198, 19);
            this.button_Verbinden.Name = "button_Verbinden";
            this.button_Verbinden.Size = new System.Drawing.Size(104, 32);
            this.button_Verbinden.TabIndex = 2;
            this.button_Verbinden.Text = "Verbinden";
            this.button_Verbinden.UseVisualStyleBackColor = true;
            this.button_Verbinden.Click += new System.EventHandler(this.button_Verbinden_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_automaticSendingActivated);
            this.groupBox1.Controls.Add(this.label_stetigesSenden);
            this.groupBox1.Controls.Add(this.button_ManuellesSenden);
            this.groupBox1.Controls.Add(this.textBox_DataToBeSend);
            this.groupBox1.Location = new System.Drawing.Point(26, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 80);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Senden";
            // 
            // checkBox_automaticSendingActivated
            // 
            this.checkBox_automaticSendingActivated.AutoSize = true;
            this.checkBox_automaticSendingActivated.Location = new System.Drawing.Point(791, 51);
            this.checkBox_automaticSendingActivated.Name = "checkBox_automaticSendingActivated";
            this.checkBox_automaticSendingActivated.Size = new System.Drawing.Size(175, 21);
            this.checkBox_automaticSendingActivated.TabIndex = 5;
            this.checkBox_automaticSendingActivated.Text = "Automatisches Senden";
            this.checkBox_automaticSendingActivated.UseVisualStyleBackColor = true;
            this.checkBox_automaticSendingActivated.CheckedChanged += new System.EventHandler(this.checkBox_automaticSendingActivated_CheckedChanged);
            // 
            // label_stetigesSenden
            // 
            this.label_stetigesSenden.AutoSize = true;
            this.label_stetigesSenden.Location = new System.Drawing.Point(7, 51);
            this.label_stetigesSenden.Name = "label_stetigesSenden";
            this.label_stetigesSenden.Size = new System.Drawing.Size(312, 17);
            this.label_stetigesSenden.TabIndex = 4;
            this.label_stetigesSenden.Text = "Button klicken, um stetiges Senden zu starten ...";
            // 
            // button_ManuellesSenden
            // 
            this.button_ManuellesSenden.Location = new System.Drawing.Point(791, 22);
            this.button_ManuellesSenden.Name = "button_ManuellesSenden";
            this.button_ManuellesSenden.Size = new System.Drawing.Size(193, 23);
            this.button_ManuellesSenden.TabIndex = 2;
            this.button_ManuellesSenden.Text = "Manuelles Senden";
            this.button_ManuellesSenden.UseVisualStyleBackColor = true;
            this.button_ManuellesSenden.Click += new System.EventHandler(this.button_ManuellesSenden_Click);
            // 
            // textBox_DataToBeSend
            // 
            this.textBox_DataToBeSend.Location = new System.Drawing.Point(7, 22);
            this.textBox_DataToBeSend.Name = "textBox_DataToBeSend";
            this.textBox_DataToBeSend.Size = new System.Drawing.Size(778, 22);
            this.textBox_DataToBeSend.TabIndex = 0;
            this.textBox_DataToBeSend.Text = "Default Stream ...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_binäresTelegram);
            this.groupBox2.Location = new System.Drawing.Point(26, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1023, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Empfangen";
            // 
            // label_binäresTelegram
            // 
            this.label_binäresTelegram.Location = new System.Drawing.Point(7, 24);
            this.label_binäresTelegram.Name = "label_binäresTelegram";
            this.label_binäresTelegram.Size = new System.Drawing.Size(1006, 62);
            this.label_binäresTelegram.TabIndex = 1;
            this.label_binäresTelegram.Text = "Warte auf binäres Telegram ... Bitte Emulator starten";
            // 
            // progressBar_Verbinden
            // 
            this.progressBar_Verbinden.Location = new System.Drawing.Point(465, 20);
            this.progressBar_Verbinden.Name = "progressBar_Verbinden";
            this.progressBar_Verbinden.Size = new System.Drawing.Size(129, 31);
            this.progressBar_Verbinden.TabIndex = 6;
            // 
            // timer_SchreibenVonMcTelegramInTxt
            // 
            this.timer_SchreibenVonMcTelegramInTxt.Interval = 2999;
            this.timer_SchreibenVonMcTelegramInTxt.Tick += new System.EventHandler(this.timer_SchreibenVonMcTelegramInTxt_Tick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox_dummyIFrontMc01);
            this.groupBox3.Controls.Add(this.button_disconnectMc1);
            this.groupBox3.Controls.Add(this.progressBar_Verbinden);
            this.groupBox3.Controls.Add(this.comboBox_AllActivePorts);
            this.groupBox3.Controls.Add(this.button_Verbinden);
            this.groupBox3.Location = new System.Drawing.Point(12, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1240, 252);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Motorcontroller 1";
            // 
            // groupBox_dummyIFrontMc01
            // 
            this.groupBox_dummyIFrontMc01.Controls.Add(this.label2);
            this.groupBox_dummyIFrontMc01.Controls.Add(this.textBox_setTorqueMc01);
            this.groupBox_dummyIFrontMc01.Controls.Add(this.textBox_setSetPointMc01);
            this.groupBox_dummyIFrontMc01.Controls.Add(this.label14);
            this.groupBox_dummyIFrontMc01.Controls.Add(this.label13);
            this.groupBox_dummyIFrontMc01.Location = new System.Drawing.Point(1056, 20);
            this.groupBox_dummyIFrontMc01.Name = "groupBox_dummyIFrontMc01";
            this.groupBox_dummyIFrontMc01.Size = new System.Drawing.Size(165, 226);
            this.groupBox_dummyIFrontMc01.TabIndex = 25;
            this.groupBox_dummyIFrontMc01.TabStop = false;
            this.groupBox_dummyIFrontMc01.Text = "Dummy IFrontendFeedback";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 47);
            this.label2.TabIndex = 6;
            this.label2.Text = "(Werte werden alle 3 Sekunden gesendet)";
            // 
            // textBox_setTorqueMc01
            // 
            this.textBox_setTorqueMc01.Location = new System.Drawing.Point(79, 71);
            this.textBox_setTorqueMc01.Name = "textBox_setTorqueMc01";
            this.textBox_setTorqueMc01.Size = new System.Drawing.Size(53, 22);
            this.textBox_setTorqueMc01.TabIndex = 5;
            this.textBox_setTorqueMc01.Text = "40";
            // 
            // textBox_setSetPointMc01
            // 
            this.textBox_setSetPointMc01.Location = new System.Drawing.Point(79, 38);
            this.textBox_setSetPointMc01.Name = "textBox_setSetPointMc01";
            this.textBox_setSetPointMc01.Size = new System.Drawing.Size(53, 22);
            this.textBox_setSetPointMc01.TabIndex = 4;
            this.textBox_setSetPointMc01.Text = "100";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Torque";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Setpoint";
            // 
            // button_disconnectMc1
            // 
            this.button_disconnectMc1.Location = new System.Drawing.Point(308, 19);
            this.button_disconnectMc1.Name = "button_disconnectMc1";
            this.button_disconnectMc1.Size = new System.Drawing.Size(151, 32);
            this.button_disconnectMc1.TabIndex = 2;
            this.button_disconnectMc1.Text = "Verbindung trennen";
            this.button_disconnectMc1.UseVisualStyleBackColor = true;
            this.button_disconnectMc1.Click += new System.EventHandler(this.button_disconnectMc1_Click);
            // 
            // progressBar_Verbinden02
            // 
            this.progressBar_Verbinden02.Location = new System.Drawing.Point(465, 21);
            this.progressBar_Verbinden02.Name = "progressBar_Verbinden02";
            this.progressBar_Verbinden02.Size = new System.Drawing.Size(129, 30);
            this.progressBar_Verbinden02.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_binaeresTelegramMc02);
            this.groupBox4.Location = new System.Drawing.Point(26, 411);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1023, 103);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Empfangen";
            // 
            // label_binaeresTelegramMc02
            // 
            this.label_binaeresTelegramMc02.Location = new System.Drawing.Point(10, 27);
            this.label_binaeresTelegramMc02.Name = "label_binaeresTelegramMc02";
            this.label_binaeresTelegramMc02.Size = new System.Drawing.Size(1007, 62);
            this.label_binaeresTelegramMc02.TabIndex = 1;
            this.label_binaeresTelegramMc02.Text = "Warte auf binäres Telegram ...";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox_automaticSendingActivated02);
            this.groupBox5.Controls.Add(this.label_stetigesSendenMc02);
            this.groupBox5.Controls.Add(this.button_ManuellesSenden02);
            this.groupBox5.Controls.Add(this.textBox_DataToBeSend02);
            this.groupBox5.Location = new System.Drawing.Point(26, 325);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1023, 80);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Senden";
            // 
            // checkBox_automaticSendingActivated02
            // 
            this.checkBox_automaticSendingActivated02.AutoSize = true;
            this.checkBox_automaticSendingActivated02.Location = new System.Drawing.Point(794, 50);
            this.checkBox_automaticSendingActivated02.Name = "checkBox_automaticSendingActivated02";
            this.checkBox_automaticSendingActivated02.Size = new System.Drawing.Size(175, 21);
            this.checkBox_automaticSendingActivated02.TabIndex = 5;
            this.checkBox_automaticSendingActivated02.Text = "Automatisches Senden";
            this.checkBox_automaticSendingActivated02.UseVisualStyleBackColor = true;
            this.checkBox_automaticSendingActivated02.CheckedChanged += new System.EventHandler(this.checkBox_automaticSendingActivated02_CheckedChanged);
            // 
            // label_stetigesSendenMc02
            // 
            this.label_stetigesSendenMc02.AutoSize = true;
            this.label_stetigesSendenMc02.Location = new System.Drawing.Point(7, 51);
            this.label_stetigesSendenMc02.Name = "label_stetigesSendenMc02";
            this.label_stetigesSendenMc02.Size = new System.Drawing.Size(312, 17);
            this.label_stetigesSendenMc02.TabIndex = 4;
            this.label_stetigesSendenMc02.Text = "Button klicken, um stetiges Senden zu starten ...";
            // 
            // button_ManuellesSenden02
            // 
            this.button_ManuellesSenden02.Location = new System.Drawing.Point(794, 21);
            this.button_ManuellesSenden02.Name = "button_ManuellesSenden02";
            this.button_ManuellesSenden02.Size = new System.Drawing.Size(193, 23);
            this.button_ManuellesSenden02.TabIndex = 2;
            this.button_ManuellesSenden02.Text = "Manuelles Senden";
            this.button_ManuellesSenden02.UseVisualStyleBackColor = true;
            this.button_ManuellesSenden02.Click += new System.EventHandler(this.button_ManuellesSenden02_Click);
            // 
            // textBox_DataToBeSend02
            // 
            this.textBox_DataToBeSend02.Location = new System.Drawing.Point(7, 22);
            this.textBox_DataToBeSend02.Name = "textBox_DataToBeSend02";
            this.textBox_DataToBeSend02.Size = new System.Drawing.Size(778, 22);
            this.textBox_DataToBeSend02.TabIndex = 0;
            this.textBox_DataToBeSend02.Text = "Default Stream ...";
            // 
            // button_VerbindenMc2
            // 
            this.button_VerbindenMc2.Location = new System.Drawing.Point(198, 21);
            this.button_VerbindenMc2.Name = "button_VerbindenMc2";
            this.button_VerbindenMc2.Size = new System.Drawing.Size(104, 30);
            this.button_VerbindenMc2.TabIndex = 10;
            this.button_VerbindenMc2.Text = "Verbinden";
            this.button_VerbindenMc2.UseVisualStyleBackColor = true;
            this.button_VerbindenMc2.Click += new System.EventHandler(this.button_VerbindenMc2_Click);
            // 
            // comboBox_AllActivePorts02
            // 
            this.comboBox_AllActivePorts02.FormattingEnabled = true;
            this.comboBox_AllActivePorts02.Location = new System.Drawing.Point(102, 287);
            this.comboBox_AllActivePorts02.Name = "comboBox_AllActivePorts02";
            this.comboBox_AllActivePorts02.Size = new System.Drawing.Size(101, 24);
            this.comboBox_AllActivePorts02.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "COM Port:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button_disconnectMc2);
            this.groupBox6.Controls.Add(this.groupBox8);
            this.groupBox6.Controls.Add(this.progressBar_Verbinden02);
            this.groupBox6.Controls.Add(this.button_VerbindenMc2);
            this.groupBox6.Location = new System.Drawing.Point(12, 263);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1240, 257);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Motorcontroller 2";
            // 
            // button_disconnectMc2
            // 
            this.button_disconnectMc2.Location = new System.Drawing.Point(308, 21);
            this.button_disconnectMc2.Name = "button_disconnectMc2";
            this.button_disconnectMc2.Size = new System.Drawing.Size(151, 30);
            this.button_disconnectMc2.TabIndex = 27;
            this.button_disconnectMc2.Text = "Verbindung trennen";
            this.button_disconnectMc2.UseVisualStyleBackColor = true;
            this.button_disconnectMc2.Click += new System.EventHandler(this.button_disconnectMc2_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.label8);
            this.groupBox8.Controls.Add(this.textBox_setTorqueMc02);
            this.groupBox8.Controls.Add(this.textBox_setSetPointMc02);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Location = new System.Drawing.Point(1056, 18);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(165, 233);
            this.groupBox8.TabIndex = 26;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Dummy IFrontendFeedback";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(7, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 74);
            this.label11.TabIndex = 7;
            this.label11.Text = "(Werte werden alle 3 Sekunden gesendet)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 117);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Secs";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Senden in";
            // 
            // textBox_setTorqueMc02
            // 
            this.textBox_setTorqueMc02.Location = new System.Drawing.Point(79, 71);
            this.textBox_setTorqueMc02.Name = "textBox_setTorqueMc02";
            this.textBox_setTorqueMc02.Size = new System.Drawing.Size(53, 22);
            this.textBox_setTorqueMc02.TabIndex = 5;
            this.textBox_setTorqueMc02.Text = "40";
            // 
            // textBox_setSetPointMc02
            // 
            this.textBox_setSetPointMc02.Location = new System.Drawing.Point(79, 38);
            this.textBox_setSetPointMc02.Name = "textBox_setSetPointMc02";
            this.textBox_setSetPointMc02.Size = new System.Drawing.Size(53, 22);
            this.textBox_setSetPointMc02.TabIndex = 4;
            this.textBox_setSetPointMc02.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Torque";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 17);
            this.label10.TabIndex = 1;
            this.label10.Text = "Setpoint";
            // 
            // progressBar_Verbinden03
            // 
            this.progressBar_Verbinden03.Location = new System.Drawing.Point(465, 21);
            this.progressBar_Verbinden03.Name = "progressBar_Verbinden03";
            this.progressBar_Verbinden03.Size = new System.Drawing.Size(129, 30);
            this.progressBar_Verbinden03.TabIndex = 22;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label_binaeresTelegramBms);
            this.groupBox7.Location = new System.Drawing.Point(14, 54);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1207, 152);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Empfangen";
            // 
            // label_binaeresTelegramBms
            // 
            this.label_binaeresTelegramBms.Location = new System.Drawing.Point(10, 32);
            this.label_binaeresTelegramBms.Name = "label_binaeresTelegramBms";
            this.label_binaeresTelegramBms.Size = new System.Drawing.Size(1177, 102);
            this.label_binaeresTelegramBms.TabIndex = 1;
            this.label_binaeresTelegramBms.Text = "Warte auf binäres Telegram ...";
            // 
            // button_VerbindenBms
            // 
            this.button_VerbindenBms.Location = new System.Drawing.Point(198, 21);
            this.button_VerbindenBms.Name = "button_VerbindenBms";
            this.button_VerbindenBms.Size = new System.Drawing.Size(104, 30);
            this.button_VerbindenBms.TabIndex = 18;
            this.button_VerbindenBms.Text = "Verbinden";
            this.button_VerbindenBms.UseVisualStyleBackColor = true;
            this.button_VerbindenBms.Click += new System.EventHandler(this.button_VerbindenBms_Click);
            // 
            // comboBox_AllActivePorts03
            // 
            this.comboBox_AllActivePorts03.FormattingEnabled = true;
            this.comboBox_AllActivePorts03.Location = new System.Drawing.Point(102, 550);
            this.comboBox_AllActivePorts03.Name = "comboBox_AllActivePorts03";
            this.comboBox_AllActivePorts03.Size = new System.Drawing.Size(101, 24);
            this.comboBox_AllActivePorts03.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 550);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "COM Port:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button_disconnectBms);
            this.groupBox9.Controls.Add(this.button_VerbindenBms);
            this.groupBox9.Controls.Add(this.progressBar_Verbinden03);
            this.groupBox9.Controls.Add(this.groupBox7);
            this.groupBox9.Location = new System.Drawing.Point(12, 526);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1240, 221);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "BMS";
            // 
            // button_disconnectBms
            // 
            this.button_disconnectBms.Location = new System.Drawing.Point(308, 21);
            this.button_disconnectBms.Name = "button_disconnectBms";
            this.button_disconnectBms.Size = new System.Drawing.Size(151, 30);
            this.button_disconnectBms.TabIndex = 28;
            this.button_disconnectBms.Text = "Verbindung trennen";
            this.button_disconnectBms.UseVisualStyleBackColor = true;
            this.button_disconnectBms.Click += new System.EventHandler(this.button_disconnectBms_Click);
            // 
            // timer_SchreibenVonMcTelegramInTxt02
            // 
            this.timer_SchreibenVonMcTelegramInTxt02.Interval = 2999;
            this.timer_SchreibenVonMcTelegramInTxt02.Tick += new System.EventHandler(this.timer_SchreibenVonMcTelegramInTxt02_Tick_1);
            // 
            // timer_SchreibenVonBmsTelegramInTxt
            // 
            this.timer_SchreibenVonBmsTelegramInTxt.Interval = 2999;
            this.timer_SchreibenVonBmsTelegramInTxt.Tick += new System.EventHandler(this.timer_SchreibenVonBmsTelegramInTxt_Tick);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.button_hilfeCom);
            this.groupBox10.Controls.Add(this.button_hilfeError);
            this.groupBox10.Controls.Add(this.button_ReturnErrorCom);
            this.groupBox10.Controls.Add(this.comboBox_addressErrorCom);
            this.groupBox10.Controls.Add(this.comboBox_SlaveIdErrorCom);
            this.groupBox10.Controls.Add(this.label_returnErrorCom);
            this.groupBox10.Controls.Add(this.label17);
            this.groupBox10.Controls.Add(this.label18);
            this.groupBox10.Controls.Add(this.label19);
            this.groupBox10.Controls.Add(this.button_ReturnIcom);
            this.groupBox10.Controls.Add(this.comboBox_IComAddress);
            this.groupBox10.Controls.Add(this.comboBox_SlaveId);
            this.groupBox10.Controls.Add(this.label_RückgabewertICom);
            this.groupBox10.Controls.Add(this.label7);
            this.groupBox10.Controls.Add(this.label3);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Location = new System.Drawing.Point(1260, 12);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(225, 508);
            this.groupBox10.TabIndex = 24;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Dummy ICommunication";
            // 
            // button_hilfeCom
            // 
            this.button_hilfeCom.Location = new System.Drawing.Point(122, 196);
            this.button_hilfeCom.Name = "button_hilfeCom";
            this.button_hilfeCom.Size = new System.Drawing.Size(93, 31);
            this.button_hilfeCom.TabIndex = 19;
            this.button_hilfeCom.Text = "Hilfe";
            this.button_hilfeCom.UseVisualStyleBackColor = true;
            this.button_hilfeCom.Click += new System.EventHandler(this.button_hilfeCom_Click);
            // 
            // button_hilfeError
            // 
            this.button_hilfeError.Location = new System.Drawing.Point(122, 426);
            this.button_hilfeError.Name = "button_hilfeError";
            this.button_hilfeError.Size = new System.Drawing.Size(93, 31);
            this.button_hilfeError.TabIndex = 18;
            this.button_hilfeError.Text = "Hilfe";
            this.button_hilfeError.UseVisualStyleBackColor = true;
            this.button_hilfeError.Click += new System.EventHandler(this.button_hilfeError_Click);
            // 
            // button_ReturnErrorCom
            // 
            this.button_ReturnErrorCom.Location = new System.Drawing.Point(16, 426);
            this.button_ReturnErrorCom.Name = "button_ReturnErrorCom";
            this.button_ReturnErrorCom.Size = new System.Drawing.Size(97, 31);
            this.button_ReturnErrorCom.TabIndex = 15;
            this.button_ReturnErrorCom.Text = "Return";
            this.button_ReturnErrorCom.UseVisualStyleBackColor = true;
            this.button_ReturnErrorCom.Click += new System.EventHandler(this.button_ReturnErrorCom_Click);
            // 
            // comboBox_addressErrorCom
            // 
            this.comboBox_addressErrorCom.FormattingEnabled = true;
            this.comboBox_addressErrorCom.Location = new System.Drawing.Point(16, 340);
            this.comboBox_addressErrorCom.Name = "comboBox_addressErrorCom";
            this.comboBox_addressErrorCom.Size = new System.Drawing.Size(121, 24);
            this.comboBox_addressErrorCom.TabIndex = 17;
            this.comboBox_addressErrorCom.SelectedIndexChanged += new System.EventHandler(this.comboBox_addressErrorCom_SelectedIndexChanged);
            // 
            // comboBox_SlaveIdErrorCom
            // 
            this.comboBox_SlaveIdErrorCom.FormattingEnabled = true;
            this.comboBox_SlaveIdErrorCom.Location = new System.Drawing.Point(16, 278);
            this.comboBox_SlaveIdErrorCom.Name = "comboBox_SlaveIdErrorCom";
            this.comboBox_SlaveIdErrorCom.Size = new System.Drawing.Size(121, 24);
            this.comboBox_SlaveIdErrorCom.TabIndex = 16;
            this.comboBox_SlaveIdErrorCom.SelectedIndexChanged += new System.EventHandler(this.comboBox_SlaveIdErrorCom_SelectedIndexChanged);
            // 
            // label_returnErrorCom
            // 
            this.label_returnErrorCom.Location = new System.Drawing.Point(16, 399);
            this.label_returnErrorCom.Name = "label_returnErrorCom";
            this.label_returnErrorCom.Size = new System.Drawing.Size(100, 36);
            this.label_returnErrorCom.TabIndex = 14;
            this.label_returnErrorCom.Text = "Return";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(16, 378);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 17);
            this.label17.TabIndex = 13;
            this.label17.Text = "Return ReceiveErrorMessage:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(16, 320);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 17);
            this.label18.TabIndex = 12;
            this.label18.Text = "Address";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(16, 258);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 17);
            this.label19.TabIndex = 11;
            this.label19.Text = "SlaveId";
            // 
            // button_ReturnIcom
            // 
            this.button_ReturnIcom.Location = new System.Drawing.Point(16, 196);
            this.button_ReturnIcom.Name = "button_ReturnIcom";
            this.button_ReturnIcom.Size = new System.Drawing.Size(97, 31);
            this.button_ReturnIcom.TabIndex = 9;
            this.button_ReturnIcom.Text = "Return";
            this.button_ReturnIcom.UseVisualStyleBackColor = true;
            this.button_ReturnIcom.Click += new System.EventHandler(this.button_ReturnIcom_Click);
            // 
            // comboBox_IComAddress
            // 
            this.comboBox_IComAddress.FormattingEnabled = true;
            this.comboBox_IComAddress.Location = new System.Drawing.Point(16, 110);
            this.comboBox_IComAddress.Name = "comboBox_IComAddress";
            this.comboBox_IComAddress.Size = new System.Drawing.Size(121, 24);
            this.comboBox_IComAddress.TabIndex = 10;
            this.comboBox_IComAddress.SelectedIndexChanged += new System.EventHandler(this.comboBox_IComAddress_SelectedIndexChanged);
            // 
            // comboBox_SlaveId
            // 
            this.comboBox_SlaveId.FormattingEnabled = true;
            this.comboBox_SlaveId.Location = new System.Drawing.Point(16, 48);
            this.comboBox_SlaveId.Name = "comboBox_SlaveId";
            this.comboBox_SlaveId.Size = new System.Drawing.Size(121, 24);
            this.comboBox_SlaveId.TabIndex = 9;
            this.comboBox_SlaveId.SelectedIndexChanged += new System.EventHandler(this.comboBox_SlaveId_SelectedIndexChanged);
            // 
            // label_RückgabewertICom
            // 
            this.label_RückgabewertICom.Location = new System.Drawing.Point(16, 165);
            this.label_RückgabewertICom.Name = "label_RückgabewertICom";
            this.label_RückgabewertICom.Size = new System.Drawing.Size(100, 36);
            this.label_RückgabewertICom.TabIndex = 8;
            this.label_RückgabewertICom.Text = "Return";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Return ReceiveData:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "SlaveId";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 755);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(164, 17);
            this.label15.TabIndex = 25;
            this.label15.Text = "Pfad Simulationsdateien:";
            // 
            // label_pathFolderSimualtion
            // 
            this.label_pathFolderSimualtion.AutoSize = true;
            this.label_pathFolderSimualtion.Location = new System.Drawing.Point(210, 755);
            this.label_pathFolderSimualtion.Name = "label_pathFolderSimualtion";
            this.label_pathFolderSimualtion.Size = new System.Drawing.Size(183, 17);
            this.label_pathFolderSimualtion.TabIndex = 26;
            this.label_pathFolderSimualtion.Text = "(Pfad aus Form pathinfo.cs)";
            // 
            // GuiSlaveSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1497, 781);
            this.Controls.Add(this.label_pathFolderSimualtion);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.comboBox_AllActivePorts03);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.comboBox_AllActivePorts02);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_ComPortDesc);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuiSlaveSimulator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI Slave Simulator";
            this.Load += new System.EventHandler(this.GuiSlaveSimulator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox_dummyIFrontMc01.ResumeLayout(false);
            this.groupBox_dummyIFrontMc01.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ComPortDesc;
        private System.Windows.Forms.ComboBox comboBox_AllActivePorts;
        private System.Windows.Forms.Button button_Verbinden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_DataToBeSend;
        private System.Windows.Forms.ProgressBar progressBar_Verbinden;
        private System.Windows.Forms.Timer timer_SchreibenVonMcTelegramInTxt;
        private System.Windows.Forms.Label label_binäresTelegram;
        private System.Windows.Forms.Label label_stetigesSenden;
        private System.Windows.Forms.CheckBox checkBox_automaticSendingActivated;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar progressBar_Verbinden02;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_binaeresTelegramMc02;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox_automaticSendingActivated02;
        private System.Windows.Forms.Label label_stetigesSendenMc02;
        private System.Windows.Forms.Button button_ManuellesSenden02;
        private System.Windows.Forms.TextBox textBox_DataToBeSend02;
        private System.Windows.Forms.Button button_VerbindenMc2;
        private System.Windows.Forms.ComboBox comboBox_AllActivePorts02;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ProgressBar progressBar_Verbinden03;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label_binaeresTelegramBms;
        private System.Windows.Forms.Button button_VerbindenBms;
        private System.Windows.Forms.ComboBox comboBox_AllActivePorts03;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button button_disconnectMc1;
        private System.IO.Ports.SerialPort serialPort_GuiBms;
        private System.IO.Ports.SerialPort serialPort_Gui02;
        private System.Windows.Forms.Timer timer_SchreibenVonMcTelegramInTxt02;
        private System.Windows.Forms.Timer timer_SchreibenVonBmsTelegramInTxt;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox_dummyIFrontMc01;
        public System.IO.Ports.SerialPort serialPort_Gui;
        private System.Windows.Forms.Label label_RückgabewertICom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_setTorqueMc01;
        private System.Windows.Forms.TextBox textBox_setSetPointMc01;
        private System.Windows.Forms.Button button_ReturnIcom;
        private System.Windows.Forms.ComboBox comboBox_SlaveId;
        private System.Windows.Forms.ComboBox comboBox_IComAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_setTorqueMc02;
        private System.Windows.Forms.TextBox textBox_setSetPointMc02;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_ManuellesSenden;
        private System.Windows.Forms.Button button_disconnectMc2;
        private System.Windows.Forms.Button button_disconnectBms;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_pathFolderSimualtion;
        private System.Windows.Forms.Button button_ReturnErrorCom;
        private System.Windows.Forms.ComboBox comboBox_addressErrorCom;
        private System.Windows.Forms.ComboBox comboBox_SlaveIdErrorCom;
        private System.Windows.Forms.Label label_returnErrorCom;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ToolTip toolTip_dummyFrontMc01;
        private System.Windows.Forms.Button button_hilfeCom;
        private System.Windows.Forms.Button button_hilfeError;
    }
}

