using System.Data.SqlClient;

namespace DershaneYonetimSistemi
{
    public partial class FormGiris : Form
    {
        FormAnaMenu formAnamenu;
        public FormGiris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T90QPC7\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");

        private bool KullaniciDogrula(string kullaniciAdi, string sifre, out string rol)  //Kullan�c� ad� ve �ifrenin do�rulanmas�, out olarak kullanc�� rol�n� al�yoruz
        {
            rol = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre,Rol FROM DershaneSistemiYonetici WHERE KullaniciAdi = @p1", baglanti);  //Ba�lant� yapt���m�z veritaban�na parametreli sorgu yaz�yoruz
                sqlKomut.Parameters.AddWithValue("@p1", kullaniciAdi); //Parametreyi veriyoruz
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader(); //Yazd���m�z SQL kodunu okuyoruz yani i�liyoruz.
                string dbSifre = "";


                while (sqlDataReader.Read())
                {
                    dbSifre = sqlDataReader[0].ToString();
                    rol = sqlDataReader[1].ToString(); // Rol bilgisini out parametresine at�yoruz
                }

                return dbSifre == sifre; // �ifre e�le�iyorsa true d�ner
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ba�lant� hatas�: " + ex.Message);
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void LogGirisDenemesi(string kullaniciAdi, bool basarili) //Log bilgilerini tabloya yazmas�n� yapan fonksiyon
        {
            try
            {
                baglanti.Open();
                SqlCommand logKomut = new SqlCommand("INSERT INTO GirisLog (KullaniciAdi, Basarili) VALUES (@kullaniciAdi, @basarili)", baglanti);
                logKomut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                logKomut.Parameters.AddWithValue("@basarili", basarili ? 1 : 0);
                logKomut.ExecuteNonQuery(); //SQL komutunu �al��t�rmak i�in kullan�lan bir metottur ve genellikle veritaban�nda veri de�i�tiren (INSERT, UPDATE, DELETE) i�lemleri i�in kullan�l�r
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loglama hatas�: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void buttonGiris_Click(object sender, EventArgs e)
        {

            string rol;
            string kullaniciAdi = textBoxKullaniciAdi.Text;
            string sifre = textBoxSifre.Text;

            // Giri� do�rulama
            bool basarili = KullaniciDogrula(kullaniciAdi, sifre, out rol);


            // Giri� loglama
            LogGirisDenemesi(kullaniciAdi, basarili);

            if (basarili)
            {
                label3.Text = "�ifre Do�ru";
                formAnamenu = new FormAnaMenu(rol); //Ana men�ye ge�i� yaparken constructor arac�l���yla rol de�erini g�nderiyoruz.
                formAnamenu.Show();

            }
            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�");
            }



        }

        //UseSystemPasswordChar = True  yaparsak ilgili textBox �zerine girilen string �ifreli g�z�k�r.
    }
}