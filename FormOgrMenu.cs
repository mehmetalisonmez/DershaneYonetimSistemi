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
    public partial class FormOgrMenu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T90QPC7\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");
        private void studentIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT StudentID FROM Ogrenci", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // Öğeleri bir listeye kaydediyoruz
                List<string> studentIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    studentIDs.Add(reader["StudentID"].ToString());
                }

                comboBoxTemporaryStudentID.Items.Clear();
                comboBoxTemporaryStudentID.Items.AddRange(studentIDs.ToArray());

                comboBoxOgrenciNo.Items.Clear();
                comboBoxOgrenciNo.Items.AddRange(studentIDs.ToArray());


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
        private void studentCourseIDYukle()
        {
            try
            {

                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT StudentCourseID FROM OgrenciDers", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                List<string> studentCourseIDs = new List<string>();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    studentCourseIDs.Add(reader["StudentCourseID"].ToString());
                }

                comboBoxTemporaryOgrenciDersID.Items.Clear();
                comboBoxTemporaryOgrenciDersID.Items.AddRange(studentCourseIDs.ToArray());

                comboBoxOgrenciDersID.Items.Clear();
                comboBoxOgrenciDersID.Items.AddRange(studentCourseIDs.ToArray());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Student Course ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void CourseIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT CourseID FROM Ders", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // ComboBox'ı temizliyoruz (yeniden yüklenirse eski değerler kalmasın)
                comboBoxDersID.Items.Clear();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    comboBoxDersID.Items.Add(reader["CourseID"].ToString());
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
        }
        private void AttendanceIdYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT AttendanceId FROM Devamsizlik", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // ComboBox'ı temizliyoruz (yeniden yüklenirse eski değerler kalmasın)
                comboBoxTemporaryDevamsizlikID.Items.Clear();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    comboBoxTemporaryDevamsizlikID.Items.Add(reader["AttendanceId"].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Attendance ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }

        private void ogrencileriGoster()
        {
            string query = "SELECT * FROM Ogrenci";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
            {
                dataGridViewOgrenciler.DataSource = dataTable;
            }
        }
        private void ogrenciDersleriGoster()
        {
            string query = "SELECT * FROM OgrenciDers";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
            {
                dataGridViewOgrenciDersleri.DataSource = dataTable;
            }
        }
        private void devamsizliklariGoster()
        {
            string query = "SELECT * FROM Devamsizlik";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);


            if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
            {
                dataGridViewDevamsizliklar.DataSource = dataTable;
            }
        }



        private void ogrenciEkle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Ogrenci (StudentID ,FirstName, LastName, DateOfBirth, Gender, RegistrationDate, Adres, OgrenciAlan) VALUES (@P1, @P2, @P3, @P4, @P5, @P6, @P7, @P8)", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxStudentID.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxOgrenciAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxOgrenciSoyadi.Text);
                sqlCommand.Parameters.AddWithValue("@P4", dateTimePickerDogumTarihi.Value);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxOgrenciCinsiyet.Text);
                sqlCommand.Parameters.AddWithValue("@P6", dateTimePickerKayitTarihi.Value);
                sqlCommand.Parameters.AddWithValue("@P7", richTextBoxOgrenciAdres.Text);
                sqlCommand.Parameters.AddWithValue("@P8", textBoxOgrenciAlan.Text);

                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci eklenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogrencileriGoster();
            studentIDYukle();
        }
        private void ogrenciGuncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Ogrenci SET StudentID = @P1, FirstName = @P2, LastName = @P3, DateOfBirth = @P4, Gender = @P5, RegistrationDate = @P6, Adres = @P7, OgrenciAlan = @P8 WHERE StudentID = @P9", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxStudentID.Text);
                sqlCommand.Parameters.AddWithValue("@P2", textBoxOgrenciAdi.Text);
                sqlCommand.Parameters.AddWithValue("@P3", textBoxOgrenciSoyadi.Text);
                sqlCommand.Parameters.AddWithValue("@P4", dateTimePickerDogumTarihi.Value);
                sqlCommand.Parameters.AddWithValue("@P5", textBoxOgrenciCinsiyet.Text);
                sqlCommand.Parameters.AddWithValue("@P6", dateTimePickerKayitTarihi.Value);
                sqlCommand.Parameters.AddWithValue("@P7", richTextBoxOgrenciAdres.Text);
                sqlCommand.Parameters.AddWithValue("@P8", textBoxOgrenciAlan.Text);
                sqlCommand.Parameters.AddWithValue("@P9", comboBoxTemporaryStudentID.SelectedItem.ToString());
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci güncellenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogrencileriGoster();
            studentIDYukle();
        }
        private void ogrenciSil()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Ogrenci WHERE StudentID = @P1", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxSilinecekOgrenci.Text);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci silinirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogrencileriGoster();
            studentIDYukle();
        }

        private void ogrenciDersEkle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO OgrenciDers (StudentID, CourseID, DerseKayitTarihi) VALUES (@P1, @P2, @P3)", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciNo.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@P2", comboBoxDersID.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerDerseKayitTarihi.Value);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci Ders eklenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogrenciDersleriGoster();
            studentCourseIDYukle();
        }
        private void ogrenciDersGuncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE OgrenciDers SET StudentID = @P1, CourseID = @P2, DerseKayitTarihi = @P3 WHERE StudentCourseID = @P4", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciNo.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@P2", comboBoxDersID.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerDerseKayitTarihi.Value);
                sqlCommand.Parameters.AddWithValue("@P4", comboBoxTemporaryOgrenciDersID.SelectedItem.ToString());
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci Ders güncellenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogrenciDersleriGoster();
            studentCourseIDYukle();
        }
        private void ogrenciDersSil()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM OgrenciDers WHERE StudentCourseID = @P1", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxSilinecekOgrenciDers.Text);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Öğrenci ders silinirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            ogrenciDersleriGoster();
            studentCourseIDYukle();
        }

        private void devamsizlikEkle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO Devamsizlik (StudentCourseID, Durum, AttendanceDate) VALUES (@P1, @P2, @P3)", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciDersID.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@P2", checkBoxDevamsizlikBilgisi.Checked ? 1 : 0);
                sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerDevamsizlikTarihi.Value);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Devamsızlık eklenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            devamsizliklariGoster();
            AttendanceIdYukle();
        }
        private void devamsizlikGuncelle()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE Devamsizlik SET StudentCourseID = @P1, Durum = @P2, AttendanceDate = @P3 WHERE AttendanceId = @P4", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", comboBoxOgrenciDersID.SelectedItem.ToString());
                sqlCommand.Parameters.AddWithValue("@P2", checkBoxDevamsizlikBilgisi.Checked ? 1 : 0);
                sqlCommand.Parameters.AddWithValue("@P3", dateTimePickerDevamsizlikTarihi.Value);
                sqlCommand.Parameters.AddWithValue("@P4", comboBoxTemporaryDevamsizlikID.SelectedItem.ToString());
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Devamsızlık güncellenirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            devamsizliklariGoster();
            AttendanceIdYukle();
        }
        private void devamsizlikSil()
        {
            try
            {
                baglanti.Open();
                SqlCommand sqlCommand = new SqlCommand("DELETE FROM Devamsizlik WHERE AttendanceId = @P1", baglanti);
                sqlCommand.Parameters.AddWithValue("@P1", textBoxSilinecekDevamsizlikID.Text);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Devamsızlık silinirken hata oluştu ! " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
            devamsizliklariGoster();
            AttendanceIdYukle();
        }



        public FormOgrMenu()
        {
            InitializeComponent();
        }

        private void FormOgrMenu_Load(object sender, EventArgs e)
        {
            studentIDYukle();
            studentCourseIDYukle();
            CourseIDYukle();
            AttendanceIdYukle();
            ogrencileriGoster();
            ogrenciDersleriGoster();
            devamsizliklariGoster();
        }

        private void buttonOgrenciEkle_Click(object sender, EventArgs e)
        {
            ogrenciEkle();
        }

        private void buttonOgrenciGuncelle_Click(object sender, EventArgs e)
        {
            ogrenciGuncelle();
        }

        private void buttonOgrenciSil_Click(object sender, EventArgs e)
        {
            ogrenciSil();
        }

        private void buttonOgrenciDersEkle_Click(object sender, EventArgs e)
        {
            ogrenciDersEkle();
        }

        private void buttonOgrenciDersGuncelle_Click(object sender, EventArgs e)
        {
            ogrenciDersGuncelle();
        }

        private void buttonOgrenciDersSil_Click(object sender, EventArgs e)
        {
            ogrenciDersSil();
        }

        private void buttonOgrenciDevamsizlikEkle_Click(object sender, EventArgs e)
        {
            devamsizlikEkle();
        }
        private void buttonSinavDevamsizlikGuncelle_Click(object sender, EventArgs e)
        {
            devamsizlikGuncelle();
        }

        private void buttonDevamsızlıkSil_Click(object sender, EventArgs e)
        {
            devamsizlikSil();
        }
    }
}
