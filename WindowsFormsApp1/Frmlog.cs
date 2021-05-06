using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frmlog : Form
    {
        public Frmlog()
        {
            InitializeComponent();

            string plainText = null;
            string path = Directory.GetCurrentDirectory() + "loki.txt";
            

            if (!File.Exists(path))
            {
                File.Create(path);

               

            }
            else if (File.Exists(path))
            {

                richTextBox1.Text += File.ReadAllText(path) + Environment.NewLine;
                plainText = richTextBox1.Text;
                File.WriteAllText(path, plainText);
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.ScrollToCaret();
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

           
            


        }
    }
}
