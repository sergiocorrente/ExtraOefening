using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtraOefening
{
    public partial class oef2 : Form
    {

        public oef2()

        {
            InitializeComponent();
        }

     

        Stream mijnStream;
        private void btnOpenBestand_Click(object sender, EventArgs e)
        {   //gebruiker wordt gevraagd een bestand te openen
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {    
                string strBestand = ofd.FileName;
                //MessageBox.Show(strBestaande);
                if((mijnStream = ofd.OpenFile()) != null)
                {
                    string bestandText = File.ReadAllText(strBestand);
                  // Splits strings die wordt gescheden door carriage return line feed en voegd ze in de lijst
                    foreach (string line in bestandText.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None))
                    {
                        listBox1.Items.Add(line);
                    }


                }
              
            }
            
        }
    }
}
