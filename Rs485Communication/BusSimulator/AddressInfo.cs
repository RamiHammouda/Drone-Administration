using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusSimulator
{
    public partial class AddressInfo : Form
    {
        public AddressInfo()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_backToSimulator_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
