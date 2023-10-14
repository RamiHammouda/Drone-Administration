using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace SlaveManager
{
    public abstract class Telegram
    {

        //Umrechnen der Datentypen in binaere Strings
        public static string ByteUmrechnen(byte byteWert)
        {
            BitArray byteAlsByteArray = new BitArray(new Byte[] {byteWert});
            //konvertiert eine byte-Zahl zu binären werten; totalWidt =16 wären 2 bytes; paddingChar=Zahl, die auffüllt
            string bitString = Convert.ToString(byteWert, 2).PadLeft(8, '0');
            return bitString;
        }
        public static string UshortUmrechnen(ushort ushortWert)
        {
            BitArray ushortAlsByteArray = new BitArray(new int[] {ushortWert});
            //konvertiert eine ushort-Zahl zu binären werten; totalWidt = 16 wären 2 bytes; paddingChar = Zahl, die auffüllt
            string bitString = Convert.ToString(ushortWert, 2).PadLeft(16, '0');
            return bitString;
        }
        public static string ShortUmrechnen(short shortWert)
        {
            //konvertiert ein short-Zahl zu binären werten; totalWidt =16 wären 2 bytes; paddingChar=Zahl, die auffüllt
            string bitString = Convert.ToString(shortWert, 2).PadLeft(16, '0');
            return bitString;
        }
        public static string IntUmrechnen(int intWert)
        {
            //konvertiert eine int-Zahl zu binären werten; totalWidt =16 wären 2 bytes; paddingChar=Zahl, die auffüllt
            string bitString = Convert.ToString(intWert, 2).PadLeft(32, '0');
            return bitString;
        }
        public static string UIntUmrechnen(uint uintWert)
        {
            //konvertiert eine int-Zahl zu binären werten; totalWidt =16 wären 2 bytes; paddingChar=Zahl, die auffüllt
            string bitString = Convert.ToString(uintWert, 2).PadLeft(32, '0');
            return bitString;
        }

        /// <summary>
        /// Methode ermöglicht das zufällige Zuweisen eines Wertes (int) in gegebener Range
        /// </summary>
        /// <param name="minValue">Minimalwert</param>
        /// <param name="maxValue">Maximalwert</param>
        /// <returns></returns>
        public static int RandomWerteZuweisen(int minValue, int maxValue)
        {
            Random randomValue = new Random();
            return randomValue.Next(minValue, maxValue);
        }

        public static uint RandomUintZuweisen(uint minValue, uint maxValue)
        {
            Random randomValue = new Random();
            int number = randomValue.Next(Int32.MinValue, Int32.MaxValue);
            return (uint)(number + (uint)Int32.MaxValue);
        }
      

        public static Dictionary<byte,string> BinaryToDictionary(string telegramType, string telegram)
        {
            string[] singleBytesTelegram = Regex.Split(telegram, "(?<=\\G.{8})");
            var telegramReadable = new Dictionary<byte, string>();
            switch (telegramType)
            {
                case "Gui":
                    var guiTelegramReadable = new Dictionary<byte, string>()
                    {
                        {1,singleBytesTelegram[0]},//1   source adresse [1]
                        {2, singleBytesTelegram[1]},//2   target adresse [85]
                        {3, singleBytesTelegram[2]},//3   Telegrammlength in bytes = 9 incl. Crc8
                        {4, singleBytesTelegram[3]+singleBytesTelegram[4]},//4   reserved (Setpoint)
                        {6, singleBytesTelegram[6]}//6   MC - Torque limit[0 - 100 %]
                        
                    };
                    telegramReadable =guiTelegramReadable;
                    break;
                case "BMS":
                    var bmsTelegramReadable = new Dictionary<byte, string>()
                    {
                        {1, singleBytesTelegram[0]},//1 source adresse [170]
                        {2, singleBytesTelegram[1]},//2   target adresse[1]
                        {3, singleBytesTelegram[2]},//3   Telegrammlength in bytes(52 incl.Crc8)
                        {4, singleBytesTelegram[3]+singleBytesTelegram[4]},//4   cell voltage 1
                        {6, singleBytesTelegram[5]+singleBytesTelegram[6]},//6   cell voltage 2
                        {8, singleBytesTelegram[7]+singleBytesTelegram[8]},//8   cell voltage 3
                        {10, singleBytesTelegram[9]+singleBytesTelegram[10]},//10  cell voltage 4
                        {12, singleBytesTelegram[11]+singleBytesTelegram[12]}, //12  cell voltage 5
                        {14, singleBytesTelegram[13]+singleBytesTelegram[14]},//14  cell voltage 6
                        {16, singleBytesTelegram[15]+singleBytesTelegram[16]},//16  cell voltage 7
                        {18, singleBytesTelegram[17]+singleBytesTelegram[18]},//18  cell voltage 8
                        {20, singleBytesTelegram[19]+singleBytesTelegram[20]},//20  cell voltage 9
                        {22, singleBytesTelegram[21]+singleBytesTelegram[22]},//22  cell voltage 10
                        {24, singleBytesTelegram[23]+singleBytesTelegram[24]+singleBytesTelegram[25]+singleBytesTelegram[26]},//24  charging current[0, 1A]
                        {28, singleBytesTelegram[27]+singleBytesTelegram[28]+singleBytesTelegram[29]+singleBytesTelegram[30]},//28  discharge current[0, 1A]1
                        {32, singleBytesTelegram[31]+singleBytesTelegram[32]},//32  Temperatur Akku 1 in 1 °C
                        {34, singleBytesTelegram[33]+singleBytesTelegram[34]},//34  Temperatur Akku 2 in 1 °C
                        {36, singleBytesTelegram[35]+singleBytesTelegram[36]},//36  Temperatur Akku 3 in 1 °C
                        {38, singleBytesTelegram[37]+singleBytesTelegram[38]},//38  Temperatur Chargerswitch in 1 °C
                        {40, singleBytesTelegram[39]+singleBytesTelegram[40]},//40  Temperatur Powerswitch in 1 °C
                        {42, singleBytesTelegram[41]+singleBytesTelegram[42]},//42  Temperatur LTC6803 bottom stack in 0, 1 °C
                        {44, singleBytesTelegram[43]+singleBytesTelegram[44]},//44  Temperatur LTC6803 top stack in 0, 1 °C
                        {46, singleBytesTelegram[45]+singleBytesTelegram[46]+singleBytesTelegram[47]+singleBytesTelegram[48]},//46  Errorword
                        {50, singleBytesTelegram[49]+singleBytesTelegram[50]}//50  Statusword
                        
                    };
                    telegramReadable = bmsTelegramReadable;
                    break;
                case "MC":
                    var mcTelegramReadable = new Dictionary<byte, string>()
                    {
                        {1, singleBytesTelegram[0]},//1   source adresse [85]
                        {2, singleBytesTelegram[1]},//2   target adresse [1]
                        {3, singleBytesTelegram[2]},//3   Telegrammlength in bytes = 19 incl. Crc8
                        {4, singleBytesTelegram[3]+singleBytesTelegram[4]},//4   MC DC-link voltage
                        {6, singleBytesTelegram[5]+singleBytesTelegram[6]},//6   battery current in A
                        {8, singleBytesTelegram[7]+singleBytesTelegram[8]},//8   motor rpm (Drehzahl)
                        {10, singleBytesTelegram[9]},//10  temperature battery in °C
                        {11, singleBytesTelegram[10]},//11  temperature motor in °C
                        {12, singleBytesTelegram[11]+singleBytesTelegram[12]},//12  motorcurrent (dc link) in A
                        {14, singleBytesTelegram[13]},//14  mc-controlbyte
                        {15, singleBytesTelegram[14]},//15  mc - errorbyte
                        {16, singleBytesTelegram[15]},//16  Throttle(Gas) setpoint
                        {17, singleBytesTelegram[16]+singleBytesTelegram[17]}//17  Torque sensor raw value if parameterized in MC; otherwise not used
                        
                    };
                    telegramReadable = mcTelegramReadable;
                    break;


            }

            return telegramReadable;
        }
    }
}
