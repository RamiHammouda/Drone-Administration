using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MasterManager;
using SlaveManager;
using WindowsFormsApp1.UserControls;



namespace BusSimulator
{
    public partial class ConnectComPorts : Form
    {
        public string pathMc1;
        public string pathMc2;
        public string pathBms;

        
        //public string empfangenesTelegram;
        //public string empfangenesTelegramMc02;
        //public string empfangenesTelegramBms;
        public GuiTelegram neuesGuiTelegramMc01Frontend;
        public GuiTelegram neuesGuiTelegramMc02Frontend;
        public McTelegram neuesMc01TelegramFrontend;
        public McTelegram neuesMc02TelegramFrontend;
        public BmsTelegram neuesBmsTelegramFrontend;
        public ConnectComPorts()
        {
            InitializeComponent();
        }

        private void ConnectComPorts_Load(object sender, EventArgs e)
        {
            
            //Laden aller simulierten(angeschlossenen) ComPorts
            string[] portsFrontend = SerialPort.GetPortNames();
            comboBox_ddMc1Ports.Items.AddRange(portsFrontend);
            comboBox_ddMc2Ports.Items.AddRange(portsFrontend);
            comboBox_ddBmsPorts.Items.AddRange(portsFrontend);

            comboBox_ddMc1Ports.Enabled = false;
            comboBox_ddMc2Ports.Enabled = false;
            comboBox_ddBmsPorts.Enabled = false;
            button_HilfeAnzeigenMc1.Enabled = false;
            button_HilfeAnzeigenMc2.Enabled = false;
            button_HilfeAnzeigenBms.Enabled = false;
            button_verbindenPorts.Enabled = false;

            //if (comboBox_ddBmsPorts.Text != "" && comboBox_ddMc1Ports.Text != "" && comboBox_ddMc2Ports.Text != "")
            //{
            //    button_verbindenPorts.Enabled = true;
            //}
            //else
            //{
            //    button_verbindenPorts.Enabled = false;
            //}

        }

        private void button_HilfeAnzeigenMc1_Click(object sender, EventArgs e)
        {
            if (comboBox_ddMc1Ports.Text != "")
            {
                string chosenComInterface = comboBox_ddMc1Ports.Text;
                int numberCom = Int32.Parse(chosenComInterface[3].ToString());

                EmulatorInfo emulatorInfoPort01 = new EmulatorInfo(numberCom, pathMc1);
                emulatorInfoPort01.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bitte erst einen COM-Port wählen");
            }

        }

        private void button_PfadFrontendWählen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Bitte einen Ordner zur Erstellung der Simulationsdaten auswählen.";
            if (fbd.ShowDialog() == DialogResult.OK)//Nur wenn im fbd mit OK bestätigt wird, wird weiter fortgeführt
            {
                textBox_PfadFrontend.Text = fbd.SelectedPath;
            }
        }

