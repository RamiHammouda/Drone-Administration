using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfacesLogic;
using MotorManagement;
using WindowsFormsApp1.UserControls;

namespace MotorDaten
{
    
        public class MotorData : IModbusLogic
        {
            public MotorController mc1;
            public MotorController mc2;
            public short Setpoint1 { get; set; }
            public short McTorque1 { get; set; }
            public short SetPoint2 { get; set; }
            public short McTorque2 { get; set; }
            public MotorData()
            {
                Coordinates motorCoordinates = new Coordinates();

                mc1 = new MotorController(185);
                mc2 = new MotorController(285);
                short Setpoint1 = Convert.ToInt16(Coordinates.Setpoint1);
                short Setpoint2 = Convert.ToInt16(Coordinates.Setpoint2);
                short Torque1 = Convert.ToInt16(Coordinates.Torque1);
                short Torque2 = Convert.ToInt16(Coordinates.Torque2);
        }



            public short GetData(int slaveId, int registerAddress)
            {
                short wert = 0;


                if (slaveId == mc1.MotorControllerId && registerAddress == 4)
                {
                    wert = Setpoint1;

                }
                else if (slaveId == mc1.MotorControllerId && registerAddress == 5)
                {
                    wert = McTorque1;
                }

                else if (slaveId == mc2.MotorControllerId && registerAddress == 4)
                {
                    wert = SetPoint2;
                }
                else if (slaveId == mc2.MotorControllerId && registerAddress == 5)
                {
                    wert = McTorque2;
                }
                else { }

                return wert;

            }


        }
    }

