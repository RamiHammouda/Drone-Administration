using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorManagement
{
    public class MotorController
    {

        public int MotorControllerId { get; set; }
      // public MotorController mc1;
       // public MotorController mc2;
        public MotorController(int motorControllerId)
        {

            this.MotorControllerId = motorControllerId;
        }
    }
}
