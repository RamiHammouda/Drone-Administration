using System;
using System.Collections.Generic;
using System.Text;
namespace SlaveManager
{
    public class BmsTelegram: Telegram
    {
        public byte sourceAddress = 170; //uint8 -> MC300
        public byte targetAddress = 1; //uint8 ->Interface
        public byte telegramLength = 51;

        //variable Werte:
        public ushort voltageCellOne;
        public ushort voltageCellTwo;
        public ushort voltageCellThree;
        public ushort voltageCellFour;
        public ushort voltageCellFive;
        public ushort voltageCellSix;
        public ushort voltageCellSeven;
        public ushort voltageCellEight;
        public ushort voltageCellNine;
        public ushort voltageCellTen;
        public int currentIc;
        public int currentId;
        public short tempAccuOne;
        public short tempAccuTwo;
        public short tempAccuThree;
        public short tempCharge;
        public short tempPowerSwitch;
        public short chipOne;
        public short chipTwo;
        public uint errorword;
        public ushort statusword;
       

        //als byteWerte
        public string SourceAddressBytestring =>ByteUmrechnen(this.sourceAddress);
        public string TargetAddressBytestring => ByteUmrechnen(this.targetAddress);
        public string TelegramLengthBytestring =>ByteUmrechnen(this.telegramLength);

        //variable Werte:
        public string VoltageCellOneBytestring => UshortUmrechnen(voltageCellOne);
        public string VoltageCellTwoBytestring => UshortUmrechnen(voltageCellTwo);
        public string VoltageCellThreeBytestring => UshortUmrechnen(voltageCellThree);
        public string VoltageCellFourBytestring => UshortUmrechnen(voltageCellFour);
        public string VoltageCellFiveBytestring => UshortUmrechnen(voltageCellFive);
        public string VoltageCellSixBytestring => UshortUmrechnen(voltageCellSix);
        public string VoltageCellSevenBytestring => UshortUmrechnen(voltageCellSeven);
        public string VoltageCellEightBytestring => UshortUmrechnen(voltageCellEight);
        public string VoltageCellNineBytestring => UshortUmrechnen(voltageCellNine);
        public string VoltageCellTenBytestring => UshortUmrechnen(voltageCellTen);
        public string CurrentIcBytestring => IntUmrechnen(currentIc);
        public string CurrentIdBytestring =>IntUmrechnen(currentId);
        public string TempAccuOneBytestring=>ShortUmrechnen(tempAccuOne);
        public string TempAccuTwoBytestring =>ShortUmrechnen(tempAccuTwo);
        public string TempAccuThreeBytestring =>ShortUmrechnen(tempAccuThree);
        public string TempChargeBytestring =>ShortUmrechnen(tempCharge);
        public string TempPowerSwitchBytestring =>ShortUmrechnen(tempPowerSwitch);
        public string ChipOneBytestring =>ShortUmrechnen(chipOne);
        public string ChipTwoBytestring =>ShortUmrechnen(chipTwo);
        public string ErrorwordBytestring =>UIntUmrechnen(errorword);
        public string StatuswordBytestring =>UshortUmrechnen(statusword);

        //Konstruktor BMS Telegram zur Simulierung zufälliger Telegramme BMS->Gui
        public BmsTelegram(ushort randomVoltageCellOne, ushort randomVoltageCellTwo, ushort randomVoltageCellThree,
            ushort randomVoltageCellFour, ushort randomVoltageCellFive, ushort randomVoltageCellSix,
            ushort randomVoltageCellSeven, ushort randomVoltageCellEight, ushort randomVoltageCellNine,
            ushort randomVoltageCellTen, int randomCurrentIc
            , int randomCurrentId, short randomTempAccuOne, short randomTempAccuTwo, short randomTempAccuThree,
            short randomTempCharge, short randomTempPowerSwitch, short randomChipOne, short randomChipTwo,
            uint randomErrorErrorword, ushort randomStatusword)
        {
            this.voltageCellOne = randomVoltageCellOne;
            this.voltageCellTwo = randomVoltageCellTwo;
            this.voltageCellThree = randomVoltageCellThree;
            this.voltageCellFour = randomVoltageCellThree;
            this.voltageCellFive = randomVoltageCellFive;
            this.voltageCellSix = randomVoltageCellSix;
            this.voltageCellSeven = randomVoltageCellSeven;
            this.voltageCellEight = randomVoltageCellEight;
            this.voltageCellNine = randomVoltageCellNine;
            this.voltageCellTen = randomVoltageCellTen;
            this.currentIc = randomCurrentIc;
            this.currentId = randomCurrentId;
            this.tempAccuOne = randomTempAccuOne;
            this.tempAccuTwo = randomTempAccuTwo;
            this.tempAccuThree = randomTempAccuThree;
            this.tempCharge = randomTempCharge;
            this.tempPowerSwitch = randomTempPowerSwitch;
            this.chipOne = randomChipOne;
            this.chipTwo = randomChipTwo;
            this.errorword = randomErrorErrorword;
            this.statusword = randomStatusword;
        }

