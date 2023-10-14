using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BusSimulator
{
    public partial class Pathinfo : Form
    {/// <summary>
    /// Zu Beginn des Programs wird über eine Form ein Ordner ausgewählt, in dem die Simulationsdateien gespeichert werden sollen.
    /// Diese Dateien müssen später im Emulator als Quelldateien für das Senden von Daten verwendet werden.
    /// Nach Auswahl des Pfades führt ein Klick auf den Button "weiter" zum Hauptprogramm, dem Bussimulator
    /// </summary>
        public Pathinfo()
        {
            InitializeComponent();
        }

        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public string PathSimulationData { get; private set; }

        private void button_openFileDia_Click(object sender, EventArgs e)
        {
            
            fbd.Description = "Bitte einen Ordner zur Erstellung der Simulationsdaten auswählen.";
            if (fbd.ShowDialog() == DialogResult.OK)//Nur wenn im fbd mit OK bestätigt wird, wird weiter fortgeführt
            {
                textBox_path.Text = fbd.SelectedPath;
            }
        }

        private void button_weiter_Click(object sender, EventArgs e)
        {
                PathSimulationData=textBox_path.Text;//da dies die Form ist, die beim Start des Programms ausgefüht wird, kann sie nicht geschlossen werden, sondern wird lediglich ausgeblendet
                this.Visible = false;
                this.ShowInTaskbar = false;
                
                //eine neue Instanz der Hauptform, d.h. des Bussimulators wird erzeugt; der Form wird der ausgwählte Pfad übergeben
                GuiSlaveSimulator simulator = new GuiSlaveSimulator(PathSimulationData);
                simulator.ShowDialog();
        }

    }
}
