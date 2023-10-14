using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonInterfacesLogic;
using MotorManagement;
using BatteryManagement;
using RsCommunication;

namespace Logic
{
    public class InformationPrep:IFrontendLogic
    {
        public int BatteryId { get; set; }
        public int AccumulatorId { get; set; }
        public int MotorControllerId { get; set; }
        public short Altitude { get; set; }


        public int MotorId => throw new NotImplementedException();

        public MotorController mc1;
        public MotorController mc2;
        public Accumulator akku1;
        public Accumulator akku2;
        public Accumulator akku3;
        public Bms bms;
        public InformationPrep()
        {
            mc1 = new MotorController(185);
            mc2 = new MotorController(285);
            akku1 = new Accumulator(170, 171);
            akku2 = new Accumulator(170, 172);
            akku3 = new Accumulator(170, 173);
            bms = new Bms(170);
        }


        /// <summary>
        ///  Error in Bms
        /// </summary>
        /// <param name="checkboxId"></param>
        /// <returns></returns>






        //public List<bool> GetMotorError(int checkboxId)
        public List<bool> GetMotorError()
        {
            //motorcheckbok selbe adresse 
            List<bool> errors = new List<bool>();
            bool undervoltage;
            bool overTempController;
            bool overTempAccu;
            bool overCurrent;
            PreparedData com2 = new PreparedData();/// Das Argument
           


            string errorMessage = com2.ReceiveErrorMessage(Convert.ToInt16(mc1.MotorControllerId), 15);



            if (errorMessage[0] == '1')
            {
                undervoltage = true;
            }

            else { undervoltage = false; }
            errors.Add(undervoltage);

            if (errorMessage[2] == '1')
            {

                overTempController = true;


            }
            else { overTempController = false; }
            errors.Add(overTempController);

            if (errorMessage[3] == '1')
            {
                overTempAccu = true;
                errors.Add(overTempAccu);

            }
            else { overTempAccu = false; }
            errors.Add(overTempAccu);


            if (errorMessage[5] == '1')
            {
                overCurrent = true;


            }
            else { overCurrent = false; }
            errors.Add(overCurrent);

            return errors;

        }
        /// <summary>
        ///  Revolution pro minute von Motoren //  Beide Motoren 
        /// </summary>
        /// <param name="motorControllerId"></param>
        /// <returns></returns>
        //public List<short> GetMotorRpm(int motorControllerId)
        public List<short> GetMotorRpm()
        {
            List<short> rpmMotors = new List<short>();
            MotorController mc1 = new MotorController(185);
            MotorController mc2 = new MotorController(285);
            short motorRpm1;
            short motorRpm2;
            motorRpm1 = ReceiveModbusData(mc1.MotorControllerId, 8);
            rpmMotors.Add(motorRpm1);
            motorRpm2 = ReceiveModbusData(mc2.MotorControllerId, 8);
            rpmMotors.Add(motorRpm2);
            return rpmMotors;
        }
        /// <summary>
        /// Temperature von Motoren
        /// </summary>
        /// <param name="motorControllerId"></param>
        /// <returns></returns>
        //public List<short> GetMotorTemperature(int motorControllerId)
        public List<short> GetMotorTemperature()
        {
            List<short> motorTemperaturen = new List<short>();
            short motorTemperatur1;
            short motorTemperatur2;


            motorTemperatur1 = ReceiveModbusData(mc1.MotorControllerId, 11);
            motorTemperaturen.Add(motorTemperatur1);
            motorTemperatur2 = ReceiveModbusData(mc2.MotorControllerId, 17);
            motorTemperaturen.Add(motorTemperatur2);



            return motorTemperaturen;


        }



        public short ReceiveModbusData(int slaveId, int address)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Voltage von zellen
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public List<short> GetCellVoltage()

        {

            List<short> cellVoltage = new List<short>();


            short cellVoltage1 = ReceiveModbusData(bms.BmsId, 4);
            cellVoltage.Add(cellVoltage1);
            //break;

            short cellVoltage2 = ReceiveModbusData(bms.BmsId, 8);
            cellVoltage.Add(cellVoltage2);
            //break;

            short cellVoltage3 = ReceiveModbusData(bms.BmsId, 8);
            cellVoltage.Add(cellVoltage3);

            short cellVoltage4 = ReceiveModbusData(bms.BmsId, 10);
            cellVoltage.Add(cellVoltage4);
            // break;

            short cellVoltage5 = ReceiveModbusData(bms.BmsId, 12);
            cellVoltage.Add(cellVoltage5);

            short cellVoltage6 = ReceiveModbusData(bms.BmsId, 14);
            cellVoltage.Add(cellVoltage6);

            short cellVoltage7 = ReceiveModbusData(bms.BmsId, 16);
            cellVoltage.Add(cellVoltage7);

            short cellVoltage8 = ReceiveModbusData(bms.BmsId, 18);
            cellVoltage.Add(cellVoltage8);

            short cellVoltage9 = ReceiveModbusData(bms.BmsId, 20);
            cellVoltage.Add(cellVoltage9);

            short cellVoltage10 = ReceiveModbusData(bms.BmsId, 22);
            cellVoltage.Add(cellVoltage10);

            return cellVoltage; ;


        }
        public List<short> GetAccuVoltage()
        {
            List<short> accuVoltage = new List<short>();



            short accuVoltage1 = ReceiveModbusData(mc1.MotorControllerId, 4);
            accuVoltage.Add(accuVoltage1);

            short accuVoltage2 = ReceiveModbusData(mc2.MotorControllerId, 4);
            accuVoltage.Add(accuVoltage2);

            return accuVoltage;

        }

