using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.UserControls
{
    /// <VariabelnSpeichern>
    /// alle Variabeln werden in Coordinates Klasse gespeischert damit wir diese Variabeln in Simulation form aufrufen können
    /// </VariabelnSpeichern>
    public class Coordinates
    {
        public static int Setpoint1{ get; set; }
        public static int Torque1 { get; set; }
        public static int Setpoint2 { get; set; }
        public static int Torque2 { get; set; }

    }
}
