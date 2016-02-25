using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arduino_LED
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //serialPort1.Open();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Profile ss = new Profile();
            ss.Closed += (s, args) => this.Hide();
            ss.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
       
            //serialPort1.Write("k");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Sender se = new Sender();
            //se.SendMessage(ipAddress, port);


            //serialPort1.Write("A");

        }
    }
}