        //public List<short> GetMotorTorque(int motorControllerId)
        public List<short> GetMotorTorque()
        {
            List<short> motorTorque = new List<short>();


            short motorTorque1 = ReceiveModbusData(mc1.MotorControllerId, 17);
            motorTorque.Add(motorTorque1);


            short motorTorque2 = ReceiveModbusData(mc2.MotorControllerId, 17);
            motorTorque.Add(motorTorque2);
            return motorTorque;







        }
        //public  List<bool> GetBmsError(int checkboxId)
        public List<bool> GetBmsError()
        {
            List<bool> bmsErrors = new List<bool>();
            bool communicationRS485Ausgefallen;
            bool controllerZumMotorControllerabgschaltet;
            bool communication_Ausgefallen;
            bool charger_Swicth_ist_Wegen_sammelfehler_abgeschaltet;
            bool power_Switch;
            bool reduceSammelAnfoderungAnMotorController;

            PreparedData com1 = new PreparedData();///XXXX PARAMETER


            string statusWord = com1.ReceiveErrorMessage(Convert.ToInt16(bms.BmsId), 6);

            if (statusWord[0] == '1')
            {
                communicationRS485Ausgefallen = true;

            }
            else { communicationRS485Ausgefallen = false; }

            bmsErrors.Add(communicationRS485Ausgefallen);/////

            if (statusWord[3] == '1')
            {
                controllerZumMotorControllerabgschaltet = true;

            }
            else { controllerZumMotorControllerabgschaltet = false; }

            bmsErrors.Add(controllerZumMotorControllerabgschaltet);//




            if (statusWord[4] == '1')
            {
                charger_Swicth_ist_Wegen_sammelfehler_abgeschaltet = true;

            }
            else { charger_Swicth_ist_Wegen_sammelfehler_abgeschaltet = false; }

            bmsErrors.Add(charger_Swicth_ist_Wegen_sammelfehler_abgeschaltet);///

            if (statusWord[5] == '1')
            {
                communication_Ausgefallen = true;

            }
            else { communication_Ausgefallen = false; }


            bmsErrors.Add(communication_Ausgefallen);///
            if (statusWord[6] == '1')
            {
                power_Switch = true;

            }
            else { power_Switch = false; }
            bmsErrors.Add(power_Switch);////


            if (statusWord[7] == '1')
            {
                reduceSammelAnfoderungAnMotorController = true;
                bmsErrors.Add(reduceSammelAnfoderungAnMotorController);
            }
            else { reduceSammelAnfoderungAnMotorController = false; }

            bmsErrors.Add(reduceSammelAnfoderungAnMotorController);

            return bmsErrors;


        }

        /* public string ReceiveErrorMessage(int bmsId, int address)
         {
             // test return data
             return "01010101";
         }*/

        //public List<short> GetMcOutput(int motorControllerId)
        public List<short> GetMcOutput()
        {
            List<short> mcOutput = new List<short>();


            short mcOutput1 = ReceiveModbusData(mc1.MotorControllerId, 16);
            mcOutput.Add(mcOutput1);


            short mcOutput2 = ReceiveModbusData(mc2.MotorControllerId, 16);
            mcOutput.Add(mcOutput2);
            return mcOutput;

        }


        public List<short> GetAccuCurrent()
        {
            List<short> AccuCurrent = new List<short>();

            short accuCurrent1 = ReceiveModbusData(mc1.MotorControllerId, 10); //muss was andern
            AccuCurrent.Add(accuCurrent1);
            

            short accuCurrent2 = ReceiveModbusData(mc2.MotorControllerId, 10);
            AccuCurrent.Add(accuCurrent2);

            return AccuCurrent;

        }




