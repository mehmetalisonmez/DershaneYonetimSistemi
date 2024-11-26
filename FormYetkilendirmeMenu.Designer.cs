namespace DershaneYonetimSistemi
{
    partial class FormYetkilendirmeMenu
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
            groupBox1 = new GroupBox();
            textBoxTemporaryRol = new TextBox();
            buttonRolGuncelle = new Button();
            labelTemporaryRol = new Label();
            checkBoxCanUpdate = new CheckBox();
            checkBoxCanDelete = new CheckBox();
            checkBoxCanInsert = new CheckBox();
            checkBoxCanRead = new CheckBox();
            buttonRolEkle = new Button();
            textBoxRol = new TextBox();
            labelCanInsert = new Label();
            label4 = new Label();
            labelCanUpdate = new Label();
            labelCanRead = new Label();
            labelCanDelete = new Label();
            groupBox2 = new GroupBox();
            comboBoxKullaniciRolleri = new ComboBox();
            textBoxTemporaryYoneticiID = new TextBox();
            labelYonetici = new Label();
            labelTemporaryYoneticiID = new Label();
            label1 = new Label();
            buttonKullaniciGuncelle = new Button();
            buttonKullaniciEkle = new Button();
            textBoxSifre = new TextBox();
            textBoxKullanıcıAdı = new TextBox();
            label3 = new Label();
            labelKullaniciAdi = new Label();
            labelYoneticiId = new Label();
            labelRol = new Label();
            groupBox3 = new GroupBox();
            dataGridViewRoller = new DataGridView();
            groupBox4 = new GroupBox();
            dataGridViewKullanicilar = new DataGridView();
            labelSilinecekRol = new Label();
            textBoxsilinecekRol = new TextBox();
            buttonRolSil = new Button();
            buttonKullaniciSil = new Button();
            textBoxSilinecekKullanici = new TextBox();
            labelSilinecekKullanici = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoller).BeginInit();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKullanicilar).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxTemporaryRol);
            groupBox1.Controls.Add(buttonRolGuncelle);
            groupBox1.Controls.Add(labelTemporaryRol);
            groupBox1.Controls.Add(checkBoxCanUpdate);
            groupBox1.Controls.Add(checkBoxCanDelete);
            groupBox1.Controls.Add(checkBoxCanInsert);
            groupBox1.Controls.Add(checkBoxCanRead);
            groupBox1.Controls.Add(buttonRolEkle);
            groupBox1.Controls.Add(textBoxRol);
            groupBox1.Controls.Add(labelCanInsert);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(labelCanUpdate);
            groupBox1.Controls.Add(labelCanRead);
            groupBox1.Controls.Add(labelCanDelete);
            groupBox1.Location = new Point(68, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(436, 304);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rol İşlemleri";
            // 
            // textBoxTemporaryRol
            // 
            textBoxTemporaryRol.Location = new Point(245, 46);
            textBoxTemporaryRol.Name = "textBoxTemporaryRol";
            textBoxTemporaryRol.Size = new Size(100, 23);
            textBoxTemporaryRol.TabIndex = 21;
            // 
            // buttonRolGuncelle
            // 
            buttonRolGuncelle.Location = new Point(39, 247);
            buttonRolGuncelle.Name = "buttonRolGuncelle";
            buttonRolGuncelle.Size = new Size(87, 38);
            buttonRolGuncelle.TabIndex = 20;
            buttonRolGuncelle.Text = "Rol Güncelle";
            buttonRolGuncelle.UseVisualStyleBackColor = true;
            buttonRolGuncelle.Click += buttonRolGuncelle_Click;
            // 
            // labelTemporaryRol
            // 
            labelTemporaryRol.Location = new Point(210, 9);
            labelTemporaryRol.Name = "labelTemporaryRol";
            labelTemporaryRol.Size = new Size(185, 34);
            labelTemporaryRol.TabIndex = 19;
            labelTemporaryRol.Text = "Güncelleme yapmak istediğiniz rol adının mevcut halini giriniz";
            labelTemporaryRol.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxCanUpdate
            // 
            checkBoxCanUpdate.AutoSize = true;
            checkBoxCanUpdate.Location = new Point(164, 210);
            checkBoxCanUpdate.Name = "checkBoxCanUpdate";
            checkBoxCanUpdate.Size = new Size(15, 14);
            checkBoxCanUpdate.TabIndex = 18;
            checkBoxCanUpdate.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanDelete
            // 
            checkBoxCanDelete.AutoSize = true;
            checkBoxCanDelete.Location = new Point(143, 171);
            checkBoxCanDelete.Name = "checkBoxCanDelete";
            checkBoxCanDelete.Size = new Size(15, 14);
            checkBoxCanDelete.TabIndex = 17;
            checkBoxCanDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanInsert
            // 
            checkBoxCanInsert.AutoSize = true;
            checkBoxCanInsert.Location = new Point(143, 133);
            checkBoxCanInsert.Name = "checkBoxCanInsert";
            checkBoxCanInsert.Size = new Size(15, 14);
            checkBoxCanInsert.TabIndex = 16;
            checkBoxCanInsert.UseVisualStyleBackColor = true;
            // 
            // checkBoxCanRead
            // 
            checkBoxCanRead.AutoSize = true;
            checkBoxCanRead.Location = new Point(143, 90);
            checkBoxCanRead.Name = "checkBoxCanRead";
            checkBoxCanRead.Size = new Size(15, 14);
            checkBoxCanRead.TabIndex = 4;
            checkBoxCanRead.UseVisualStyleBackColor = true;
            // 
            // buttonRolEkle
            // 
            buttonRolEkle.Location = new Point(164, 247);
            buttonRolEkle.Name = "buttonRolEkle";
            buttonRolEkle.Size = new Size(87, 38);
            buttonRolEkle.TabIndex = 15;
            buttonRolEkle.Text = "Yeni Rol Ekle";
            buttonRolEkle.UseVisualStyleBackColor = true;
            buttonRolEkle.Click += buttonRolEkle_Click;
            // 
            // textBoxRol
            // 
            textBoxRol.Location = new Point(61, 51);
            textBoxRol.Name = "textBoxRol";
            textBoxRol.Size = new Size(118, 23);
            textBoxRol.TabIndex = 13;
            // 
            // labelCanInsert
            // 
            labelCanInsert.AutoSize = true;
            labelCanInsert.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCanInsert.Location = new Point(9, 131);
            labelCanInsert.Name = "labelCanInsert";
            labelCanInsert.Size = new Size(126, 16);
            labelCanInsert.TabIndex = 6;
            labelCanInsert.Text = "Veri Ekleme Yetkisi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(9, 53);
            label4.Name = "label4";
            label4.Size = new Size(35, 16);
            label4.TabIndex = 10;
            label4.Text = "Rol : ";
            // 
            // labelCanUpdate
            // 
            labelCanUpdate.AutoSize = true;
            labelCanUpdate.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCanUpdate.Location = new Point(9, 208);
            labelCanUpdate.Name = "labelCanUpdate";
            labelCanUpdate.Size = new Size(149, 16);
            labelCanUpdate.TabIndex = 5;
            labelCanUpdate.Text = "Veri Güncelleme Yetkisi :";
            // 
            // labelCanRead
            // 
            labelCanRead.AutoSize = true;
            labelCanRead.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCanRead.Location = new Point(9, 88);
            labelCanRead.Name = "labelCanRead";
            labelCanRead.Size = new Size(125, 16);
            labelCanRead.TabIndex = 3;
            labelCanRead.Text = "Veri Okuma Yetkisi :";
            // 
            // labelCanDelete
            // 
            labelCanDelete.AutoSize = true;
            labelCanDelete.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelCanDelete.Location = new Point(9, 171);
            labelCanDelete.Name = "labelCanDelete";
            labelCanDelete.Size = new Size(117, 16);
            labelCanDelete.TabIndex = 4;
            labelCanDelete.Text = "Veri Silme Yetkisi :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(comboBoxKullaniciRolleri);
            groupBox2.Controls.Add(textBoxTemporaryYoneticiID);
            groupBox2.Controls.Add(labelYonetici);
            groupBox2.Controls.Add(labelTemporaryYoneticiID);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(buttonKullaniciGuncelle);
            groupBox2.Controls.Add(buttonKullaniciEkle);
            groupBox2.Controls.Add(textBoxSifre);
            groupBox2.Controls.Add(textBoxKullanıcıAdı);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(labelKullaniciAdi);
            groupBox2.Controls.Add(labelYoneticiId);
            groupBox2.Controls.Add(labelRol);
            groupBox2.Location = new Point(755, 15);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(449, 271);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kullanıcı İşlemleri";
            // 
            // comboBoxKullaniciRolleri
            // 
            comboBoxKullaniciRolleri.FormattingEnabled = true;
            comboBoxKullaniciRolleri.Location = new Point(109, 150);
            comboBoxKullaniciRolleri.Name = "comboBoxKullaniciRolleri";
            comboBoxKullaniciRolleri.Size = new Size(121, 23);
            comboBoxKullaniciRolleri.TabIndex = 22;
            // 
            // textBoxTemporaryYoneticiID
            // 
            textBoxTemporaryYoneticiID.Location = new Point(263, 50);
            textBoxTemporaryYoneticiID.Name = "textBoxTemporaryYoneticiID";
            textBoxTemporaryYoneticiID.Size = new Size(118, 23);
            textBoxTemporaryYoneticiID.TabIndex = 21;
            // 
            // labelYonetici
            // 
            labelYonetici.AutoSize = true;
            labelYonetici.Location = new Point(128, 43);
            labelYonetici.Name = "labelYonetici";
            labelYonetici.Size = new Size(12, 15);
            labelYonetici.TabIndex = 19;
            labelYonetici.Text = "-";
            // 
            // labelTemporaryYoneticiID
            // 
            labelTemporaryYoneticiID.Location = new Point(234, 6);
            labelTemporaryYoneticiID.Name = "labelTemporaryYoneticiID";
            labelTemporaryYoneticiID.Size = new Size(209, 47);
            labelTemporaryYoneticiID.TabIndex = 20;
            labelTemporaryYoneticiID.Text = "Güncelleme yapmak istediğiniz yöneticinin mevcut ID değerini girniz.";
            labelTemporaryYoneticiID.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 42);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 18;
            // 
            // buttonKullaniciGuncelle
            // 
            buttonKullaniciGuncelle.Location = new Point(30, 194);
            buttonKullaniciGuncelle.Name = "buttonKullaniciGuncelle";
            buttonKullaniciGuncelle.Size = new Size(87, 38);
            buttonKullaniciGuncelle.TabIndex = 17;
            buttonKullaniciGuncelle.Text = "Kullanıcı Güncelle";
            buttonKullaniciGuncelle.UseVisualStyleBackColor = true;
            buttonKullaniciGuncelle.Click += buttonKullaniciGuncelle_Click;
            // 
            // buttonKullaniciEkle
            // 
            buttonKullaniciEkle.Location = new Point(168, 196);
            buttonKullaniciEkle.Name = "buttonKullaniciEkle";
            buttonKullaniciEkle.Size = new Size(87, 38);
            buttonKullaniciEkle.TabIndex = 16;
            buttonKullaniciEkle.Text = "Yeni Kullanıcı Ekle";
            buttonKullaniciEkle.UseVisualStyleBackColor = true;
            buttonKullaniciEkle.Click += buttonKullaniciEkle_Click;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(106, 115);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(118, 23);
            textBoxSifre.TabIndex = 12;
            // 
            // textBoxKullanıcıAdı
            // 
            textBoxKullanıcıAdı.Location = new Point(106, 79);
            textBoxKullanıcıAdı.Name = "textBoxKullanıcıAdı";
            textBoxKullanıcıAdı.Size = new Size(118, 23);
            textBoxKullanıcıAdı.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(17, 117);
            label3.Name = "label3";
            label3.Size = new Size(40, 16);
            label3.TabIndex = 9;
            label3.Text = "Şifre :";
            // 
            // labelKullaniciAdi
            // 
            labelKullaniciAdi.AutoSize = true;
            labelKullaniciAdi.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelKullaniciAdi.Location = new Point(17, 81);
            labelKullaniciAdi.Name = "labelKullaniciAdi";
            labelKullaniciAdi.Size = new Size(87, 16);
            labelKullaniciAdi.TabIndex = 8;
            labelKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // labelYoneticiId
            // 
            labelYoneticiId.AutoSize = true;
            labelYoneticiId.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelYoneticiId.Location = new Point(17, 41);
            labelYoneticiId.Name = "labelYoneticiId";
            labelYoneticiId.Size = new Size(77, 16);
            labelYoneticiId.TabIndex = 7;
            labelYoneticiId.Text = "Yonetici ID : ";
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelRol.Location = new Point(17, 152);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(86, 16);
            labelRol.TabIndex = 2;
            labelRol.Text = "Kullanıcı Rol :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dataGridViewRoller);
            groupBox3.Location = new Point(21, 396);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(627, 269);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Rol Listesi";
            // 
            // dataGridViewRoller
            // 
            dataGridViewRoller.AllowUserToAddRows = false;
            dataGridViewRoller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewRoller.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoller.Dock = DockStyle.Fill;
            dataGridViewRoller.Location = new Point(3, 19);
            dataGridViewRoller.Name = "dataGridViewRoller";
            dataGridViewRoller.RowTemplate.Height = 25;
            dataGridViewRoller.Size = new Size(621, 247);
            dataGridViewRoller.TabIndex = 0;
            dataGridViewRoller.CellClick += dataGridViewRoller_CellClick;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridViewKullanicilar);
            groupBox4.Location = new Point(651, 396);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(556, 266);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Kullanıcı Listesi";
            // 
            // dataGridViewKullanicilar
            // 
            dataGridViewKullanicilar.AllowUserToAddRows = false;
            dataGridViewKullanicilar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKullanicilar.Dock = DockStyle.Fill;
            dataGridViewKullanicilar.Location = new Point(3, 19);
            dataGridViewKullanicilar.Name = "dataGridViewKullanicilar";
            dataGridViewKullanicilar.RowTemplate.Height = 25;
            dataGridViewKullanicilar.Size = new Size(550, 244);
            dataGridViewKullanicilar.TabIndex = 0;
            dataGridViewKullanicilar.CellClick += dataGridViewKullanicilar_CellClick;
            // 
            // labelSilinecekRol
            // 
            labelSilinecekRol.AutoSize = true;
            labelSilinecekRol.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSilinecekRol.Location = new Point(77, 352);
            labelSilinecekRol.Name = "labelSilinecekRol";
            labelSilinecekRol.Size = new Size(160, 16);
            labelSilinecekRol.TabIndex = 6;
            labelSilinecekRol.Text = "Silinecek Rol adını giriniz : ";
            // 
            // textBoxsilinecekRol
            // 
            textBoxsilinecekRol.Location = new Point(256, 350);
            textBoxsilinecekRol.Name = "textBoxsilinecekRol";
            textBoxsilinecekRol.Size = new Size(118, 23);
            textBoxsilinecekRol.TabIndex = 14;
            // 
            // buttonRolSil
            // 
            buttonRolSil.Location = new Point(402, 341);
            buttonRolSil.Name = "buttonRolSil";
            buttonRolSil.Size = new Size(87, 38);
            buttonRolSil.TabIndex = 16;
            buttonRolSil.Text = "Rolü sil";
            buttonRolSil.UseVisualStyleBackColor = true;
            buttonRolSil.Click += buttonRolSil_Click;
            // 
            // buttonKullaniciSil
            // 
            buttonKullaniciSil.Location = new Point(1062, 319);
            buttonKullaniciSil.Name = "buttonKullaniciSil";
            buttonKullaniciSil.Size = new Size(87, 38);
            buttonKullaniciSil.TabIndex = 19;
            buttonKullaniciSil.Text = "Kullanıcıyı sil";
            buttonKullaniciSil.UseVisualStyleBackColor = true;
            buttonKullaniciSil.Click += buttonKullaniciSil_Click;
            // 
            // textBoxSilinecekKullanici
            // 
            textBoxSilinecekKullanici.Location = new Point(932, 328);
            textBoxSilinecekKullanici.Name = "textBoxSilinecekKullanici";
            textBoxSilinecekKullanici.Size = new Size(118, 23);
            textBoxSilinecekKullanici.TabIndex = 18;
            // 
            // labelSilinecekKullanici
            // 
            labelSilinecekKullanici.AutoSize = true;
            labelSilinecekKullanici.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelSilinecekKullanici.Location = new Point(693, 330);
            labelSilinecekKullanici.Name = "labelSilinecekKullanici";
            labelSilinecekKullanici.Size = new Size(233, 16);
            labelSilinecekKullanici.TabIndex = 17;
            labelSilinecekKullanici.Text = "Silinecek Yoneticinin ID değerini giriniz :";
            // 
            // FormYetkilendirmeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 677);
            Controls.Add(buttonKullaniciSil);
            Controls.Add(textBoxSilinecekKullanici);
            Controls.Add(labelSilinecekKullanici);
            Controls.Add(buttonRolSil);
            Controls.Add(textBoxsilinecekRol);
            Controls.Add(labelSilinecekRol);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormYetkilendirmeMenu";
            Text = "Yönetici ve Yetki İşlemleri Menüsü";
            Load += FormYetkilendirmeMenu_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoller).EndInit();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewKullanicilar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelRol;
        private Label labelCanRead;
        private Label labelCanDelete;
        private GroupBox groupBox2;
        private Label labelCanUpdate;
        private Label labelCanInsert;
        private Label label3;
        private Label label4;
        private Label labelKullaniciAdi;
        private Label labelYoneticiId;
        private TextBox textBoxRol;
        private TextBox textBoxSifre;
        private TextBox textBoxKullanıcıAdı;
        private GroupBox groupBox3;
        private DataGridView dataGridViewRoller;
        private GroupBox groupBox4;
        private DataGridView dataGridViewKullanicilar;
        private Button buttonRolEkle;
        private Button buttonKullaniciGuncelle;
        private Button buttonKullaniciEkle;
        private CheckBox checkBoxCanUpdate;
        private CheckBox checkBoxCanDelete;
        private CheckBox checkBoxCanInsert;
        private CheckBox checkBoxCanRead;
        private Label label1;
        private Label labelYonetici;
        private Button buttonRolGuncelle;
        private TextBox textBoxTemporaryRol;
        private Label labelTemporaryRol;
        private Label labelSilinecekRol;
        private TextBox textBoxsilinecekRol;
        private Button buttonRolSil;
        private Button buttonKullaniciSil;
        private TextBox textBoxSilinecekKullanici;
        private Label labelSilinecekKullanici;
        private TextBox textBoxTemporaryYoneticiID;
        private Label labelTemporaryYoneticiID;
        private ComboBox comboBoxKullaniciRolleri;
    }
}