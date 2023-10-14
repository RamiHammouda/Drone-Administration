using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;
using BusSimulator;
using Logic;


namespace WindowsFormsApp1.UserControls
{
    public partial class Dashboard : UserControl
    {
        InformationPrep informations = new InformationPrep();
        Coordinates coord = new Coordinates(); // Die Klasse Coordinates wird benutzt um die Setpoint und Torque Werte zu speichern. Diese Klasse enthält static Variabeln

        public Dashboard()
        {            
            InitializeComponent();
            //Trackbars müssen disabled sein wenn das Program started
            trackBar1.Enabled = false;
            trackBar2.Enabled = false;
            trackBar3.Enabled = false;
            trackBar4.Enabled = false;          
        }

        /// <InputFenester>
        /// Zeigt die Input Fenester wenn auf das Button "Insert Input Here" geklickt würde
        /// </InputFenester>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CircularButton14_Click(object sender, EventArgs e)
        {           
            List<double> InputList = Prompt.ShowDialog("Input_Data");              
        }

        /// <Output>
        /// Zeigt die Input-Data in das Form
        /// </Output>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Test_button_Click(object sender, EventArgs e)
        {

            List<double> InputList = Prompt.GetList(); //Die Liste von Inputs aus dem Testing Fenester ist InputList

            /// Berechnung der Höhe der Blaue Panels für die Ausgabe
            /// Jede Berechnung ist unterschiedlich
            /// Bei negativer Input muss eine if benutzt werden
            //MC-Output
            double percentage = (double)(InputList[0] / 1000.0);
            int a = Convert.ToInt32(Infopanel1.Height * percentage);
            Valuepanel1.Height = a;
            Point start = new Point(-1, 123 - a); ///123
            Valuepanel1.Location = start;
            //AccuVoltage
            double percentage1 = (double)((InputList[1] - 40.0) / 20.0);
            int a1 = Convert.ToInt32(Infopanel2.Height * percentage1);
            panel1.Height = a1;
            Point start1 = new Point(-1, 123 - a1); ///123
            panel1.Location = start1;
            //AccuCurrent
            double percentage2 = (double)((InputList[2] + 350.0) / 700.0);
            int a2 = Convert.ToInt32(Infopanel3.Height * percentage2);
            panel3.Height = a2;
            Point start2 = new Point(-1, 123 - a2); ///123
            panel3.Location = start2;
            //MotorCurrent
            double percentage3 = (double)((InputList[3] + 350.0) / 700.0);
            int a3 = Convert.ToInt32(Infopanel4.Height * percentage3);
            panel5.Height = a3;
            Point start3 = new Point(-1, 123 - a3); ///123
            panel5.Location = start3;
            //Torque
            double percentage4 = (double)((InputList[4] + 72.0) / 144.0);
            int a4 = Convert.ToInt32(Infopanel5.Height * percentage4);
            panel6.Height = a4;
            Point start4 = new Point(-1, 123 - a4); ///123
            panel6.Location = start4;
            //RPM
            double percentage5 = (double)((InputList[5] + 20000.0) / 40000.0);
            int a5 = Convert.ToInt32(Infopanel6.Height * percentage5);
            panel14.Height = a5;
            Point start5 = new Point(-1, 123 - a5); ///123
            panel14.Location = start5;
            //AccuTemp
            double percentage6 = (double)(InputList[6] / 65.0);
            int a6 = Convert.ToInt32(Infopanel7.Height * percentage6);
            panel15.Height = a6;
            Point start6 = new Point(-1, 123 - a6); ///123
            panel15.Location = start6;
            //MotorTemp
            double percentage7 = (double)(InputList[7] / 110.0);
            int a7 = Convert.ToInt32(Infopanel8.Height * percentage7);
            panel16.Height = a7;
            Point start7 = new Point(-1, 123 - a7); ///123
            panel16.Location = start7;

            /// Zeigt die InputData in Dashboard unter die Säulen
            Input1.Text = InputList[0].ToString();
            Input2.Text = InputList[1].ToString("0.0");
            Input3.Text = InputList[2].ToString();
            Input4.Text = InputList[3].ToString();
            Input5.Text = InputList[4].ToString("0.0");
            Input6.Text = InputList[5].ToString();
            Input7.Text = InputList[6].ToString();
            Input8.Text = InputList[7].ToString();
        }