        /// <summary>
        /// BMS Telegram wird in Textdatei geschrieben
        /// </summary>
        /// <param name="pathTxtDatei"></param>
        public void BmsTelegramInTextdateiSchreiben(string pathTxtDatei)
        {
            string[] telegramBmsArray = new string[]
            {
                this.SourceAddressBytestring,
                this.TargetAddressBytestring,
                this.TelegramLengthBytestring,
                this.VoltageCellOneBytestring,
                this.VoltageCellTwoBytestring,
                this.VoltageCellThreeBytestring,
                this.VoltageCellFourBytestring,
                this.VoltageCellFiveBytestring,
                this.VoltageCellSixBytestring,
                this.VoltageCellSevenBytestring,
                this.VoltageCellEightBytestring,
                this.VoltageCellNineBytestring,
                this.VoltageCellTenBytestring,
                this.CurrentIcBytestring,
                this.CurrentIdBytestring,
                this.TempAccuOneBytestring,
                this.TempAccuTwoBytestring,
                this.TempAccuThreeBytestring,
                this.TempChargeBytestring,
                this.TempPowerSwitchBytestring,
                this.ChipOneBytestring,
                this.ChipTwoBytestring,
                this.ErrorwordBytestring,
                this.StatuswordBytestring
            };

            string newBmsTelegram = "";

            foreach (string dataElement in telegramBmsArray)
            {
                newBmsTelegram += dataElement;
            }

            System.IO.File.WriteAllText(pathTxtDatei,newBmsTelegram);
        }

        public Dictionary<byte, string> FindDataType()
        {
            //zweites Dictionary, dass die Information über den Datentyp enthält; wichtig für die prepared data, da es sonst bei binär zu dezimal zu fehlern kommen kann
            var bmsTelegramDatatypes = new Dictionary<byte, string>()
            {
                {1, sourceAddress.GetType().ToString()},//1 source adresse [170]
                {2, targetAddress.GetType().ToString()},//2   target adresse[1]
                {3, telegramLength.ToString()},//3   Telegrammlength in bytes(52 incl.Crc8)
                { 4,voltageCellOne.GetType().ToString()},//4   cell voltage 1
                { 6, voltageCellTwo.GetType().ToString()},//6   cell voltage 2
                { 8, voltageCellThree.GetType().ToString()},//8   cell voltage 3
                { 10, voltageCellFour.GetType().ToString()},//10  cell voltage 4
                { 12, voltageCellFive.GetType().ToString()}, //12  cell voltage 5
                { 14, voltageCellSix.GetType().ToString()},//14  cell voltage 6
                { 16, voltageCellSeven.GetType().ToString()},//16  cell voltage 7
                { 18, voltageCellEight.GetType().ToString()},//18  cell voltage 8
                { 20, voltageCellNine.GetType().ToString()},//20  cell voltage 9
                { 22, voltageCellTen.GetType().ToString()},//22  cell voltage 10
                { 24, currentIc.GetType().ToString()},//24  charging current[0, 1A]
                { 28, currentId.GetType().ToString()},//28  discharge current[0, 1A]1
                { 32, tempAccuOne.GetType().ToString()},//32  Temperatur Akku 1 in 1 °C
                { 34, tempAccuTwo.GetType().ToString()},//34  Temperatur Akku 2 in 1 °C
                { 36, tempAccuThree.GetType().ToString()},//36  Temperatur Akku 3 in 1 °C
                { 38, tempCharge.GetType().ToString()},//38  Temperatur Chargerswitch in 1 °C 
                { 40, tempPowerSwitch.GetType().ToString()},//40  Temperatur Powerswitch in 1 °C
                { 42, chipOne.GetType().ToString()},//42  Temperatur LTC6803 bottom stack in 0, 1 °C(Chip 1)
                { 44, chipTwo.GetType().ToString()},//44  Temperatur LTC6803 top stack in 0, 1 °C(Chip 2)
                { 46, errorword.GetType().ToString()},//46  Errorword
                { 50, statusword.GetType().ToString()}//50  Statusword
            };
            return bmsTelegramDatatypes = new Dictionary<byte, string>();
        }
    }
}
