using DershaneYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DershaneYonetimSistemi
{
    public partial class FormOdemeMenu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T90QPC7\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");
        private KullaniciYetkileri kullaniciYetkileri;

        public FormOdemeMenu(KullaniciYetkileri yetkiler)
        {
            InitializeComponent();
            kullaniciYetkileri = yetkiler;
        }
        private void odemeIDYukle()
        {

            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT PaymentID FROM Odemeler", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                List<string> paymentIDs = new List<string>();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    paymentIDs.Add(reader["PaymentID"].ToString());
                }

                comboBoxTemporaryPaymentD.Items.Clear();
                comboBoxTemporaryPaymentD.Items.AddRange(paymentIDs.ToArray());

                comboBoxSilinecekOdemeID.Items.Clear();
                comboBoxSilinecekOdemeID.Items.AddRange(paymentIDs.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Payment ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void ogrenciIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT StudentID FROM Ogrenci", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // ComboBox'ı temizliyoruz (yeniden yüklenirse eski değerler kalmasın)
                comboBoxOgrenciNo.Items.Clear();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    comboBoxOgrenciNo.Items.Add(reader["StudentID"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ogrenci ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void odemeTuruYukle()
        {
            string[] odemeTurleri = { "Nakit", "Kredi Kartı", "Banka Transfer" };
            comboBoxOdemeTuru.Items.AddRange(odemeTurleri);
        }

        private void odemeleriGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Odemeler";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewOdemeler.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Ödemeleri görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }

        private void odemeEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Odemeler (StudentID ,PaymentDate, Amount, PaymentType) VALUES (@P1, @P2, @P3, @P4)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciNo.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", dateTimePickerOdemeTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P3", numericUpDownOdemeMiktari.Value);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxOdemeTuru.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ödeme eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                odemeleriGoster();
                odemeIDYukle();
            }
            else
            {
                MessageBox.Show("Ödeme ekleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void odemeGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Odemeler SET StudentID = @P1, PaymentDate = @P2, Amount = @P3, PaymentType = @P4 WHERE PaymentID = @P5", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciNo.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", dateTimePickerOdemeTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P3", numericUpDownOdemeMiktari.Value);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxOdemeTuru.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P5", comboBoxTemporaryPaymentD.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ödeme güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                odemeleriGoster();
                odemeIDYukle();
            }
            else
            {
                MessageBox.Show("Ödeme güncelleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void odemeSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Odemeler WHERE PaymentID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekOdemeID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ÖDeme silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                odemeleriGoster();
                odemeIDYukle();
            }
            else
            {
                MessageBox.Show("Ödeme silme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }



        private void FormOdemeMenu_Load(object sender, EventArgs e)
        {
            odemeTuruYukle();
            odemeIDYukle();
            ogrenciIDYukle();

        }

        private void buttonOdemeEkle_Click(object sender, EventArgs e)
        {
            odemeEkle();
        }

        private void buttonOdemeGuncelle_Click(object sender, EventArgs e)
        {
            odemeGuncelle();
        }

        private void buttonOdemeSil_Click(object sender, EventArgs e)
        {
            odemeSil();
        }

        private void buttonOdemeleriGoruntule_Click(object sender, EventArgs e)
        {
            odemeleriGoster();
        }
    }
}
