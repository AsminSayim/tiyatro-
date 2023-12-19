namespace tiyatro_
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.cmbOyunAdi = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.nupSüre = new System.Windows.Forms.NumericUpDown();
            this.chkMüzikal = new System.Windows.Forms.CheckBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.cmbSahne = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.dgvListe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nupSüre)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Oyun Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(395, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(395, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Süre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sahne";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Fiyat";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(110, 45);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(208, 26);
            this.txtId.TabIndex = 7;
            // 
            // cmbOyunAdi
            // 
            this.cmbOyunAdi.FormattingEnabled = true;
            this.cmbOyunAdi.Items.AddRange(new object[] {
            "12. Gece",
            "Antigone",
            "Ay, Carmela!",
            "Ben Medea Değilim",
            "Benim Güzel Pabuçlarım",
            "Benim Küçük Yıldızım",
            "Bir Gece Masalı",
            "Bir Gün Ayakkabımın Teki",
            "Cadı Kazanı",
            "Fındıkkıran"});
            this.cmbOyunAdi.Location = new System.Drawing.Point(110, 80);
            this.cmbOyunAdi.Name = "cmbOyunAdi";
            this.cmbOyunAdi.Size = new System.Drawing.Size(208, 28);
            this.cmbOyunAdi.TabIndex = 8;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(448, 44);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 26);
            this.dtpTarih.TabIndex = 9;
            // 
            // nupSüre
            // 
            this.nupSüre.Location = new System.Drawing.Point(448, 76);
            this.nupSüre.Name = "nupSüre";
            this.nupSüre.Size = new System.Drawing.Size(200, 26);
            this.nupSüre.TabIndex = 10;
            // 
            // chkMüzikal
            // 
            this.chkMüzikal.AutoSize = true;
            this.chkMüzikal.Location = new System.Drawing.Point(448, 117);
            this.chkMüzikal.Name = "chkMüzikal";
            this.chkMüzikal.Size = new System.Drawing.Size(88, 24);
            this.chkMüzikal.TabIndex = 11;
            this.chkMüzikal.Text = "Müzikal";
            this.chkMüzikal.UseVisualStyleBackColor = true;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(110, 165);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(208, 26);
            this.txtFiyat.TabIndex = 12;
            // 
            // cmbSahne
            // 
            this.cmbSahne.FormattingEnabled = true;
            this.cmbSahne.Items.AddRange(new object[] {
            "Beylikdüzü Fatih Sultan Mehmet Kültür Sanat Merkezi Rasim Öztekin Sahnesi",
            "Fatih Reşat Nuri Sahnesi",
            "Gaziosmanpaşa Ferih Egemen Çocuk Tiyatrosu Sahnesi",
            "Gaziosmanpaşa Sahnesi",
            "Harbiye Cemil Topuzlu Açıkhava Tiyatrosu",
            "Harbiye Muhsin Ertuğrul Sahnesi",
            "İBB Güngören Erdem Beyazıt Kültür Merkezi",
            "İBB Yenibosna Dr. Enver Ören Kültür Merkezi",
            "Kağıthane Sadabad Sahnesi"});
            this.cmbSahne.Location = new System.Drawing.Point(110, 119);
            this.cmbSahne.Name = "cmbSahne";
            this.cmbSahne.Size = new System.Drawing.Size(208, 28);
            this.cmbSahne.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGüncelle);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnKaydet);
            this.groupBox1.Controls.Add(this.cmbSahne);
            this.groupBox1.Controls.Add(this.chkMüzikal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nupSüre);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.cmbOyunAdi);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 265);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiyatro Bilgi";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Image = global::tiyatro_.Properties.Resources._002_diskette;
            this.btnKaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnKaydet.Location = new System.Drawing.Point(368, 165);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(114, 59);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Image = global::tiyatro_.Properties.Resources._003_bin;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(497, 165);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(114, 59);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Image = global::tiyatro_.Properties.Resources._001_refresh;
            this.btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGüncelle.Location = new System.Drawing.Point(626, 165);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(114, 59);
            this.btnGüncelle.TabIndex = 16;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // dgvListe
            // 
            this.dgvListe.AllowUserToAddRows = false;
            this.dgvListe.AllowUserToDeleteRows = false;
            this.dgvListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListe.Location = new System.Drawing.Point(3, 274);
            this.dgvListe.Name = "dgvListe";
            this.dgvListe.ReadOnly = true;
            this.dgvListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListe.Size = new System.Drawing.Size(764, 150);
            this.dgvListe.TabIndex = 15;
            this.dgvListe.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListe_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 436);
            this.Controls.Add(this.dgvListe);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupSüre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ComboBox cmbOyunAdi;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.NumericUpDown nupSüre;
        private System.Windows.Forms.CheckBox chkMüzikal;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.ComboBox cmbSahne;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView dgvListe;
    }
}

