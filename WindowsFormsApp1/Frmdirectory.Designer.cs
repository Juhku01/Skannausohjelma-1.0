
namespace WindowsFormsApp1
{
    partial class Frmdirectory
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toimmotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lataaPalvelimelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kopioTiedostotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siiräTiedostoaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.haeTietojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhnlFormLoader2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toimmotToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(701, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toimmotToolStripMenuItem
            // 
            this.toimmotToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lataaPalvelimelleToolStripMenuItem,
            this.kopioTiedostotToolStripMenuItem,
            this.siiräTiedostoaToolStripMenuItem,
            this.haeTietojaToolStripMenuItem});
            this.toimmotToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.toimmotToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.toimmotToolStripMenuItem.Image = global::WindowsFormsApp1.Properties.Resources.iconmonstr_arrow_65_24;
            this.toimmotToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toimmotToolStripMenuItem.Name = "toimmotToolStripMenuItem";
            this.toimmotToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.toimmotToolStripMenuItem.Text = "Toiminnot";
            this.toimmotToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // lataaPalvelimelleToolStripMenuItem
            // 
            this.lataaPalvelimelleToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lataaPalvelimelleToolStripMenuItem.Name = "lataaPalvelimelleToolStripMenuItem";
            this.lataaPalvelimelleToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.lataaPalvelimelleToolStripMenuItem.Text = "Skannaa Tiedosto";
            this.lataaPalvelimelleToolStripMenuItem.Click += new System.EventHandler(this.lataaPalvelimelleToolStripMenuItem_Click);
            // 
            // kopioTiedostotToolStripMenuItem
            // 
            this.kopioTiedostotToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.kopioTiedostotToolStripMenuItem.Name = "kopioTiedostotToolStripMenuItem";
            this.kopioTiedostotToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.kopioTiedostotToolStripMenuItem.Text = "Kopioi tiedostot";
            this.kopioTiedostotToolStripMenuItem.Click += new System.EventHandler(this.kopioTiedostotToolStripMenuItem_Click);
            // 
            // siiräTiedostoaToolStripMenuItem
            // 
            this.siiräTiedostoaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.siiräTiedostoaToolStripMenuItem.Name = "siiräTiedostoaToolStripMenuItem";
            this.siiräTiedostoaToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.siiräTiedostoaToolStripMenuItem.Text = "Siirrä tiedostot";
            this.siiräTiedostoaToolStripMenuItem.Click += new System.EventHandler(this.siiräTiedostoaToolStripMenuItem_Click);
            // 
            // haeTietojaToolStripMenuItem
            // 
            this.haeTietojaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.haeTietojaToolStripMenuItem.Name = "haeTietojaToolStripMenuItem";
            this.haeTietojaToolStripMenuItem.Size = new System.Drawing.Size(274, 30);
            this.haeTietojaToolStripMenuItem.Text = "Hae tietoja";
            this.haeTietojaToolStripMenuItem.Click += new System.EventHandler(this.haeTietojaToolStripMenuItem_Click);
            // 
            // PhnlFormLoader2
            // 
            this.PhnlFormLoader2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhnlFormLoader2.Location = new System.Drawing.Point(0, 33);
            this.PhnlFormLoader2.Name = "PhnlFormLoader2";
            this.PhnlFormLoader2.Size = new System.Drawing.Size(701, 366);
            this.PhnlFormLoader2.TabIndex = 1;
            this.PhnlFormLoader2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Frmdirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(701, 399);
            this.Controls.Add(this.PhnlFormLoader2);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmdirectory";
            this.Text = "Frmdirectory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toimmotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kopioTiedostotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siiräTiedostoaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lataaPalvelimelleToolStripMenuItem;
        private System.Windows.Forms.Panel PhnlFormLoader2;
        private System.Windows.Forms.ToolStripMenuItem haeTietojaToolStripMenuItem;
    }
}