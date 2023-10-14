using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Linq.Expressions;
using System.Text.RegularExpressions;
using SlaveManager;


namespace RsCommunication
{
    public class PreparedData : CommonInterfaces.ICommunication
    {
        public string lastTelegram;


        public PreparedData(string telegram)
        {
            this.lastTelegram = telegram;
        } 
        
        //ICommunication Implementierung
        public short ReceiveData(short slaveId, int address)
        {
            string type = ""; ; 

            switch (slaveId)
            {
                case 185:
                    type = "MC";
                    break;
                case 285:
                    type = "MC";
                    break;
                case 170:
                    type = "BMS";
                    break;
            }


            Dictionary<byte, string> neuesTelegramDictionary = Telegram.BinaryToDictionary(type, lastTelegram);
            Dictionary<byte, string> neuesTypeDictionary = FindType(type);

            string dataType=neuesTypeDictionary[(byte) address];
            short ausgabe=0;
            switch (dataType)
            {
                case "uint8":
                    ausgabe= (short) Convert.ToByte(neuesTelegramDictionary[(byte)address], 2);
                    break;
                case "uint16":
                    ausgabe = (short) Convert.ToUInt16(neuesTelegramDictionary[(byte) address], 2);
                    break;
                case "int16":
                    ausgabe = (short)Convert.ToInt16(neuesTelegramDictionary[(byte)address], 2);
                    break;
                case "int32":
                    ausgabe = (short)Convert.ToInt32(neuesTelegramDictionary[(byte)address], 2);
                    break;
                case "uint32":
                    ausgabe = (short)Convert.ToUInt32(neuesTelegramDictionary[(byte)address], 2);
                    break;
            }

            return ausgabe;


        }

        public string ReceiveErrorMessage(short slaveId, int address)
        {
            string type = "";
            string ausgabe;
            if (((slaveId == 185 ^ slaveId == 285) & address == 15) ^
                (slaveId == 170 & (address == 46 ^ address == 50)))
            {
                switch (slaveId)
                {
                    case 185:
                        type = "MC";
                        break;
                    case 285:
                        type = "MC";
                        break;
                    case 170:
                        type = "BMS";
                        break;
                }

                Dictionary<byte, string> neuesTelegram = Telegram.BinaryToDictionary(type, lastTelegram);
                ausgabe = neuesTelegram[(byte) address];
            }
            else
            {
                ausgabe = "Use ReceiveDataFunction to return short value";
            }

            return ausgabe;

        }
        /// <summary>
        /// Gibt ein Dictionary mit gleicher Indizierung wie eigentliches DatenTelegramm wieder, dass den Namen des jeweiligen Datentyps enthält
        /// Dies ist notwendig, um die binäre Codierung korrekt in den geforderten Short-Wert umzuwandeln
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static Dictionary<byte, string> FindType(string type)
        {
            var telegramTypes = new Dictionary<byte, string>();

            switch (type)
            {
                case "BMS":
                    var telegramTypesBms = new Dictionary<byte, string>()
                    {
                        {1, "uint8"}, //1 source adresse [170]
                        {2, "uint"}, //2   target adresse[1]
                        {3, "uint"}, //3   Telegrammlength in bytes(52 incl.Crc8)
                        {4, "uint"}, //4   cell voltage 1
                        {6, "uint"}, //6   cell voltage 2
                        {8, "uint"}, //8   cell voltage 3
                        {10, "uint"}, //10  cell voltage 4
                        {12, "uint"}, //12  cell voltage 5
                        {14, "uint"}, //14  cell voltage 6
                        {16, "uint"}, //16  cell voltage 7
                        {18, "uint"}, //18  cell voltage 8
                        {20, "uint"}, //20  cell voltage 9
                        {22, "uint"}, //22  cell voltage 10
                        {24, "int32"}, //24  charging current[0, 1A]
                        {28, "int32"}, //28  discharge current[0, 1A]1
                        {32, "int16"}, //32  Temperatur Akku 1 in 1 °C
                        {34, "int16"}, //34  Temperatur Akku 2 in 1 °C
                        {36, "int16"}, //36  Temperatur Akku 3 in 1 °C
                        {38, "int16"}, //38  Temperatur Chargerswitch in 1 °C 
                        {40, "int16"}, //40  Temperatur Powerswitch in 1 °C
                        {42, "int16"}, //42  Temperatur LTC6803 bottom stack in 0, 1 °C(Chip 1)
                        {44, "int16"}, //44  Temperatur LTC6803 top stack in 0, 1 °C(Chip 2)
                        {46, "uint32"}, //46  Errorword
                        {50, "uint16"} //50  Statusword
                    };
                    telegramTypes = telegramTypesBms;
                    break;
                case "MC":
                    var telegramTypesMc = new Dictionary<byte, string>()
                    {
                        {1, "uint8"},//1   source adresse [85]
                        {2, "uint8"},//2   target adresse [1]
                        {3, "uint8"},//3   Telegrammlength in bytes = 19 incl. Crc8
                        {4, "uint16"},//4   MC DC-link voltage
                        {6, "int16"},//6   battery current in A
                        {8, "uint16"},//8   motor rpm (Drehzahl)
                        {10, "uint8"},//10  temperature battery in °C
                        {11, "uint8"},//11  temperature motor in °C
                        {12, "int16"},//12  motorcurrent (dc link) in A
                        {14, "uint8"},//14  mc-controlbyte
                        {15, "uint8"},//15  mc - errorbyte
                        {16, "uint8"},//16  Throttle(Gas) setpoint
                        {17, "uint16"}//17  Torque sensor raw value if parameterized in MC; otherwise not used
                        //19  Checksum CRC8

                    };
                    telegramTypes = telegramTypesMc;
                    break;

            }

            return telegramTypes;

        }
    }
}
