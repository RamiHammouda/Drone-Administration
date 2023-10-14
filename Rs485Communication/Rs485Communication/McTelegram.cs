using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Collections;

namespace MasterManager
{
    public class McTelegram:SlaveManager.Telegram
    {
        //feste Telegramwerte

        public byte sourceAddress = 85; //uint8 -> MC300
        public byte targetAddress = 1; //uint8 ->Interface
        public byte telegramLength = 18; //uint8 ->im Opublic byte telegramIdentification = 0; //uint8

        //Random Werte werden ab hier benötigt; werden im Konstruktor randomly (in bestimmten Grenzen+1) gesetzt
        public ushort accuVoltage;
        public short accuCurrent;
        public ushort motorRpm;
        public byte batteryTemperature;
        public byte motorTemperature;
        public short motorCurrent;
        public byte mcControlbyte;
        public byte mcErrorbyte; 
        public byte throttleMcOutput;
        public ushort torque;
      
        //als Bitarrays
        public string SourceAddressBitString => ByteUmrechnen(sourceAddress);
        public string TargetAddressBitString => ByteUmrechnen(targetAddress);
        public string TelegramLengthBitString => ByteUmrechnen(telegramLength);

        public string AccuVoltageBitString => UshortUmrechnen(accuVoltage);
        public string AccuCurrentBitString => ShortUmrechnen(accuCurrent);
        public string MotorRpmBitString => UshortUmrechnen(motorRpm);
        public string BatteryTemperatureBitString => ByteUmrechnen(batteryTemperature);
        public string MotorTemperatureBitString => ByteUmrechnen(motorTemperature);
        public string MotorCurrentBitString => UshortUmrechnen((ushort) motorCurrent);
        public string McControlbyteBitString => ByteUmrechnen(mcControlbyte);
        public string McErrorbyteBitString => ByteUmrechnen(mcErrorbyte);
        public string ThrottleMcOutputBitString => ByteUmrechnen(throttleMcOutput);
        public string TorqueBitString => UshortUmrechnen((ushort)torque);

        //Konstruktor MC Telegram zur Simulierung zufälliger Telegramme MC->Gui
        public McTelegram(ushort randomAccuVoltage, short randomAccuCurrent,  ushort randomMotorRpm, byte randomBatteryTemperature, byte randomMotorTemperature,
            short randomMotorCurrent, byte randomMcControlbyte, byte randomMcErrorbyte, byte randomThrottle, ushort randomTorque)
        {
            this.accuVoltage = randomAccuVoltage;
            this.accuCurrent = randomAccuCurrent;
            this.motorRpm = randomMotorRpm;
            this.batteryTemperature = randomBatteryTemperature;
            this.motorTemperature = randomMotorTemperature;
            this.motorCurrent = randomMotorCurrent;
            this.mcControlbyte = randomMcControlbyte;
            this.mcErrorbyte = randomMcErrorbyte;
            this.throttleMcOutput = randomThrottle;
            this.torque = randomTorque;
        }


        /// <summary>
        /// Das zufällig generierte Telgram soll in Textdatei (als bytestream mit binaren Werten) geschrieben werden, die wiederum von Emulator als Grundlage zum Senden der Daten verwendet wird
        /// </summary>
        /// <param name="pathTxtDatei">gibt den Pfad an, in der das generierte Telegram geschrieben werden soll</param>
        public void TelegramInTextdateiSchreiben(string pathTxtDatei)
        {
            string[] telegramMcArray = new string[]
            {
                this.SourceAddressBitString,
                this.TargetAddressBitString,
                this.TelegramLengthBitString,
                this.AccuVoltageBitString,
                this.AccuCurrentBitString,
                this.MotorRpmBitString,
                this.BatteryTemperatureBitString,
                this.MotorTemperatureBitString,
                this.MotorCurrentBitString,
                this.McControlbyteBitString,
                this.McErrorbyteBitString,
                this.ThrottleMcOutputBitString,
                this.TorqueBitString
            };

            string newTelegram = "";

            foreach (string dataElement in telegramMcArray)
            {
                newTelegram += dataElement;
            }

            System.IO.File.WriteAllText(pathTxtDatei, newTelegram);

        }

    }
}
