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
    public partial class oef4Bis : Form
    {
        public oef4Bis()
        {
            InitializeComponent();
        }
        int nud1;
        oef4 objA = new oef4();
        private void button1_Click(object sender, EventArgs e)
        {
            nud1 = Convert.ToInt32(numericUpDown1.Value);
        
            objA.ab(nud1);
            objA.Show();
            this.Close();
           
        }

        private void oef4Bis_Load(object sender, EventArgs e)
        {
            
        }
       
    }
    }

