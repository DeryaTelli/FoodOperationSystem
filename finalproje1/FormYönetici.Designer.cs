namespace finalproje1
{
    partial class FormYonetici
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageHesapAnalizi = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxHasilat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewMenu2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewSiparis2 = new System.Windows.Forms.DataGridView();
            this.tabPageCalisan = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Silme = new System.Windows.Forms.Button();
            this.Kaydet = new System.Windows.Forms.Button();
            this.comboBoxYetki = new System.Windows.Forms.ComboBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.labelYetki = new System.Windows.Forms.Label();
            this.labelSifre = new System.Windows.Forms.Label();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.labelSoyadi = new System.Windows.Forms.Label();
            this.labelAdi = new System.Windows.Forms.Label();
            this.dataGridViewYonetici = new System.Windows.Forms.DataGridView();
            this.tabPageStokKontrol = new System.Windows.Forms.TabPage();
            this.textBoxMiktarY = new System.Windows.Forms.TextBox();
            this.textBoxFiyatY = new System.Windows.Forms.TextBox();
            this.textBoxAdiY = new System.Windows.Forms.TextBox();
            this.comboBoxYiyecekTuru = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxYemekAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewStok = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPageHesapAnalizi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis2)).BeginInit();
            this.tabPageCalisan.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYonetici)).BeginInit();
            this.tabPageStokKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStok)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageHesapAnalizi);
            this.tabControl1.Controls.Add(this.tabPageCalisan);
            this.tabControl1.Controls.Add(this.tabPageStokKontrol);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.dataGridViewStok_SelectionChanged);
            // 
            // tabPageHesapAnalizi
            // 
            this.tabPageHesapAnalizi.BackColor = System.Drawing.Color.Silver;
            this.tabPageHesapAnalizi.Controls.Add(this.button2);
            this.tabPageHesapAnalizi.Controls.Add(this.textBoxHasilat);
            this.tabPageHesapAnalizi.Controls.Add(this.label6);
            this.tabPageHesapAnalizi.Controls.Add(this.dataGridViewMenu2);
            this.tabPageHesapAnalizi.Controls.Add(this.dataGridViewSiparis2);
            this.tabPageHesapAnalizi.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageHesapAnalizi.ForeColor = System.Drawing.Color.Black;
            this.tabPageHesapAnalizi.Location = new System.Drawing.Point(4, 22);
            this.tabPageHesapAnalizi.Name = "tabPageHesapAnalizi";
            this.tabPageHesapAnalizi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHesapAnalizi.Size = new System.Drawing.Size(792, 424);
            this.tabPageHesapAnalizi.TabIndex = 0;
            this.tabPageHesapAnalizi.Text = "SİPARİŞ İNCELEME";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(543, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hesapla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxHasilat
            // 
            this.textBoxHasilat.Location = new System.Drawing.Point(608, 61);
            this.textBoxHasilat.Name = "textBoxHasilat";
            this.textBoxHasilat.Size = new System.Drawing.Size(147, 25);
            this.textBoxHasilat.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(489, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Toplam Hasılat";
            // 
            // dataGridViewMenu2
            // 
            this.dataGridViewMenu2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMenu2.Location = new System.Drawing.Point(8, 202);
            this.dataGridViewMenu2.Name = "dataGridViewMenu2";
            this.dataGridViewMenu2.Size = new System.Drawing.Size(767, 214);
            this.dataGridViewMenu2.TabIndex = 1;
            // 
            // dataGridViewSiparis2
            // 
            this.dataGridViewSiparis2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSiparis2.Location = new System.Drawing.Point(8, 6);
            this.dataGridViewSiparis2.Name = "dataGridViewSiparis2";
            this.dataGridViewSiparis2.Size = new System.Drawing.Size(465, 190);
            this.dataGridViewSiparis2.TabIndex = 0;
            // 
            // tabPageCalisan
            // 
            this.tabPageCalisan.BackColor = System.Drawing.Color.Silver;
            this.tabPageCalisan.Controls.Add(this.groupBox1);
            this.tabPageCalisan.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageCalisan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.tabPageCalisan.Location = new System.Drawing.Point(4, 22);
            this.tabPageCalisan.Name = "tabPageCalisan";
            this.tabPageCalisan.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCalisan.Size = new System.Drawing.Size(792, 424);
            this.tabPageCalisan.TabIndex = 1;
            this.tabPageCalisan.Text = "KULLANICI ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Silme);
            this.groupBox1.Controls.Add(this.Kaydet);
            this.groupBox1.Controls.Add(this.comboBoxYetki);
            this.groupBox1.Controls.Add(this.textBoxSifre);
            this.groupBox1.Controls.Add(this.textBoxKullaniciAdi);
            this.groupBox1.Controls.Add(this.textBoxSoyadi);
            this.groupBox1.Controls.Add(this.textBoxAdi);
            this.groupBox1.Controls.Add(this.labelYetki);
            this.groupBox1.Controls.Add(this.labelSifre);
            this.groupBox1.Controls.Add(this.labelKullaniciAdi);
            this.groupBox1.Controls.Add(this.labelSoyadi);
            this.groupBox1.Controls.Add(this.labelAdi);
            this.groupBox1.Controls.Add(this.dataGridViewYonetici);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 418);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // Silme
            // 
            this.Silme.BackColor = System.Drawing.Color.DarkGray;
            this.Silme.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Silme.Location = new System.Drawing.Point(592, 69);
            this.Silme.Name = "Silme";
            this.Silme.Size = new System.Drawing.Size(159, 38);
            this.Silme.TabIndex = 12;
            this.Silme.Text = "Silme";
            this.Silme.UseVisualStyleBackColor = false;
            this.Silme.Click += new System.EventHandler(this.Silme_Click);
            // 
            // Kaydet
            // 
            this.Kaydet.BackColor = System.Drawing.Color.DarkGray;
            this.Kaydet.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Kaydet.ForeColor = System.Drawing.Color.Black;
            this.Kaydet.Location = new System.Drawing.Point(592, 15);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(159, 45);
            this.Kaydet.TabIndex = 11;
            this.Kaydet.Text = "Kaydet";
            this.Kaydet.UseVisualStyleBackColor = false;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // comboBoxYetki
            // 
            this.comboBoxYetki.FormattingEnabled = true;
            this.comboBoxYetki.Items.AddRange(new object[] {
            "Yönetici",
            "Çalışan",
            "Müşteri"});
            this.comboBoxYetki.Location = new System.Drawing.Point(409, 69);
            this.comboBoxYetki.Name = "comboBoxYetki";
            this.comboBoxYetki.Size = new System.Drawing.Size(121, 25);
            this.comboBoxYetki.TabIndex = 10;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(409, 21);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.Size = new System.Drawing.Size(100, 25);
            this.textBoxSifre.TabIndex = 9;
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(162, 100);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(100, 25);
            this.textBoxKullaniciAdi.TabIndex = 8;
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(162, 52);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(100, 25);
            this.textBoxSoyadi.TabIndex = 7;
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(162, 15);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(100, 25);
            this.textBoxAdi.TabIndex = 6;
            // 
            // labelYetki
            // 
            this.labelYetki.AutoSize = true;
            this.labelYetki.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelYetki.Location = new System.Drawing.Point(355, 72);
            this.labelYetki.Name = "labelYetki";
            this.labelYetki.Size = new System.Drawing.Size(39, 17);
            this.labelYetki.TabIndex = 5;
            this.labelYetki.Text = "Yetki";
            // 
            // labelSifre
            // 
            this.labelSifre.AutoSize = true;
            this.labelSifre.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSifre.Location = new System.Drawing.Point(355, 24);
            this.labelSifre.Name = "labelSifre";
            this.labelSifre.Size = new System.Drawing.Size(36, 17);
            this.labelSifre.TabIndex = 4;
            this.labelSifre.Text = "Şifre";
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullaniciAdi.Location = new System.Drawing.Point(56, 103);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(86, 17);
            this.labelKullaniciAdi.TabIndex = 3;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // labelSoyadi
            // 
            this.labelSoyadi.AutoSize = true;
            this.labelSoyadi.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyadi.Location = new System.Drawing.Point(93, 55);
            this.labelSoyadi.Name = "labelSoyadi";
            this.labelSoyadi.Size = new System.Drawing.Size(49, 17);
            this.labelSoyadi.TabIndex = 2;
            this.labelSoyadi.Text = "Soyadı";
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdi.Location = new System.Drawing.Point(93, 21);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(29, 17);
            this.labelAdi.TabIndex = 1;
            this.labelAdi.Text = "Adı";
            // 
            // dataGridViewYonetici
            // 
            this.dataGridViewYonetici.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGridViewYonetici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewYonetici.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewYonetici.Location = new System.Drawing.Point(31, 131);
            this.dataGridViewYonetici.Name = "dataGridViewYonetici";
            this.dataGridViewYonetici.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewYonetici.Size = new System.Drawing.Size(720, 272);
            this.dataGridViewYonetici.TabIndex = 0;
            this.dataGridViewYonetici.SelectionChanged += new System.EventHandler(this.dataGridViewYonetici_SelectionChanged);
            // 
            // tabPageStokKontrol
            // 
            this.tabPageStokKontrol.BackColor = System.Drawing.Color.Silver;
            this.tabPageStokKontrol.Controls.Add(this.textBoxMiktarY);
            this.tabPageStokKontrol.Controls.Add(this.textBoxFiyatY);
            this.tabPageStokKontrol.Controls.Add(this.textBoxAdiY);
            this.tabPageStokKontrol.Controls.Add(this.comboBoxYiyecekTuru);
            this.tabPageStokKontrol.Controls.Add(this.label5);
            this.tabPageStokKontrol.Controls.Add(this.label4);
            this.tabPageStokKontrol.Controls.Add(this.label3);
            this.tabPageStokKontrol.Controls.Add(this.label2);
            this.tabPageStokKontrol.Controls.Add(this.button1);
            this.tabPageStokKontrol.Controls.Add(this.textBoxYemekAdi);
            this.tabPageStokKontrol.Controls.Add(this.label1);
            this.tabPageStokKontrol.Controls.Add(this.dataGridViewStok);
            this.tabPageStokKontrol.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabPageStokKontrol.ForeColor = System.Drawing.Color.Black;
            this.tabPageStokKontrol.Location = new System.Drawing.Point(4, 22);
            this.tabPageStokKontrol.Name = "tabPageStokKontrol";
            this.tabPageStokKontrol.Size = new System.Drawing.Size(792, 424);
            this.tabPageStokKontrol.TabIndex = 2;
            this.tabPageStokKontrol.Text = "STOK KONTROL";
            this.tabPageStokKontrol.Click += new System.EventHandler(this.tabPageStokKontrol_Click);
            // 
            // textBoxMiktarY
            // 
            this.textBoxMiktarY.Location = new System.Drawing.Point(181, 326);
            this.textBoxMiktarY.Name = "textBoxMiktarY";
            this.textBoxMiktarY.Size = new System.Drawing.Size(100, 25);
            this.textBoxMiktarY.TabIndex = 17;
            // 
            // textBoxFiyatY
            // 
            this.textBoxFiyatY.Location = new System.Drawing.Point(181, 250);
            this.textBoxFiyatY.Name = "textBoxFiyatY";
            this.textBoxFiyatY.Size = new System.Drawing.Size(100, 25);
            this.textBoxFiyatY.TabIndex = 16;
            this.textBoxFiyatY.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxAdiY
            // 
            this.textBoxAdiY.Location = new System.Drawing.Point(181, 115);
            this.textBoxAdiY.Name = "textBoxAdiY";
            this.textBoxAdiY.Size = new System.Drawing.Size(100, 25);
            this.textBoxAdiY.TabIndex = 15;
            // 
            // comboBoxYiyecekTuru
            // 
            this.comboBoxYiyecekTuru.FormattingEnabled = true;
            this.comboBoxYiyecekTuru.Location = new System.Drawing.Point(181, 180);
            this.comboBoxYiyecekTuru.Name = "comboBoxYiyecekTuru";
            this.comboBoxYiyecekTuru.Size = new System.Drawing.Size(121, 25);
            this.comboBoxYiyecekTuru.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(88, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(88, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Fiyat";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(61, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yiyecek Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Yiyecek Yemek Adı";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(365, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 292);
            this.button1.TabIndex = 8;
            this.button1.Text = "S\r\nT\r\nO\r\nK\r\n\r\nG\r\nÜ\r\nN\r\nC\r\nE\r\nL\r\nL\r\nE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxYemekAdi
            // 
            this.textBoxYemekAdi.Location = new System.Drawing.Point(191, 18);
            this.textBoxYemekAdi.Name = "textBoxYemekAdi";
            this.textBoxYemekAdi.Size = new System.Drawing.Size(593, 25);
            this.textBoxYemekAdi.TabIndex = 7;
            this.textBoxYemekAdi.TextChanged += new System.EventHandler(this.textBoxYemekAdi_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yiyecek Yemek Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewStok
            // 
            this.dataGridViewStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStok.Location = new System.Drawing.Point(417, 49);
            this.dataGridViewStok.Name = "dataGridViewStok";
            this.dataGridViewStok.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStok.Size = new System.Drawing.Size(367, 356);
            this.dataGridViewStok.TabIndex = 0;
            this.dataGridViewStok.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewStok_DataBindingComplete);
            this.dataGridViewStok.SelectionChanged += new System.EventHandler(this.dataGridViewStok_SelectionChanged_1);
            // 
            // FormYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormYonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Portalı";
            this.Load += new System.EventHandler(this.FormYonetici_Load_2);
            this.tabControl1.ResumeLayout(false);
            this.tabPageHesapAnalizi.ResumeLayout(false);
            this.tabPageHesapAnalizi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMenu2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSiparis2)).EndInit();
            this.tabPageCalisan.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewYonetici)).EndInit();
            this.tabPageStokKontrol.ResumeLayout(false);
            this.tabPageStokKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStok)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageHesapAnalizi;
        private System.Windows.Forms.TabPage tabPageCalisan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.ComboBox comboBoxYetki;
        private System.Windows.Forms.TextBox textBoxSifre;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.Label labelYetki;
        private System.Windows.Forms.Label labelSifre;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.Label labelSoyadi;
        private System.Windows.Forms.Label labelAdi;
        public System.Windows.Forms.DataGridView dataGridViewYonetici;
        private System.Windows.Forms.Button Silme;
        private System.Windows.Forms.TabPage tabPageStokKontrol;
        private System.Windows.Forms.TextBox textBoxYemekAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewStok;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxYiyecekTuru;
        private System.Windows.Forms.TextBox textBoxMiktarY;
        private System.Windows.Forms.TextBox textBoxFiyatY;
        private System.Windows.Forms.TextBox textBoxAdiY;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxHasilat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewMenu2;
        private System.Windows.Forms.DataGridView dataGridViewSiparis2;
    }
}