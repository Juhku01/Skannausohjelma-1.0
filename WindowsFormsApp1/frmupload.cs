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
/* 
 *  Bugilista
 *    Kalenterista voi katsoa tällä hetkellä vain yhteen kaupunkiin
 *    
 *  Ideat
 *       
 *     
 *          
 *  
 *  ToDo lista
 *      
 *     
 *     
 *      Tiedostojen kopiointi 1/2 ja siirtäminen moneen kansioon kerralla
 *      Skanaa useamman tiedoston saman aikaisesti
 *      
 *  Valmis
 *      Kalenteri joka avulla voi katsoa vanhoja tiedostoja ✓
 *      Lokit  skanaus ✓, kopiointi ✓, siirtely 1/2
 *      Kun tiedosto skanaataan on mahdolisuus arkistoida tiedosto haluttuun päivämäärään ja jos tämä ei muutetta se skanataan tämänpäiväiseen kansioon ✓ 
 *      Luo kansion päivämäärän ja paikkakunnan mukaisesti ✓ 
 *      Valitse useamman kaupungin yhdellä kerralla ✓
 *      Tiedoston kopiominen ja siirtäminen ✓
 *      lokikirjauksen näyttäminen ✓
 *      kun tiedostoja voi klikkaamalla avata erilisen ohjelman kuten acrobat ✓
 *      
 *  Korjatut Bugit
 *   voi skanata vain yhteen kaupunkiin, muuten ohjelma kaatuu
 *          päivitys 29.1.2021
 *              Nyt voi valita useamman kaupungin, ohjelma ei enää kaadu, ja tiedostot menevät halutuille kaupungeille, tekee myös varmuuskopiot
 *          
 *   Jos hakemistosta valitsee päivämäärän jota ei ole olemassa ohjelma kaatuu  
 *          päivitys 9.2.2021
 *              Jos hakee hakemistosta jota ei ole olemassa softa ilmoitaa että "Ei tuloksia"
 *   
 *   Ei ilmoitanut jos tiedosto oli jo olemassa kansiossa
 *          Pävitys 18.2.2021
 *              Korjattu ja ilmoitaa kyseisen tiedoston olemassa oloa
 */



namespace WindowsFormsApp1
{
    public partial class frmupload : Form
    {



        OpenFileDialog open = new OpenFileDialog();

        string tekstisijainti = Directory.GetCurrentDirectory()+"loki.txt";
       


        string sijainti = "Z:/a/Kaupungit/";
        string sijaintibu = "Z:/backup/Kaupungit/";
        string kaupunki = null;
        string filename = null;
        string päivä = null;
        string Todayis = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss");

        private bool isCollapsed;

        public frmupload()
        {
            InitializeComponent();
        

        }
       
      

        public void buttonBrowse_Click(object sender, EventArgs e)
        {
            
            open.Filter = "Pdf Files|*.pdf";
            open.Multiselect = true;
            if (open.ShowDialog() == DialogResult.OK)
            {
                string teksti = listBox1.Text = open.FileName;

                listBox1.Items.Add(teksti);

                filename = Path.GetFileName(teksti);






            }






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
           
          

            
            päivä = dateTimePicker1.Value.ToString("dd-MM-yyyy");
           
            string teksti2 = listBox1.Text = open.FileName;
            string filename = null;
            filename = Path.GetFileName(teksti2);



         


           


            if (checkBoxUlvila.CheckState == CheckState.Checked)
            {
                label2.Text = "";

                string KaupunkiUlvila = "Ulvila";
                string KohdeUlvila = sijainti + "Ulvila/";
                string KohdebuUlvila = sijaintibu + "Ulvila/";
              
                kaupunki += "Ulvila ";
                string TodaysdateUlvila = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeUlvila + TodaysdateUlvila);
                    Directory.CreateDirectory(KohdebuUlvila + TodaysdateUlvila);


                }
                string sijaintiUlvila = KohdeUlvila + TodaysdateUlvila;
                string sijaintibuUlvila = KohdeUlvila + TodaysdateUlvila;
                string tekstinlopulinensijainti = sijaintiUlvila + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                { 

                
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;

                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiUlvila + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiUlvila + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiUlvila, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuUlvila, Path.GetFileName(listBox1.Text)), true);

