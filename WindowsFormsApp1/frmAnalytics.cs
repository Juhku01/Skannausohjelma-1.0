using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
            var directoryInfo = new System.IO.DirectoryInfo(@"Z:\a\Kaupungit\");
            int directoryCount = directoryInfo.GetDirectories().Length;
            string directoryCount2 = directoryCount.ToString();
           
            labelCities.Text = directoryCount2;

          
        
           
            

           



            
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
       void laskenta ()
        {
            

        }
      
       
    private void labelCities_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(@"Z:\a\Kaupungit\");
            FileInfo[] Files = d.GetFiles("*.pdf"); 
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = str + ", " + file.Name;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
          
        }
    }
}
