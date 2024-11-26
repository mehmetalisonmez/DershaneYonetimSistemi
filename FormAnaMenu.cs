using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DershaneYonetimSistemi
{

    public partial class FormAnaMenu : Form
    {
        FormGiris formGiris;
        FormOgrMenu formStdDersTch;
        FormExamMenu formExamMenu;
        FormYetkilendirmeMenu formYetkilendirmeMenu;
        private string kullaniciRol;
        public FormAnaMenu(string rol)
        {
            InitializeComponent();
            kullaniciRol = rol; //FormGiris'den gelen rolü constructor aracılığya aldık.
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            formGiris = new FormGiris();
            formGiris.Show();
            this.Close();
        }

        private void buttonStdDersTch_Click(object sender, EventArgs e)
        {
            formStdDersTch = new FormOgrMenu();
            formStdDersTch.Show();
        }

        private void buttonExam_Click(object sender, EventArgs e)
        {
            formExamMenu = new FormExamMenu();
            formExamMenu.Show();
        }

        private void buttonYetkiIslemleri_Click(object sender, EventArgs e)
        {
            if (kullaniciRol == "Admin") //Yetki işlemlerini sadece admin olanlar yapabilir diye düzenledik
            {
                formYetkilendirmeMenu = new FormYetkilendirmeMenu();
                formYetkilendirmeMenu.Show();
            }
            else
            {
                MessageBox.Show("Yönetici ve Yetki işlemleri için admin kullanıcısı olmanız gerekmektedir!");
            }
        }

       
    }
}
