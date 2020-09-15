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
    public partial class oef5 : Form
    {
        public oef5()
        {
            InitializeComponent();
        }
        //Lijst Lijst1 = new Lijst();
        List<Persoon> naamLijst = new List<Persoon>();
        private void button1_Click(object sender, EventArgs e)
        {
            naamLijst.Add(new Persoon(textBox1.Text, textBox2.Text, textBox3.Text));
            int count = naamLijst.Count - 1;
            listBox1.Items.Add(naamLijst[count]);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void labResultaat_Click(object sender, EventArgs e)
        {
        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persoon naamLijst = (Persoon)listBox1.SelectedItem;
            labResultaat.Text = naamLijst.Inhoud();
        }
    }
} 