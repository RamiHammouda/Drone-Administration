using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic;


namespace WindowsFormsApp1.UserControls
{
    public partial class BMS : UserControl
    {
        InformationPrep informations = new InformationPrep();
        public BMS()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //CellVoltage
            var CellVoltageListe = new List<short>();
            CellVoltageListe = informations.GetCellVoltage();
            //Cell1
            double percentage1 = (double)((Convert.ToDouble(CellVoltageListe[0]) - 4.2) / 2.2);
            int a1 = Convert.ToInt32(panel10.Height * percentage1);
            Valuepanel1.Height = a1;
            Point start1 = new Point(-1, 123 - a1); ///123
            Valuepanel1.Location = start1;
            //Cell2
            double percentage2 = (double)((Convert.ToDouble(CellVoltageListe[1]) - 4.2) / 2.2);
            int a2 = Convert.ToInt32(panel3.Height * percentage2);
            panel22.Height = a2;
            Point start2 = new Point(-1, 123 - a2); ///123
            panel22.Location = start2;
            //Cell3
            double percentage3 = (double)((Convert.ToDouble(CellVoltageListe[2]) - 4.2) / 2.2);
            int a3 = Convert.ToInt32(panel6.Height * percentage3);
            panel36.Height = a3;
            Point start3 = new Point(-1, 123 - a3); ///123
            panel36.Location = start3;
            //Cell4
            double percentage4 = (double)((Convert.ToDouble(CellVoltageListe[3]) - 4.2) / 2.2);
            int a4 = Convert.ToInt32(panel8.Height * percentage4);
            panel37.Height = a4;
            Point start4 = new Point(-1, 123 - a4); ///123
            panel37.Location = start4;
            //Cell5
            double percentage5 = (double)((Convert.ToDouble(CellVoltageListe[4]) - 4.2) / 2.2);
            int a5 = Convert.ToInt32(panel23.Height * percentage5);
            panel38.Height = a5;
            Point start5 = new Point(-1, 123 - a5); ///123
            panel38.Location = start5;
            //Cell6
            double percentage6 = (double)((Convert.ToDouble(CellVoltageListe[5]) - 4.2) / 2.2);
            int a6 = Convert.ToInt32(panel25.Height * percentage6);
            panel39.Height = a6;
            Point start6 = new Point(-1, 123 - a6); ///123
            panel39.Location = start1;
            //Cell7
            double percentage7 = (double)((Convert.ToDouble(CellVoltageListe[6]) - 4.2) / 2.2);
            int a7 = Convert.ToInt32(panel27.Height * percentage7);
            panel40.Height = a7;
            Point start7 = new Point(-1, 123 - a7); ///123
            panel40.Location = start1;
            //Cell8
            double percentage8 = (double)((Convert.ToDouble(CellVoltageListe[7]) - 4.2) / 2.2);
            int a8 = Convert.ToInt32(panel29.Height * percentage8);
            panel41.Height = a8;
            Point start8 = new Point(-1, 123 - a8); ///123
            panel41.Location = start8;
            //Cell9
            double percentage9 = (double)((Convert.ToDouble(CellVoltageListe[8]) - 4.2) / 2.2);
            int a9 = Convert.ToInt32(panel31.Height * percentage9);
            panel42.Height = a9;
            Point start9 = new Point(-1, 123 - a9); ///123
            panel42.Location = start9;
            //Cell10
            double percentage10 = (double)((Convert.ToDouble(CellVoltageListe[9]) - 4.2) / 2.2);
            int a10 = Convert.ToInt32(panel33.Height * percentage10);
            panel43.Height = a10;
            Point start10 = new Point(-1, 123 - a10); ///123
            panel43.Location = start10;