        /// <summary>
        /// kontrolliert die erste zwei Trackbars ob funktionierbar sein soll oder nicht
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                trackBar1.Enabled = false;
                trackBar2.Enabled = false;
                checkBox5.Checked = false;
            }
            else
            {
                trackBar1.Enabled = true;
                trackBar2.Enabled = true;
            }
        }

        /// <summary>
        /// kontrolliert die zweite zwei Trackbars ob funktionierbar sein soll oder nicht
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                trackBar3.Enabled = false;
                trackBar4.Enabled = false;
                checkBox5.Checked = false;
            }
            else
            {
                trackBar3.Enabled = true;
                trackBar4.Enabled = true;
            }
        }

        /// <trackBar1>
        /// Zeigt die Value von Motor1_Setpoint im oberen Textbox
        /// </trackBar1>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBar1_Scroll(object sender, EventArgs e)
        {           
            textBox1.Text = (trackBar1.Value).ToString();
            if ((checkBox5.Checked == true) && (checkBox3.Checked==true) && (checkBox4.Checked == true))
            {              
                trackBar4.Value = Convert.ToInt32(trackBar1.Value);
                textBox3.Text = textBox1.Text;
                Coordinates.Setpoint2 = trackBar1.Value;
            }
            Coordinates.Setpoint1 = trackBar1.Value;    // alle Variabeln werden in Coordinates Klasse gespeischert       
        }

        /// <trackBar4>
        /// Zeigt die Value von Motor2_Setpoint im oberen Textbox
        /// </trackBar4>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBar4_Scroll(object sender, EventArgs e)
        {
            textBox3.Text = (trackBar4.Value).ToString();
            if ((checkBox5.Checked == true) && (checkBox3.Checked == true) && (checkBox4.Checked == true))
            {
                trackBar1.Value = Convert.ToInt32(trackBar4.Value);
                textBox1.Text = textBox3.Text;
                Coordinates.Setpoint1 = trackBar4.Value;
            }
            Coordinates.Setpoint2 = trackBar4.Value;
        }

        /// <trackBar2>
        /// Zeigt die Value von Motor1_Torque im oberen Textbox
        /// </trackBar2>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBar2_Scroll(object sender, EventArgs e)
        {
            textBox2.Text = (trackBar2.Value).ToString();
            if ((checkBox5.Checked == true) && (checkBox3.Checked == true) && (checkBox4.Checked == true))
            {
                trackBar3.Value = Convert.ToInt32(trackBar2.Value);
                textBox4.Text = textBox2.Text;
                Coordinates.Torque2 = trackBar3.Value;
            }
            Coordinates.Torque1 = trackBar2.Value;            
        }

        /// <trackBar3>
        /// Zeigt die Value von Motor2_Torque im oberen Textbox
        /// </trackBar3>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrackBar3_Scroll(object sender, EventArgs e)
        {
            textBox4.Text = (trackBar3.Value).ToString();
            if ((checkBox5.Checked == true) && (checkBox3.Checked == true) && (checkBox4.Checked == true))
            {
                trackBar2.Value = Convert.ToInt32(trackBar3.Value);
                textBox2.Text = textBox4.Text;
                Coordinates.Torque1 = trackBar2.Value;
            }
            Coordinates.Torque2 = trackBar3.Value;
        }

        /// <TextOutput>
        /// zeigt das Output Text ob die zwei Motors synchroniziert sind oder nicht oder nicht mehr
        /// </TextOutput>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox3.Checked = true;
                checkBox4.Checked = true;
                label117.Text = "(The two motors are synchronized)";
            }
            else label117.Text = "(The two motors are no longer synchronized)";
        }

        /// <Stabilize>
        /// stabiliziert das Drone das heisst das drone bleibt Fest in nur eine Position und ohne Moment 
        /// </Stabilize>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CircularButton11_Click(object sender, EventArgs e)
        {
            trackBar2.Value = 50;
            trackBar3.Value = 50;
            trackBar1.Value = 5;
            trackBar4.Value = 5;
            textBox1.Text = "5";
            textBox3.Text = "5";
            textBox4.Text = "50";
            textBox2.Text = "50";

            //neue Stabilize Werte in die Static Variabeln der Klasse speichern
            Coordinates.Setpoint1 = trackBar1.Value;
            Coordinates.Setpoint2 = trackBar4.Value;
            Coordinates.Torque1 = trackBar2.Value;
            Coordinates.Torque2 = trackBar3.Value;

        }

        //connect 
        private void Button_with_rounded_boarders3_Click(object sender, EventArgs e)
        {
            ConnectComPorts connectComPorts01 = new ConnectComPorts();
            connectComPorts01.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //RPM
            var RPMListe = new List<short>();
            RPMListe = informations.GetMotorRpm();
                //Motor1
            double percentage5 = (double)((Convert.ToDouble(RPMListe[0]) + 20000.0) / 40000.0);
            int a5 = Convert.ToInt32(Infopanel6.Height * percentage5);
            panel14.Height = a5;
            Point start5 = new Point(-1, 123 - a5); ///123
            panel14.Location = start5;
                //Motor2
            double percentage51 = (double)((Convert.ToDouble(RPMListe[1]) + 20000.0) / 40000.0);
            int a51 = Convert.ToInt32(Infopanel14.Height * percentage51);
            panel17.Height = a51;
            Point start51 = new Point(-1, 123 - a51); ///123
            panel17.Location = start51;

            //MC Output
            var MCOutputList = new List<short>();
            MCOutputList = informations.GetMcOutput();
                //Motor1
            double percentage = (double)(Convert.ToDouble(MCOutputList[0]) / 1000.0);
            int a = Convert.ToInt32(Infopanel1.Height * percentage);
            Valuepanel1.Height = a;
            Point start = new Point(-1, 123 - a); ///123
            Valuepanel1.Location = start;
                //Motor2
            double percentage00 = (double)(Convert.ToDouble(MCOutputList[1]) / 1000.0);
            int a0 = Convert.ToInt32(Infopanel9.Height * percentage00);
            panel9.Height = a0;
            Point start0 = new Point(-1, 123 - a0); ///123
            panel9.Location = start0;

            //Akku Voltage
            var AkkuVoltageList = new List<short>();
            AkkuVoltageList = informations.GetAccuVoltage();
                //Motor1
            double percentage10 = (double)((Convert.ToDouble(AkkuVoltageList[0]) - 40.0) / 20.0);
            int a1 = Convert.ToInt32(Infopanel2.Height * percentage10);
            panel1.Height = a1;
            Point start1 = new Point(-1, 123 - a1); ///123
            panel1.Location = start1;
                //Motor2
            double percentage11 = (double)(((Convert.ToDouble(AkkuVoltageList[1])) - 40.0) / 20.0); int a10 = Convert.ToInt32(Infopanel1.Height * percentage);
            int a11 = Convert.ToInt32(Infopanel10.Height * percentage11);
            panel8.Height = a11;
            Point start11 = new Point(-1, 123 - a11); ///123
            panel8.Location = start11;

            //Akku Current
            var AkkuCurrentList = new List<short>();
            AkkuCurrentList = informations.GetAccuCurrent();
                //Motor1
            double percentage2 = (double)((Convert.ToDouble(AkkuCurrentList[0]) + 350.0) / 700.0);
            int a2 = Convert.ToInt32(Infopanel3.Height * percentage2);
            panel3.Height = a2;
            Point start2 = new Point(-1, 123 - a2); ///123
            panel3.Location = start2;
                //Motor2
            double percentage20 = (double)((Convert.ToDouble(AkkuCurrentList[1]) + 350.0) / 700.0);
            int a20 = Convert.ToInt32(Infopanel11.Height * percentage20);
            panel10.Height = a20;
            Point start20 = new Point(-1, 123 - a20); ///123
            panel10.Location = start20;

            //Motor Current
            var MotorCurrentList = new List<short>();
            MotorCurrentList = informations.GetMotorCurrent();
                //Motor1
            double percentage3 = (double)((Convert.ToDouble(MotorCurrentList[0]) + 350.0) / 700.0);
            int a3 = Convert.ToInt32(Infopanel4.Height * percentage3);
            panel5.Height = a3;
            Point start3 = new Point(-1, 123 - a3); ///123
            panel5.Location = start3;
                //Motor2
            double percentage30 = (double)((Convert.ToDouble(MotorCurrentList[1]) + 350.0) / 700.0);
            int a30 = Convert.ToInt32(Infopanel12.Height * percentage30);
            panel13.Height = a3;
            Point start30 = new Point(-1, 123 - a30); ///123
            panel13.Location = start30;

            //Motor Torque
            var MotorTorqueList = new List<short>();
            MotorTorqueList = informations.GetMotorTorque();
                //Motor1
            double percentage4 = (double)((Convert.ToDouble(MotorTorqueList[0]) + 72.0) / 144.0);
            int a4 = Convert.ToInt32(Infopanel5.Height * percentage4);
            panel6.Height = a4;
            Point start4 = new Point(-1, 123 - a4); ///123
            panel6.Location = start4;
                //Motor2
            double percentage40 = (double)((Convert.ToDouble(MotorTorqueList[1]) + 72.0) / 144.0);
            int a40 = Convert.ToInt32(Infopanel13.Height * percentage40);
            panel17.Height = a40;
            Point start40 = new Point(-1, 123 - a40); ///123
            panel17.Location = start40;

            //Motor Torque
            var AccuTempList = new List<short>();
            AccuTempList = informations.GetBatteryTemperature();
                //Motor1
            double percentage6 = (double)(Convert.ToDouble(AccuTempList[0]) / 65.0);
            int a6 = Convert.ToInt32(Infopanel7.Height * percentage6);
            panel15.Height = a6;
            Point start6 = new Point(-1, 123 - a6); ///123
            panel15.Location = start6;
                //Motor2
            double percentage60 = (double)(Convert.ToDouble(AccuTempList[1]) / 65.0);
            int a60 = Convert.ToInt32(Infopanel15.Height * percentage60);
            panel18.Height = a60;
            Point start60 = new Point(-1, 123 - a60); ///123
            panel18.Location = start60;

            //Motor Temp
            var MotorTempList = new List<short>();
            MotorTempList = informations.GetMotorTemperature();
                //Motor1
            double percentage7 = (double)(Convert.ToDouble(MotorTempList[0]) / 110.0);
            int a7 = Convert.ToInt32(Infopanel8.Height * percentage7);
            panel16.Height = a7;
            Point start7 = new Point(-1, 123 - a7); ///123
            panel16.Location = start7;
                //Motor2
            double percentage70 = (double)(Convert.ToDouble(MotorTempList[1]) / 110.0);
            int a70 = Convert.ToInt32(Infopanel16.Height * percentage70);
            panel19.Height = a70;
            Point start70 = new Point(-1, 123 - a70); ///123
            panel19.Location = start70;

            //ErrorList
            var ErrorList = new List<bool>();
            ErrorList = informations.GetMotorError();
            if (ErrorList[0] == true)
            {
                circularButton10.ForeColor = Color.Red;
            }
            if (ErrorList[1] == true)
            {
                circularButton9.ForeColor = Color.Red;
            }
            if (ErrorList[2] == true)
            {
                circularButton8.ForeColor = Color.Red;
            }
            if (ErrorList[3] == true)
            {
                circularButton7.ForeColor = Color.Red;
            }
        }
    }
}
