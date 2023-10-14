using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonInterfacesLogic
{
    public interface IErrorManagement

    {
        short ErrorCode { get; }

        short ErrorType { get; }

        bool BindErrorDescription(short code, string type);

    }
    public interface IModbusLogic

    {
        // short GetModbusData(int slaveId, int registerAddress);
        short GetData(int slaveId, int registerAddress);


    }

    public interface IFrontend

    {

        List<short> SetMotorTorque();


        List<short> SetPoint();






    }

    public interface ICommunication  // ICommunication
    {
        // short networkAddress { get; }

        //int registerAddress { get; }

        short ReceiveModbusData(int slaveId, int address);
        //string ReceiveErrorMessage(int slaveId, int address);//addres des checkbox in bms
        string ReceiveErrorMessage(int slaveId, int address);

    }

    public interface IFrontendLogic

    {

        int BatteryId { get; }
        int MotorId { get; }
        int AccumulatorId { get; }
        int MotorControllerId { get; }
        short Altitude { get; }


        //short GetMotorTorque(int id);
        List<short> GetMotorTorque();


        //short GetMotorRpm(int id);
        List<short> GetMotorRpm();
        short GetChargingCurrent(int id);//im BMS
        //List<short> GetChargingCurrent();
        short GetDischargingCurrent(int id);
        //List<short> GetDischargingCurren();



        //short GetBatteryTemperature( int idAccumulator);
        List<short> GetBatteryTemperature();


        //short GetAccuVoltage(int idBattery, byte idAccumulator);
        // short GetAccuVoltage(int  idAccumulator);
        List<short> GetAccuVoltage();
        //short GetCellVoltage(int cellId);//neue
        List<short> GetCellVoltage();

        List<short> GetChip();


        //short GetBatteryCurrent(int idBattery);
        List<short> GetBatteryCurrent();

        // List<bool> GetBmsError(int checkboxId);
        List<bool> GetBmsError();
        //string GetBmsError(int checkboxId);
        // short GetMcOutput(int idMc);// schon implementiert
        List<short> GetMcOutput();
        //short GetMotorCurrent(int motorId);//schon implementiert
        List<short> GetMotorCurrent();
        //List<bool> GetMotorControllStatus(int slaveId );//neue
        List<bool> GetMotorControllStatus();
















    }

}