            //CellCurrent_IC
            double Ic = Convert.ToDouble(informations.GetChargingCurrent(28));
            double percentage01 = (double)((Ic + 400.0) / 800.0);
            int a01 = Convert.ToInt32(panel35.Height * percentage01);
            panel48.Height = a01;
            Point start01 = new Point(-1, 123 - a01); ///123
            panel48.Location = start01;
            //CellCurrent_ID
            double Id = Convert.ToDouble(informations.GetDischargingCurrent(28));
            double percentage02 = (double)((Id + 30.0) / 60.0);
            int a02 = Convert.ToInt32(panel34.Height * percentage02);
            panel49.Height = a02;
            Point start02 = new Point(-1, 123 - a02); ///123
            panel49.Location = start02;

            //Akkutemp
            var AkkuTempList = new List<short>();
            AkkuTempList = informations.GetAkkuTemp();
            //Akku1
            double percentage30 = (double)((Convert.ToDouble(AkkuTempList[0]) + 85.0) / 115.0);
            int a30 = Convert.ToInt32(panel20.Height * percentage30);
            panel50.Height = a30;
            Point start30 = new Point(-1, 123 - a30); ///123
            panel50.Location = start30;
            //Akku2
            double percentage31 = (double)((Convert.ToDouble(AkkuTempList[1]) + 85.0) / 115.0);
            int a31 = Convert.ToInt32(panel19.Height * percentage31);
            panel51.Height = a31;
            Point start31 = new Point(-1, 123 - a31); ///123
            panel51.Location = start31;
            //Akku3
            double percentage32 = (double)((Convert.ToDouble(AkkuTempList[2]) + 85.0) / 115.0);
            int a32 = Convert.ToInt32(panel18.Height * percentage32);
            panel52.Height = a32;
            Point start32 = new Point(-1, 123 - a32); ///123
            panel52.Location = start32;

            //AKKU_PS
            double Ps = Convert.ToDouble(informations.GetAkkuPs());
            double percentage20 = (double)(Ps / 120.0);
            int a20 = Convert.ToInt32(panel17.Height * percentage20);
            panel44.Height = a20;
            Point start20 = new Point(-1, 123 - a20); ///123
            panel44.Location = start20;

            //AKKU_Charge
            double charge = Convert.ToDouble(informations.GetAkkuCharge());
            double percentage21 = (double)(Ps / 120.0);
            int a21 = Convert.ToInt32(panel16.Height * percentage21);
            panel45.Height = a21;
            Point start21 = new Point(-1, 123 - a21); ///123
            panel45.Location = start21;

            //AkkuChipTemp
            var AkkuchipTemp = new List<short>();
            AkkuchipTemp = informations.GetChip();
            //Chip1
            double percentage22 = (double)(Convert.ToDouble(AkkuchipTemp[0]) / 120.0);
            int a22 = Convert.ToInt32(panel15.Height * percentage22);
            panel46.Height = a22;
            Point start22 = new Point(-1, 123 - a22); ///123
            panel46.Location = start22;
            //Chip2
            double percentage23 = (double)(Convert.ToDouble(AkkuchipTemp[1]) / 120.0);
            int a23 = Convert.ToInt32(panel14.Height * percentage23);
            panel47.Height = a23;
            Point start23 = new Point(-1, 123 - a23); ///123
            panel47.Location = start23;

            //ErrorList
            var ErrorList = new List<bool>();
            ErrorList = informations.GetBmsError();
            if (ErrorList[0] == true)
            {
                circularButton19.ForeColor = Color.Red;
            }
            if (ErrorList[1] == true)
            {
                circularButton18.ForeColor = Color.Red;
            }
            if (ErrorList[2] == true)
            {
                circularButton17.ForeColor = Color.Red;
            }
            if (ErrorList[3] == true)
            {
                circularButton16.ForeColor = Color.Red;
            }
            if (ErrorList[4] == true)
            {
                circularButton27.ForeColor = Color.Red;
            }
            if (ErrorList[5] == true)
            {
                circularButton26.ForeColor = Color.Red;
            }

        }
    }
}
