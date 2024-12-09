namespace DershaneYonetimSistemi
{
    partial class FormGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiris));
            buttonGiris = new Button();
            textBoxKullaniciAdi = new TextBox();
            textBoxSifre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonGiris
            // 
            buttonGiris.BackColor = Color.Teal;
            buttonGiris.Font = new Font("Ravie", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            buttonGiris.Location = new Point(150, 187);
            buttonGiris.Name = "buttonGiris";
            buttonGiris.Size = new Size(132, 46);
            buttonGiris.TabIndex = 0;
            buttonGiris.Text = "Giriş Yap";
            buttonGiris.UseVisualStyleBackColor = false;
            buttonGiris.Click += buttonGiris_Click;
            // 
            // textBoxKullaniciAdi
            // 
            textBoxKullaniciAdi.Location = new Point(161, 93);
            textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            textBoxKullaniciAdi.Size = new Size(110, 23);
            textBoxKullaniciAdi.TabIndex = 1;
            // 
            // textBoxSifre
            // 
            textBoxSifre.Location = new Point(161, 140);
            textBoxSifre.Name = "textBoxSifre";
            textBoxSifre.Size = new Size(110, 23);
            textBoxSifre.TabIndex = 2;
            textBoxSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(61, 99);
            label1.Name = "label1";
            label1.Size = new Size(92, 14);
            label1.TabIndex = 3;
            label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(81, 143);
            label2.Name = "label2";
            label2.Size = new Size(42, 14);
            label2.TabIndex = 4;
            label2.Text = "Şifre :";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(345, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 487);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Teal;
            button1.Font = new Font("Yu Gothic", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 162);
            button1.Location = new Point(161, 404);
            button1.Name = "button1";
            button1.Size = new Size(160, 62);
            button1.TabIndex = 7;
            button1.Text = "Yedekten Full Dön";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormGiris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(794, 487);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSifre);
            Controls.Add(textBoxKullaniciAdi);
            Controls.Add(buttonGiris);
            Name = "FormGiris";
            Text = "Giriş Ekranı";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonGiris;
        private TextBox textBoxKullaniciAdi;
        private TextBox textBoxSifre;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button button1;
    }
}