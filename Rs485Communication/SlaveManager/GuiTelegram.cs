using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;
namespace SlaveManager
{
    public class GuiTelegram:Telegram
    {
        //feste Telegrammwerte
        public byte sourceAddress = 1; //uint8 -> MC300
        public byte targetAddress = 85; //uint8 ->Interface
        public byte telegramLength = 6; //uint8 ->im Original 87; enspricht der Anzahl an bytes, die gesendet werden

        //variable Werte
        public ushort mcSetpoint;
        public byte mcTorque;


        //als Binärwerte
        public string SourceAddressBitString => ByteUmrechnen(this.sourceAddress);
        public string TargetAddressBitString => ByteUmrechnen(this.targetAddress);
        public string TelegramLengthBitString => ByteUmrechnen(this.telegramLength);
        //public string AltitudeBitString => UshortUmrechnen(this.altitude);
        public string McSetpointBitString => UshortUmrechnen(this.mcSetpoint);
        public string McTorqueBitString => ByteUmrechnen(this.mcTorque);

        


        //Konstruktor GUI Telegram zur Simulierung zufälliger Telegramme Gui->MC
        public GuiTelegram(ushort randomMcSetpoint, byte randomMcTorque) 
        {
           // this.altitude = randomAltitude;
            this.mcSetpoint = randomMcSetpoint;
            this.mcTorque = randomMcTorque;
        }

        public string TelgramBinaerAusgeben()
        {
            string binaerString = SourceAddressBitString + TargetAddressBitString + TelegramLengthBitString + McSetpointBitString + McTorqueBitString;
            return binaerString;
        }
    }
}


