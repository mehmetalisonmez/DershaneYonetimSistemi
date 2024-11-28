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
    public partial class FormExamMenu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T90QPC7\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");

        private KullaniciYetkileri kullaniciYetkileri;
        public FormExamMenu(KullaniciYetkileri yetkiler)
        {
            InitializeComponent();
            kullaniciYetkileri = yetkiler;
        }
        private void courseIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT CourseID FROM Ders", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // ComboBox'ı temizliyoruz (yeniden yüklenirse eski değerler kalmasın)
                comboBoxCourseID.Items.Clear();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    comboBoxCourseID.Items.Add(reader["CourseID"].ToString());
                }

                // İlk seçili öğeyi belirtebilirsiniz (opsiyonel)
                if (comboBoxCourseID.Items.Count > 0)
                {
                    comboBoxCourseID.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Course ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        } // Sadece Ders tablosundan CourseID'leri çeker
        private void sinavIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT ExamID FROM Sinav", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // Öğeleri bir listeye kaydediyoruz
                List<string> examIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    examIDs.Add(reader["ExamID"].ToString());
                }

                comboBoxSinavIDforSınavSonuc.Items.Clear();
                comboBoxSinavIDforSınavSonuc.Items.AddRange(examIDs.ToArray());

                comboBoxSilinecekSinavID.Items.Clear();
                comboBoxSilinecekSinavID.Items.AddRange(examIDs.ToArray());

                comboBoxTemporarySinavID.Items.Clear();
                comboBoxTemporarySinavID.Items.AddRange(examIDs.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exam ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void sinavSonucIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT ResultID FROM SinavSonuc", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // Öğeleri bir listeye kaydediyoruz
                List<string> examResultIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    examResultIDs.Add(reader["ResultID"].ToString());
                }

                comboBoxSilinecekSinavSonucID.Items.Clear();
                comboBoxSilinecekSinavSonucID.Items.AddRange(examResultIDs.ToArray());

                comboBoxTemporarySinavSonucID.Items.Clear();
                comboBoxTemporarySinavSonucID.Items.AddRange(examResultIDs.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exam ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void studentIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT StudentID FROM Ogrenci", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // ComboBox'ı temizliyoruz (yeniden yüklenirse eski değerler kalmasın)
                comboBoxStudentID.Items.Clear();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    comboBoxStudentID.Items.Add(reader["StudentID"].ToString());
                }

                // İlk seçili öğeyi belirtebilirsiniz (opsiyonel)
                if (comboBoxStudentID.Items.Count > 0)
                {
                    comboBoxStudentID.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }


        private void sinavlariGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Sinav";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewSinavlar.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Sınavları görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void sinavSonuclariGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM SinavSonuc";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewSinavSonuclari.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Sınav sonuçlarını görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }


        private void sinavEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Sinav (CourseID, ExamName, ExamDate) VALUES (@P1, @P2, @P3)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxCourseID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxSinavIsmi.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerSinavTarihi.Value);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavlariGoster();
                sinavIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav eklemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void sinavGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Sinav SET CourseID = @P1, ExamName = @P2, ExamDate = @P3 WHERE ExamID = @P4", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxCourseID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", textBoxSinavIsmi.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerSinavTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxTemporarySinavID.SelectedItem.ToString());

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavlariGoster();
                sinavIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav güncellemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void sinavSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Sinav WHERE ExamID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekSinavID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavlariGoster();
                sinavIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav silmeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }

        private void sinavSonucEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO SinavSonuc (ExamID, StudentID, AlinanPuan) VALUES (@P1, @P2, @P3)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSinavIDforSınavSonuc.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxStudentID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxAlinanPuan.Text);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav sonucu eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavSonuclariGoster();
                sinavSonucIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav sonuç ekleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void sinavSonucGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE SinavSonuc SET ExamID = @P1, StudentID = @P2, AlinanPuan = @P3 WHERE ResultID = @P4", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSinavIDforSınavSonuc.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxStudentID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxAlinanPuan.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxTemporarySinavSonucID.SelectedItem.ToString());

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav sonucu güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavSonuclariGoster();
                sinavSonucIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav sonuç güncelleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void sinavSonucSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM SinavSonuc WHERE ResultID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekSinavSonucID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınav sonucu silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinavSonuclariGoster();
                sinavSonucIDYukle();
            }
            else
            {
                MessageBox.Show("Sınav sonuç silme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }




        private void FormExamMenu_Load(object sender, EventArgs e)
        {
            sinavSonucIDYukle();
            courseIDYukle();
            sinavIDYukle();
            studentIDYukle();

        }

        private void buttonSinavEkle_Click(object sender, EventArgs e)
        {
            sinavEkle();
        }
        private void buttonSinavGuncelle_Click(object sender, EventArgs e)
        {
            sinavGuncelle();
        }

        private void buttonSinavSil_Click(object sender, EventArgs e)
        {
            sinavSil();
        }

        private void buttonSinavSonucEkle_Click(object sender, EventArgs e)
        {
            sinavSonucEkle();
        }

        private void buttonSinavSonucGuncelle_Click(object sender, EventArgs e)
        {
            sinavSonucGuncelle();
        }

        private void buttonSinavSonucSil_Click(object sender, EventArgs e)
        {
            sinavSonucSil();
        }

        private void buttonSinavlariGoruntule_Click(object sender, EventArgs e)
        {
            sinavlariGoster();
        }

        private void buttonSinavSonucGoruntule_Click(object sender, EventArgs e)
        {
            sinavSonuclariGoster();
        }
    }
}
