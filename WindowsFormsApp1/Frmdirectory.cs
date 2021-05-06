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
    public partial class Frmdirectory : Form
    {
        public Frmdirectory()
        {
            InitializeComponent();
        }

        private void DirectoryMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void norlsiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lataaPalvelimelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PhnlFormLoader2.Controls.Clear();
            frmupload frmupload_Vrb = new frmupload() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmupload_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader2.Controls.Add(frmupload_Vrb);
            frmupload_Vrb.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            frmupload frmupload_Vrb = new frmupload() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmupload_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader2.Controls.Add(frmupload_Vrb);
            frmupload_Vrb.Show();
        }

        private void kopioTiedostotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PhnlFormLoader2.Controls.Clear();
            frmcopy frmcopy_Vrb = new frmcopy() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmcopy_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader2.Controls.Add(frmcopy_Vrb);
            frmcopy_Vrb.Show();
        }

        private void haeVarmuuskopioitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PhnlFormLoader2.Controls.Clear();
            frmrestore frmrestore_Vrb = new frmrestore() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmrestore_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader2.Controls.Add(frmrestore_Vrb);
            frmrestore_Vrb.Show();
        }

        private void siiräTiedostoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PhnlFormLoader2.Controls.Clear();
            frmmove frmmove_Vrb = new frmmove() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmmove_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader2.Controls.Add(frmmove_Vrb);
            frmmove_Vrb.Show();
        }

        private void haeTietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.PhnlFormLoader2.Controls.Clear();
            frmCalendar frmCalendar_Vrb = new frmCalendar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCalendar_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.PhnlFormLoader2.Controls.Add(frmCalendar_Vrb);
            frmCalendar_Vrb.Show();
        }
    }
}
