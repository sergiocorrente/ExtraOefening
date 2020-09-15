using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraOefening
{
    public partial class oef4 : Form
    {
        public oef4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            oef4Bis objB = new oef4Bis();
            objB.Show();
            this.Close();
            



        }

        private void oef4_Load(object sender, EventArgs e)
        {

        }
        public void ab(int a)
        {
            int b;
            b = a;
            label2.Text = " Tafel van " + Convert.ToString(b) + " vermenigvuldiging met de getallen 1 t/m 10.";
            for (int i = 1; i <= 10; i++)
            {
                int result = i * b;
                label1.Text += " " + Convert.ToString(result);
            
            }
        }
    }
    }

