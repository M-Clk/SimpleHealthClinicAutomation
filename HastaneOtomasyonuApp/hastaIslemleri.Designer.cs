namespace HastaneOtomasyonuApp
{
    partial class hastaIslemleri
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
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHastaAdi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKurumAdi = new System.Windows.Forms.TextBox();
            this.dtSevk = new System.Windows.Forms.DateTimePicker();
            this.btnBul = new System.Windows.Forms.Button();
            this.btnGit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnHastaBilgileri = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbOncelikliIslemleri = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBirimFiyat = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.nmMiktar = new System.Windows.Forms.NumericUpDown();
            this.cbDrAdi = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cbYapilanIslem = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cbPoliklinik = new System.Windows.Forms.ComboBox();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgYapilanTahlil = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblToplam = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btnBaski = new System.Windows.Forms.Button();
            this.Yazdir = new System.Windows.Forms.Button();
            this.btnTaburcu = new System.Windows.Forms.Button();
            this.btnSecSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.temporaryDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMiktar)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgYapilanTahlil)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temporaryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Location = new System.Drawing.Point(105, 6);
            this.txtDosyaNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(86, 20);
            this.txtDosyaNo.TabIndex = 0;
            this.txtDosyaNo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDosyaNo_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dosya No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sevk Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Onceki Islemler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasta Adi";
            // 
            // txtHastaAdi
            // 
            this.txtHastaAdi.Location = new System.Drawing.Point(338, 6);
            this.txtHastaAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaAdi.Name = "txtHastaAdi";
            this.txtHastaAdi.Size = new System.Drawing.Size(86, 20);
            this.txtHastaAdi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Soyadi";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(338, 36);
            this.txtSoyadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(86, 20);
            this.txtSoyadi.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kurum Adi";
            // 
            // txtKurumAdi
            // 
            this.txtKurumAdi.Location = new System.Drawing.Point(338, 66);
            this.txtKurumAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKurumAdi.Name = "txtKurumAdi";
            this.txtKurumAdi.Size = new System.Drawing.Size(86, 20);
            this.txtKurumAdi.TabIndex = 10;
            // 
            // dtSevk
            // 
            this.dtSevk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSevk.Location = new System.Drawing.Point(105, 34);
            this.dtSevk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtSevk.Name = "dtSevk";
            this.dtSevk.Size = new System.Drawing.Size(133, 20);
            this.dtSevk.TabIndex = 12;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(196, 6);
            this.btnBul.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(41, 19);
            this.btnBul.TabIndex = 13;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // btnGit
            // 
            this.btnGit.Location = new System.Drawing.Point(196, 63);
            this.btnGit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(41, 19);
            this.btnGit.TabIndex = 14;
            this.btnGit.Text = "Git";
            this.btnGit.UseVisualStyleBackColor = true;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(489, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Saglik Ocagi Hasta Takip Sistemi";
            // 
            // btnHastaBilgileri
            // 
            this.btnHastaBilgileri.Enabled = false;
            this.btnHastaBilgileri.Location = new System.Drawing.Point(484, 44);
            this.btnHastaBilgileri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHastaBilgileri.Name = "btnHastaBilgileri";
            this.btnHastaBilgileri.Size = new System.Drawing.Size(169, 37);
            this.btnHastaBilgileri.TabIndex = 16;
            this.btnHastaBilgileri.Text = "Hasta Bilgileri";
            this.btnHastaBilgileri.UseVisualStyleBackColor = true;
            this.btnHastaBilgileri.Click += new System.EventHandler(this.btnHastaBilgileri_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.cbOncelikliIslemleri);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDosyaNo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHastaBilgileri);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtHastaAdi);
            this.panel1.Controls.Add(this.btnGit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBul);
            this.panel1.Controls.Add(this.txtSoyadi);
            this.panel1.Controls.Add(this.dtSevk);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtKurumAdi);
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(668, 90);
            this.panel1.TabIndex = 18;
            // 
            // cbOncelikliIslemleri
            // 
            this.cbOncelikliIslemleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOncelikliIslemleri.FormattingEnabled = true;
            this.cbOncelikliIslemleri.Location = new System.Drawing.Point(105, 63);
            this.cbOncelikliIslemleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbOncelikliIslemleri.Name = "cbOncelikliIslemleri";
            this.cbOncelikliIslemleri.Size = new System.Drawing.Size(86, 21);
            this.cbOncelikliIslemleri.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.txtBirimFiyat);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.nmMiktar);
            this.panel2.Controls.Add(this.cbDrAdi);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.cbYapilanIslem);
            this.panel2.Controls.Add(this.btnEkle);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.cbPoliklinik);
            this.panel2.Controls.Add(this.txtSiraNo);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(10, 105);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(668, 46);
            this.panel2.TabIndex = 19;
            // 
            // txtBirimFiyat
            // 
            this.txtBirimFiyat.Location = new System.Drawing.Point(419, 16);
            this.txtBirimFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirimFiyat.Name = "txtBirimFiyat";
            this.txtBirimFiyat.Size = new System.Drawing.Size(67, 20);
            this.txtBirimFiyat.TabIndex = 26;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(417, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Birim Fiyati";
            // 
            // nmMiktar
            // 
            this.nmMiktar.Location = new System.Drawing.Point(353, 16);
            this.nmMiktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nmMiktar.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmMiktar.Name = "nmMiktar";
            this.nmMiktar.Size = new System.Drawing.Size(62, 20);
            this.nmMiktar.TabIndex = 25;
            this.nmMiktar.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbDrAdi
            // 
            this.cbDrAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDrAdi.FormattingEnabled = true;
            this.cbDrAdi.Location = new System.Drawing.Point(278, 16);
            this.cbDrAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDrAdi.Name = "cbDrAdi";
            this.cbDrAdi.Size = new System.Drawing.Size(70, 21);
            this.cbDrAdi.TabIndex = 24;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(285, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Dr. Adi";
            // 
            // cbYapilanIslem
            // 
            this.cbYapilanIslem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYapilanIslem.FormattingEnabled = true;
            this.cbYapilanIslem.Location = new System.Drawing.Point(177, 16);
            this.cbYapilanIslem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbYapilanIslem.Name = "cbYapilanIslem";
            this.cbYapilanIslem.Size = new System.Drawing.Size(96, 21);
            this.cbYapilanIslem.TabIndex = 22;
            this.cbYapilanIslem.SelectedIndexChanged += new System.EventHandler(this.cbYapilanIslem_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(491, 11);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(103, 28);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(185, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Yapilan Islem";
            // 
            // cbPoliklinik
            // 
            this.cbPoliklinik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPoliklinik.FormattingEnabled = true;
            this.cbPoliklinik.Location = new System.Drawing.Point(5, 16);
            this.cbPoliklinik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPoliklinik.Name = "cbPoliklinik";
            this.cbPoliklinik.Size = new System.Drawing.Size(96, 21);
            this.cbPoliklinik.TabIndex = 20;
            this.cbPoliklinik.SelectedIndexChanged += new System.EventHandler(this.cbPoliklinik_SelectedIndexChanged);
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(105, 16);
            this.txtSiraNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(67, 20);
            this.txtSiraNo.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Poliklinik";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(118, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Sira No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(360, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Miktar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgYapilanTahlil);
            this.groupBox1.Location = new System.Drawing.Point(10, 155);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(668, 158);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yapilan Tahlil Ve Islemler";
            // 
            // dgYapilanTahlil
            // 
            this.dgYapilanTahlil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgYapilanTahlil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgYapilanTahlil.Location = new System.Drawing.Point(3, 15);
            this.dgYapilanTahlil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgYapilanTahlil.Name = "dgYapilanTahlil";
            this.dgYapilanTahlil.ReadOnly = true;
            this.dgYapilanTahlil.RowHeadersWidth = 51;
            this.dgYapilanTahlil.RowTemplate.Height = 26;
            this.dgYapilanTahlil.Size = new System.Drawing.Size(662, 141);
            this.dgYapilanTahlil.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkBlue;
            this.panel3.Controls.Add(this.lblToplam);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(494, 319);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(182, 28);
            this.panel3.TabIndex = 21;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.lblToplam.ForeColor = System.Drawing.Color.Red;
            this.lblToplam.Location = new System.Drawing.Point(111, 3);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(30, 13);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "0 TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(9, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Toplam Tutar";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button3);
            this.panel4.Controls.Add(this.btnBaski);
            this.panel4.Controls.Add(this.Yazdir);
            this.panel4.Controls.Add(this.btnTaburcu);
            this.panel4.Controls.Add(this.btnSecSil);
            this.panel4.Controls.Add(this.btnGuncelle);
            this.panel4.Location = new System.Drawing.Point(15, 352);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(660, 45);
            this.panel4.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(581, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 37);
            this.button3.TabIndex = 18;
            this.button3.Text = "Cikis";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnBaski
            // 
            this.btnBaski.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaski.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnBaski.ForeColor = System.Drawing.Color.Black;
            this.btnBaski.Location = new System.Drawing.Point(383, 2);
            this.btnBaski.Name = "btnBaski";
            this.btnBaski.Size = new System.Drawing.Size(75, 37);
            this.btnBaski.TabIndex = 17;
            this.btnBaski.Text = "Baski Onizleme";
            this.btnBaski.UseVisualStyleBackColor = false;
            this.btnBaski.Click += new System.EventHandler(this.btnBaski_Click);
            // 
            // Yazdir
            // 
            this.Yazdir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Yazdir.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Yazdir.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Yazdir.Location = new System.Drawing.Point(290, 2);
            this.Yazdir.Name = "Yazdir";
            this.Yazdir.Size = new System.Drawing.Size(75, 37);
            this.Yazdir.TabIndex = 16;
            this.Yazdir.Text = "Yazdir";
            this.Yazdir.UseVisualStyleBackColor = false;
            this.Yazdir.Click += new System.EventHandler(this.Yazdir_Click);
            // 
            // btnTaburcu
            // 
            this.btnTaburcu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaburcu.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnTaburcu.Location = new System.Drawing.Point(197, 2);
            this.btnTaburcu.Name = "btnTaburcu";
            this.btnTaburcu.Size = new System.Drawing.Size(75, 37);
            this.btnTaburcu.TabIndex = 15;
            this.btnTaburcu.Text = "Taburcu";
            this.btnTaburcu.UseVisualStyleBackColor = false;
            this.btnTaburcu.Click += new System.EventHandler(this.btnTaburcu_Click);
            // 
            // btnSecSil
            // 
            this.btnSecSil.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSecSil.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnSecSil.ForeColor = System.Drawing.Color.Red;
            this.btnSecSil.Location = new System.Drawing.Point(101, 2);
            this.btnSecSil.Name = "btnSecSil";
            this.btnSecSil.Size = new System.Drawing.Size(75, 37);
            this.btnSecSil.TabIndex = 14;
            this.btnSecSil.Text = "Sec - Sil";
            this.btnSecSil.UseVisualStyleBackColor = false;
            this.btnSecSil.Click += new System.EventHandler(this.btnSecSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuncelle.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.btnGuncelle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnGuncelle.Location = new System.Drawing.Point(8, 2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 37);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Yeni";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // temporaryDataGrid
            // 
            this.temporaryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.temporaryDataGrid.Location = new System.Drawing.Point(396, 319);
            this.temporaryDataGrid.Name = "temporaryDataGrid";
            this.temporaryDataGrid.Size = new System.Drawing.Size(10, 10);
            this.temporaryDataGrid.TabIndex = 23;
            this.temporaryDataGrid.Visible = false;
            // 
            // hastaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 406);
            this.Controls.Add(this.temporaryDataGrid);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "hastaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Islemleri";
            this.Load += new System.EventHandler(this.frmHastaIslemleri_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmMiktar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgYapilanTahlil)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temporaryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHastaAdi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKurumAdi;
        private System.Windows.Forms.DateTimePicker dtSevk;
        private System.Windows.Forms.Button btnBul;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnHastaBilgileri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBirimFiyat;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown nmMiktar;
        private System.Windows.Forms.ComboBox cbDrAdi;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbYapilanIslem;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbPoliklinik;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgYapilanTahlil;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnBaski;
        private System.Windows.Forms.Button Yazdir;
        private System.Windows.Forms.Button btnTaburcu;
        private System.Windows.Forms.Button btnSecSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cbOncelikliIslemleri;
        private System.Windows.Forms.DataGridView temporaryDataGrid;
    }
}