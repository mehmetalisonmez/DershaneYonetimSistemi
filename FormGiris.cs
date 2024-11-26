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

        private bool KullaniciDogrula(string kullaniciAdi, string sifre, out string rol)  //Kullanýcý adý ve þifrenin doðrulanmasý, out olarak kullancýý rolünü alýyoruz
        {
            rol = "";
            try
            {
                baglanti.Open();
                SqlCommand sqlKomut = new SqlCommand("SELECT Sifre,Rol FROM DershaneSistemiYonetici WHERE KullaniciAdi = @p1", baglanti);  //Baðlantý yaptýðýmýz veritabanýna parametreli sorgu yazýyoruz
                sqlKomut.Parameters.AddWithValue("@p1", kullaniciAdi); //Parametreyi veriyoruz
                SqlDataReader sqlDataReader = sqlKomut.ExecuteReader(); //Yazdýðýmýz SQL kodunu okuyoruz yani iþliyoruz.
                string dbSifre = "";


                while (sqlDataReader.Read())
                {
                    dbSifre = sqlDataReader[0].ToString();
                    rol = sqlDataReader[1].ToString(); // Rol bilgisini out parametresine atýyoruz
                }

                return dbSifre == sifre; // Þifre eþleþiyorsa true döner
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý hatasý: " + ex.Message);
                return false;
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void LogGirisDenemesi(string kullaniciAdi, bool basarili) //Log bilgilerini tabloya yazmasýný yapan fonksiyon
        {
            try
            {
                baglanti.Open();
                SqlCommand logKomut = new SqlCommand("INSERT INTO GirisLog (KullaniciAdi, Basarili) VALUES (@kullaniciAdi, @basarili)", baglanti);
                logKomut.Parameters.AddWithValue("@kullaniciAdi", kullaniciAdi);
                logKomut.Parameters.AddWithValue("@basarili", basarili ? 1 : 0);
                logKomut.ExecuteNonQuery(); //SQL komutunu çalýþtýrmak için kullanýlan bir metottur ve genellikle veritabanýnda veri deðiþtiren (INSERT, UPDATE, DELETE) iþlemleri için kullanýlýr
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loglama hatasý: " + ex.Message);
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

            // Giriþ doðrulama
            bool basarili = KullaniciDogrula(kullaniciAdi, sifre, out rol);


            // Giriþ loglama
            LogGirisDenemesi(kullaniciAdi, basarili);

            if (basarili)
            {
                label3.Text = "Þifre Doðru";
                formAnamenu = new FormAnaMenu(rol); //Ana menüye geçiþ yaparken constructor aracýlýðýyla rol deðerini gönderiyoruz.
                formAnamenu.Show();

            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya Þifre hatalý");
            }



        }

        //UseSystemPasswordChar = True  yaparsak ilgili textBox üzerine girilen string þifreli gözükür.
    }
}