namespace DershaneYonetimSistemi
{
    partial class FormExamMenu
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
            buttonSinavSonucSil = new Button();
            textBoxSilinecekSinavSonucID = new TextBox();
            labelSilinecekSinavSonucID = new Label();
            buttonSinavSil = new Button();
            textBoxSilinecekSinav = new TextBox();
            labelSilinecekRol = new Label();
            groupBox4 = new GroupBox();
            dataGridViewSinavSonuclari = new DataGridView();
            groupBox3 = new GroupBox();
            dataGridViewSinavlar = new DataGridView();
            groupBox2 = new GroupBox();
            label2 = new Label();
            textBoxAlinanPuan = new TextBox();
            comboBoxStudentID = new ComboBox();
            comboBoxSinavIDforSınavSonuc = new ComboBox();
            textBoxTemporaryResultID = new TextBox();
            labelSonucIDValue = new Label();
            labelTemporarySonucID = new Label();
            label1 = new Label();
            buttonSinavSonucGuncelle = new Button();
            buttonSinavSonucEkle = new Button();
            labelExamID = new Label();
            labelSonucID = new Label();
            labelAlinanPuan = new Label();
            groupBox1 = new GroupBox();
            labelSinavIDValue = new Label();
            comboBoxCourseID = new ComboBox();
            textBoxSinavIsmi = new TextBox();
            dateTimePickerSinavTarihi = new DateTimePicker();
            textBoxTemporarySinavID = new TextBox();
            buttonSinavGuncelle = new Button();
            labelTemporarySinavID = new Label();
            buttonSinavEkle = new Button();
            labelSinavIsmi = new Label();
            labelSınavID = new Label();
            labelCourseID = new Label();
            labelSinavTarihi = new Label();
            buttonSinavlariGoruntule = new Button();
            buttonSinavSonucGoruntule = new Button();
            labelOgrenciID = new Label();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinavSonuclari).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinavlar).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonSinavSonucSil
            // 
            buttonSinavSonucSil.Location = new Point(1196, 307);
            buttonSinavSonucSil.Name = "buttonSinavSonucSil";
            buttonSinavSonucSil.Size = new Size(87, 38);
            buttonSinavSonucSil.TabIndex = 29;
            buttonSinavSonucSil.Text = "Sınav sonucunu sil";
            buttonSinavSonucSil.UseVisualStyleBackColor = true;
            buttonSinavSonucSil.Click += buttonSinavSonucSil_Click;
            // 
            // textBoxSilinecekSinavSonucID
            // 
            textBoxSilinecekSinavSonucID.Location = new Point(1066, 316);
            textBoxSilinecekSinavSonucID.Name = "textBoxSilinecekSinavSonucID";
            textBoxSilinecekSinavSonucID.Size = new Size(118, 23);
            textBoxSilinecekSinavSonucID.TabIndex = 28;
            // 
            // labelSilinecekSinavSonucID
            // 
            labelSilinecekSinavSonucID.AutoSize = true;
            labelSilinecekSinavSonucID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSilinecekSinavSonucID.Location = new Point(798, 318);
            labelSilinecekSinavSonucID.Name = "labelSilinecekSinavSonucID";
            labelSilinecekSinavSonucID.Size = new Size(262, 16);
            labelSilinecekSinavSonucID.TabIndex = 27;
            labelSilinecekSinavSonucID.Text = "Silinecek sınav sonucunun ID değerini giriniz :";
            // 
            // buttonSinavSil
            // 
            buttonSinavSil.Location = new Point(509, 298);
            buttonSinavSil.Name = "buttonSinavSil";
            buttonSinavSil.Size = new Size(87, 38);
            buttonSinavSil.TabIndex = 26;
            buttonSinavSil.Text = "Sınavı Sil";
            buttonSinavSil.UseVisualStyleBackColor = true;
            buttonSinavSil.Click += buttonSinavSil_Click;
            // 
            // textBoxSilinecekSinav
            // 
            textBoxSilinecekSinav.Location = new Point(363, 307);
            textBoxSilinecekSinav.Name = "textBoxSilinecekSinav";
            textBoxSilinecekSinav.Size = new Size(118, 23);
            textBoxSilinecekSinav.TabIndex = 25;
            // 
            // labelSilinecekRol
            // 
            labelSilinecekRol.AutoSize = true;
            labelSilinecekRol.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSilinecekRol.Location = new Point(144, 309);
            labelSilinecekRol.Name = "labelSilinecekRol";
            labelSilinecekRol.Size = new Size(213, 16);
            labelSilinecekRol.TabIndex = 24;
            labelSilinecekRol.Text = "Silinecek Sınavın ID değerini giriniz :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewSinavSonuclari);
            groupBox4.Location = new Point(735, 401);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(597, 266);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Sonuç Listesi";
            // 
            // dataGridViewSinavSonuclari
            // 
            dataGridViewSinavSonuclari.AllowUserToAddRows = false;
            dataGridViewSinavSonuclari.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSinavSonuclari.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinavSonuclari.Dock = DockStyle.Fill;
            dataGridViewSinavSonuclari.Location = new Point(3, 19);
            dataGridViewSinavSonuclari.Name = "dataGridViewSinavSonuclari";
            dataGridViewSinavSonuclari.RowTemplate.Height = 25;
            dataGridViewSinavSonuclari.Size = new Size(591, 244);
            dataGridViewSinavSonuclari.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewSinavlar);
            groupBox3.Location = new Point(51, 402);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(650, 269);
            groupBox3.TabIndex = 22;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınav Listesi";
            // 
            // dataGridViewSinavlar
            // 
            dataGridViewSinavlar.AllowUserToAddRows = false;
            dataGridViewSinavlar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewSinavlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSinavlar.Dock = DockStyle.Fill;
            dataGridViewSinavlar.Location = new Point(3, 19);
            dataGridViewSinavlar.Name = "dataGridViewSinavlar";
            dataGridViewSinavlar.RowTemplate.Height = 25;
            dataGridViewSinavlar.Size = new Size(644, 247);
            dataGridViewSinavlar.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(labelOgrenciID);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxAlinanPuan);
            groupBox2.Controls.Add(comboBoxStudentID);
            groupBox2.Controls.Add(comboBoxSinavIDforSınavSonuc);
            groupBox2.Controls.Add(textBoxTemporaryResultID);
            groupBox2.Controls.Add(labelSonucIDValue);
            groupBox2.Controls.Add(labelTemporarySonucID);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(buttonSinavSonucGuncelle);
            groupBox2.Controls.Add(buttonSinavSonucEkle);
            groupBox2.Controls.Add(labelExamID);
            groupBox2.Controls.Add(labelSonucID);
            groupBox2.Controls.Add(labelAlinanPuan);
            groupBox2.Location = new Point(831, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 280);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Sonuç İşlemleri";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 176);
            label2.Name = "label2";
            label2.Size = new Size(101, 37);
            label2.TabIndex = 32;
            label2.Text = "(Lütfen 0-100 arasında bir sayı giriniz)";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxAlinanPuan
            // 
            textBoxAlinanPuan.Location = new Point(113, 158);
            textBoxAlinanPuan.Name = "textBoxAlinanPuan";
            textBoxAlinanPuan.Size = new Size(118, 23);
            textBoxAlinanPuan.TabIndex = 28;
            // 
            // comboBoxStudentID
            // 
            comboBoxStudentID.FormattingEnabled = true;
            comboBoxStudentID.Location = new Point(110, 120);
            comboBoxStudentID.Name = "comboBoxStudentID";
            comboBoxStudentID.Size = new Size(121, 23);
            comboBoxStudentID.TabIndex = 27;
            // 
            // comboBoxSinavIDforSınavSonuc
            // 
            comboBoxSinavIDforSınavSonuc.FormattingEnabled = true;
            comboBoxSinavIDforSınavSonuc.Location = new Point(110, 79);
            comboBoxSinavIDforSınavSonuc.Name = "comboBoxSinavIDforSınavSonuc";
            comboBoxSinavIDforSınavSonuc.Size = new Size(121, 23);
            comboBoxSinavIDforSınavSonuc.TabIndex = 26;
            // 
            // textBoxTemporaryResultID
            // 
            textBoxTemporaryResultID.Location = new Point(268, 50);
            textBoxTemporaryResultID.Name = "textBoxTemporaryResultID";
            textBoxTemporaryResultID.Size = new Size(118, 23);
            textBoxTemporaryResultID.TabIndex = 21;
            // 
            // labelSonucIDValue
            // 
            labelSonucIDValue.AutoSize = true;
            labelSonucIDValue.Location = new Point(141, 42);
            labelSonucIDValue.Name = "labelSonucIDValue";
            labelSonucIDValue.Size = new Size(12, 15);
            labelSonucIDValue.TabIndex = 19;
            labelSonucIDValue.Text = "-";
            // 
            // labelTemporarySonucID
            // 
            labelTemporarySonucID.Location = new Point(243, 6);
            labelTemporarySonucID.Name = "labelTemporarySonucID";
            labelTemporarySonucID.Size = new Size(209, 48);
            labelTemporarySonucID.TabIndex = 20;
            labelTemporarySonucID.Text = "Güncelleme yapmak istediğiniz sınavın mevcut ID değerini giriniz.";
            labelTemporarySonucID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 42);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // buttonSinavSonucGuncelle
            // 
            buttonSinavSonucGuncelle.Location = new Point(30, 236);
            buttonSinavSonucGuncelle.Name = "buttonSinavSonucGuncelle";
            buttonSinavSonucGuncelle.Size = new Size(87, 38);
            buttonSinavSonucGuncelle.TabIndex = 17;
            buttonSinavSonucGuncelle.Text = "Sınav Sonuç Güncelle";
            buttonSinavSonucGuncelle.UseVisualStyleBackColor = true;
            buttonSinavSonucGuncelle.Click += buttonSinavSonucGuncelle_Click;
            // 
            // buttonSinavSonucEkle
            // 
            buttonSinavSonucEkle.Location = new Point(142, 236);
            buttonSinavSonucEkle.Name = "buttonSinavSonucEkle";
            buttonSinavSonucEkle.Size = new Size(87, 38);
            buttonSinavSonucEkle.TabIndex = 16;
            buttonSinavSonucEkle.Text = "Sınav Sonuç Ekle";
            buttonSinavSonucEkle.UseVisualStyleBackColor = true;
            buttonSinavSonucEkle.Click += buttonSinavSonucEkle_Click;
            // 
            // labelExamID
            // 
            labelExamID.AutoSize = true;
            labelExamID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelExamID.Location = new Point(17, 81);
            labelExamID.Name = "labelExamID";
            labelExamID.Size = new Size(61, 16);
            labelExamID.TabIndex = 8;
            labelExamID.Text = "Sınav ID :";
            // 
            // labelSonucID
            // 
            labelSonucID.AutoSize = true;
            labelSonucID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSonucID.Location = new Point(17, 41);
            labelSonucID.Name = "labelSonucID";
            labelSonucID.Size = new Size(62, 16);
            labelSonucID.TabIndex = 7;
            labelSonucID.Text = "Sonuç ID :";
            // 
            // labelAlinanPuan
            // 
            labelAlinanPuan.AutoSize = true;
            labelAlinanPuan.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelAlinanPuan.Location = new Point(17, 160);
            labelAlinanPuan.Name = "labelAlinanPuan";
            labelAlinanPuan.Size = new Size(83, 16);
            labelAlinanPuan.TabIndex = 2;
            labelAlinanPuan.Text = "Alınan Puan :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelSinavIDValue);
            groupBox1.Controls.Add(comboBoxCourseID);
            groupBox1.Controls.Add(textBoxSinavIsmi);
            groupBox1.Controls.Add(dateTimePickerSinavTarihi);
            groupBox1.Controls.Add(textBoxTemporarySinavID);
            groupBox1.Controls.Add(buttonSinavGuncelle);
            groupBox1.Controls.Add(labelTemporarySinavID);
            groupBox1.Controls.Add(buttonSinavEkle);
            groupBox1.Controls.Add(labelSinavIsmi);
            groupBox1.Controls.Add(labelSınavID);
            groupBox1.Controls.Add(labelCourseID);
            groupBox1.Controls.Add(labelSinavTarihi);
            groupBox1.Location = new Point(166, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 280);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Sınav İşlemleri";
            // 
            // labelSinavIDValue
            // 
            labelSinavIDValue.AutoSize = true;
            labelSinavIDValue.Location = new Point(88, 53);
            labelSinavIDValue.Name = "labelSinavIDValue";
            labelSinavIDValue.Size = new Size(12, 15);
            labelSinavIDValue.TabIndex = 26;
            labelSinavIDValue.Text = "-";
            // 
            // comboBoxCourseID
            // 
            comboBoxCourseID.FormattingEnabled = true;
            comboBoxCourseID.Location = new Point(89, 87);
            comboBoxCourseID.Name = "comboBoxCourseID";
            comboBoxCourseID.Size = new Size(121, 23);
            comboBoxCourseID.TabIndex = 25;
            // 
            // textBoxSinavIsmi
            // 
            textBoxSinavIsmi.Location = new Point(92, 120);
            textBoxSinavIsmi.Name = "textBoxSinavIsmi";
            textBoxSinavIsmi.Size = new Size(118, 23);
            textBoxSinavIsmi.TabIndex = 23;
            // 
            // dateTimePickerSinavTarihi
            // 
            dateTimePickerSinavTarihi.Location = new Point(92, 153);
            dateTimePickerSinavTarihi.Name = "dateTimePickerSinavTarihi";
            dateTimePickerSinavTarihi.Size = new Size(191, 23);
            dateTimePickerSinavTarihi.TabIndex = 22;
            // 
            // textBoxTemporarySinavID
            // 
            textBoxTemporarySinavID.Location = new Point(240, 46);
            textBoxTemporarySinavID.Name = "textBoxTemporarySinavID";
            textBoxTemporarySinavID.Size = new Size(100, 23);
            textBoxTemporarySinavID.TabIndex = 21;
            // 
            // buttonSinavGuncelle
            // 
            buttonSinavGuncelle.Location = new Point(37, 222);
            buttonSinavGuncelle.Name = "buttonSinavGuncelle";
            buttonSinavGuncelle.Size = new Size(90, 38);
            buttonSinavGuncelle.TabIndex = 20;
            buttonSinavGuncelle.Text = "Sınav Güncelle";
            buttonSinavGuncelle.UseVisualStyleBackColor = true;
            buttonSinavGuncelle.Click += buttonSinavGuncelle_Click;
            // 
            // labelTemporarySinavID
            // 
            labelTemporarySinavID.Location = new Point(210, 9);
            labelTemporarySinavID.Name = "labelTemporarySinavID";
            labelTemporarySinavID.Size = new Size(199, 34);
            labelTemporarySinavID.TabIndex = 19;
            labelTemporarySinavID.Text = "Güncelleme yapmak istediğiniz sınavın mevcut ID değerini giriniz";
            labelTemporarySinavID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonSinavEkle
            // 
            buttonSinavEkle.Location = new Point(164, 222);
            buttonSinavEkle.Name = "buttonSinavEkle";
            buttonSinavEkle.Size = new Size(87, 38);
            buttonSinavEkle.TabIndex = 15;
            buttonSinavEkle.Text = "Yeni Sınav Ekle";
            buttonSinavEkle.UseVisualStyleBackColor = true;
            buttonSinavEkle.Click += buttonSinavEkle_Click;
            // 
            // labelSinavIsmi
            // 
            labelSinavIsmi.AutoSize = true;
            labelSinavIsmi.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSinavIsmi.Location = new Point(10, 122);
            labelSinavIsmi.Name = "labelSinavIsmi";
            labelSinavIsmi.Size = new Size(76, 16);
            labelSinavIsmi.TabIndex = 6;
            labelSinavIsmi.Text = "Sınav İsmi : ";
            // 
            // labelSınavID
            // 
            labelSınavID.AutoSize = true;
            labelSınavID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSınavID.Location = new Point(9, 53);
            labelSınavID.Name = "labelSınavID";
            labelSınavID.Size = new Size(64, 16);
            labelSınavID.TabIndex = 10;
            labelSınavID.Text = "Sınav ID : ";
            // 
            // labelCourseID
            // 
            labelCourseID.AutoSize = true;
            labelCourseID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCourseID.Location = new Point(10, 89);
            labelCourseID.Name = "labelCourseID";
            labelCourseID.Size = new Size(68, 16);
            labelCourseID.TabIndex = 3;
            labelCourseID.Text = "Course ID :";
            // 
            // labelSinavTarihi
            // 
            labelSinavTarihi.AutoSize = true;
            labelSinavTarihi.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSinavTarihi.Location = new Point(10, 155);
            labelSinavTarihi.Name = "labelSinavTarihi";
            labelSinavTarihi.Size = new Size(83, 16);
            labelSinavTarihi.TabIndex = 4;
            labelSinavTarihi.Text = "Sınav Tarihi :";
            // 
            // buttonSinavlariGoruntule
            // 
            buttonSinavlariGoruntule.Location = new Point(330, 358);
            buttonSinavlariGoruntule.Name = "buttonSinavlariGoruntule";
            buttonSinavlariGoruntule.Size = new Size(108, 38);
            buttonSinavlariGoruntule.TabIndex = 30;
            buttonSinavlariGoruntule.Text = "Sınavları Görüntüle";
            buttonSinavlariGoruntule.UseVisualStyleBackColor = true;
            // 
            // buttonSinavSonucGoruntule
            // 
            buttonSinavSonucGoruntule.Location = new Point(998, 368);
            buttonSinavSonucGoruntule.Name = "buttonSinavSonucGoruntule";
            buttonSinavSonucGoruntule.Size = new Size(113, 38);
            buttonSinavSonucGoruntule.TabIndex = 31;
            buttonSinavSonucGoruntule.Text = "Sınav Sonuçlarını Görüntüle";
            buttonSinavSonucGoruntule.UseVisualStyleBackColor = true;
            // 
            // labelOgrenciID
            // 
            labelOgrenciID.AutoSize = true;
            labelOgrenciID.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelOgrenciID.Location = new Point(17, 122);
            labelOgrenciID.Name = "labelOgrenciID";
            labelOgrenciID.Size = new Size(71, 16);
            labelOgrenciID.TabIndex = 32;
            labelOgrenciID.Text = "Öğrenci ID :";
            // 
            // FormExamMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 679);
            Controls.Add(buttonSinavSonucGoruntule);
            Controls.Add(buttonSinavlariGoruntule);
            Controls.Add(buttonSinavSonucSil);
            Controls.Add(textBoxSilinecekSinavSonucID);
            Controls.Add(labelSilinecekSinavSonucID);
            Controls.Add(buttonSinavSil);
            Controls.Add(textBoxSilinecekSinav);
            Controls.Add(labelSilinecekRol);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormExamMenu";
            Text = "Sınav İşlemleri Menüsü";
            Load += FormExamMenu_Load;
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinavSonuclari).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewSinavlar).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSinavSonucSil;
        private TextBox textBoxSilinecekSinavSonucID;
        private Label labelSilinecekSinavSonucID;
        private Button buttonSinavSil;
        private TextBox textBoxSilinecekSinav;
        private Label labelSilinecekRol;
        private GroupBox groupBox4;
        private DataGridView dataGridViewSinavSonuclari;
        private GroupBox groupBox3;
        private DataGridView dataGridViewSinavlar;
        private GroupBox groupBox2;
        private TextBox textBoxTemporaryResultID;
        private Label labelSonucIDValue;
        private Label labelTemporarySonucID;
        private Label label1;
        private Button buttonSinavSonucGuncelle;
        private Button buttonSinavSonucEkle;
        private TextBox textBoxSifre;
        private TextBox textBoxKullanıcıAdı;
        private Label label3;
        private Label labelExamID;
        private Label labelSonucID;
        private Label labelAlinanPuan;
        private GroupBox groupBox1;
        private TextBox textBoxTemporarySinavID;
        private Button buttonSinavGuncelle;
        private Label labelTemporarySinavID;
        private CheckBox checkBoxCanUpdate;
        private CheckBox checkBoxCanDelete;
        private CheckBox checkBoxCanInsert;
        private CheckBox checkBoxCanRead;
        private Button buttonSinavEkle;
        private Label labelSinavIsmi;
        private Label labelSınavID;
        private Label labelCanUpdate;
        private Label labelCourseID;
        private Label labelSinavTarihi;
        private Label labelSinavIDValue;
        private ComboBox comboBoxCourseID;
        private TextBox textBoxSinavIsmi;
        private DateTimePicker dateTimePickerSinavTarihi;
        private ComboBox comboBoxStudentID;
        private ComboBox comboBoxSinavIDforSınavSonuc;
        private TextBox textBoxAlinanPuan;
        private Button buttonSinavlariGoruntule;
        private Button buttonSinavSonucGoruntule;
        private Label label2;
        private Label labelOgrenciID;
    }
}