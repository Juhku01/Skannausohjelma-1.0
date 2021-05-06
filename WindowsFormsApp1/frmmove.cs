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


namespace WindowsFormsApp1
{
    public partial class frmmove : Form
    {
        OpenFileDialog o = new OpenFileDialog();
        BackgroundWorker worker = new BackgroundWorker();
        string path = Environment.CurrentDirectory;
        public frmmove()
        {
            InitializeComponent();
            worker.WorkerSupportsCancellation = true;
            worker.WorkerReportsProgress = true;

         
            worker.DoWork += Worker_DoWork;
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            CopyFile(textBox1.Text, textBox2.Text);
            if (File.Exists(textBox1.Text))
            {
                File.Delete(textBox1.Text);

            }
            
        }
        void CopyFile(string source, string des)
        {
            FileStream fsout = new FileStream(des, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);
            byte[] bt = new byte[1048756];
            int readByte;

            while ((readByte = fsIn.Read(bt, 0, bt.Length)) > 0)
            {
                fsout.Write(bt, 0, readByte);
                worker.ReportProgress((int)(fsIn.Position * 100 / fsIn.Length));
            }
            fsIn.Close();
            fsout.Close();
           
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            worker.RunWorkerAsync();
            
                        string tekstisijainti = @"C:\Users\juhani.jokitulppo\source\repos\WindowsFormsApp1\WindowsFormsApp1\loki.txt";
                        string Todayis = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
                      
                        string teksti1 = textBox1.Text = o.FileName;

                        string filename = null;

                        filename = Path.GetFileName(teksti1);

                        string teksti2 = textBox2.Text;
                        string filename2 = null;
                        filename2 = Path.GetFileName(teksti2);

                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " siirettiin kansiolle" + teksti1 + " \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                              tw.WriteLine(Todayis + " Tiedosto " + filename + " siirettiin kansiolle" + teksti1 + " \r\n");
                            }
                        }


        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            if (o.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = o.FileName;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBox2.Text = Path.Combine(fbd.SelectedPath, Path.GetFileName(textBox1.Text));
            }
        }

        private void frmmove_Load(object sender, EventArgs e)
        {

        }
    }
}
