namespace DershaneYonetimSistemi
{
    partial class FormAnaMenu
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
            buttonStdDersTch = new Button();
            buttonYetkiIslemleri = new Button();
            buttonExam = new Button();
            label1 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            buttonQuit = new Button();
            SuspendLayout();
            // 
            // buttonStdDersTch
            // 
            buttonStdDersTch.Location = new Point(107, 99);
            buttonStdDersTch.Name = "buttonStdDersTch";
            buttonStdDersTch.Size = new Size(152, 50);
            buttonStdDersTch.TabIndex = 0;
            buttonStdDersTch.Text = "Öğrenci/Ders/Öğretmen işlemlerine git.";
            buttonStdDersTch.UseVisualStyleBackColor = true;
            buttonStdDersTch.Click += buttonStdDersTch_Click;
            // 
            // buttonYetkiIslemleri
            // 
            buttonYetkiIslemleri.Location = new Point(107, 325);
            buttonYetkiIslemleri.Name = "buttonYetkiIslemleri";
            buttonYetkiIslemleri.Size = new Size(152, 48);
            buttonYetkiIslemleri.TabIndex = 1;
            buttonYetkiIslemleri.Text = "Yönetici / yetki işlemlerine git.";
            buttonYetkiIslemleri.UseVisualStyleBackColor = true;
            buttonYetkiIslemleri.Click += buttonYetkiIslemleri_Click;
            // 
            // buttonExam
            // 
            buttonExam.Location = new Point(107, 211);
            buttonExam.Name = "buttonExam";
            buttonExam.Size = new Size(152, 48);
            buttonExam.TabIndex = 2;
            buttonExam.Text = "Sınav işlemlerine git.";
            buttonExam.UseVisualStyleBackColor = true;
            buttonExam.Click += buttonExam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Bright", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(143, 19);
            label1.Name = "label1";
            label1.Size = new Size(323, 20);
            label1.TabIndex = 3;
            label1.Text = "Dershane Yönetim Sistemine Hoşgeldiniz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 65);
            label5.Name = "label5";
            label5.Size = new Size(272, 16);
            label5.TabIndex = 7;
            label5.Text = "Öğrenci, Ders ve Öğretmen İşlemleri";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(31, 170);
            label6.Name = "label6";
            label6.Size = new Size(115, 16);
            label6.TabIndex = 8;
            label6.Text = "Sınav İşlemleri";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(31, 278);
            label7.Name = "label7";
            label7.Size = new Size(197, 16);
            label7.TabIndex = 9;
            label7.Text = "Yönetici ve Yetki İşlemleri";
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(451, 359);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(122, 40);
            buttonQuit.TabIndex = 10;
            buttonQuit.Text = "Sistemden Çıkış yap.";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += buttonQuit_Click;
            // 
            // FormAnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 432);
            Controls.Add(buttonQuit);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(buttonExam);
            Controls.Add(buttonYetkiIslemleri);
            Controls.Add(buttonStdDersTch);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "FormAnaMenu";
            Text = "Dershane Yönetim Sistemi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStdDersTch;
        private Button buttonYetkiIslemleri;
        private Button buttonExam;
        private Label label1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button buttonQuit;
        private Button button4;
    }
}