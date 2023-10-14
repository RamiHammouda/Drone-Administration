using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusSimulator
{
    /// <summary>
    /// In dieser Form wird dem*r User*in ein kurzes Tutorial angezeigt, wie die Emulationssoftware eingestellt werden muss
    /// </summary>
    public partial class EmulatorInfo : Form
    {
       public string comAnweisung;
        public string pathFile;
        public EmulatorInfo()
        {
            InitializeComponent();
        }

        //Diese Form wird angezeigt, sobald im Bussimulator der Verbinden-Button gedrückt wurde
        private void EmulatorInfo_Load(object sender, EventArgs e)
        {
            label_anweisungEins.Text = comAnweisung;
            textBox_pfad.Text = pathFile;
            textBox_filename.Text= Path.GetFileName(pathFile);
        }
        //dieser Form werden vom Bussimulator der Pfad zu den Simulationsdateien mitgegeben sowohl die Info, welcher Port als Sender ausgewählt wurde
        public EmulatorInfo(int comInfo, string pathToFile)
        {
            InitializeComponent();
            comAnweisung = SchreibeEmulatorAnweisung(comInfo);
            pathFile = pathToFile;

        }
        //Die dem*r User*in angezeigten Informationen sollen  sich immer passgenau auf den Port beziehen, der im Simulator als Sender ausgewählt wurde
        public static string SchreibeEmulatorAnweisung(int numberComPort)
        {
            string anweisung;

            switch (numberComPort)
            {
                case 1:
                    anweisung = "Bitte im Emulator mit COM2 verbinden";
                    break;
                case 2:
                    anweisung = "Bitte im Emulator mit COM1 verbinden";
                    break;
                case 3:
                    anweisung = "Bitte im Emulator mit COM4 verbinden";
                    break;
                case 4:
                    anweisung = "Bitte im Emulator mit COM3 verbinden";
                    break;
                case 5:
                    anweisung = "Bitte im Emulator mit COM6 verbinden";
                    break;
                case 6:
                    anweisung = "Bitte im Emulator mit COM5 verbinden";
                    break;
                default:
                    anweisung = "Bitte im Emulator mit dem zugehörigen Gegenport verbinden";
                    break;
            }

            return anweisung;
        }
        //Nach Klick auf den Button Fertig soll der*die User*in wieder zum Bussimulator gelangen
        private void button_fertig_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
