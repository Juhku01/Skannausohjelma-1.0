
namespace WindowsFormsApp1
{
    partial class frmcopy
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.checkBoxTampere = new System.Windows.Forms.CheckBox();
            this.checkBoxSastamala = new System.Windows.Forms.CheckBox();
            this.checkBoxRauma = new System.Windows.Forms.CheckBox();
            this.checkBoxFuengirola = new System.Windows.Forms.CheckBox();
            this.checkBoxMantta = new System.Windows.Forms.CheckBox();
            this.checkBoxPori = new System.Windows.Forms.CheckBox();
            this.checkBoxKeuruu = new System.Windows.Forms.CheckBox();
            this.checkBoxUlvila = new System.Windows.Forms.CheckBox();
            this.checkBoxKankaanpaa = new System.Windows.Forms.CheckBox();
            this.checkBoxJyvaskyla = new System.Windows.Forms.CheckBox();
            this.checkBoxHelsinki = new System.Windows.Forms.CheckBox();
            this.checkBoxHuittinen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // buttonSave
            // 
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSave.Location = new System.Drawing.Point(12, 118);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(105, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Skanaa tiedosto";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonBrowse.Location = new System.Drawing.Point(218, 49);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 5;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click_1);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(12, 51);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(200, 20);
            this.textBoxFileName.TabIndex = 4;
            this.textBoxFileName.TextChanged += new System.EventHandler(this.textBoxFileName_TextChanged_1);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(-2, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(215, 36);
            this.button1.TabIndex = 40;
            this.button1.Text = "Kaupungit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.checkBoxTampere);
            this.panelDropDown.Controls.Add(this.button1);
            this.panelDropDown.Controls.Add(this.checkBoxSastamala);
            this.panelDropDown.Controls.Add(this.checkBoxRauma);
            this.panelDropDown.Controls.Add(this.checkBoxFuengirola);
            this.panelDropDown.Controls.Add(this.checkBoxMantta);
            this.panelDropDown.Controls.Add(this.checkBoxPori);
            this.panelDropDown.Controls.Add(this.checkBoxKeuruu);
            this.panelDropDown.Controls.Add(this.checkBoxUlvila);
            this.panelDropDown.Controls.Add(this.checkBoxKankaanpaa);
            this.panelDropDown.Controls.Add(this.checkBoxJyvaskyla);
            this.panelDropDown.Controls.Add(this.checkBoxHelsinki);
            this.panelDropDown.Controls.Add(this.checkBoxHuittinen);
            this.panelDropDown.Location = new System.Drawing.Point(351, 51);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(213, 213);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(213, 36);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(213, 37);
            this.panelDropDown.TabIndex = 49;
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
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 41;
            this.label2.Text = "Kopioi tiedosto!";
            // 
            // frmcopy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(701, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelDropDown);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonBrowse);
            this.Controls.Add(this.textBoxFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmcopy";
            this.Text = "frmcopy";
            this.Load += new System.EventHandler(this.frmcopy_Load);
            this.panelDropDown.ResumeLayout(false);
            this.panelDropDown.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.CheckBox checkBoxTampere;
        private System.Windows.Forms.CheckBox checkBoxSastamala;
        private System.Windows.Forms.CheckBox checkBoxRauma;
        private System.Windows.Forms.CheckBox checkBoxFuengirola;
        private System.Windows.Forms.CheckBox checkBoxMantta;
        private System.Windows.Forms.CheckBox checkBoxPori;
        private System.Windows.Forms.CheckBox checkBoxKeuruu;
        private System.Windows.Forms.CheckBox checkBoxUlvila;
        private System.Windows.Forms.CheckBox checkBoxKankaanpaa;
        private System.Windows.Forms.CheckBox checkBoxJyvaskyla;
        private System.Windows.Forms.CheckBox checkBoxHelsinki;
        private System.Windows.Forms.CheckBox checkBoxHuittinen;
        private System.Windows.Forms.Label label2;
    }
}