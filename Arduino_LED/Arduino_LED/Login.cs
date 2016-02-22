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
    }
}
