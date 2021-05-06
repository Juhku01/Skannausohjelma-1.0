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
    public partial class frmcopy : Form
    {
      
        private bool isCollapsed;
        OpenFileDialog o = new OpenFileDialog();
       

        public frmcopy()
        {
            InitializeComponent();

        }
        private void frmcopy_Load(object sender, EventArgs e)
        {

        }
        public void buttonBrowse_Click(object sender, EventArgs e)
        {

        }
        void CopyFile(string source, string des)
        {
            FileStream fsOut = new FileStream(des, FileMode.Create);
            FileStream fsIn = new FileStream(source, FileMode.Open);
            byte[] bt = new byte[10487564];
            int readByte;

            while ((readByte = fsIn.Read(bt, 0, bt.Length)) > 0)
            {
                fsOut.Write(bt, 0, readByte);


            }
            fsOut.Close();

        }

        private void buttonSave_Click(object sender, EventArgs e)
        //Talennus ominaisuus 
        {

        }





        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //näyttää kuvan

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //Tiedoston sisältö
        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmupload_Load(object sender, EventArgs e)
        {

        }

        private void checkBoxUlvila_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxPori_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
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

        private void checkBoxHelsinki_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHuittinen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxJyvaskyla_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxKankaanpaa_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxKeuruu_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTampere_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSastamala_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxRauma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxMantta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFuengirola_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }



      

        private void timer1_Tick_1(object sender, EventArgs e)
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

        private void panelDropDown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonBrowse_Click_1(object sender, EventArgs e)
        {
             o.Multiselect = true;
      
            o.Filter = "Pdf Files|*.pdf";
            if (o.ShowDialog() == DialogResult.OK)
            {


                string teksti = textBoxFileName.Text = o.FileName;
                string filename = null;
                filename = Path.GetFileName(teksti);







            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            string Todayis = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");
            string teksti2 = textBoxFileName.Text = o.FileName;
            string filename = null;
            filename = Path.GetFileName(teksti2);



            string tekstisijainti = @"C:\Users\juhani.jokitulppo\source\repos\WindowsFormsApp1\WindowsFormsApp1\loki.txt";


            string sijainti = "Z:/a/Kaupungit/";
            string sijaintibu = "Z:/backup/Kaupungit/";
            string kaupunki = null;
            //varasijainti, siltä varalta jos netti ei toimi 

            //string sijainti = @"C:/Users/juhani.jokitulppo/source/repos/WindowsFormsApp1/WindowsFormsApp1/tiedostot/a/";
            //string sijaintibu = @"C:/Users/juhani.jokitulppo/source/repos/WindowsFormsApp1/WindowsFormsApp1/tiedostot/backup/Kaupungit/";


            if (checkBoxUlvila.CheckState == CheckState.Checked)
            {
                label2.Text = "";

                string KaupunkiUlvila = "Ulvila";
                string KohdeUlvila = sijainti + "Ulvila/";
                string KohdebuUlvila = sijaintibu + "Ulvila/";
                kaupunki += "Ulvila ";

                string TodaysdateUlvila = DateTime.Now.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeUlvila + TodaysdateUlvila + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuUlvila + TodaysdateUlvila + "/kopioidut tiedostot");


                }
                string sijaintiUlvila = KohdeUlvila + TodaysdateUlvila + "/kopioidut tiedostot";
                string sijaintibuUlvila = KohdeUlvila + TodaysdateUlvila+"/kopioidut tiedostot";
                string tekstinlopulinensijainti = sijaintiUlvila + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiUlvila, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuUlvila, Path.GetFileName(textBoxFileName.Text)), true);

                        label2.Text = "Tiedoston kopiointi onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiUlvila + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + "kopioitiin kaupungille " + KaupunkiUlvila + "  \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxPori.CheckState == CheckState.Checked)
            {
                label2.Text = "";
                string KaupunkiPori = "Pori";
                string KohdePori = sijainti + "Pori/";
                string KohdebuPori = sijaintibu + "Pori/";
                string TodaysdatePori = DateTime.Now.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdePori + TodaysdatePori+"/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuPori + TodaysdatePori+"/kopioidut tiedostot");

                }

                string sijaintiPori = KohdePori + TodaysdatePori + "/kopioidut tiedostot";
                string sijaintibuPori = KohdebuPori + TodaysdatePori + "/kopioidut tiedostot";
                kaupunki += "Pori ";

                string tekstinlopulinensijainti = sijaintiPori + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiPori, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuPori, Path.GetFileName(textBoxFileName.Text)), true);
                        label2.Text = "Tiedoston kopiointi onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiPori + "  \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiPori + "  \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxFuengirola.CheckState == CheckState.Checked)
            {
                label2.Text = "";
                string KaupunkiFuengirola = "Fuengirola";
                string KohdeFuengirola = sijainti + "Fuengirola/";
                string KohdebuFuengirola = sijaintibu + "Fuengirola/";
                string TodaysdateFuengirola = DateTime.Now.ToString("dd-MM-yyyy");

                string sijaintiFuengirola = KohdeFuengirola + TodaysdateFuengirola + "/kopioidut tiedostot";
                string sijaintibuFuengirola = KohdebuFuengirola + TodaysdateFuengirola + "/kopioidut tiedostot";
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeFuengirola + TodaysdateFuengirola + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuFuengirola + TodaysdateFuengirola + "/kopioidut tiedostot");
                }
                kaupunki += "Fuengirola ";

                string tekstinlopulinensijainti = sijaintiFuengirola + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiFuengirola, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuFuengirola, Path.GetFileName(textBoxFileName.Text)), true);

                        label2.Text = "Tiedoston kopiointi onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiFuengirola + " \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiFuengirola + " \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxHelsinki.CheckState == CheckState.Checked)
            {
                label2.Text = "";
                string KaupunkiHelsinki = "Helsinki";
                string KohdeHelsinki = sijainti + "Helsinki/";
                string KohdebuHelsinki = sijaintibu + "Helsinki/";
                string TodaysdateHelsinki = DateTime.Now.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeHelsinki + TodaysdateHelsinki + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuHelsinki + TodaysdateHelsinki + "/kopioidut tiedostot");


                }
                string sijaintiHelsinki = KohdeHelsinki + TodaysdateHelsinki + "/kopioidut tiedostot";
                string sijaintibuHelsinki = KohdebuHelsinki + TodaysdateHelsinki + "/kopioidut tiedostot";
                kaupunki += "Helsinki ";

                string tekstinlopulinensijainti = sijaintiHelsinki + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiHelsinki, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuHelsinki, Path.GetFileName(textBoxFileName.Text)), true);

                        label2.Text = "Tiedoston kopiointi onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiHelsinki + "  \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiHelsinki + "  \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxHuittinen.CheckState == CheckState.Checked)
            {
                label2.Text = "";
                string KaupunkiHuittinen = "Huittinen";
                string KohdeHuittinen = sijainti + "Huittinen/";
                string KohdebuHuittinen = sijaintibu + "Huittinen/";
                string TodaysdateHuittinen = DateTime.Now.ToString("dd-MM-yyyy");
                string sijaintiHuittinen = KohdeHuittinen + TodaysdateHuittinen + "/kopioidut tiedostot";
                string sijaintibuHuittinen = KohdebuHuittinen + TodaysdateHuittinen + "/kopioidut tiedostot";
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeHuittinen + TodaysdateHuittinen + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuHuittinen + TodaysdateHuittinen + "/kopioidut tiedostot");


                }
                kaupunki += "Huittinen ";

                string tekstinlopulinensijainti = sijaintiHuittinen + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiHuittinen, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuHuittinen, Path.GetFileName(textBoxFileName.Text)), true);

                        label2.Text = "Tiedoston kopiointi onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiHuittinen + " \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiHuittinen + " \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxJyvaskyla.CheckState == CheckState.Checked)
            {
                label2.Text = "";
                string KaupunkiJyväskylä = "Jyväskylä";
                string KohdeJyväskylä = sijainti + "Jyväskylä/";
                string KohdebuJyväskylä = sijaintibu + "Jyväskylä/";
                string TodaysdateJyväskylä = DateTime.Now.ToString("dd-MM-yyyy");
                string sijaintiJyväskylä = KohdeJyväskylä + TodaysdateJyväskylä + "/kopioidut tiedostot";
                string sijaintibuJyväskylä = KohdebuJyväskylä + TodaysdateJyväskylä + "/kopioidut tiedostot";
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeJyväskylä + TodaysdateJyväskylä + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuJyväskylä + TodaysdateJyväskylä + "/kopioidut tiedostot");


                }
                kaupunki += "Jyväskylä ";

                string tekstinlopulinensijainti = sijaintiJyväskylä + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiJyväskylä, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuJyväskylä, Path.GetFileName(textBoxFileName.Text)), true);
                        label2.Text = "Tiedoston kopiointi onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiJyväskylä + "  \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiJyväskylä + "  \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxKankaanpaa.CheckState == CheckState.Checked)
            {
                label2.Text = "";
                string KaupunkiKankaanpää = "Kankaanpää";
                string KohdeKankaanpää = sijainti + "Kankaanpää/";
                string KohdebuKankaanpää = sijaintibu + "Kankaanpää/";
                string TodaysdateKankaanpää = DateTime.Now.ToString("dd-MM-yyyy");
                string sijaintiKankaanpää = KohdeKankaanpää + TodaysdateKankaanpää + "/kopioidut tiedostot";
                string sijaintibuKankaanpää = KohdebuKankaanpää + TodaysdateKankaanpää + "/kopioidut tiedostot";
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeKankaanpää + TodaysdateKankaanpää + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuKankaanpää + TodaysdateKankaanpää + "/kopioidut tiedostot");


                }
                kaupunki += "Kankaanpää ";

                string tekstinlopulinensijainti = sijaintiKankaanpää + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiKankaanpää, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuKankaanpää, Path.GetFileName(textBoxFileName.Text)), true);

                        label2.Text = "Tiedoston kopiointi onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiKankaanpää + " \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiKankaanpää + " \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxKeuruu.CheckState == CheckState.Checked)
            {
                label2.Text = "";
                string KaupunkiKeuruu = "Keuruu";
                string KohdeKeuruu = sijainti + "Keuruu/";
                string KohdebuKeuruu = sijaintibu + "Keuruu/";
                string TodaysdateKeuruu = DateTime.Now.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeKeuruu + TodaysdateKeuruu + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuKeuruu + TodaysdateKeuruu + "/kopioidut tiedostot");


                }

                string sijaintiKeuruu = KohdeKeuruu + TodaysdateKeuruu + "/kopioidut tiedostot";
                string sijaintibuKeuruu = KohdebuKeuruu + TodaysdateKeuruu + "/kopioidut tiedostot";
                kaupunki += "Keuruu ";

                string tekstinlopulinensijainti = sijaintiKeuruu + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiKeuruu, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuKeuruu, Path.GetFileName(textBoxFileName.Text)), true);
                        label2.Text = "Tiedoston kopiointi onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiKeuruu + "  \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiKeuruu + "  \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxMantta.CheckState == CheckState.Checked)
            {
                label2.Text = "";
                string KaupunkiMänttä = "Mänttä";
                string KohdeMänttä = sijainti + "Mänttä/";
                string KohdebuMänttä = sijaintibu + "Mänttä/";
                string TodaysdateMänttä = DateTime.Now.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeMänttä + TodaysdateMänttä + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuMänttä + TodaysdateMänttä + "/kopioidut tiedostot");


                }
                string sijaintiMänttä = KohdeMänttä + TodaysdateMänttä + "/kopioidut tiedostot";
                string sijaintibuMänttä = KohdebuMänttä + TodaysdateMänttä + "/kopioidut tiedostot";
                kaupunki += "Mänttä ";

                string tekstinlopulinensijainti = sijaintiMänttä + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiMänttä, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuMänttä, Path.GetFileName(textBoxFileName.Text)), true);
                        label2.Text = "Tiedoston kopiointi onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiMänttä + "  \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiMänttä + "  \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxRauma.CheckState == CheckState.Checked)
            {
                label2.Text = "";
                string KaupunkiRauma = "Rauma";
                string KohdeRauma = sijainti + "Rauma/";
                string KohdebuRauma = sijaintibu + "Rauma/";
                string TodaysdateRauma = DateTime.Now.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeRauma + TodaysdateRauma + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuRauma + TodaysdateRauma + "/kopioidut tiedostot");


                }
                string sijaintiRauma = KohdeRauma + TodaysdateRauma + "/kopioidut tiedostot";
                string sijaintibuRauma = KohdebuRauma + TodaysdateRauma + "/kopioidut tiedostot";
                kaupunki += "Rauma ";

                string tekstinlopulinensijainti = sijaintiRauma + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiRauma, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuRauma, Path.GetFileName(textBoxFileName.Text)), true);
                        label2.Text = "Tiedoston kopiointi onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiRauma + " \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiRauma + "  \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxSastamala.CheckState == CheckState.Checked)
            {
                label2.Text = "";
                string KaupunkiSastamala = "Sastamala";
                string KohdeSastamala = sijainti + "Sastamala/";
                string KohdebuSastamala = sijaintibu + "Sastamala/";

                string TodaysdateSastamala = DateTime.Now.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeSastamala + TodaysdateSastamala + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuSastamala + TodaysdateSastamala + "/kopioidut tiedostot");


                }
                string sijaintiSastamala = KohdeSastamala + TodaysdateSastamala + "/kopioidut tiedostot";
                string sijaintibuSastamala = KohdebuSastamala + TodaysdateSastamala + "/kopioidut tiedostot";
                kaupunki += "Sastamala ";

                string tekstinlopulinensijainti = sijaintiSastamala + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiSastamala, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuSastamala, Path.GetFileName(textBoxFileName.Text)), true);
                        label2.Text = "Tiedoston kopiointi onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiSastamala + "  \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiSastamala + "  \r\n");

                            }
                        }
                    }
                }
            }
            if (checkBoxTampere.CheckState == CheckState.Checked)
            {

                label2.Text = "";

                string KaupunkiTampere = "Tampere";
                string KohdeTampere = sijainti + "Tampere/";
                string KohdebuTampere = sijaintibu + "Tampere/";
                string TodaysdateTampere = DateTime.Now.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeTampere + TodaysdateTampere + "/kopioidut tiedostot");
                    Directory.CreateDirectory(KohdebuTampere + TodaysdateTampere + "/kopioidut tiedostot");


                }
                string sijaintiTampere = KohdeTampere + TodaysdateTampere + "/kopioidut tiedostot";
                string sijaintibuTampere = KohdebuTampere + TodaysdateTampere + "/kopioidut tiedostot";
                kaupunki += "Tampere ";

                string tekstinlopulinensijainti = sijaintiTampere + "/" + filename;
                if (textBoxFileName.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                    }
                    else
                    {
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintiTampere, Path.GetFileName(textBoxFileName.Text)), true);
                        File.Copy(textBoxFileName.Text, Path.Combine(sijaintibuTampere, Path.GetFileName(textBoxFileName.Text)), true);

                        label2.Text = "Tiedoston kopiointi onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiTampere + " \r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " kopioitiin kaupungille " + KaupunkiTampere + "  \r\n");

                            }
                        }
                    }
                }
            }
            if (!checkBoxPori.Checked && !checkBoxFuengirola.Checked && !checkBoxHelsinki.Checked && !checkBoxJyvaskyla.Checked && !checkBoxKankaanpaa.Checked && !checkBoxKeuruu.Checked && !checkBoxMantta.Checked && !checkBoxRauma.Checked && !checkBoxSastamala.Checked && !checkBoxTampere.Checked && !checkBoxUlvila.Checked && !checkBoxHuittinen.Checked)
            {
                label2.Text = " Valitse kaupunki!";
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void textBoxFileName_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
