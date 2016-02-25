using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_LED
{
    public partial class Profile : Form
    {
        public Profile()
        {
            SerialPort port = new SerialPort();
            port.PortName = "COM3";
            InitializeComponent();
            serialPort1.Open();
        }

        private void ReturnToChatt_Click(object sender, EventArgs e)
        {
            Main ss = new Main();
            ss.Closed += (s, args) => this.Close();
            ss.Show();
        }
    }
}
