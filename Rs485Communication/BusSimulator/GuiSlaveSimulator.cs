using System;
using System.IO;
using System.Windows.Forms;
using System.IO.Ports;
using MasterManager;
using SlaveManager;
using RsCommunication;

namespace BusSimulator
{/// <summary>
/// Der GuiSlaveSimulator ist die Hauptapplikation in der das Empfangen und Senden von Daten über eine serielle Schnittstelle ermöglicht werden soll.
/// Dabei können insgesamt drei Geräte (2*MC und 1*BMS) simuliert werden
/// Eine Hauptaufgabe der Applikation ist es dabei, zufällige Daten zu erzeugen
/// </summary>
    public partial class GuiSlaveSimulator : Form
    {

        #region Definitionen übergreifender Variablen
        public string pathSimulationData;
        public string empfangenesTelegram;
        public string empfangenesTelegramMc02;
        public string empfangenesTelegramBms;
        public GuiTelegram neuesGuiTelegram;
        public GuiTelegram neuesGuiTelegramMc02;
        public McTelegram neuesMcTelegram;
        public McTelegram neuesMc02Telegram;
        public BmsTelegram neuesBmsTelegram;
        #endregion

        #region Laden/Starten und Schließen der Applikation
        public GuiSlaveSimulator(string pathSimulationDataForm1)
        {
            InitializeComponent();
            pathSimulationData = pathSimulationDataForm1;
        }

        private void GuiSlaveSimulator_Load(object sender, EventArgs e)
        {
            label_pathFolderSimualtion.Text = pathSimulationData;

            //Laden aller simulierten(angeschlossenen) ComPorts
            string[] ports = SerialPort.GetPortNames();
            comboBox_AllActivePorts.Items.AddRange(ports);
            comboBox_AllActivePorts02.Items.AddRange(ports);
            comboBox_AllActivePorts03.Items.AddRange(ports);


            //die verschiedenen Funktionen sollen erst zur Verfügung stehen, sobald COM verbunden wurde
            button_ManuellesSenden.Enabled = false; //z.B. solange Port noch nicht geöffnet, soll Senden nicht möglich sein
            checkBox_automaticSendingActivated.Enabled = false;
            button_ManuellesSenden02.Enabled = false;
            checkBox_automaticSendingActivated02.Enabled = false;
            textBox_setSetPointMc01.Enabled = false;
            textBox_setTorqueMc01.Enabled = false;
            textBox_setSetPointMc02.Enabled = false;
            textBox_setTorqueMc02.Enabled = false;
            comboBox_SlaveIdErrorCom.Enabled = false;
            comboBox_addressErrorCom.Enabled = false;
            button_ReturnErrorCom.Enabled = false;
            comboBox_SlaveId.Enabled = false;
            comboBox_IComAddress.Enabled = false;
            button_ReturnIcom.Enabled = false;
        }
        /// <summary>
        /// Beim Schließen des Simulators sollen alle COM-Verbindungen getrennt werden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuiSlaveSimulator_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            serialPort_Gui.Close();
            serialPort_Gui02.Close();
            serialPort_GuiBms.Close();
        }
        #endregion

        #region Implementierung für MC01

