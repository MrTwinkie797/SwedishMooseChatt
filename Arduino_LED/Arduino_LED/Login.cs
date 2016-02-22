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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            serialPort1.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("A");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("k");
            Console.Beep();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            Main ss = new Main();
            ss.Closed += (s, args) => this.Close();
            ss.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register ss = new Register();
            ss.Closed += (s, args) => this.Close();
            ss.Show();
        }

        private void LoginBttn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Close();
        }
    }
}
