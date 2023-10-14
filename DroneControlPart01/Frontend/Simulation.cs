using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.UserControls;


namespace WindowsFormsApp1
{
    public partial class Simulation : Form 
    {
        
        int droneSpeed;
        double newHeight;
        int dronYPosition;
     
        public Simulation()
        {
            
            InitializeComponent();
            GameTimer.Start(); //timer wir gestartet
            dronYPosition = pictureBox1.Location.Y; //drone Y Position wird gespeichert

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {  
            //Die Werte aus dem Dashboard in vier variabeln geschpeichert
            double torque1 = Convert.ToDouble(Coordinates.Torque1);
            double torque2 = Convert.ToDouble(Coordinates.Torque2);
            int setpoint1 = Coordinates.Setpoint1;
            int setpoint2 = Coordinates.Setpoint2;

            // Hier wird die neue Höhe von dem Drone berechnet
            double var1 = torque1 / 200.0;
            double var2 = (double)setpoint1 / 20;
            double percentage = var1 + var2;
            newHeight = dronYPosition - (percentage* dronYPosition) ;

            droneSpeed = Math.Abs(setpoint1 - setpoint2) + ((int)(Math.Abs(torque1 - torque2)) / 10); //Dronespeed wird berechnet abhängig von die Differenz zwischen die Werte von die zwei Motoren

            /// wenn die beide Motoren synchroniziert sind geht das Drone nur nach oben und unten
            if ((torque1 == torque2) && (setpoint1 == setpoint2))
            {
                if (pictureBox1.Location.Y > newHeight)
                {
                    pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - setpoint1); //Drone geht nach oben mit setpoint als speed
                    Drone_Altitude.Text = (dronYPosition - pictureBox1.Location.Y).ToString();
                }
                else pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + setpoint1); //Drone geht nach unten mit setpoint als speed 
            }
            else
            {
                if ((setpoint1 > setpoint2) | (torque1 > torque2))
                {                  
                    if (pictureBox1.Location.X < 620) //wenn das Drone die Ende das Form erreicht muss es von der anderen Seite erscheinen
                    {
                        pictureBox1.Location = new Point(pictureBox1.Location.X + droneSpeed, pictureBox1.Location.Y); //Drone Position geht nach rechts mit Dronespeed
                    }
                    else pictureBox1.Location = new Point(-50, pictureBox1.Location.Y); //Drone Location in der rechte Seite erscheint

                }
                if ((setpoint1 < setpoint2) | (torque1 < torque2))
                {
                    {
                        if (pictureBox1.Location.X > -50) //falls rechte Seite erreicht ist
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X - droneSpeed, pictureBox1.Location.Y); //Drone Position geht nach links mit Dronespeed
                        }
                    else pictureBox1.Location = new Point(620, pictureBox1.Location.Y); //Drone Location in der linke Seite erscheint
                    }
                }
            }           
        }
    }
}