                        label2.Text = "Tiedoston skannaus onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiUlvila + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiUlvila + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                string TodaysdatePori = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdePori + TodaysdatePori);
                    Directory.CreateDirectory(KohdebuPori + TodaysdatePori);

                }

                string sijaintiPori = KohdePori + TodaysdatePori;
                string sijaintibuPori = KohdebuPori + TodaysdatePori;
                kaupunki += "Pori ";

                string tekstinlopulinensijainti = sijaintiPori + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;

                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiPori + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiPori + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiPori, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuPori, Path.GetFileName(listBox1.Text)), true);
                        label2.Text = "Tiedoston skannaus onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiPori + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiPori + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                string TodaysdateFuengirola = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string sijaintiFuengirola = KohdeFuengirola + TodaysdateFuengirola;
                string sijaintibuFuengirola = KohdebuFuengirola + TodaysdateFuengirola;
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeFuengirola + TodaysdateFuengirola);
                    Directory.CreateDirectory(KohdebuFuengirola + TodaysdateFuengirola);
                }
                kaupunki += "Fuengirola ";

                string tekstinlopulinensijainti = sijaintiFuengirola + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiFuengirola + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiFuengirola + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiFuengirola, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuFuengirola, Path.GetFileName(listBox1.Text)), true);

                        label2.Text = "Tiedoston skannaus onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiFuengirola + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiFuengirola + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                string TodaysdateHelsinki = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeHelsinki + TodaysdateHelsinki);
                    Directory.CreateDirectory(KohdebuHelsinki + TodaysdateHelsinki);


                }
                string sijaintiHelsinki = KohdeHelsinki + TodaysdateHelsinki;
                string sijaintibuHelsinki = KohdebuHelsinki + TodaysdateHelsinki;
                kaupunki += "Helsinki ";

                string tekstinlopulinensijainti = sijaintiHelsinki + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiHelsinki + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiHelsinki + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiHelsinki, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuHelsinki, Path.GetFileName(listBox1.Text)), true);

                        label2.Text = "Tiedoston skannaus onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiHelsinki + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiHelsinki + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                string TodaysdateHuittinen = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string sijaintiHuittinen = KohdeHuittinen + TodaysdateHuittinen;
                string sijaintibuHuittinen = KohdebuHuittinen + TodaysdateHuittinen;
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeHuittinen + TodaysdateHuittinen);
                    Directory.CreateDirectory(KohdebuHuittinen + TodaysdateHuittinen);


                }
                kaupunki += "Huittinen ";

                string tekstinlopulinensijainti = sijaintiHuittinen + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiHuittinen + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiHuittinen + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }

                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiHuittinen, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuHuittinen, Path.GetFileName(listBox1.Text)), true);

                        label2.Text = "Tiedoston skannaus onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiHuittinen + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiHuittinen + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                string TodaysdateJyväskylä = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string sijaintiJyväskylä = KohdeJyväskylä + TodaysdateJyväskylä;
                string sijaintibuJyväskylä = KohdebuJyväskylä + TodaysdateJyväskylä;
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeJyväskylä + TodaysdateJyväskylä);
                    Directory.CreateDirectory(KohdebuJyväskylä + TodaysdateJyväskylä);


                }
                kaupunki += "Jyväskylä ";

                string tekstinlopulinensijainti = sijaintiJyväskylä + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiJyväskylä + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiJyväskylä + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiJyväskylä, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuJyväskylä, Path.GetFileName(listBox1.Text)), true);
                        label2.Text = "Tiedoston skannaus onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiJyväskylä + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiJyväskylä + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                string TodaysdateKankaanpää = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                string sijaintiKankaanpää = KohdeKankaanpää + TodaysdateKankaanpää;
                string sijaintibuKankaanpää = KohdebuKankaanpää + TodaysdateKankaanpää;
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeKankaanpää + TodaysdateKankaanpää);
                    Directory.CreateDirectory(KohdebuKankaanpää + TodaysdateKankaanpää);


                }
                kaupunki += "Kankaanpää ";

                string tekstinlopulinensijainti = sijaintiKankaanpää + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiKankaanpää + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiKankaanpää + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiKankaanpää, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuKankaanpää, Path.GetFileName(listBox1.Text)), true);

                        label2.Text = "Tiedoston skannaus onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiKankaanpää + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiKankaanpää + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                string TodaysdateKeuruu = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeKeuruu + TodaysdateKeuruu);
                    Directory.CreateDirectory(KohdebuKeuruu + TodaysdateKeuruu);


                }

                string sijaintiKeuruu = KohdeKeuruu + TodaysdateKeuruu;
                string sijaintibuKeuruu = KohdebuKeuruu + TodaysdateKeuruu;
                kaupunki += "Keuruu ";

                string tekstinlopulinensijainti = sijaintiKeuruu + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiKeuruu + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiKeuruu + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiKeuruu, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuKeuruu, Path.GetFileName(listBox1.Text)), true);
                        label2.Text = "Tiedoston skannaus onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiKeuruu + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiKeuruu + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                string TodaysdateMänttä = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeMänttä + TodaysdateMänttä);
                    Directory.CreateDirectory(KohdebuMänttä + TodaysdateMänttä);


                }
                string sijaintiMänttä = KohdeMänttä + TodaysdateMänttä;
                string sijaintibuMänttä = KohdebuMänttä + TodaysdateMänttä;
                kaupunki += "Mänttä ";

                string tekstinlopulinensijainti = sijaintiMänttä + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiMänttä + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiMänttä + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiMänttä, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuMänttä, Path.GetFileName(listBox1.Text)), true);
                        label2.Text = "Tiedoston skannaus onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiMänttä + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiMänttä + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                string TodaysdateRauma = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeRauma + TodaysdateRauma);
                    Directory.CreateDirectory(KohdebuRauma + TodaysdateRauma);


                }
                string sijaintiRauma = KohdeRauma + TodaysdateRauma;
                string sijaintibuRauma = KohdebuRauma + TodaysdateRauma;
                kaupunki += "Rauma ";

                string tekstinlopulinensijainti = sijaintiRauma + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiRauma + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiRauma + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiRauma, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuRauma, Path.GetFileName(listBox1.Text)), true);
                        label2.Text = "Tiedoston skannaus onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiRauma + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiRauma + " Päivämäärä kansiolle " + päivä + "\r\n");

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

                string TodaysdateSastamala = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeSastamala + TodaysdateSastamala);
                    Directory.CreateDirectory(KohdebuSastamala + TodaysdateSastamala);


                }
                string sijaintiSastamala = KohdeSastamala + TodaysdateSastamala;
                string sijaintibuSastamala = KohdebuSastamala + TodaysdateSastamala;
                kaupunki += "Sastamala ";

                string tekstinlopulinensijainti = sijaintiSastamala + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiSastamala + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiSastamala + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiSastamala, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuSastamala, Path.GetFileName(listBox1.Text)), true);
                        label2.Text = "Tiedoston skannaus onnistui!";







                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiSastamala + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiSastamala + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                string TodaysdateTampere = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                {
                    // nämä luovat kansion halutulle sijainille  

                    Directory.CreateDirectory(KohdeTampere + TodaysdateTampere);
                    Directory.CreateDirectory(KohdebuTampere + TodaysdateTampere);


                }
                string sijaintiTampere = KohdeTampere + TodaysdateTampere;
                string sijaintibuTampere = KohdebuTampere + TodaysdateTampere;
                kaupunki += "Tampere ";

                string tekstinlopulinensijainti = sijaintiTampere + "/" + filename;
                if (listBox1.Text == "")
                {
                    label2.Text = "Anna tiedosto!";
                }
                else
                {
                    if (File.Exists(tekstinlopulinensijainti))
                    {
                        label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiTampere + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiTampere + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }
                        }
                    }
                    else
                    {
                        File.Copy(listBox1.Text, Path.Combine(sijaintiTampere, Path.GetFileName(listBox1.Text)), true);
                        File.Copy(listBox1.Text, Path.Combine(sijaintibuTampere, Path.GetFileName(listBox1.Text)), true);

                        label2.Text = "Tiedoston skannaus onnistui!";






                        //luo tiedoston
                        if (!File.Exists(tekstisijainti))
                        {
                            File.Create(tekstisijainti);

                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiTampere + " Päivämäärä kansiolle " + päivä + "\r\n");

                            }

                        }
                        else if (File.Exists(tekstisijainti))
                        {
                            using (var tw = new StreamWriter(tekstisijainti, true))
                            {
                                tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiTampere + " Päivämäärä kansiolle " + päivä + "\r\n");

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

    




        





        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //näyttää kuvan

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
        

        private void panelDropDown_Paint(object sender, PaintEventArgs e)
        {

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

     

        private void button2_Click(object sender, EventArgs e)
        {
            
            dateTimePicker1.Value = DateTime.Now;
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
           

        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
           
        }
        private string getFileName(string path)
        {
            return Path.GetFileNameWithoutExtension(path);
        }

        private void textBoxFileName_DragDrop(object sender, DragEventArgs e)
        {

            string[] files1 = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files1)
            {
                string filename = file;

                listBox1.Text = file;
                listBox1.Items.Add(filename);

                if (checkBoxUlvila.CheckState == CheckState.Checked)
                {
                    label2.Text = "";

                    string KaupunkiUlvila = "Ulvila";
                    string KohdeUlvila = sijainti + "Ulvila/";
                    string KohdebuUlvila = sijaintibu + "Ulvila/";

                    kaupunki += "Ulvila ";
                    string TodaysdateUlvila = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeUlvila + TodaysdateUlvila);
                        Directory.CreateDirectory(KohdebuUlvila + TodaysdateUlvila);


                    }
                    string sijaintiUlvila = KohdeUlvila + TodaysdateUlvila;
                    string sijaintibuUlvila = KohdeUlvila + TodaysdateUlvila;
                    string tekstinlopulinensijainti = sijaintiUlvila + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {


                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;

                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiUlvila + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiUlvila + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiUlvila, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuUlvila, Path.GetFileName(listBox1.Text)), true);

                            label2.Text = "Tiedoston skannaus onnistui!";






                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiUlvila + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiUlvila + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                    string TodaysdatePori = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdePori + TodaysdatePori);
                        Directory.CreateDirectory(KohdebuPori + TodaysdatePori);

                    }

                    string sijaintiPori = KohdePori + TodaysdatePori;
                    string sijaintibuPori = KohdebuPori + TodaysdatePori;
                    kaupunki += "Pori ";

                    string tekstinlopulinensijainti = sijaintiPori + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;

                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiPori + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiPori + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiPori, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuPori, Path.GetFileName(listBox1.Text)), true);
                            label2.Text = "Tiedoston skannaus onnistui!";







                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiPori + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiPori + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                    string TodaysdateFuengirola = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    string sijaintiFuengirola = KohdeFuengirola + TodaysdateFuengirola;
                    string sijaintibuFuengirola = KohdebuFuengirola + TodaysdateFuengirola;
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeFuengirola + TodaysdateFuengirola);
                        Directory.CreateDirectory(KohdebuFuengirola + TodaysdateFuengirola);
                    }
                    kaupunki += "Fuengirola ";

                    string tekstinlopulinensijainti = sijaintiFuengirola + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiFuengirola + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiFuengirola + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiFuengirola, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuFuengirola, Path.GetFileName(listBox1.Text)), true);

                            label2.Text = "Tiedoston skannaus onnistui!";






                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiFuengirola + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiFuengirola + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                    string TodaysdateHelsinki = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeHelsinki + TodaysdateHelsinki);
                        Directory.CreateDirectory(KohdebuHelsinki + TodaysdateHelsinki);


                    }
                    string sijaintiHelsinki = KohdeHelsinki + TodaysdateHelsinki;
                    string sijaintibuHelsinki = KohdebuHelsinki + TodaysdateHelsinki;
                    kaupunki += "Helsinki ";

                    string tekstinlopulinensijainti = sijaintiHelsinki + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiHelsinki + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiHelsinki + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiHelsinki, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuHelsinki, Path.GetFileName(listBox1.Text)), true);

                            label2.Text = "Tiedoston skannaus onnistui!";






                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiHelsinki + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiHelsinki + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                    string TodaysdateHuittinen = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    string sijaintiHuittinen = KohdeHuittinen + TodaysdateHuittinen;
                    string sijaintibuHuittinen = KohdebuHuittinen + TodaysdateHuittinen;
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeHuittinen + TodaysdateHuittinen);
                        Directory.CreateDirectory(KohdebuHuittinen + TodaysdateHuittinen);


                    }
                    kaupunki += "Huittinen ";

                    string tekstinlopulinensijainti = sijaintiHuittinen + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiHuittinen + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiHuittinen + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }

                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiHuittinen, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuHuittinen, Path.GetFileName(listBox1.Text)), true);

                            label2.Text = "Tiedoston skannaus onnistui!";






                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiHuittinen + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiHuittinen + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                    string TodaysdateJyväskylä = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    string sijaintiJyväskylä = KohdeJyväskylä + TodaysdateJyväskylä;
                    string sijaintibuJyväskylä = KohdebuJyväskylä + TodaysdateJyväskylä;
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeJyväskylä + TodaysdateJyväskylä);
                        Directory.CreateDirectory(KohdebuJyväskylä + TodaysdateJyväskylä);


                    }
                    kaupunki += "Jyväskylä ";

                    string tekstinlopulinensijainti = sijaintiJyväskylä + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiJyväskylä + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiJyväskylä + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiJyväskylä, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuJyväskylä, Path.GetFileName(listBox1.Text)), true);
                            label2.Text = "Tiedoston skannaus onnistui!";







                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiJyväskylä + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiJyväskylä + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                    string TodaysdateKankaanpää = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    string sijaintiKankaanpää = KohdeKankaanpää + TodaysdateKankaanpää;
                    string sijaintibuKankaanpää = KohdebuKankaanpää + TodaysdateKankaanpää;
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeKankaanpää + TodaysdateKankaanpää);
                        Directory.CreateDirectory(KohdebuKankaanpää + TodaysdateKankaanpää);


                    }
                    kaupunki += "Kankaanpää ";

                    string tekstinlopulinensijainti = sijaintiKankaanpää + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiKankaanpää + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiKankaanpää + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiKankaanpää, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuKankaanpää, Path.GetFileName(listBox1.Text)), true);

                            label2.Text = "Tiedoston skannaus onnistui!";






                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiKankaanpää + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiKankaanpää + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                    string TodaysdateKeuruu = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeKeuruu + TodaysdateKeuruu);
                        Directory.CreateDirectory(KohdebuKeuruu + TodaysdateKeuruu);


                    }

                    string sijaintiKeuruu = KohdeKeuruu + TodaysdateKeuruu;
                    string sijaintibuKeuruu = KohdebuKeuruu + TodaysdateKeuruu;
                    kaupunki += "Keuruu ";

                    string tekstinlopulinensijainti = sijaintiKeuruu + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiKeuruu + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiKeuruu + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiKeuruu, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuKeuruu, Path.GetFileName(listBox1.Text)), true);
                            label2.Text = "Tiedoston skannaus onnistui!";







                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiKeuruu + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiKeuruu + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                    string TodaysdateMänttä = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeMänttä + TodaysdateMänttä);
                        Directory.CreateDirectory(KohdebuMänttä + TodaysdateMänttä);


                    }
                    string sijaintiMänttä = KohdeMänttä + TodaysdateMänttä;
                    string sijaintibuMänttä = KohdebuMänttä + TodaysdateMänttä;
                    kaupunki += "Mänttä ";

                    string tekstinlopulinensijainti = sijaintiMänttä + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiMänttä + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiMänttä + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiMänttä, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuMänttä, Path.GetFileName(listBox1.Text)), true);
                            label2.Text = "Tiedoston skannaus onnistui!";







                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiMänttä + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiMänttä + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                    string TodaysdateRauma = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeRauma + TodaysdateRauma);
                        Directory.CreateDirectory(KohdebuRauma + TodaysdateRauma);


                    }
                    string sijaintiRauma = KohdeRauma + TodaysdateRauma;
                    string sijaintibuRauma = KohdebuRauma + TodaysdateRauma;
                    kaupunki += "Rauma ";

                    string tekstinlopulinensijainti = sijaintiRauma + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiRauma + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiRauma + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiRauma, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuRauma, Path.GetFileName(listBox1.Text)), true);
                            label2.Text = "Tiedoston skannaus onnistui!";







                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiRauma + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiRauma + " Päivämäärä kansiolle " + päivä + "\r\n");

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

                    string TodaysdateSastamala = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeSastamala + TodaysdateSastamala);
                        Directory.CreateDirectory(KohdebuSastamala + TodaysdateSastamala);


                    }
                    string sijaintiSastamala = KohdeSastamala + TodaysdateSastamala;
                    string sijaintibuSastamala = KohdebuSastamala + TodaysdateSastamala;
                    kaupunki += "Sastamala ";

                    string tekstinlopulinensijainti = sijaintiSastamala + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiSastamala + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiSastamala + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiSastamala, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuSastamala, Path.GetFileName(listBox1.Text)), true);
                            label2.Text = "Tiedoston skannaus onnistui!";







                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiSastamala + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiSastamala + " Päivämäärä kansiolle " + päivä + "\r\n");

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
                    string TodaysdateTampere = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                    {
                        // nämä luovat kansion halutulle sijainille  

                        Directory.CreateDirectory(KohdeTampere + TodaysdateTampere);
                        Directory.CreateDirectory(KohdebuTampere + TodaysdateTampere);


                    }
                    string sijaintiTampere = KohdeTampere + TodaysdateTampere;
                    string sijaintibuTampere = KohdebuTampere + TodaysdateTampere;
                    kaupunki += "Tampere ";

                    string tekstinlopulinensijainti = sijaintiTampere + "/" + filename;
                    if (listBox1.Text == "")
                    {
                        label2.Text = "Anna tiedosto!";
                    }
                    else
                    {
                        if (File.Exists(tekstinlopulinensijainti))
                        {
                            label2.Text = "Tiedosto on jo olemassa kohteissa " + kaupunki;
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiTampere + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " Yritettiin skannata, mutta tiedosto on jo olemassa kohteessa " + KaupunkiTampere + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }
                            }
                        }
                        else
                        {
                            File.Copy(listBox1.Text, Path.Combine(sijaintiTampere, Path.GetFileName(listBox1.Text)), true);
                            File.Copy(listBox1.Text, Path.Combine(sijaintibuTampere, Path.GetFileName(listBox1.Text)), true);

                            label2.Text = "Tiedoston skannaus onnistui!";






                            //luo tiedoston
                            if (!File.Exists(tekstisijainti))
                            {
                                File.Create(tekstisijainti);

                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiTampere + " Päivämäärä kansiolle " + päivä + "\r\n");

                                }

                            }
                            else if (File.Exists(tekstisijainti))
                            {
                                using (var tw = new StreamWriter(tekstisijainti, true))
                                {
                                    tw.WriteLine(Todayis + " Tiedosto " + filename + " skannattiin kaupungille " + KaupunkiTampere + " Päivämäärä kansiolle " + päivä + "\r\n");

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

        }
        
        private void textBoxFileName_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            string teksti = listBox1.Text = open.FileName;
            string filename = null;

            if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
            {
                using (OpenFileDialog dialog = new OpenFileDialog())
                {
                    listBox1.Text = dialog.FileName;
                  
                  
                    filename = Path.GetFileName(teksti);


                }
               

            }
        }

      

    

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (listBox1.Text == "")
            {
                label2.Text += " Anna tiedosto!";

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
