using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.UserControls
{
    public class Prompt
    {
        public static List<double> InputList = new List<double>(); // InputList ist die Liste wo die Input-Data gespeichert werden muss

        /// <ShowDialog>
        /// Diese Methode zeigt das InputFenester und verifiziert unsere Input
        /// </ShowDialog>
        /// <param name="caption"></param>
        /// <InputList></InputList>
        public static List<double> ShowDialog(string caption)
        {
            ///Initialisierung der Liste
            for (int i = 0; i < 8; i++)
            {
                InputList.Add(0.0);
            }

            ///Erstellung das Form für die Input data
            Form prompt = new Form()
            {
                Width = 320,
                Height = 630,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterScreen
            };
            ///Erzeugung von textboxes und dem entsprechenden Titel
            Label McOutputTextLabel = new Label() { Left = 50, Top = 20, Text = "MC_Output:" };
            TextBox McOutput = new TextBox() { Left = 50, Top = 50, Width = 200 };
            Label AccuVoltageTextLabel = new Label() { Left = 50, Top = 80, Text = "Accu Voltage:" };
            TextBox AccuVoltage = new TextBox() { Left = 50, Top = 110, Width = 200 };
            Label AccuCurrentTextLabel = new Label() { Left = 50, Top = 140, Text = "AccuCurrent:" };
            TextBox AccuCurrent = new TextBox() { Left = 50, Top = 170, Width = 200 };
            Label MotorCurrentTextLabel = new Label() { Left = 50, Top = 200, Text = "MotorCurrent:" };
            TextBox MotorCurrent = new TextBox() { Left = 50, Top = 230, Width = 200 };
            Label TorqueTextLabel = new Label() { Left = 50, Top = 260, Text = "Torque:" };
            TextBox Torque = new TextBox() { Left = 50, Top = 290, Width = 200 };
            Label RPMTextLabel = new Label() { Left = 50, Top = 320, Text = "RPM:" };
            TextBox RPM = new TextBox() { Left = 50, Top = 350, Width = 200 };
            Label AccuTempTextLabel = new Label() { Left = 50, Top = 380, Text = "AccuTemp:" };
            TextBox AccuTemp = new TextBox() { Left = 50, Top = 410, Width = 200 };
            Label MotorTempTextLabel = new Label() { Left = 50, Top = 440, Text = "MotorTemp:" };
            TextBox MotorTemp = new TextBox() { Left = 50, Top = 470, Width = 200 };

            ///Erzeugung das Button OK
            Button confirmation = new Button() { Text = "Ok", Left = 150, Width = 100, Top = 520, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };

            ///Hinzufügung von alle Elemente in das Form
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(McOutput);
            prompt.Controls.Add(AccuVoltage);
            prompt.Controls.Add(AccuCurrent);
            prompt.Controls.Add(MotorCurrent);
            prompt.Controls.Add(Torque);
            prompt.Controls.Add(RPM);
            prompt.Controls.Add(AccuTemp);
            prompt.Controls.Add(MotorTemp);
            prompt.Controls.Add(McOutputTextLabel);
            prompt.Controls.Add(AccuVoltageTextLabel);
            prompt.Controls.Add(AccuCurrentTextLabel);
            prompt.Controls.Add(MotorCurrentTextLabel);
            prompt.Controls.Add(TorqueTextLabel);
            prompt.Controls.Add(RPMTextLabel);
            prompt.Controls.Add(AccuTempTextLabel);
            prompt.Controls.Add(MotorTempTextLabel);
            prompt.AcceptButton = confirmation;

            ///Wenn ok wird geklickt muss unsere if die Input-Data verifizieren ob sie stimmt oder nicht
            ///Falls nicht muss ein Error fenester auftreten
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                ///verif 1 bis 8 sind zu verifizieren ob das Typ stimmt
                bool verif1 = int.TryParse(McOutput.Text, out int result1);
                bool verif2 = double.TryParse(AccuVoltage.Text, out double result2);
                bool verif3 = int.TryParse(AccuCurrent.Text, out int result3);
                bool verif4 = int.TryParse(MotorCurrent.Text, out int result4);
                bool verif5 = double.TryParse(Torque.Text, out double result5);
                bool verif6 = int.TryParse(RPM.Text, out int result6);
                bool verif7 = int.TryParse(AccuTemp.Text, out int result7);
                bool verif8 = int.TryParse(MotorTemp.Text, out int result8);
                bool falseinput = true;
                if (verif1 == true && ((result1 < 1000) && (0 < result1)))
                {
                    InputList[0] = (Convert.ToDouble(result1));
                }
                else falseinput = false;
                if (verif2 == true && (result2 < 60.0) && (40.0 < result2))
                {
                    InputList[1] = (Convert.ToDouble(result2));
                }
                else falseinput = false;
                if (verif3 == true && (result3 < 350) && (-350 < result3))
                {
                    InputList[2] = (Convert.ToDouble(result3));
                }
                else falseinput = false;
                if (verif4 == true && (result4 < 350) && (-350 < result4))
                {
                    InputList[3] = (Convert.ToDouble(result4));
                }
                else falseinput = false;
                if (verif5 == true && (result5 < 72.0) && (-72.0 < result5))
                {
                    InputList[4] = (Convert.ToDouble(result5));
                }
                else falseinput = false;
                if (verif6 == true && (result6 < 20000) && (-20000 < result6))
                {
                    InputList[5] = (Convert.ToDouble(result6));
                }
                else falseinput = false;
                if (verif7 == true && (result7 < 65) && (0 < result7))
                {
                    InputList[6] = (Convert.ToDouble(result7));
                }
                else falseinput = false;
                if (verif7 == true && (result8 < 110) && (0 < result8))
                {
                    InputList[7] = (Convert.ToDouble(result8));
                }
                else falseinput = false;

                ///Output falls einer Input-Data nicht stimmt
                if (falseinput == false)
                {
                    MessageBox.Show("Input_Data wrongly written or out of boudaries", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return InputList;
                }
                else
                {
                    MessageBox.Show("Input_Data are correct", "Informationbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return InputList;
                }
            }
            else return null;
        }

        /// <GetList>
        /// Methode um die Input-List zu kriegen
        /// </GetList>
        /// <InputList></InputList>
        public static List<double> GetList()
        {
            return InputList;
        }

    }
}
