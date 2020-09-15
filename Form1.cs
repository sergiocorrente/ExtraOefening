using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraOefening
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oef1 obj = new oef1();
            obj.Show();
            //this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oef2 obj = new oef2();
            obj.Show();
            //this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oef3 obj = new oef3();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            oef4 obj = new oef4();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oef5 obj = new oef5();
            obj.Show();
        }
    }
    
}
