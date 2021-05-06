using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmCalendar : Form
    {
        List<string> listFiles = new List<string>();
        private bool isCollapsed;
        string kaupunki = "";
        

        public frmCalendar()
        {
            InitializeComponent();
           
        }

        private void frmCalendar_Load(object sender, EventArgs e)
        {

        }
       
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public static List<FileInfo> GetFileList(string fileSearchPattern, string rootFolderPath)
        {
            DirectoryInfo rootDir = new DirectoryInfo(rootFolderPath);

            List<DirectoryInfo> dirList = new List<DirectoryInfo>(
                rootDir.GetDirectories("*", SearchOption.AllDirectories));
            dirList.Add(rootDir);

            List<FileInfo> fileList = new List<FileInfo>();

            foreach (DirectoryInfo dir in dirList)
            {
                fileList.AddRange(
                    dir.GetFiles(fileSearchPattern, SearchOption.TopDirectoryOnly));
            }

            return fileList;
        }

        private void button1_Click(object sender, EventArgs e, string rootFolderPath)
        {
          
        }
            

        

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

      

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true;

        }


   
        private void checkBoxUlvila_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string päivä = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            
           
           
           

            if (checkBoxUlvila.CheckState == CheckState.Checked)
            {
                kaupunki = "Ulvila ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Ulvila\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;



            }
            else if (checkBoxPori.CheckState == CheckState.Checked)
            {
                kaupunki = "Pori ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Pori\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;


            }
            else if (checkBoxRauma.CheckState == CheckState.Checked)
            {
                kaupunki = "Rauma ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Rauma\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;


            }
            else if (checkBoxSastamala.CheckState == CheckState.Checked)
            {
                kaupunki = "Sastamala ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Sastamala\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;

            }
            else if (checkBoxTampere.CheckState == CheckState.Checked)
            {
                kaupunki = "Tampere ";


                listFilesInDirecotry(@"Z:\a\Kaupungit\Tampere\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;

            }
            else if (checkBoxFuengirola.CheckState == CheckState.Checked)
            {
                kaupunki = "Fuengirola ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Fuengirola\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;


            }
            else if (checkBoxMantta.CheckState == CheckState.Checked)
            {
                kaupunki = "Mänttä ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Mänttä\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;

            }
            else if (checkBoxKankaanpaa.CheckState == CheckState.Checked)
            {
                kaupunki = "Kankaanpää ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Kankaanpää\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;

            }
            else if (checkBoxJyvaskyla.CheckState == CheckState.Checked)
            {
                kaupunki = "Jyväskylä ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Jyväskylä\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;

            }
            else if (checkBoxHelsinki.CheckState == CheckState.Checked)
            {
                kaupunki = "Helsinki ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Helsinki\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;


            }
            else if (checkBoxHuittinen.CheckState == CheckState.Checked)
            {
                kaupunki = "Huittinen ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Huittinen\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;

            }
            else if (checkBoxKeuruu.CheckState == CheckState.Checked)
            {
                kaupunki = "Keuruu ";

                listFilesInDirecotry(@"Z:\a\Kaupungit\Keuruu\" + päivä);
                label4.Text = "Tuloksia haulle: " + päivä + "," + kaupunki;


            }
            else
            {
                label4.Text = "Valitse kaupunki!";
                webBrowser1.Navigate((Uri)null);
              
            }






        }
        private void listFilesInDirecotry(string workingDirecotry)
        {
            try
            {
             string[] filePaths = Directory.GetFiles(workingDirecotry);



             
            foreach (string filePath in filePaths)
            {
                webBrowser1.Url = new Uri(workingDirecotry);
            }
            }
            catch (DirectoryNotFoundException)
            {
                
                webBrowser1.DocumentText = "Ei tuloksia";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxRauma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSastamala_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTampere_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFuengirola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMantta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxKankaanpaa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxJyvaskyla_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHelsinki_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHuittinen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxKeuruu_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {

                
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = false;
                }
            }
            else
            {

               
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
        }   

        private void folderBrowserDialog_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}