        private void button_verbindenPorts_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox_ddMc1Ports.Text != "" && comboBox_ddMc2Ports.Text != "" && comboBox_ddBmsPorts.Text != "")
                {
                    //Slave.InitializeComPort(comboBox_AllActivePorts.Text);
                    serialPort_Mc01.PortName = comboBox_ddMc1Ports.Text;
                    serialPort_Mc02.PortName = comboBox_ddMc2Ports.Text;
                    serialPort_Bms.PortName = comboBox_ddBmsPorts.Text;



                    serialPort_Mc01.BaudRate = 115200;//aus Geiger Engineering Telegram
                    serialPort_Mc01.DataBits = 8;//ggf. anpassen an MC Requirements (hier: Standardeinstellungen)
                    serialPort_Mc01.Parity = Parity.None;//ggf. anpassen an MC Requirements
                    serialPort_Mc01.StopBits = StopBits.One;//ggf. anpassen an MC Requirements
                    serialPort_Mc01.Open();//öffnen des 
                    serialPort_Mc01.ReadTimeout = 1000;


                    serialPort_Mc02.BaudRate = 115200;//aus Geiger Engineering Telegram
                    serialPort_Mc02.DataBits = 8;//ggf. anpassen an MC Requirements (hier: Standardeinstellungen)
                    serialPort_Mc02.Parity = Parity.None;//ggf. anpassen an MC Requirements
                    serialPort_Mc02.StopBits = StopBits.One;//ggf. anpassen an MC Requirements
                    serialPort_Mc02.Open();//öffnen des 
                    serialPort_Mc02.ReadTimeout = 1000;

                    serialPort_Bms.BaudRate = 115200;//aus Geiger Engineering Telegram
                    serialPort_Bms.DataBits = 8;//ggf. anpassen an MC Requirements (hier: Standardeinstellungen)
                    serialPort_Bms.Parity = Parity.None;//ggf. anpassen an MC Requirements
                    serialPort_Bms.StopBits = StopBits.One;//ggf. anpassen an MC Requirements
                    serialPort_Bms.Open();//öffnen des 
                    serialPort_Bms.ReadTimeout = 1000;

                    string pathSimulationData = textBox_PfadFrontend.Text;

                    //string[] path = { @pathSimulationData, "Rs485MasterCommunication.txt" };


                    //neuesMcTelegram.TelegramInTextdateiSchreiben(Path.Combine(path));
                    //string[] firstTel = "-first Mc Telegram";
                    //System.IO.File.WriteAllLines(path, firstTel);
                    //string pfadToFile = (Path.Combine(path));
                    //var newTelegramFile = System.IO.File.Create(pfadToFile);
                    //newTelegramFile.Close();

                    //open Form Emulatoranweisungen; Com Port Nr. wird übergeben
                    //string chosenComInterface = comboBox_AllActivePorts.Text;
                    //int numberCom = Int32.Parse(chosenComInterface[3].ToString());

                    //EmulatorInfo emulatorInfoPort01 = new EmulatorInfo(numberCom, pfadToFile);
                    //emulatorInfoPort01.ShowDialog();


                    //Starten des Timers, wodurch Empfangen der Telegramme des MC beginnt
                    //XXX timer_SchreibenVonMcTelegramInTxt.Enabled = true;

                    //Starten der Timer
                    timer_Communication.Enabled = true;
                    timer_Mc2.Enabled = true;
                    timer_Bms.Enabled = true;

                    this.Visible = false;
                    this.ShowInTaskbar = false;
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie alle drei Ports aus");
                }
                

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void button_PfadValidieren_Click(object sender, EventArgs e)
        {
            string pathSimulationData = textBox_PfadFrontend.Text;
            

            pathMc1 =  @pathSimulationData+ @"\Rs485Mc1Communication.txt" ;
            pathMc2 =  @pathSimulationData+ @"\Rs485Mc2Communication.txt";
            pathBms = @pathSimulationData+ @"\Rs485BmsCommunication.txt" ;
            //neuesMcTelegram.TelegramInTextdateiSchreiben(Path.Combine(path));
            //string[] firstTel = "-first Mc Telegram";
            //System.IO.File.WriteAllLines(path, firstTel);
            string pfadToFileMc1 = (Path.Combine(pathMc1));
            var newTelegramMc1File = System.IO.File.Create(pfadToFileMc1);
            newTelegramMc1File.Close();

            string pfadToFileMc2 = (Path.Combine(pathMc2));
            var newTelegramMc2File = System.IO.File.Create(pfadToFileMc2);
            newTelegramMc2File.Close();

            string pfadToFileBms = (Path.Combine(pathBms));
            var newTelegramBmsFile = System.IO.File.Create(pfadToFileBms);
            newTelegramBmsFile.Close();

            comboBox_ddMc1Ports.Enabled = true;
            comboBox_ddMc2Ports.Enabled = true;
            comboBox_ddBmsPorts.Enabled = true;
            button_HilfeAnzeigenMc1.Enabled = true;
            button_HilfeAnzeigenMc2.Enabled = true;
            button_HilfeAnzeigenBms.Enabled = true;
            button_verbindenPorts.Enabled = true;
        }

        private void button_HilfeAnzeigenMc2_Click(object sender, EventArgs e)
        {
            if (comboBox_ddMc2Ports.Text != "")
            {
                string chosenComInterface = comboBox_ddMc2Ports.Text;
                int numberCom = Int32.Parse(chosenComInterface[3].ToString());

                EmulatorInfo emulatorInfoPort02 = new EmulatorInfo(numberCom, pathMc2);
                emulatorInfoPort02.ShowDialog();
            }
            else
            {
            MessageBox.Show("Bitte erst einen COM-Port wählen");
            }
}

        private void button_HilfeAnzeigenBms_Click(object sender, EventArgs e)
        {
            if (comboBox_ddBmsPorts.Text != "")
            {
                string chosenComInterface = comboBox_ddBmsPorts.Text;
                int numberCom = Int32.Parse(chosenComInterface[3].ToString());

                EmulatorInfo emulatorInfoPort02 = new EmulatorInfo(numberCom, pathBms);
                emulatorInfoPort02.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bitte erst einen COM-Port wählen.");
            }
            
        }

        private void timer_Communication_Tick_1(object sender, EventArgs e)
        {
            timer_Communication.Enabled = false;

            MotorDaten.MotorData Data = new MotorDaten.MotorData();// Ich habe ein Objekt der klasse M

            //alle 2 Sekunden wird ein neues zufälliges Telegramm des MC01, Mc02 und BMS generiert
            neuesMc01TelegramFrontend = new McTelegram((ushort)McTelegram.RandomWerteZuweisen(32, 60), (byte)McTelegram.RandomWerteZuweisen(-30, 401), (ushort)McTelegram.RandomWerteZuweisen(0, 2501), (byte)McTelegram.RandomWerteZuweisen(0, 66), (byte)McTelegram.RandomWerteZuweisen(0, 131), (short)McTelegram.RandomWerteZuweisen(0, 401), (byte)McTelegram.RandomWerteZuweisen(1, 256), (byte)McTelegram.RandomWerteZuweisen(1, 256), (byte)McTelegram.RandomWerteZuweisen(0, 101), (ushort)McTelegram.RandomWerteZuweisen(0, 65536));
            neuesMc01TelegramFrontend.TelegramInTextdateiSchreiben(Path.Combine(pathMc1));
            neuesMc02TelegramFrontend = new McTelegram((ushort)McTelegram.RandomWerteZuweisen(32, 60), (byte)McTelegram.RandomWerteZuweisen(-30, 401), (ushort)McTelegram.RandomWerteZuweisen(0, 2501), (byte)McTelegram.RandomWerteZuweisen(0, 66), (byte)McTelegram.RandomWerteZuweisen(0, 131), (short)McTelegram.RandomWerteZuweisen(0, 401), (byte)McTelegram.RandomWerteZuweisen(1, 256), (byte)McTelegram.RandomWerteZuweisen(1, 256), (byte)McTelegram.RandomWerteZuweisen(0, 101), (ushort)McTelegram.RandomWerteZuweisen(0, 65536));
            neuesMc02TelegramFrontend.TelegramInTextdateiSchreiben(Path.Combine(pathMc2));
            neuesBmsTelegramFrontend = new BmsTelegram((ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (ushort)Telegram.RandomWerteZuweisen(0, 65536), (int)Telegram.RandomWerteZuweisen(-2147483648, 214748364), Telegram.RandomWerteZuweisen(-2147483648, 214748364), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), (short)Telegram.RandomWerteZuweisen(-32768, 32768), Telegram.RandomUintZuweisen(0, 4294967294), (ushort)Telegram.RandomWerteZuweisen(0, 65536));
            neuesBmsTelegramFrontend.BmsTelegramInTextdateiSchreiben(Path.Combine(pathBms));

            //alle 2 Sekunden wird ein Telegram von der GUI an die MC1 und MC2 gesendet

            //hier muss angepasst werden!!!
            //Senden an Mc01
            ushort setPointMc01 = Convert.ToUInt16(Data.GetData(185,4));
            byte torqueMc01 = Convert.ToByte(Data.GetData(185,5));
            neuesGuiTelegramMc01Frontend = new GuiTelegram(setPointMc01, torqueMc01);
            string binaeresGuiMc01Telegram = neuesGuiTelegramMc01Frontend.TelgramBinaerAusgeben();
            serialPort_Mc01.Write(binaeresGuiMc01Telegram);

            //Senden an MC02
            ushort setPointMc02 = Convert.ToUInt16(Data.GetData(285, 4));
            byte torqueMc02 = Convert.ToByte(Data.GetData(285, 5));
            neuesGuiTelegramMc01Frontend = new GuiTelegram(setPointMc01, torqueMc02);
            string binaeresGuiMc02Telegram = neuesGuiTelegramMc01Frontend.TelgramBinaerAusgeben();
            serialPort_Mc01.Write(binaeresGuiMc02Telegram);



            //Random GuiTelegram(d.h. von Gui an MC) wird erzeugt
            ////if (checkBox_automaticSendingActivated.Checked)
            ////{
            ////    try
            ////    {
            ////        ushort setPoint = Convert.ToUInt16(textBox_setSetPointMc01.Text);
            ////        byte torque = Convert.ToByte(textBox_setTorqueMc01.Text);
            ////        if (setPoint > 0 & setPoint <= 1000 & torque > 0 & torque <= 100)
            ////        {
            ////            neuesGuiTelegram = new GuiTelegram(setPoint, torque);
            ////            string binaeresGuiTelegram = neuesGuiTelegram.TelgramBinaerAusgeben();
            ////            serialPort_Gui.Write(binaeresGuiTelegram);
            ////            label_stetigesSenden.Text = binaeresGuiTelegram;
            ////        }
            ////        else
            ////        {
            ////            MessageBox.Show("Bitte Wertebereiche des Setpoints (0-1000) und des Torques (0-100) beachten.");
            ////        }
            ////    }
            ////    catch (Exception exception)
            ////    {
            ////        MessageBox.Show(exception.Message);
            ////    }

            //}

            //Telegram (des MC) wird vom Slave-Gui empfangen/gelesen und angezeigt in Simulator

            timer_Communication.Enabled = true;
        }
    }
}