        /// <summary>
        /// Die Verbindung zum COM Port wird hergestellt sowie die grundlegenden Eigenschaften des Ports initialisiert;
        /// der ausgewählte Port ist der sendende Port; im Emulator muss der angeschlossene Part ausgewählt werden
        /// (z.B. bei COM1 wird an COM2 gesendet); Hinweise dazu werden dem*r User*in in der Form EmulatorInfo gegeben, die beim Klick auf Verbinden erscheint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Verbinden_Click(object sender, EventArgs e)
        {
            try
            {
                //Slave.InitializeComPort(comboBox_AllActivePorts.Text);
                serialPort_Gui.PortName = comboBox_AllActivePorts.Text;
                
                progressBar_Verbinden.Value = 20;
                serialPort_Gui.BaudRate = 115200;//aus Geiger Engineering Telegram
                progressBar_Verbinden.Value = 40;
                serialPort_Gui.DataBits = 8;//ggf. anpassen an MC Requirements (hier: Standardeinstellungen)
                progressBar_Verbinden.Value = 60;
                serialPort_Gui.Parity = Parity.None;//ggf. anpassen an MC Requirements
                progressBar_Verbinden.Value = 80;
                serialPort_Gui.StopBits = StopBits.One;//ggf. anpassen an MC Requirements
                progressBar_Verbinden.Value = 90;
                serialPort_Gui.Open();//öffnen des 
                serialPort_Gui.ReadTimeout = 1000;
                serialPort_Gui.DiscardOutBuffer();
                serialPort_Gui.DiscardInBuffer();
                string[] path = { @pathSimulationData, "Rs485MasterCommunication.txt" };
                //neuesMcTelegram.TelegramInTextdateiSchreiben(Path.Combine(path));
                //string[] firstTel = "-first Mc Telegram";
                //System.IO.File.WriteAllLines(path, firstTel);
                string pfadToFile = (Path.Combine(path));
                var newTelegramFile = System.IO.File.Create(pfadToFile);
                newTelegramFile.Close();

                //open Form Emulatoranweisungen; Com Port Nr. wird übergeben
                string chosenComInterface = comboBox_AllActivePorts.Text;
                int numberCom = Int32.Parse(chosenComInterface[3].ToString());
                
                EmulatorInfo emulatorInfoPort01 = new EmulatorInfo(numberCom,pfadToFile);
                emulatorInfoPort01.ShowDialog();

                //sobald emulatorinfo geschlossen, wird alles gestartet
                progressBar_Verbinden.Value = 95;
                button_ManuellesSenden.Enabled = true;
                checkBox_automaticSendingActivated.Enabled = true;

                //Starten des Timers, wodurch Empfangen der Telegramme des MC beginnt
                timer_SchreibenVonMcTelegramInTxt.Enabled = true;

                //ermöglicht das Testen des Interfaces für den MC01
                comboBox_SlaveId.Items.Add(185);
                comboBox_SlaveId.Enabled = true;
                comboBox_IComAddress.Enabled = true;
                button_ReturnIcom.Enabled = true;

                comboBox_SlaveIdErrorCom.Items.Add(185);
                comboBox_SlaveIdErrorCom.Enabled = true;
                comboBox_addressErrorCom.Enabled = true;
                button_ReturnErrorCom.Enabled = true;

                progressBar_Verbinden.Value = 100;

                //serialPort_Gui.DiscardOutBuffer();


            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// UserIn soll in der Lage sein einen manuell veränderten Bytestream/Telegram zu senden;
        /// Dieses Szenario dient lediglich zu Testzwecken und hat in der reellen Applikation keine Bewandniss
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ManuellesSenden_Click(object sender, EventArgs e)
        {
            string telegramManuell = textBox_DataToBeSend.Text;
            serialPort_Gui.Write(telegramManuell);
            textBox_DataToBeSend.Clear();

        }

        /// <summary>
        /// Beim Starten des Timers werden alle ~3 Sekunden randomisierte MC Telegramme erstellt, die anhand der Geiger-Excel-Telegram-Tabelle angelehnt aufgebaut wurden
        /// Die darin enthaltenen Informationen wurden dabei auf unser Dashboard angepasst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_SchreibenVonMcTelegramInTxt_Tick(object sender, EventArgs e)
        {
            timer_SchreibenVonMcTelegramInTxt.Enabled = false;

            //angepasst: Random Grenze+1
            neuesMcTelegram = new McTelegram((ushort)McTelegram.RandomWerteZuweisen(32,60),(byte)McTelegram.RandomWerteZuweisen(-30,401),(ushort)McTelegram.RandomWerteZuweisen(0, 2501), (byte)McTelegram.RandomWerteZuweisen(0, 66), (byte)McTelegram.RandomWerteZuweisen(0, 131), (short)McTelegram.RandomWerteZuweisen(0, 401),(byte)McTelegram.RandomWerteZuweisen(1,256), (byte)McTelegram.RandomWerteZuweisen(1, 256),(byte)McTelegram.RandomWerteZuweisen(0, 101),(ushort)McTelegram.RandomWerteZuweisen(0, 65536));
            string[] path = { @pathSimulationData, "Rs485MasterCommunication.txt" };
            neuesMcTelegram.TelegramInTextdateiSchreiben(Path.Combine(path));

            //Random GuiTelegram(d.h. von Gui an MC) wird erzeugt
            if (checkBox_automaticSendingActivated.Checked)
            {
                try
                {
                    ushort setPoint = Convert.ToUInt16(textBox_setSetPointMc01.Text);
                    byte torque = Convert.ToByte(textBox_setTorqueMc01.Text);
                    if (setPoint > 0 & setPoint <= 1000 & torque > 0 & torque <= 100)
                    {
                        neuesGuiTelegram = new GuiTelegram(setPoint, torque);
                        string binaeresGuiTelegram = neuesGuiTelegram.TelgramBinaerAusgeben();
                        serialPort_Gui.Write(binaeresGuiTelegram);
                        label_stetigesSenden.Text = binaeresGuiTelegram;
                    }
                    else
                    {
                        MessageBox.Show("Bitte Wertebereiche des Setpoints (0-1000) und des Torques (0-100) beachten.");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }

            //Telegram (des MC) wird vom Slave-Gui empfangen/gelesen und angezeigt in Simulator
            empfangenesTelegram = serialPort_Gui.ReadExisting();
            this.Invoke(new EventHandler(TelegramAnzeigen));
            timer_SchreibenVonMcTelegramInTxt.Enabled = true;
        }
        
        /// <summary>
        /// Nachdem eine Verbindung zwischen den ausgewählten COM Ports hergestellt wurde, wird im Empfangen-Fenster der Anwendung das jeweils letzte Telegram angezeigt, dass von der GUI (vom MC01) empfangen wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TelegramAnzeigen(object sender, EventArgs e)
        {
            label_binäresTelegram.Text = empfangenesTelegram;
        }

        /// <summary>
        /// Sobald das automatische Senden aktiviert ist, soll der*die User*in nicht mit in der Lage sein eigene Telegramme zu senden
        /// Gleichzeitig soll nun möglich sein, die Funktionsweise der Interfaces zu testen
        /// d.h. es soll ein Slave/Master ausgewählt werden können (MC1, MC2 oder BMS) und ein bestimmter Wert in bestimmten Fällen gesetzt bzw. erhalten werden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_automaticSendingActivated_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_automaticSendingActivated.Checked)
            {
                 textBox_DataToBeSend.Enabled = false;
                 button_ManuellesSenden.Enabled = false;
                 textBox_setSetPointMc01.Enabled = true;
                 textBox_setTorqueMc01.Enabled = true;
            }
            else
            {
                textBox_setSetPointMc01.Enabled = false;
                textBox_setTorqueMc01.Enabled = false;
                textBox_DataToBeSend.Enabled = true;
                button_ManuellesSenden.Enabled = true;
            }

        }

        /// <summary>
        /// Beim Klick auf den Button disconnect wird die Verbindung zwischen Gui und Mc01 getrennt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_disconnectMc1_Click(object sender, EventArgs e)
        {
            serialPort_Gui.Close();
            timer_SchreibenVonMcTelegramInTxt.Enabled = false;
            checkBox_automaticSendingActivated.Enabled = false;
            button_ManuellesSenden.Enabled = false;
            progressBar_Verbinden.Value = 0;

        }
        #endregion

        #region Implementierung für MC02

        /// <summary>
        /// Die Verbindung zum COM Port wird hergestellt sowie die grundlegenden Eigenschaften des Ports initialisiert;
        /// der ausgewählte Port ist der sendende Port; im Emulator muss der angeschlossene Part ausgewählt werden
        /// (z.B. bei COM1 wird an COM2 gesendet); Hinweise dazu werden dem*r User*in in der Form EmulatorInfo gegeben, die beim Klick auf Verbinden erscheint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_VerbindenMc2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_Gui02.PortName = comboBox_AllActivePorts02.Text;

                progressBar_Verbinden02.Value = 20;
                serialPort_Gui02.BaudRate = 115200;//aus Geiger Engineering Telegram
                progressBar_Verbinden02.Value = 40;
                serialPort_Gui02.DataBits = 8;//ggf. anpassen an MC Requirements
                progressBar_Verbinden02.Value = 60;
                serialPort_Gui02.Parity = Parity.None;//ggf. anpassen an MC Requirements
                progressBar_Verbinden02.Value = 80;
                serialPort_Gui02.StopBits = StopBits.One;//ggf. anpassen an MC Requirements
                progressBar_Verbinden02.Value = 90;
                serialPort_Gui02.Open();//öffnen des Ports
                progressBar_Verbinden02.Value = 95;
                string[] path = { @pathSimulationData, "Rs485Master02Communication.txt" };
                string pfadToFile = (Path.Combine(path));
                var newTelegramFile = System.IO.File.Create(pfadToFile);
                newTelegramFile.Close();

                //Die Form EmulatorInfo wird geöffnet; Com Port Nr. wird übergeben
                string chosenComInterface = comboBox_AllActivePorts02.Text;
                int numberCom = Int32.Parse(chosenComInterface[3].ToString());
                
                EmulatorInfo emulatorInfoPort02 = new EmulatorInfo(numberCom, pfadToFile);
                emulatorInfoPort02.ShowDialog();

                //sobald emulatorinfo geschlossen, wird alles gestartet
                button_ManuellesSenden02.Enabled = true;
                checkBox_automaticSendingActivated02.Enabled = true;
                
                //Empfangen der MC300-Daten wird gestartet durch Beginn des (zweiten) Timers
                timer_SchreibenVonMcTelegramInTxt02.Enabled = true;

                //ermöglicht das Testen des Interfaces für den MC02
                comboBox_SlaveId.Items.Add(285);
                comboBox_SlaveId.Enabled = true;
                comboBox_IComAddress.Enabled = true;
                button_ReturnIcom.Enabled = true;

                comboBox_SlaveIdErrorCom.Items.Add(285);
                comboBox_SlaveIdErrorCom.Enabled = true;
                comboBox_addressErrorCom.Enabled = true;
                button_ReturnErrorCom.Enabled = true;
                progressBar_Verbinden02.Value = 100;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// UserIn soll in der Lage sein einen manuell veränderten Bytestream/Telegram zu senden;
        /// Dieses Szenario dient lediglich zu Testzwecken und hat in der reellen Applikation keine Bewandniss
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ManuellesSenden02_Click(object sender, EventArgs e)
        {
            string telegramManuell = textBox_DataToBeSend02.Text;
            serialPort_Gui02.Write(telegramManuell);
            textBox_DataToBeSend02.Clear();
        }
        /// <summary>
        /// Beim Starten des Timers werden alle ~3 Sekunden randomisierte MC Telegramme erstellt, die anhand der Geiger-Excel-Telegram-Tabelle angelehnt aufgebaut wurden
        /// Die darin enthaltenen Informationen wurden dabei auf unser Dashboard angepasst
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_SchreibenVonMcTelegramInTxt02_Tick_1(object sender, EventArgs e)
        {
            timer_SchreibenVonMcTelegramInTxt02.Enabled = false;

            neuesMc02Telegram = new McTelegram((ushort)Telegram.RandomWerteZuweisen(32, 60), (byte)Telegram.RandomWerteZuweisen(-30, 401), (ushort)Telegram.RandomWerteZuweisen(0, 2501), (byte)Telegram.RandomWerteZuweisen(0, 66), (byte)Telegram.RandomWerteZuweisen(0, 131), (short)Telegram.RandomWerteZuweisen(0, 401), (byte)Telegram.RandomWerteZuweisen(1, 256), (byte)Telegram.RandomWerteZuweisen(1, 256), (byte)Telegram.RandomWerteZuweisen(0, 101), (ushort)Telegram.RandomWerteZuweisen(0, 65536));
            string[] path = { @pathSimulationData, "Rs485Master02Communication.txt" };
            neuesMc02Telegram.TelegramInTextdateiSchreiben(Path.Combine(path));


            //Random GuiTelegram wird erzeugt
            //if (checkBox_automaticSendingActivated02.Checked)
            //{
            //    //angepasst: Random Grenze+1
            //    neuesGuiTelegramMc02 = new GuiTelegram((ushort)Telegram.RandomWerteZuweisen(0, 1001), (byte)Telegram.RandomWerteZuweisen(0, 101));
            //    string binaeresGuiTelegramm = neuesGuiTelegramMc02.TelgramBinaerAusgeben();
            //    serialPort_Gui02.Write(binaeresGuiTelegramm);
            //    label_stetigesSendenMc02.Text = binaeresGuiTelegramm;
            //}

            if (checkBox_automaticSendingActivated02.Checked)
            {
                try
                {
                    ushort setPoint = Convert.ToUInt16(textBox_setSetPointMc02.Text);
                    byte torque = Convert.ToByte(textBox_setTorqueMc02.Text);
                    if (setPoint > 0 & setPoint <= 1000 & torque > 0 & torque <= 100)
                    {
                        neuesGuiTelegramMc02 = new GuiTelegram(setPoint, torque);
                        string binaeresGuiTelegram = neuesGuiTelegramMc02.TelgramBinaerAusgeben();
                        serialPort_Gui02.Write(binaeresGuiTelegram);
                        label_stetigesSendenMc02.Text = binaeresGuiTelegram;
                    }
                    else
                    {
                        MessageBox.Show("Bitte Wertebereiche des Setpoints (0-1000) und des Torques (0-100) beachten.");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

            //Telegram wird vom Slave-Gui empfangen/gelesen und angezeigt in Simulator
            empfangenesTelegramMc02 = serialPort_Gui02.ReadExisting();
            this.Invoke(new EventHandler(TelegramMc02Anzeigen));
            timer_SchreibenVonMcTelegramInTxt02.Enabled = true;
        }
        /// <summary>
        /// Nachdem eine Verbindung zwischen den ausgewählten COM Ports hergestellt wurde, wird im Empfangen-Fenster der Anwendung das jeweils letzte Telegram angezeigt, dass von der GUI (vom MC02) empfangen wurde
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TelegramMc02Anzeigen(object sender, EventArgs e)
        {
            label_binaeresTelegramMc02.Text = empfangenesTelegramMc02;
        }
        /// <summary>
        /// Sobald das automatische Senden aktiviert ist, soll der*die User*in nicht mit in der Lage sein eigene Telegramme zu senden
        /// Gleichzeitig soll nun möglich sein, die Funktionsweise der Interfaces zu testen
        /// d.h. es soll ein Slave/Master ausgewählt werden können (MC1, MC2 oder BMS) und ein bestimmter Wert in bestimmten Fällen gesetzt bzw. erhalten werden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox_automaticSendingActivated02_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_automaticSendingActivated02.Checked)
            {
                textBox_setSetPointMc02.Enabled = true;
                textBox_setTorqueMc02.Enabled = true;
                textBox_DataToBeSend02.Enabled = false;
                button_ManuellesSenden02.Enabled = false;
            }
            else
            {
                textBox_setSetPointMc02.Enabled = false;
                textBox_setTorqueMc02.Enabled = false;
                textBox_DataToBeSend02.Enabled = true;
                button_ManuellesSenden02.Enabled = true;
            }
        }

        /// <summary>
        /// Beim Klick auf den Button disconnect wird die Verbindung zwischen Gui und Mc01 getrennt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_disconnectMc2_Click(object sender, EventArgs e)
        {
            serialPort_Gui02.Close();
            timer_SchreibenVonMcTelegramInTxt02.Enabled = false;
            checkBox_automaticSendingActivated.Enabled = false;
            button_ManuellesSenden.Enabled = false;
            progressBar_Verbinden02.Value = 0;
        }

        #endregion

        #region Implementierung für das BMS
        /// <summary>
        /// Die Verbindung zum COM Port wird hergestellt sowie die grundlegenden Eigenschaften des Ports initialisiert;
        /// der ausgewählte Port ist der sendende Port; im Emulator muss der angeschlossene Part ausgewählt werden
        /// (z.B. bei COM1 wird an COM2 gesendet); Hinweise dazu werden dem*r User*in in der Form EmulatorInfo gegeben, die beim Klick auf Verbinden erscheint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_VerbindenBms_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort_GuiBms.PortName = comboBox_AllActivePorts03.Text;

                progressBar_Verbinden03.Value = 20;
                serialPort_GuiBms.BaudRate = 115200;//aus Geiger Engineering Telegram
                progressBar_Verbinden03.Value = 40;
                serialPort_GuiBms.DataBits = 8;//ggf. anpassen an MC Requirements
                progressBar_Verbinden03.Value = 60;
                serialPort_GuiBms.Parity = Parity.None;//ggf. anpassen an MC Requirements
                progressBar_Verbinden03.Value = 80;
                serialPort_GuiBms.StopBits = StopBits.One;//ggf. anpassen an MC Requirements
                progressBar_Verbinden03.Value = 90;
                serialPort_GuiBms.Open();//öffnen des Ports
                progressBar_Verbinden03.Value = 95;
                string[] path = { @pathSimulationData, "BmsCommunication.txt" };
                string pfadToFile = (Path.Combine(path));

                var newTelegramFile = System.IO.File.Create(pfadToFile);
                newTelegramFile.Close();

                //Die Form EmulatorInfo wird geöffnet; Com Port Nr. wird übergeben
                string chosenComInterface = comboBox_AllActivePorts03.Text;
                int numberCom = Int32.Parse(chosenComInterface[3].ToString());
                EmulatorInfo emulatorInfoPort03 = new EmulatorInfo(numberCom, pfadToFile);
                emulatorInfoPort03.ShowDialog();

                //sobald emulatorinfo geschlossen, wird alles gestartet

                //Empfangen der Daten wird gestartet durch Beginn des 3. Timers
                timer_SchreibenVonBmsTelegramInTxt.Enabled = true;

                //ermöglicht das Testen des Interfaces für den Bms (d.h. ob Daten empfangen werden können mit der ReceiveData/ReceiveErrorMessages Funktion)
                comboBox_SlaveId.Items.Add(170);
                comboBox_SlaveId.Enabled = true;
                comboBox_IComAddress.Enabled = true;
                button_ReturnIcom.Enabled = true;

                comboBox_SlaveIdErrorCom.Items.Add(170);
                comboBox_SlaveIdErrorCom.Enabled = true;
                comboBox_addressErrorCom.Enabled = true;
                button_ReturnErrorCom.Enabled = true;

                progressBar_Verbinden03.Value = 100;

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        /// <summary>
        /// Der Timer starten die randomisierte Erstellung von BMS Telegrammen, die wieder in Anlehung an die Excel von Geiger aufgebaut sind
        /// Gleichzeitig wird alle 3 Sekunden vom GUI ein Telegram empfangen, das vom Emulator gesendet wird
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_SchreibenVonBmsTelegramInTxt_Tick(object sender, EventArgs e)
        {
            timer_SchreibenVonBmsTelegramInTxt.Enabled = false;
            neuesBmsTelegram=new BmsTelegram((ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536),(int)Telegram.RandomWerteZuweisen(-2147483648, 214748364), Telegram.RandomWerteZuweisen(-2147483648, 214748364), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768),Telegram.RandomUintZuweisen(0, 4294967294), (ushort)Telegram.RandomWerteZuweisen(0,65536));

            string[] path = { @pathSimulationData, "BmsCommunication.txt" };
            neuesBmsTelegram.BmsTelegramInTextdateiSchreiben(Path.Combine(path));

            empfangenesTelegramBms = serialPort_GuiBms.ReadExisting();
            this.Invoke(new EventHandler(TelegramBmsAnzeigen));
            timer_SchreibenVonBmsTelegramInTxt.Enabled = true;
        }
        /// <summary>
        /// Das empfange Telegram des BMS wird angezeigt im Empfangen-Fenster der Applikation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TelegramBmsAnzeigen(object sender, EventArgs e)
        {
            label_binaeresTelegramBms.Text = empfangenesTelegramBms;
        }
        /// <summary>
        /// Der Verbindung zwischen GUI und BMS wird getrennt 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_disconnectBms_Click(object sender, EventArgs e)
        {
            serialPort_GuiBms.Close();
            timer_SchreibenVonBmsTelegramInTxt.Enabled = false;
            checkBox_automaticSendingActivated.Enabled = false;
            button_ManuellesSenden.Enabled = false;
            progressBar_Verbinden03.Value = 0;
        }
        #endregion

        #region Interfaces Testing
        /// <summary>
        /// Mit Hilfe diesem Teil der Applikation soll das Interface ICommunication getestet werden
        /// In diesem Fall wird die Methode ReceiveData getestet, der zwei Parameter (SlaveID und Address) übergeben werden
        /// Diese zwei Parameter werden hier über die beiden Textboxen übergeben
        /// Parameter: SlaveId - entweder 185 für MC1, 285 für MC2 oder 170 für das BMS
        /// Parameter: Address ist die Position des Bytes im empfangenen Bytestring.
        /// Für genauere Erklärungen zum Bytestring bitte auf die Excel RS485Telegramme_unserSetup (git->Phase02>Nina) zurückgreifen
        /// Der Logik ist die Position ebenfalls bekannt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ReturnIcom_Click(object sender, EventArgs e)
        {
            try
            {
                string telegram = "";
                switch (comboBox_SlaveId.Text)
                {
                    case "185":
                        telegram = empfangenesTelegram;
                        break;
                    case "285":
                        telegram = empfangenesTelegramMc02;
                        break;
                    case "170":
                        telegram = empfangenesTelegramBms;
                        break;
                }

                PreparedData preparedTelegram = new PreparedData(telegram);
                label_RückgabewertICom.Text = preparedTelegram.ReceiveData(Convert.ToInt16(comboBox_SlaveId.Text), Convert.ToInt32(comboBox_IComAddress.Text)).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
        /// <summary>
        /// je nachdem welcher Slave(Master) verbunden ist, soll es dem*der User*in möglich sein, die entsprechenden Positionen/Adressen der Werte zu erhalten
        ///Hierbei handelt es sich um die Funktion ReceiveData, die mit diesem Teil der Applikation verbunden ist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SlaveId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SlaveId.SelectedItem.Equals(185) ^ comboBox_SlaveId.SelectedItem.Equals(285))
            {
                comboBox_IComAddress.Items.Clear();
                comboBox_IComAddress.Items.AddRange(new string[] { "1", "2", "3", "4", "6", "8", "10", "11", "12", "14", "16", "17" });
            }

            if (comboBox_SlaveId.SelectedItem.Equals(170))
            {
                comboBox_IComAddress.Items.Clear();
                comboBox_IComAddress.Items.AddRange(new string[] { "1", "2", "3", "4", "6", "8", "10", "12", "14", "16", "18", "20", "22", "24", "28", "32", "34", "36", "38", "40", "42", "44" });
            }

            label_RückgabewertICom.Text = "";
        }
        /// <summary>
        /// Wenn der*die User*in die Paramter der Funktion ReceiveData (d.h. die Textboxen) ändert, soll der alte Wert nicht mehr angezeigt werden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_IComAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_RückgabewertICom.Text = "";
        }

        /// <summary>
        /// je nachdem welcher Slave(Master) verbunden ist, soll es dem*der User*in möglich sein, die entsprechenden Positionen/Adressen der Werte zu erhalten
        /// Hierbei handelt es sich um die Funktion ReceiveErrorMessage, die mit diesem Teil der Applikation verbunden ist
        /// </summary>       
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_SlaveIdErrorCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_SlaveIdErrorCom.SelectedItem.Equals(185) ^ comboBox_SlaveIdErrorCom.SelectedItem.Equals(285))
            {
                comboBox_addressErrorCom.Items.Clear();
                comboBox_addressErrorCom.Items.Add(15);
            }

            if (comboBox_SlaveIdErrorCom.SelectedItem.Equals(170))
            {
                comboBox_addressErrorCom.Items.Clear();
                comboBox_addressErrorCom.Items.AddRange(new string[] { "46", "50" });
            }

            label_RückgabewertICom.Text = "";
        }
        /// <summary>
        /// Der alte Wert soll nicht weiter angezeit werden, sobald die Eingabeparamter verändert werden
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_addressErrorCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_returnErrorCom.Text = "";
        }

        /// <summary>
        /// Der Return von der Funktion ReceiveErrorMessage soll ausgegeben werden. Dabei sind die Paramter zu vergleichen mit jenen der Funktion ReceiveData
        /// Allerdings wird in diesem Fall ein Bytewert zurückgegeben (als String), der für die Auswertung der Logik der Fehlermeldungen notwendig ist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_ReturnErrorCom_Click(object sender, EventArgs e)
        {
            string telegram = "";
            switch (comboBox_SlaveIdErrorCom.Text)
            {
                case "185":
                    telegram = empfangenesTelegram;
                    break;
                case "285":
                    telegram = empfangenesTelegramMc02;
                    break;
                case "170":
                    telegram = empfangenesTelegramBms;
                    break;
            }

            PreparedData preparedTelegram = new PreparedData(telegram);
            label_returnErrorCom.Text = preparedTelegram.ReceiveErrorMessage(Convert.ToInt16(comboBox_SlaveIdErrorCom.Text), Convert.ToInt32(comboBox_addressErrorCom.Text));
        }

        /// <summary>
        /// Hilfe-Window wird angezeigt mit Infos zu den Adressen
        /// </summary>
        private static void HilfeAnzeigen()
        {
            AddressInfo hilfeAddressen = new AddressInfo();
            hilfeAddressen.ShowDialog();
        }
        private void button_hilfeError_Click(object sender, EventArgs e)
        {
            HilfeAnzeigen();
        }
        private void button_hilfeCom_Click(object sender, EventArgs e)
        {
            HilfeAnzeigen();
        }

        #endregion


    }
}
