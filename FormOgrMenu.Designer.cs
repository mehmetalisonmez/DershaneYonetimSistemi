﻿namespace DershaneYonetimSistemi
{
    partial class FormOgrMenu
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
            buttonOgrencileriGoruntule = new Button();
            buttonDevamsızlıkSil = new Button();
            textBoxSilinecekDevamsizlikID = new TextBox();
            labelSilinecekDevamsizlikID = new Label();
            buttonOgrenciSil = new Button();
            textBoxSilinecekOgrenci = new TextBox();
            labelSilinecekRol = new Label();
            groupBox3 = new GroupBox();
            dataGridViewOgrenciler = new DataGridView();
            groupBox2 = new GroupBox();
            comboBoxTemporaryDevamsizlikID = new ComboBox();
            checkBoxDevamsizlikBilgisi = new CheckBox();
            labelDevamsizlikBilgisi = new Label();
            dateTimePickerDevamsizlikTarihi = new DateTimePicker();
            labelDevamsizlikTarihi = new Label();
            labelTemporaryDevamsizlikID = new Label();
            comboBoxOgrenciDersID = new ComboBox();
            buttonSinavDevamsizlikGuncelle = new Button();
            buttonOgrenciDevamsizlikEkle = new Button();
            labelOgrenciDersID = new Label();
            groupBox1 = new GroupBox();
            comboBoxTemporaryStudentID = new ComboBox();
            textBoxStudentID = new TextBox();
            labelStudentID = new Label();
            richTextBoxOgrenciAdres = new RichTextBox();
            labelOgrenciAdres = new Label();
            textBoxOgrenciAlan = new TextBox();
            labelOgrenciAlan = new Label();
            dateTimePickerKayitTarihi = new DateTimePicker();
            labelKayitTarihi = new Label();
            label12 = new Label();
            textBoxOgrenciCinsiyet = new TextBox();
            labelCinsiyet = new Label();
            textBoxOgrenciAdi = new TextBox();
            textBoxOgrenciSoyadi = new TextBox();
            dateTimePickerDogumTarihi = new DateTimePicker();
            buttonOgrenciGuncelle = new Button();
            labelTemporarySinavID = new Label();
            buttonOgrenciEkle = new Button();
            labelSoyad = new Label();
            labelFirstName = new Label();
            labelDogumTarihi = new Label();
            groupBox5 = new GroupBox();
            dataGridViewDevamsizliklar = new DataGridView();
            labelOgrenciCRUD = new Label();
            labelDevamsizlikCRUD = new Label();
            label3 = new Label();
            groupBox6 = new GroupBox();
            buttonOgrenciDersGuncelle = new Button();
            dateTimePickerDerseKayitTarihi = new DateTimePicker();
            comboBoxTemporaryOgrenciDersID = new ComboBox();
            labelTemporaryOgrenciDersID = new Label();
            labelDersID = new Label();
            comboBoxDersID = new ComboBox();
            comboBoxOgrenciNo = new ComboBox();
            buttonOgrenciDersEkle = new Button();
            labelOgrenciID = new Label();
            labelDerseKayitTarihi = new Label();
            labelOgrenciDersCRUD = new Label();
            buttonOgrenciDersleriGoruntule = new Button();
            groupBox4 = new GroupBox();
            dataGridViewOgrenciDersleri = new DataGridView();
            buttonDevamsizlikGoruntule = new Button();
            buttonOgrenciDersSil = new Button();
            textBoxSilinecekOgrenciDers = new TextBox();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevamsizliklar).BeginInit();
            groupBox6.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciDersleri).BeginInit();
            SuspendLayout();
            // 
            // buttonOgrencileriGoruntule
            // 
            buttonOgrencileriGoruntule.Location = new Point(682, 6);
            buttonOgrencileriGoruntule.Name = "buttonOgrencileriGoruntule";
            buttonOgrencileriGoruntule.Size = new Size(108, 38);
            buttonOgrencileriGoruntule.TabIndex = 42;
            buttonOgrencileriGoruntule.Text = "Öğrencileri Görüntüle";
            buttonOgrencileriGoruntule.UseVisualStyleBackColor = true;
            // 
            // buttonDevamsızlıkSil
            // 
            buttonDevamsızlıkSil.Location = new Point(1401, 354);
            buttonDevamsızlıkSil.Name = "buttonDevamsızlıkSil";
            buttonDevamsızlıkSil.Size = new Size(87, 38);
            buttonDevamsızlıkSil.TabIndex = 41;
            buttonDevamsızlıkSil.Text = "Devamsızlık Sil";
            buttonDevamsızlıkSil.UseVisualStyleBackColor = true;
            buttonDevamsızlıkSil.Click += buttonDevamsızlıkSil_Click;
            // 
            // textBoxSilinecekDevamsizlikID
            // 
            textBoxSilinecekDevamsizlikID.Location = new Point(1248, 363);
            textBoxSilinecekDevamsizlikID.Name = "textBoxSilinecekDevamsizlikID";
            textBoxSilinecekDevamsizlikID.Size = new Size(118, 23);
            textBoxSilinecekDevamsizlikID.TabIndex = 40;
            // 
            // labelSilinecekDevamsizlikID
            // 
            labelSilinecekDevamsizlikID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSilinecekDevamsizlikID.Location = new Point(1069, 356);
            labelSilinecekDevamsizlikID.Name = "labelSilinecekDevamsizlikID";
            labelSilinecekDevamsizlikID.Size = new Size(162, 36);
            labelSilinecekDevamsizlikID.TabIndex = 39;
            labelSilinecekDevamsizlikID.Text = "Silinecek devamsızlığın ID değerini giriniz :";
            // 
            // buttonOgrenciSil
            // 
            buttonOgrenciSil.Location = new Point(329, 481);
            buttonOgrenciSil.Name = "buttonOgrenciSil";
            buttonOgrenciSil.Size = new Size(87, 38);
            buttonOgrenciSil.TabIndex = 38;
            buttonOgrenciSil.Text = "Öğrenci Sil";
            buttonOgrenciSil.UseVisualStyleBackColor = true;
            buttonOgrenciSil.Click += buttonOgrenciSil_Click;
            // 
            // textBoxSilinecekOgrenci
            // 
            textBoxSilinecekOgrenci.Location = new Point(183, 489);
            textBoxSilinecekOgrenci.Name = "textBoxSilinecekOgrenci";
            textBoxSilinecekOgrenci.Size = new Size(131, 23);
            textBoxSilinecekOgrenci.TabIndex = 37;
            // 
            // labelSilinecekRol
            // 
            labelSilinecekRol.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSilinecekRol.Location = new Point(41, 480);
            labelSilinecekRol.Name = "labelSilinecekRol";
            labelSilinecekRol.Size = new Size(149, 39);
            labelSilinecekRol.TabIndex = 36;
            labelSilinecekRol.Text = "Silinecek Öğrencinin numarasını giriniz :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewOgrenciler);
            groupBox3.Location = new Point(476, 38);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(573, 260);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Öğrenci Listesi";
            // 
            // dataGridViewOgrenciler
            // 
            dataGridViewOgrenciler.AllowUserToAddRows = false;
            dataGridViewOgrenciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOgrenciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciler.Dock = DockStyle.Fill;
            dataGridViewOgrenciler.Location = new Point(3, 19);
            dataGridViewOgrenciler.Name = "dataGridViewOgrenciler";
            dataGridViewOgrenciler.RowTemplate.Height = 25;
            dataGridViewOgrenciler.Size = new Size(567, 238);
            dataGridViewOgrenciler.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxTemporaryDevamsizlikID);
            groupBox2.Controls.Add(checkBoxDevamsizlikBilgisi);
            groupBox2.Controls.Add(labelDevamsizlikBilgisi);
            groupBox2.Controls.Add(dateTimePickerDevamsizlikTarihi);
            groupBox2.Controls.Add(labelDevamsizlikTarihi);
            groupBox2.Controls.Add(labelTemporaryDevamsizlikID);
            groupBox2.Controls.Add(comboBoxOgrenciDersID);
            groupBox2.Controls.Add(buttonSinavDevamsizlikGuncelle);
            groupBox2.Controls.Add(buttonOgrenciDevamsizlikEkle);
            groupBox2.Controls.Add(labelOgrenciDersID);
            groupBox2.Location = new Point(1069, 25);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 303);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            // 
            // comboBoxTemporaryDevamsizlikID
            // 
            comboBoxTemporaryDevamsizlikID.FormattingEnabled = true;
            comboBoxTemporaryDevamsizlikID.Location = new Point(212, 35);
            comboBoxTemporaryDevamsizlikID.Name = "comboBoxTemporaryDevamsizlikID";
            comboBoxTemporaryDevamsizlikID.Size = new Size(121, 23);
            comboBoxTemporaryDevamsizlikID.TabIndex = 71;
            // 
            // checkBoxDevamsizlikBilgisi
            // 
            checkBoxDevamsizlikBilgisi.AutoSize = true;
            checkBoxDevamsizlikBilgisi.Location = new Point(179, 145);
            checkBoxDevamsizlikBilgisi.Name = "checkBoxDevamsizlikBilgisi";
            checkBoxDevamsizlikBilgisi.Size = new Size(15, 14);
            checkBoxDevamsizlikBilgisi.TabIndex = 37;
            checkBoxDevamsizlikBilgisi.UseVisualStyleBackColor = true;
            // 
            // labelDevamsizlikBilgisi
            // 
            labelDevamsizlikBilgisi.AutoSize = true;
            labelDevamsizlikBilgisi.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDevamsizlikBilgisi.Location = new Point(17, 143);
            labelDevamsizlikBilgisi.Name = "labelDevamsizlikBilgisi";
            labelDevamsizlikBilgisi.Size = new Size(137, 16);
            labelDevamsizlikBilgisi.TabIndex = 36;
            labelDevamsizlikBilgisi.Text = "Devamsızlık Yaptı mı ?";
            // 
            // dateTimePickerDevamsizlikTarihi
            // 
            dateTimePickerDevamsizlikTarihi.Location = new Point(143, 173);
            dateTimePickerDevamsizlikTarihi.Name = "dateTimePickerDevamsizlikTarihi";
            dateTimePickerDevamsizlikTarihi.Size = new Size(191, 23);
            dateTimePickerDevamsizlikTarihi.TabIndex = 35;
            // 
            // labelDevamsizlikTarihi
            // 
            labelDevamsizlikTarihi.AutoSize = true;
            labelDevamsizlikTarihi.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDevamsizlikTarihi.Location = new Point(16, 176);
            labelDevamsizlikTarihi.Name = "labelDevamsizlikTarihi";
            labelDevamsizlikTarihi.Size = new Size(121, 16);
            labelDevamsizlikTarihi.TabIndex = 34;
            labelDevamsizlikTarihi.Text = "Devamsızlık Tarihi :";
            // 
            // labelTemporaryDevamsizlikID
            // 
            labelTemporaryDevamsizlikID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTemporaryDevamsizlikID.Location = new Point(17, 11);
            labelTemporaryDevamsizlikID.Name = "labelTemporaryDevamsizlikID";
            labelTemporaryDevamsizlikID.Size = new Size(189, 80);
            labelTemporaryDevamsizlikID.TabIndex = 33;
            labelTemporaryDevamsizlikID.Text = "Bu alana sadece güncelleme yapacağınız zaman, güncelleyeceğiniz devamsızlığın mevcut ID değerini seçiniz :";
            labelTemporaryDevamsizlikID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxOgrenciDersID
            // 
            comboBoxOgrenciDersID.FormattingEnabled = true;
            comboBoxOgrenciDersID.Location = new Point(143, 102);
            comboBoxOgrenciDersID.Name = "comboBoxOgrenciDersID";
            comboBoxOgrenciDersID.Size = new Size(121, 23);
            comboBoxOgrenciDersID.TabIndex = 26;
            // 
            // buttonSinavDevamsizlikGuncelle
            // 
            buttonSinavDevamsizlikGuncelle.Location = new Point(67, 232);
            buttonSinavDevamsizlikGuncelle.Name = "buttonSinavDevamsizlikGuncelle";
            buttonSinavDevamsizlikGuncelle.Size = new Size(107, 41);
            buttonSinavDevamsizlikGuncelle.TabIndex = 17;
            buttonSinavDevamsizlikGuncelle.Text = "Devamsızlık Güncelle";
            buttonSinavDevamsizlikGuncelle.UseVisualStyleBackColor = true;
            buttonSinavDevamsizlikGuncelle.Click += buttonSinavDevamsizlikGuncelle_Click;
            // 
            // buttonOgrenciDevamsizlikEkle
            // 
            buttonOgrenciDevamsizlikEkle.Location = new Point(201, 232);
            buttonOgrenciDevamsizlikEkle.Name = "buttonOgrenciDevamsizlikEkle";
            buttonOgrenciDevamsizlikEkle.Size = new Size(108, 41);
            buttonOgrenciDevamsizlikEkle.TabIndex = 16;
            buttonOgrenciDevamsizlikEkle.Text = "Yeni Devamsızlık Ekle";
            buttonOgrenciDevamsizlikEkle.UseVisualStyleBackColor = true;
            buttonOgrenciDevamsizlikEkle.Click += buttonOgrenciDevamsizlikEkle_Click;
            // 
            // labelOgrenciDersID
            // 
            labelOgrenciDersID.AutoSize = true;
            labelOgrenciDersID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOgrenciDersID.Location = new Point(17, 104);
            labelOgrenciDersID.Name = "labelOgrenciDersID";
            labelOgrenciDersID.Size = new Size(100, 16);
            labelOgrenciDersID.TabIndex = 8;
            labelOgrenciDersID.Text = "Öğrenci Ders ID :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxTemporaryStudentID);
            groupBox1.Controls.Add(textBoxStudentID);
            groupBox1.Controls.Add(labelStudentID);
            groupBox1.Controls.Add(richTextBoxOgrenciAdres);
            groupBox1.Controls.Add(labelOgrenciAdres);
            groupBox1.Controls.Add(textBoxOgrenciAlan);
            groupBox1.Controls.Add(labelOgrenciAlan);
            groupBox1.Controls.Add(dateTimePickerKayitTarihi);
            groupBox1.Controls.Add(labelKayitTarihi);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(textBoxOgrenciCinsiyet);
            groupBox1.Controls.Add(labelCinsiyet);
            groupBox1.Controls.Add(textBoxOgrenciAdi);
            groupBox1.Controls.Add(textBoxOgrenciSoyadi);
            groupBox1.Controls.Add(dateTimePickerDogumTarihi);
            groupBox1.Controls.Add(buttonOgrenciGuncelle);
            groupBox1.Controls.Add(labelTemporarySinavID);
            groupBox1.Controls.Add(buttonOgrenciEkle);
            groupBox1.Controls.Add(labelSoyad);
            groupBox1.Controls.Add(labelFirstName);
            groupBox1.Controls.Add(labelDogumTarihi);
            groupBox1.Location = new Point(9, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(431, 447);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            // 
            // comboBoxTemporaryStudentID
            // 
            comboBoxTemporaryStudentID.FormattingEnabled = true;
            comboBoxTemporaryStudentID.Location = new Point(198, 51);
            comboBoxTemporaryStudentID.Name = "comboBoxTemporaryStudentID";
            comboBoxTemporaryStudentID.Size = new Size(121, 23);
            comboBoxTemporaryStudentID.TabIndex = 70;
            // 
            // textBoxStudentID
            // 
            textBoxStudentID.Location = new Point(112, 111);
            textBoxStudentID.Name = "textBoxStudentID";
            textBoxStudentID.Size = new Size(118, 23);
            textBoxStudentID.TabIndex = 71;
            // 
            // labelStudentID
            // 
            labelStudentID.AutoSize = true;
            labelStudentID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelStudentID.Location = new Point(13, 113);
            labelStudentID.Name = "labelStudentID";
            labelStudentID.Size = new Size(71, 16);
            labelStudentID.TabIndex = 70;
            labelStudentID.Text = "Öğrenci ID :";
            // 
            // richTextBoxOgrenciAdres
            // 
            richTextBoxOgrenciAdres.Location = new Point(67, 346);
            richTextBoxOgrenciAdres.Name = "richTextBoxOgrenciAdres";
            richTextBoxOgrenciAdres.Size = new Size(126, 96);
            richTextBoxOgrenciAdres.TabIndex = 69;
            richTextBoxOgrenciAdres.Text = "";
            // 
            // labelOgrenciAdres
            // 
            labelOgrenciAdres.AutoSize = true;
            labelOgrenciAdres.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOgrenciAdres.Location = new Point(15, 361);
            labelOgrenciAdres.Name = "labelOgrenciAdres";
            labelOgrenciAdres.Size = new Size(46, 16);
            labelOgrenciAdres.TabIndex = 68;
            labelOgrenciAdres.Text = "Adres :";
            // 
            // textBoxOgrenciAlan
            // 
            textBoxOgrenciAlan.Location = new Point(114, 317);
            textBoxOgrenciAlan.Name = "textBoxOgrenciAlan";
            textBoxOgrenciAlan.Size = new Size(118, 23);
            textBoxOgrenciAlan.TabIndex = 67;
            // 
            // labelOgrenciAlan
            // 
            labelOgrenciAlan.AutoSize = true;
            labelOgrenciAlan.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOgrenciAlan.Location = new Point(15, 321);
            labelOgrenciAlan.Name = "labelOgrenciAlan";
            labelOgrenciAlan.Size = new Size(85, 16);
            labelOgrenciAlan.TabIndex = 66;
            labelOgrenciAlan.Text = "Öğrenci Alan :";
            // 
            // dateTimePickerKayitTarihi
            // 
            dateTimePickerKayitTarihi.Location = new Point(114, 283);
            dateTimePickerKayitTarihi.Name = "dateTimePickerKayitTarihi";
            dateTimePickerKayitTarihi.Size = new Size(191, 23);
            dateTimePickerKayitTarihi.TabIndex = 65;
            // 
            // labelKayitTarihi
            // 
            labelKayitTarihi.AutoSize = true;
            labelKayitTarihi.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelKayitTarihi.Location = new Point(14, 286);
            labelKayitTarihi.Name = "labelKayitTarihi";
            labelKayitTarihi.Size = new Size(82, 16);
            labelKayitTarihi.TabIndex = 64;
            labelKayitTarihi.Text = "Kayıt Tarihi :";
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(12, 266);
            label12.Name = "label12";
            label12.Size = new Size(75, 13);
            label12.TabIndex = 63;
            label12.Text = "(E veya K giriniz)";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxOgrenciCinsiyet
            // 
            textBoxOgrenciCinsiyet.Location = new Point(114, 251);
            textBoxOgrenciCinsiyet.Name = "textBoxOgrenciCinsiyet";
            textBoxOgrenciCinsiyet.Size = new Size(118, 23);
            textBoxOgrenciCinsiyet.TabIndex = 28;
            // 
            // labelCinsiyet
            // 
            labelCinsiyet.AutoSize = true;
            labelCinsiyet.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCinsiyet.Location = new Point(14, 251);
            labelCinsiyet.Name = "labelCinsiyet";
            labelCinsiyet.Size = new Size(60, 16);
            labelCinsiyet.TabIndex = 27;
            labelCinsiyet.Text = "Cinsiyet :";
            // 
            // textBoxOgrenciAdi
            // 
            textBoxOgrenciAdi.Location = new Point(114, 150);
            textBoxOgrenciAdi.Name = "textBoxOgrenciAdi";
            textBoxOgrenciAdi.Size = new Size(118, 23);
            textBoxOgrenciAdi.TabIndex = 26;
            // 
            // textBoxOgrenciSoyadi
            // 
            textBoxOgrenciSoyadi.Location = new Point(114, 183);
            textBoxOgrenciSoyadi.Name = "textBoxOgrenciSoyadi";
            textBoxOgrenciSoyadi.Size = new Size(118, 23);
            textBoxOgrenciSoyadi.TabIndex = 23;
            // 
            // dateTimePickerDogumTarihi
            // 
            dateTimePickerDogumTarihi.Location = new Point(114, 216);
            dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            dateTimePickerDogumTarihi.Size = new Size(191, 23);
            dateTimePickerDogumTarihi.TabIndex = 22;
            // 
            // buttonOgrenciGuncelle
            // 
            buttonOgrenciGuncelle.Location = new Point(215, 399);
            buttonOgrenciGuncelle.Name = "buttonOgrenciGuncelle";
            buttonOgrenciGuncelle.Size = new Size(90, 38);
            buttonOgrenciGuncelle.TabIndex = 20;
            buttonOgrenciGuncelle.Text = "Öğrenci Güncelle";
            buttonOgrenciGuncelle.UseVisualStyleBackColor = true;
            buttonOgrenciGuncelle.Click += buttonOgrenciGuncelle_Click;
            // 
            // labelTemporarySinavID
            // 
            labelTemporarySinavID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTemporarySinavID.Location = new Point(15, 19);
            labelTemporarySinavID.Name = "labelTemporarySinavID";
            labelTemporarySinavID.Size = new Size(187, 84);
            labelTemporarySinavID.TabIndex = 19;
            labelTemporarySinavID.Text = "Bu alana sadece güncelleme yapacağınız zaman, güncellecemek istediğiniz öğrencinin mevcut numarasını seçiniz :";
            labelTemporarySinavID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonOgrenciEkle
            // 
            buttonOgrenciEkle.Location = new Point(328, 399);
            buttonOgrenciEkle.Name = "buttonOgrenciEkle";
            buttonOgrenciEkle.Size = new Size(87, 38);
            buttonOgrenciEkle.TabIndex = 15;
            buttonOgrenciEkle.Text = "Yeni Öğrenci Ekle";
            buttonOgrenciEkle.UseVisualStyleBackColor = true;
            buttonOgrenciEkle.Click += buttonOgrenciEkle_Click;
            // 
            // labelSoyad
            // 
            labelSoyad.AutoSize = true;
            labelSoyad.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSoyad.Location = new Point(11, 185);
            labelSoyad.Name = "labelSoyad";
            labelSoyad.Size = new Size(103, 16);
            labelSoyad.TabIndex = 6;
            labelSoyad.Text = "Öğrenci Soyismi :";
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelFirstName.Location = new Point(11, 152);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(78, 16);
            labelFirstName.TabIndex = 3;
            labelFirstName.Text = "Öğrenci Adı :";
            // 
            // labelDogumTarihi
            // 
            labelDogumTarihi.AutoSize = true;
            labelDogumTarihi.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDogumTarihi.Location = new Point(14, 221);
            labelDogumTarihi.Name = "labelDogumTarihi";
            labelDogumTarihi.Size = new Size(90, 16);
            labelDogumTarihi.TabIndex = 4;
            labelDogumTarihi.Text = "Doğum Tarihi :";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(dataGridViewDevamsizliklar);
            groupBox5.Location = new Point(1043, 474);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(492, 255);
            groupBox5.TabIndex = 44;
            groupBox5.TabStop = false;
            groupBox5.Text = "Devamsızlık Listesi";
            // 
            // dataGridViewDevamsizliklar
            // 
            dataGridViewDevamsizliklar.AllowUserToAddRows = false;
            dataGridViewDevamsizliklar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewDevamsizliklar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDevamsizliklar.Dock = DockStyle.Fill;
            dataGridViewDevamsizliklar.Location = new Point(3, 19);
            dataGridViewDevamsizliklar.Name = "dataGridViewDevamsizliklar";
            dataGridViewDevamsizliklar.RowTemplate.Height = 25;
            dataGridViewDevamsizliklar.Size = new Size(486, 233);
            dataGridViewDevamsizliklar.TabIndex = 0;
            // 
            // labelOgrenciCRUD
            // 
            labelOgrenciCRUD.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelOgrenciCRUD.Location = new Point(12, 6);
            labelOgrenciCRUD.Name = "labelOgrenciCRUD";
            labelOgrenciCRUD.Size = new Size(411, 18);
            labelOgrenciCRUD.TabIndex = 49;
            labelOgrenciCRUD.Text = "Öğrenci Ekleme/Güncelleme/Silme/Görüntüleme İşlemleri";
            // 
            // labelDevamsizlikCRUD
            // 
            labelDevamsizlikCRUD.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelDevamsizlikCRUD.Location = new Point(1069, 6);
            labelDevamsizlikCRUD.Name = "labelDevamsizlikCRUD";
            labelDevamsizlikCRUD.Size = new Size(441, 16);
            labelDevamsizlikCRUD.TabIndex = 51;
            labelDevamsizlikCRUD.Text = "Devamsızlık Ekleme/Güncelleme/Silme/Görüntüleme İşlemleri";
            // 
            // label3
            // 
            label3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 888);
            label3.Name = "label3";
            label3.Size = new Size(161, 36);
            label3.TabIndex = 60;
            label3.Text = "Silinecek öğrenci dersin ID değerini giriniz :";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(buttonOgrenciDersGuncelle);
            groupBox6.Controls.Add(dateTimePickerDerseKayitTarihi);
            groupBox6.Controls.Add(comboBoxTemporaryOgrenciDersID);
            groupBox6.Controls.Add(labelTemporaryOgrenciDersID);
            groupBox6.Controls.Add(labelDersID);
            groupBox6.Controls.Add(comboBoxDersID);
            groupBox6.Controls.Add(comboBoxOgrenciNo);
            groupBox6.Controls.Add(buttonOgrenciDersEkle);
            groupBox6.Controls.Add(labelOgrenciID);
            groupBox6.Controls.Add(labelDerseKayitTarihi);
            groupBox6.Location = new Point(12, 555);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(449, 325);
            groupBox6.TabIndex = 59;
            groupBox6.TabStop = false;
            // 
            // buttonOgrenciDersGuncelle
            // 
            buttonOgrenciDersGuncelle.Location = new Point(69, 225);
            buttonOgrenciDersGuncelle.Name = "buttonOgrenciDersGuncelle";
            buttonOgrenciDersGuncelle.Size = new Size(87, 38);
            buttonOgrenciDersGuncelle.TabIndex = 74;
            buttonOgrenciDersGuncelle.Text = "Öğrenci Ders Güncelle";
            buttonOgrenciDersGuncelle.UseVisualStyleBackColor = true;
            buttonOgrenciDersGuncelle.Click += buttonOgrenciDersGuncelle_Click;
            // 
            // dateTimePickerDerseKayitTarihi
            // 
            dateTimePickerDerseKayitTarihi.Location = new Point(149, 174);
            dateTimePickerDerseKayitTarihi.Name = "dateTimePickerDerseKayitTarihi";
            dateTimePickerDerseKayitTarihi.Size = new Size(191, 23);
            dateTimePickerDerseKayitTarihi.TabIndex = 73;
            // 
            // comboBoxTemporaryOgrenciDersID
            // 
            comboBoxTemporaryOgrenciDersID.FormattingEnabled = true;
            comboBoxTemporaryOgrenciDersID.Location = new Point(195, 39);
            comboBoxTemporaryOgrenciDersID.Name = "comboBoxTemporaryOgrenciDersID";
            comboBoxTemporaryOgrenciDersID.Size = new Size(121, 23);
            comboBoxTemporaryOgrenciDersID.TabIndex = 72;
            // 
            // labelTemporaryOgrenciDersID
            // 
            labelTemporaryOgrenciDersID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelTemporaryOgrenciDersID.Location = new Point(10, 19);
            labelTemporaryOgrenciDersID.Name = "labelTemporaryOgrenciDersID";
            labelTemporaryOgrenciDersID.Size = new Size(168, 67);
            labelTemporaryOgrenciDersID.TabIndex = 71;
            labelTemporaryOgrenciDersID.Text = "Bu alana sadece güncelleme yapacağınız zaman, güncelleyeceğiniz öğrencinin mevcut numarasını seçiniz :";
            labelTemporaryOgrenciDersID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelDersID
            // 
            labelDersID.AutoSize = true;
            labelDersID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDersID.Location = new Point(11, 141);
            labelDersID.Name = "labelDersID";
            labelDersID.Size = new Size(55, 16);
            labelDersID.TabIndex = 32;
            labelDersID.Text = "Ders ID :";
            // 
            // comboBoxDersID
            // 
            comboBoxDersID.FormattingEnabled = true;
            comboBoxDersID.Location = new Point(104, 139);
            comboBoxDersID.Name = "comboBoxDersID";
            comboBoxDersID.Size = new Size(121, 23);
            comboBoxDersID.TabIndex = 27;
            // 
            // comboBoxOgrenciNo
            // 
            comboBoxOgrenciNo.FormattingEnabled = true;
            comboBoxOgrenciNo.Location = new Point(104, 98);
            comboBoxOgrenciNo.Name = "comboBoxOgrenciNo";
            comboBoxOgrenciNo.Size = new Size(121, 23);
            comboBoxOgrenciNo.TabIndex = 26;
            // 
            // buttonOgrenciDersEkle
            // 
            buttonOgrenciDersEkle.Location = new Point(193, 225);
            buttonOgrenciDersEkle.Name = "buttonOgrenciDersEkle";
            buttonOgrenciDersEkle.Size = new Size(87, 38);
            buttonOgrenciDersEkle.TabIndex = 16;
            buttonOgrenciDersEkle.Text = "Öğrenci Ders Ekle";
            buttonOgrenciDersEkle.UseVisualStyleBackColor = true;
            buttonOgrenciDersEkle.Click += buttonOgrenciDersEkle_Click;
            // 
            // labelOgrenciID
            // 
            labelOgrenciID.AutoSize = true;
            labelOgrenciID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOgrenciID.Location = new Point(11, 100);
            labelOgrenciID.Name = "labelOgrenciID";
            labelOgrenciID.Size = new Size(74, 16);
            labelOgrenciID.TabIndex = 8;
            labelOgrenciID.Text = "Öğrenci No :";
            // 
            // labelDerseKayitTarihi
            // 
            labelDerseKayitTarihi.AutoSize = true;
            labelDerseKayitTarihi.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDerseKayitTarihi.Location = new Point(11, 179);
            labelDerseKayitTarihi.Name = "labelDerseKayitTarihi";
            labelDerseKayitTarihi.Size = new Size(117, 16);
            labelDerseKayitTarihi.TabIndex = 2;
            labelDerseKayitTarihi.Text = "Derse Kayıt Tarihi :";
            // 
            // labelOgrenciDersCRUD
            // 
            labelOgrenciDersCRUD.Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelOgrenciDersCRUD.Location = new Point(12, 534);
            labelOgrenciDersCRUD.Name = "labelOgrenciDersCRUD";
            labelOgrenciDersCRUD.Size = new Size(446, 18);
            labelOgrenciDersCRUD.TabIndex = 57;
            labelOgrenciDersCRUD.Text = "Öğrenci Ders Ekleme/Güncelleme/Silme/Görüntüleme İşlemleri";
            // 
            // buttonOgrenciDersleriGoruntule
            // 
            buttonOgrenciDersleriGoruntule.Location = new Point(655, 555);
            buttonOgrenciDersleriGoruntule.Name = "buttonOgrenciDersleriGoruntule";
            buttonOgrenciDersleriGoruntule.Size = new Size(113, 38);
            buttonOgrenciDersleriGoruntule.TabIndex = 58;
            buttonOgrenciDersleriGoruntule.Text = "Öğrenci Dersleri Görüntüle";
            buttonOgrenciDersleriGoruntule.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewOgrenciDersleri);
            groupBox4.Location = new Point(464, 594);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(505, 268);
            groupBox4.TabIndex = 57;
            groupBox4.TabStop = false;
            groupBox4.Text = "Öğrenci Ders Listesi";
            // 
            // dataGridViewOgrenciDersleri
            // 
            dataGridViewOgrenciDersleri.AllowUserToAddRows = false;
            dataGridViewOgrenciDersleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOgrenciDersleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOgrenciDersleri.Dock = DockStyle.Fill;
            dataGridViewOgrenciDersleri.Location = new Point(3, 19);
            dataGridViewOgrenciDersleri.Name = "dataGridViewOgrenciDersleri";
            dataGridViewOgrenciDersleri.RowTemplate.Height = 25;
            dataGridViewOgrenciDersleri.Size = new Size(499, 246);
            dataGridViewOgrenciDersleri.TabIndex = 0;
            // 
            // buttonDevamsizlikGoruntule
            // 
            buttonDevamsizlikGoruntule.Location = new Point(1233, 430);
            buttonDevamsizlikGoruntule.Name = "buttonDevamsizlikGoruntule";
            buttonDevamsizlikGoruntule.Size = new Size(113, 38);
            buttonDevamsizlikGoruntule.TabIndex = 70;
            buttonDevamsizlikGoruntule.Text = "Devamsızlıkları Görüntüle";
            buttonDevamsizlikGoruntule.UseVisualStyleBackColor = true;
            // 
            // buttonOgrenciDersSil
            // 
            buttonOgrenciDersSil.Location = new Point(336, 888);
            buttonOgrenciDersSil.Name = "buttonOgrenciDersSil";
            buttonOgrenciDersSil.Size = new Size(87, 38);
            buttonOgrenciDersSil.TabIndex = 71;
            buttonOgrenciDersSil.Text = "Öğrenci Ders Sil";
            buttonOgrenciDersSil.UseVisualStyleBackColor = true;
            buttonOgrenciDersSil.Click += buttonOgrenciDersSil_Click;
            // 
            // textBoxSilinecekOgrenciDers
            // 
            textBoxSilinecekOgrenciDers.Location = new Point(186, 897);
            textBoxSilinecekOgrenciDers.Name = "textBoxSilinecekOgrenciDers";
            textBoxSilinecekOgrenciDers.Size = new Size(131, 23);
            textBoxSilinecekOgrenciDers.TabIndex = 72;
            // 
            // FormOgrMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1539, 953);
            Controls.Add(textBoxSilinecekOgrenciDers);
            Controls.Add(buttonOgrenciDersSil);
            Controls.Add(buttonDevamsizlikGoruntule);
            Controls.Add(labelOgrenciDersCRUD);
            Controls.Add(label3);
            Controls.Add(groupBox6);
            Controls.Add(buttonOgrenciDersleriGoruntule);
            Controls.Add(groupBox4);
            Controls.Add(labelDevamsizlikCRUD);
            Controls.Add(labelOgrenciCRUD);
            Controls.Add(groupBox5);
            Controls.Add(buttonOgrencileriGoruntule);
            Controls.Add(buttonDevamsızlıkSil);
            Controls.Add(textBoxSilinecekDevamsizlikID);
            Controls.Add(labelSilinecekDevamsizlikID);
            Controls.Add(buttonOgrenciSil);
            Controls.Add(textBoxSilinecekOgrenci);
            Controls.Add(labelSilinecekRol);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormOgrMenu";
            Text = "Öğrenci İşlemleri Menüsü";
            Load += FormOgrMenu_Load;
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciler).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDevamsizliklar).EndInit();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOgrenciDersleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonOgrencileriGoruntule;
        private Button buttonDevamsızlıkSil;
        private TextBox textBoxSilinecekDevamsizlikID;
        private Label labelSilinecekDevamsizlikID;
        private Button buttonOgrenciSil;
        private TextBox textBoxSilinecekOgrenci;
        private Label labelSilinecekRol;
        private GroupBox groupBox3;
        private DataGridView dataGridViewOgrenciler;
        private GroupBox groupBox2;
        private Label labelOgrenciID;
        private Label label2;
        private TextBox textBoxAlinanPuan;
        private ComboBox comboBoxStudentID;
        private ComboBox comboBoxOgrenciDersID;
        private Label labelSonucIDValue;
        private Label labelTemporarySonucID;
        private Label label1;
        private Button buttonSinavDevamsizlikGuncelle;
        private Button buttonOgrenciDevamsizlikEkle;
        private Label labelOgrenciDersID;
        private Label labelSonucID;
        private Label labelAlinanPuan;
        private GroupBox groupBox1;
        private TextBox textBoxOgrenciSoyadi;
        private DateTimePicker dateTimePickerDogumTarihi;
        private Button buttonOgrenciGuncelle;
        private Label labelTemporarySinavID;
        private Button buttonOgrenciEkle;
        private Label labelSoyad;
        private Label labelFirstName;
        private Label labelDogumTarihi;
        private GroupBox groupBox5;
        private DataGridView dataGridViewDevamsizliklar;
        private Label labelOgrenciCRUD;
        private Label labelDevamsizlikCRUD;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
        private GroupBox groupBox6;
        private Label labelDersID;
        private Label label5;
        private TextBox textBox2;
        private ComboBox comboBoxDersID;
        private ComboBox comboBoxOgrenciNo;
        private Button button2;
        private Button buttonOgrenciDersEkle;
        private Label label9;
        private Label labelDerseKayitTarihi;
        private Label labelOgrenciDersCRUD;
        private Button buttonOgrenciDersleriGoruntule;
        private GroupBox groupBox4;
        private DataGridView dataGridViewOgrenciDersleri;
        private TextBox textBoxOgrenciAdi;
        private TextBox textBoxOgrenciCinsiyet;
        private Label labelCinsiyet;
        private Label label12;
        private DateTimePicker dateTimePickerKayitTarihi;
        private Label labelKayitTarihi;
        private TextBox textBoxOgrenciAlan;
        private Label labelOgrenciAlan;
        private Label labelOgrenciAdres;
        private RichTextBox richTextBoxOgrenciAdres;
        private Label labelTemporaryDevamsizlikID;
        private DateTimePicker dateTimePickerDevamsizlikTarihi;
        private Label labelDevamsizlikTarihi;
        private CheckBox checkBoxDevamsizlikBilgisi;
        private Label labelDevamsizlikBilgisi;
        private Button buttonDevamsizlikGoruntule;
        private Label labelTemporaryOgrenciDersID;
        private ComboBox comboBoxTemporaryStudentID;
        private ComboBox comboBoxTemporaryOgrenciDersID;
        private ComboBox comboBoxTemporaryDevamsizlikID;
        private Button buttonOgrenciDersGuncelle;
        private DateTimePicker dateTimePickerDerseKayitTarihi;
        private Button buttonOgrenciDersSil;
        private TextBox textBoxSilinecekOgrenciDers;
        private TextBox textBoxStudentID;
        private Label labelStudentID;
    }
}