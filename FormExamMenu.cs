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
        private void examIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT ExamID FROM Sinav", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // ComboBox'ı temizliyoruz (yeniden yüklenirse eski değerler kalmasın)
                comboBoxSinavIDforSınavSonuc.Items.Clear();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    comboBoxSinavIDforSınavSonuc.Items.Add(reader["ExamID"].ToString());
                }

                // İlk seçili öğeyi belirtebilirsiniz (opsiyonel)
                if (comboBoxSinavIDforSınavSonuc.Items.Count > 0)
                {
                    comboBoxSinavIDforSınavSonuc.SelectedIndex = 0;
                }
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
            string query = "SELECT * FROM Sinav";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
            {
                dataGridViewSinavlar.DataSource = dataTable;
            }
        }
        private void sinavSonuclariGoster()
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
        private void sinavEkle()
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
        }
        private void sinavGuncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Sinav SET CourseID = @P1, ExamName = @P2, ExamDate = @P3 WHERE ExamID = @P4", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", comboBoxCourseID.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@P2", textBoxSinavIsmi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerSinavTarihi.Value);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxTemporarySinavID.Text);

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
            textBoxTemporarySinavID.Text = "";
        }
        private void sinavSil()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Sinav WHERE ExamID = @P1", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxSilinecekSinav.Text);
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
        }
        private void sinavSonucEkle()
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
        }
        private void sinavSonucGuncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE SinavSonuc SET ExamID = @P1, StudentID = @P2, AlinanPuan = @P3 WHERE ResultID = @P4", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", comboBoxSinavIDforSınavSonuc.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@P2", comboBoxStudentID.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@P3", textBoxAlinanPuan.Text);
                sqlCommand.Parameters.AddWithValue("@P4", textBoxTemporaryResultID.Text);

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
            textBoxTemporaryResultID.Text = "";
        }
        private void sinavSonucSil()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM SinavSonuc WHERE ResultID = @P1", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxSilinecekSinavSonucID.Text);
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
        }

        public FormExamMenu()
        {
            InitializeComponent();
        }


        private void FormExamMenu_Load(object sender, EventArgs e)
        {
            courseIDYukle();
            examIDYukle();
            studentIDYukle();
            sinavlariGoster();
            sinavSonuclariGoster();
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
    }
}