        //public List<short> GetMotorCurrent(int motorControllerId)
        public List<short> GetMotorCurrent()
        {
            List<short> motorCurrent = new List<short>();

            short motorCurrent1 = ReceiveModbusData(mc1.MotorControllerId, 12);
            motorCurrent.Add(motorCurrent1);


            short motorCurrent2 = ReceiveModbusData(mc2.MotorControllerId, 12);
            motorCurrent.Add(motorCurrent2);

            return motorCurrent;

        }
        //public List<short> GetBatteryTemperature(int mcId)
        public List<short> GetBatteryTemperature()
        {
            List<short> accuTemperatur = new List<short>();


            short accuTemperatur1 = ReceiveModbusData(mc1.MotorControllerId, 4);
            accuTemperatur.Add(accuTemperatur1);

            short accuTemperatur2 = ReceiveModbusData(mc2.MotorControllerId, 4);
            accuTemperatur.Add(accuTemperatur2);

            return accuTemperatur;


            //throw new NotImplementedException();
        }
        //public  List<short> GetBatteryCurrent(int slaveId)
        public List<short> GetBatteryCurrent()
        {
            List<short> currentBattery = new List<short>();

            short currentBattery1 = ReceiveModbusData(mc1.MotorControllerId, 10);
            currentBattery.Add(currentBattery1);


            short currentBattery2 = ReceiveModbusData(mc2.MotorControllerId, 10);
            currentBattery.Add(currentBattery2);

            return currentBattery;


            //throw new NotImplementedException();
        }




        /// <summary>
        /// Gibt an , ob die Motoren und Motor Controller connected sind
        /// </summary>
        /// <returns></returns>
        public List<bool> GetMotorControllStatus()

        {
           PreparedData com3 = new PreparedData();


            List<bool> motorControllerStatus_motor = new List<bool>(); //slaveId2 = mc2.MotorControllerId;// slaveId = mc1.MotorControllerId;
            string motorControllByte1 = com3.ReceiveErrorMessage(Convert.ToInt16(mc1.MotorControllerId), 14);
            string motorControllByte2 = com3.ReceiveErrorMessage(Convert.ToInt16(mc2.MotorControllerId), 14);
            bool statusMotorController1;
            bool statusMotorController2;
            bool statusMotor1;
            bool statusMotor2;
            if (motorControllByte1[0] == 1)
            {
                statusMotorController1 = true;

            }
            else { statusMotorController1 = false; }
            motorControllerStatus_motor.Add(statusMotorController1);

            if (motorControllByte2[0] == 1)
            {
                statusMotorController2 = true;

            }
            else { statusMotorController2 = false; }
            motorControllerStatus_motor.Add(statusMotorController2);

            if (motorControllByte1[6] == 1)
            {
                statusMotor1 = true;

            }
            else { statusMotor1 = false; }
            motorControllerStatus_motor.Add(statusMotor1);

            if (motorControllByte2[6] == 1)
            {
                statusMotor2 = true;

            }
            else { statusMotor2 = false; }

            motorControllerStatus_motor.Add(statusMotor2);

            return motorControllerStatus_motor;
        }

        /// <summary>
        /// get 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public short GetChargingCurrent(int address)
        {
            address = 24;
            short currentCharging = ReceiveModbusData(bms.BmsId, address);
            return currentCharging;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public short GetDischargingCurrent(int address)
        {
            address = 28;
            short currentDischarging = ReceiveModbusData(bms.BmsId, address);
            return currentDischarging;
            //throw new NotImplementedException();
        }
        /// <summary>
        /// Gibt die Liste der ChipeWerte
        /// </summary>
        /// <returns></returns>
        public List<short> GetChip()
        {
            List<short> chipWert = new List<short>();
            short chipeWert1 = ReceiveModbusData(bms.BmsId, 42);
            short chipeWert2 = ReceiveModbusData(bms.BmsId, 44);
            chipWert.Add(chipeWert1);
            chipWert.Add(chipeWert2);
            return chipWert;

        }

        public List<short> GetAkkuTemp()
        {
            List<short> Akkutemp = new List<short>();
            short AkkutempWert1 = ReceiveModbusData(bms.BmsId, 32);
            short AkkutempWert2 = ReceiveModbusData(bms.BmsId, 34);
            short AkkutempWert3 = ReceiveModbusData(bms.BmsId, 36);
            Akkutemp.Add(AkkutempWert1);
            Akkutemp.Add(AkkutempWert2);
            Akkutemp.Add(AkkutempWert3);
            return Akkutemp;
        }
        public short GetAkkuPs()
        {            
            short currentPS = ReceiveModbusData(bms.BmsId, 40);
            return currentPS;
        }
        public short GetAkkuCharge()
        {
            short currentCharge = ReceiveModbusData(bms.BmsId, 60); // muss was andern
            return currentCharge;
        }
    }
}
