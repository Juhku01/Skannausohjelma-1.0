using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            if (Screen.AllScreens.Length > 1)
                this.Location = Screen.AllScreens[1].WorkingArea.Location;

            this.PhnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int mov;
        int movX;
        int movY;



        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;


            movX = e.X;
            movY = e.Y;

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            InitializeComponent();
           
        }

      

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {
            this.PhnlFormLoader.Controls.Clear();
            frmDashboard frmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader.Controls.Add(frmDashboard_Vrb);
            frmDashboard_Vrb.Show();
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            this.PhnlFormLoader.Controls.Clear();
            frmAnalytics frmAnalytics_Vrb = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAnalytics_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader.Controls.Add(frmAnalytics_Vrb);
            frmAnalytics_Vrb.Show();
        }

        

        private void btnlog_Click(object sender, EventArgs e)
        {
            this.PhnlFormLoader.Controls.Clear();
            Frmlog Frmlog_Vrb = new Frmlog() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmlog_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader.Controls.Add(Frmlog_Vrb);
            Frmlog_Vrb.Show();
        }

        private void btnfromupload_Click(object sender, EventArgs e)
        {
            this.PhnlFormLoader.Controls.Clear();
            frmupload frmupload_Vrb = new frmupload() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmupload_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader.Controls.Add(frmupload_Vrb);
            frmupload_Vrb.Show();
        }

     

        private void btnDirectory_Click(object sender, EventArgs e)
        {
            this.PhnlFormLoader.Controls.Clear();
            Frmdirectory Frmdirectory_Vrb = new Frmdirectory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Frmdirectory_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader.Controls.Add(Frmdirectory_Vrb);
            Frmdirectory_Vrb.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
          

        private void button1_Click_1(object sender, EventArgs e)
        {
          
            if (this.WindowState == FormWindowState.Normal)
            {
                this.TopMost = true;

                this.FormBorderStyle = FormBorderStyle.Sizable;
                
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.TopMost = true;

                this.FormBorderStyle = FormBorderStyle.None;

                this.WindowState = FormWindowState.Normal;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          
        }
    }
}
