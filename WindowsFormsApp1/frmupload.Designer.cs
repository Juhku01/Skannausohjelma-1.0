
namespace WindowsFormsApp1
{
    partial class frmupload
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxUlvila = new System.Windows.Forms.CheckBox();
            this.checkBoxPori = new System.Windows.Forms.CheckBox();
            this.checkBoxFuengirola = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkBoxHelsinki = new System.Windows.Forms.CheckBox();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.checkBoxTampere = new System.Windows.Forms.CheckBox();
            this.checkBoxSastamala = new System.Windows.Forms.CheckBox();
            this.checkBoxRauma = new System.Windows.Forms.CheckBox();
            this.checkBoxMantta = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxKeuruu = new System.Windows.Forms.CheckBox();
            this.checkBoxKankaanpaa = new System.Windows.Forms.CheckBox();
            this.checkBoxJyvaskyla = new System.Windows.Forms.CheckBox();
            this.checkBoxHuittinen = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panelDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBrowse.Location = new System.Drawing.Point(222, 88);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Skannaa tiedosto!";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBoxUlvila
            // 
            this.checkBoxUlvila.AutoSize = true;
            this.checkBoxUlvila.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUlvila.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxUlvila.Location = new System.Drawing.Point(111, 182);
            this.checkBoxUlvila.Name = "checkBoxUlvila";
            this.checkBoxUlvila.Size = new System.Drawing.Size(62, 22);
            this.checkBoxUlvila.TabIndex = 21;
            this.checkBoxUlvila.Text = "Ulvila";
            this.checkBoxUlvila.UseVisualStyleBackColor = true;
            this.checkBoxUlvila.CheckedChanged += new System.EventHandler(this.checkBoxUlvila_CheckedChanged);
            // 
            // checkBoxPori
            // 
            this.checkBoxPori.AutoSize = true;
            this.checkBoxPori.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPori.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxPori.Location = new System.Drawing.Point(111, 70);
            this.checkBoxPori.Name = "checkBoxPori";
            this.checkBoxPori.Size = new System.Drawing.Size(54, 22);
            this.checkBoxPori.TabIndex = 22;
            this.checkBoxPori.Text = "Pori";
            this.checkBoxPori.UseVisualStyleBackColor = true;
            this.checkBoxPori.CheckedChanged += new System.EventHandler(this.checkBoxPori_CheckedChanged);
            // 
            // checkBoxFuengirola
            // 
            this.checkBoxFuengirola.AutoSize = true;
            this.checkBoxFuengirola.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFuengirola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxFuengirola.Location = new System.Drawing.Point(9, 42);
            this.checkBoxFuengirola.Name = "checkBoxFuengirola";
            this.checkBoxFuengirola.Size = new System.Drawing.Size(96, 22);
            this.checkBoxFuengirola.TabIndex = 24;
            this.checkBoxFuengirola.Text = "Fuengirola";
            this.checkBoxFuengirola.UseVisualStyleBackColor = true;
            this.checkBoxFuengirola.CheckedChanged += new System.EventHandler(this.checkBoxFuengirola_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // checkBoxHelsinki
            // 
            this.checkBoxHelsinki.AutoSize = true;
            this.checkBoxHelsinki.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHelsinki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxHelsinki.Location = new System.Drawing.Point(9, 70);
            this.checkBoxHelsinki.Name = "checkBoxHelsinki";
            this.checkBoxHelsinki.Size = new System.Drawing.Size(79, 22);
            this.checkBoxHelsinki.TabIndex = 25;
            this.checkBoxHelsinki.Text = "Helsinki";
            this.checkBoxHelsinki.UseVisualStyleBackColor = true;
            this.checkBoxHelsinki.CheckedChanged += new System.EventHandler(this.checkBoxHelsinki_CheckedChanged);
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.checkBoxTampere);
            this.panelDropDown.Controls.Add(this.checkBoxSastamala);
            this.panelDropDown.Controls.Add(this.checkBoxRauma);
            this.panelDropDown.Controls.Add(this.checkBoxFuengirola);
            this.panelDropDown.Controls.Add(this.checkBoxMantta);
            this.panelDropDown.Controls.Add(this.button1);
            this.panelDropDown.Controls.Add(this.checkBoxPori);
            this.panelDropDown.Controls.Add(this.checkBoxKeuruu);
            this.panelDropDown.Controls.Add(this.checkBoxUlvila);
            this.panelDropDown.Controls.Add(this.checkBoxKankaanpaa);
            this.panelDropDown.Controls.Add(this.checkBoxJyvaskyla);
            this.panelDropDown.Controls.Add(this.checkBoxHelsinki);
            this.panelDropDown.Controls.Add(this.checkBoxHuittinen);
            this.panelDropDown.Location = new System.Drawing.Point(348, 46);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(213, 213);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(213, 36);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(213, 37);
            this.panelDropDown.TabIndex = 26;
            this.panelDropDown.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDropDown_Paint);
            // 
            // checkBoxTampere
            // 
            this.checkBoxTampere.AutoSize = true;
            this.checkBoxTampere.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTampere.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxTampere.Location = new System.Drawing.Point(111, 154);
            this.checkBoxTampere.Name = "checkBoxTampere";
            this.checkBoxTampere.Size = new System.Drawing.Size(86, 22);
            this.checkBoxTampere.TabIndex = 35;
            this.checkBoxTampere.Text = "Tampere";
            this.checkBoxTampere.UseVisualStyleBackColor = true;
            this.checkBoxTampere.CheckedChanged += new System.EventHandler(this.checkBoxTampere_CheckedChanged);
            // 
            // checkBoxSastamala
            // 
            this.checkBoxSastamala.AutoSize = true;
            this.checkBoxSastamala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSastamala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxSastamala.Location = new System.Drawing.Point(111, 126);
            this.checkBoxSastamala.Name = "checkBoxSastamala";
            this.checkBoxSastamala.Size = new System.Drawing.Size(97, 22);
            this.checkBoxSastamala.TabIndex = 34;
            this.checkBoxSastamala.Text = "Sastamala";
            this.checkBoxSastamala.UseVisualStyleBackColor = true;
            this.checkBoxSastamala.CheckedChanged += new System.EventHandler(this.checkBoxSastamala_CheckedChanged);
            // 
            // checkBoxRauma
            // 
            this.checkBoxRauma.AutoSize = true;
            this.checkBoxRauma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRauma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxRauma.Location = new System.Drawing.Point(111, 98);
            this.checkBoxRauma.Name = "checkBoxRauma";
            this.checkBoxRauma.Size = new System.Drawing.Size(75, 22);
            this.checkBoxRauma.TabIndex = 33;
            this.checkBoxRauma.Text = "Rauma";
            this.checkBoxRauma.UseVisualStyleBackColor = true;
            this.checkBoxRauma.CheckedChanged += new System.EventHandler(this.checkBoxRauma_CheckedChanged);
            // 
            // checkBoxMantta
            // 
            this.checkBoxMantta.AutoSize = true;
            this.checkBoxMantta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMantta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxMantta.Location = new System.Drawing.Point(111, 42);
            this.checkBoxMantta.Name = "checkBoxMantta";
            this.checkBoxMantta.Size = new System.Drawing.Size(72, 22);
            this.checkBoxMantta.TabIndex = 32;
            this.checkBoxMantta.Text = "Mänttä";
            this.checkBoxMantta.UseVisualStyleBackColor = true;
            this.checkBoxMantta.CheckedChanged += new System.EventHandler(this.checkBoxMantta_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 36);
            this.button1.TabIndex = 27;
            this.button1.Text = "Kaupungit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxKeuruu
            // 
            this.checkBoxKeuruu.AutoSize = true;
            this.checkBoxKeuruu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKeuruu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxKeuruu.Location = new System.Drawing.Point(9, 182);
            this.checkBoxKeuruu.Name = "checkBoxKeuruu";
            this.checkBoxKeuruu.Size = new System.Drawing.Size(74, 22);
            this.checkBoxKeuruu.TabIndex = 31;
            this.checkBoxKeuruu.Text = "Keuruu";
            this.checkBoxKeuruu.UseVisualStyleBackColor = true;
            this.checkBoxKeuruu.CheckedChanged += new System.EventHandler(this.checkBoxKeuruu_CheckedChanged);
            // 
            // checkBoxKankaanpaa
            // 
            this.checkBoxKankaanpaa.AutoSize = true;
            this.checkBoxKankaanpaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKankaanpaa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxKankaanpaa.Location = new System.Drawing.Point(9, 154);
            this.checkBoxKankaanpaa.Name = "checkBoxKankaanpaa";
            this.checkBoxKankaanpaa.Size = new System.Drawing.Size(109, 22);
            this.checkBoxKankaanpaa.TabIndex = 30;
            this.checkBoxKankaanpaa.Text = "Kankaanpää";
            this.checkBoxKankaanpaa.UseVisualStyleBackColor = true;
            this.checkBoxKankaanpaa.CheckedChanged += new System.EventHandler(this.checkBoxKankaanpaa_CheckedChanged);
            // 
            // checkBoxJyvaskyla
            // 
            this.checkBoxJyvaskyla.AutoSize = true;
            this.checkBoxJyvaskyla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxJyvaskyla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxJyvaskyla.Location = new System.Drawing.Point(9, 126);
            this.checkBoxJyvaskyla.Name = "checkBoxJyvaskyla";
            this.checkBoxJyvaskyla.Size = new System.Drawing.Size(91, 22);
            this.checkBoxJyvaskyla.TabIndex = 29;
            this.checkBoxJyvaskyla.Text = "Jyväskylä";
            this.checkBoxJyvaskyla.UseVisualStyleBackColor = true;
            this.checkBoxJyvaskyla.CheckedChanged += new System.EventHandler(this.checkBoxJyvaskyla_CheckedChanged);
            // 
            // checkBoxHuittinen
            // 
            this.checkBoxHuittinen.AutoSize = true;
            this.checkBoxHuittinen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxHuittinen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.checkBoxHuittinen.Location = new System.Drawing.Point(9, 98);
            this.checkBoxHuittinen.Name = "checkBoxHuittinen";
            this.checkBoxHuittinen.Size = new System.Drawing.Size(84, 22);
            this.checkBoxHuittinen.TabIndex = 28;
            this.checkBoxHuittinen.Text = "Huittinen";
            this.checkBoxHuittinen.UseVisualStyleBackColor = true;
            this.checkBoxHuittinen.CheckedChanged += new System.EventHandler(this.checkBoxHuittinen_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 27;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(222, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Tänään";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSave.Location = new System.Drawing.Point(16, 189);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Skanaa tiedosto";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 78);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 95);
            this.listBox1.TabIndex = 32;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // frmupload
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panelDropDown);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmupload";
            this.Text = "frmupload";
            this.Load += new System.EventHandler(this.frmupload_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxFileName_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxFileName_DragEnter);
            this.panelDropDown.ResumeLayout(false);
            this.panelDropDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxUlvila;
        private System.Windows.Forms.CheckBox checkBoxPori;
        private System.Windows.Forms.CheckBox checkBoxFuengirola;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkBoxHelsinki;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxHuittinen;
        private System.Windows.Forms.CheckBox checkBoxTampere;
        private System.Windows.Forms.CheckBox checkBoxSastamala;
        private System.Windows.Forms.CheckBox checkBoxRauma;
        private System.Windows.Forms.CheckBox checkBoxMantta;
        private System.Windows.Forms.CheckBox checkBoxKeuruu;
        private System.Windows.Forms.CheckBox checkBoxKankaanpaa;
        private System.Windows.Forms.CheckBox checkBoxJyvaskyla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBox1;
    }
}