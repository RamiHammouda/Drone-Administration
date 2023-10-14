using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Windows.Forms.Integration;
using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
using System.Windows;
using WindowsFormsApp1.UserControls;

namespace WindowsFormsApp1
{
    public partial class Drone_Controller_Interface : Form
    {

        public Drone_Controller_Interface()
        {
            
            InitializeComponent();
            this.MinimumSize = new System.Drawing.Size(1500, 800);
            DashboardEnglish.BringToFront();               
        }

        /// <DashboardButton>
        /// Wenn auf dem Dashboard Button geklickt wird, wird Dashboard gezeigt und BMS versteckt
        /// </DashboardButton>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            DashboardEnglish.Show();
            BmsEnglish_Panel.Hide();
        }

        /// <BMSButton>
        /// Wenn auf dem BMS Button geklickt wird, wird BMS gezeigt und Dashboard versteckt
        /// </BMSButton>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button6_Click(object sender, EventArgs e)
        {
            BmsEnglish_Panel.Show();
            DashboardEnglish.Hide();
        }

        /// <PfeilButton>
        /// Wenn auf dem Pfeil geklickt wird, wird Dashboard gezeigt und BMS versteckt
        /// </PfeilButton>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            DashboardEnglish.Show();
            BmsEnglish_Panel.Hide();
        }

        /// <EnglishButton>
        /// Convertiert die Texte züruck auf English.
        /// </EnglishButton>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnglishButton_Click(object sender, EventArgs e)
        {
            BatteryButton.Text = "                    Battery -                             ManagementSystem";
            SimulationButton.Text = "Start Simulation";
            DroneStatus.Text = "Drone: Connected/ diconnected";
            DashboardEnglish.Show();
            DashboardEnglish.BringToFront();
        }

        /// <BatteryButton>
        /// Convertiert die Texte auf Deutsch.
        /// </BatteryButton>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeutschButton_Click(object sender, EventArgs e)
        {
            BatteryButton.Text = "                    Batterie -                            ManagementSystem";           
            SimulationButton.Text = "Simulation Starten";           
            DroneStatus.Text = "Drone: Verbunden/ Getrennt";
            DashboardEnglish.Hide();
        }

        /// <SimulationFormStarten>
        /// Beim klicken auf Das Simulation Button wir die SimulationsForm aufgerufen und gezeigt
        /// </SimulationFormStarten>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SimulationButton_Click(object sender, EventArgs e)
        {
            var form = new Simulation();
            form.Show();
        }

        /// <NeueWerteSpeichern>
        /// Jede 100ms werden die neue Werte von Setpoint und Torque in der Excel Dokument gespeichert
        /// </NeueWerteSpeichern>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetNewValues_Tick(object sender, EventArgs e)
        {
            int setpoint1 = Coordinates.Setpoint1;
            int setpoint2 = Coordinates.Setpoint2;
            int Torque1 = Coordinates.Torque1;
            int Torque2 = Coordinates.Torque2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
