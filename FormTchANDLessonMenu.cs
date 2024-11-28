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
    public partial class FormTchANDLessonMenu : Form
    {

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T90QPC7\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");
        KullaniciYetkileri kullaniciYetkileri;
        public FormTchANDLessonMenu(KullaniciYetkileri yetkiler)
        {
            InitializeComponent();
            kullaniciYetkileri = yetkiler;
        }
        private void teacherIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT TeacherID FROM Ogretmen", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // Öğeleri bir listeye kaydediyoruz
                List<string> teacherIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    teacherIDs.Add(reader["TeacherID"].ToString());
                }

                comboBoxTemporaryTeacherID.Items.Clear();
                comboBoxTemporaryTeacherID.Items.AddRange(teacherIDs.ToArray());

                comboBoxSilinecekOgretmenID.Items.Clear();
                comboBoxSilinecekOgretmenID.Items.AddRange(teacherIDs.ToArray());


            }
            catch (Exception ex)
            {
                MessageBox.Show("Teacher ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void dersIDYukle()
        {
            try
            {

                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT CourseID FROM Ders", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                List<string> courseIDs = new List<string>();

                // Gelen rolleri ComboBox'a ekliyoruz
                while (reader.Read())
                {
                    courseIDs.Add(reader["CourseID"].ToString());
                }

                comboBoxTemporaryDersID.Items.Clear();
                comboBoxTemporaryDersID.Items.AddRange(courseIDs.ToArray());

                comboBoxSilinecekDersID.Items.Clear();
                comboBoxSilinecekDersID.Items.AddRange(courseIDs.ToArray());

                comboBoxLessonID.Items.Clear();
                comboBoxLessonID.Items.AddRange(courseIDs.ToArray());

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
        private void ogretmenAlanYukle()
        {
            string[] ogretmenAlanlari = { "MATEMATİK", "FİZİK", "KİMYA", "TÜRKÇE", "TARİH", "COĞRAFYA", "DİN", "FELSEFE", "BİYOLOJİ", "DANIŞMAN" };
            comboBoxOgretmenAlan.Items.AddRange(ogretmenAlanlari);
        }
        private void dersAdYukle()
        {
            string[] dersAdlari = { "TYT-Matematik", "TYT-Fizik", "TYT-Kimya", "TYT-Türkçe", "TYT-Tarih", "TYT-Coğrafya", "TYT-Din", "TYT-Felsefe", "TYT-Biyoloji", "AYT-Matematik", "AYT-Fizik", "AYT-Kimya", "AYT-Türkçe", "AYT-Tarih", "AYT-Coğrafya", "AYT-Felsefe", "AYT-Biyoloji", "YDT-İngilizce" };
            comboBoxDersAdi.Items.AddRange(dersAdlari);
        }

        private void ogretmenleriGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Ogretmen";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewOgretmenler.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Öğretmenleri görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void dersleriGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Ders";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewDersler.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Dersleri görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }

        private void ogretmenEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Ogretmen (TeacherID ,CourseID, FirstName, LastName, HireDate, Alan) VALUES (@P1, @P2, @P3, @P4, @P5, @P6)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxTeacherID.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxLessonID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxOgretmenAdi.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", textBoxOgretmenSoyadi.Text);
                    sqlCommand.Parameters.AddWithValue("@P5", dateTimePickerBaslangicTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P6", comboBoxOgretmenAlan.SelectedItem.ToString());


                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğretmen eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                ogretmenleriGoster();
                teacherIDYukle();
            }
            else
            {
                MessageBox.Show("Öğretmen eklemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void ogretmenGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Ogretmen SET TeacherID = @P1, CourseID = @P2, FirstName = @P3, LastName = @P4, HireDate = @P5, Alan = @P6 WHERE TeacherID = @P7", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", textBoxTeacherID.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxLessonID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", textBoxOgretmenAdi.Text);
                    sqlCommand.Parameters.AddWithValue("@P4", textBoxOgretmenSoyadi.Text);
                    sqlCommand.Parameters.AddWithValue("@P5", dateTimePickerBaslangicTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P6", comboBoxOgretmenAlan.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P7", comboBoxTemporaryTeacherID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğretmen güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                ogretmenleriGoster();
                teacherIDYukle();
            }
            else
            {
                MessageBox.Show("Öğretmen güncellemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void ogretmenSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Ogretmen WHERE TeacherID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekOgretmenID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Öğretmen silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                ogretmenleriGoster();
                teacherIDYukle();
            }
            else
            {
                MessageBox.Show("Öğretmen silmeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }

        private void dersEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Ders (CourseName ,HaftalikSaat) VALUES (@P1, @P2)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxDersAdi.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", numericUpDownHaftalikSaati.Value);
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ders eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                dersleriGoster();
                dersIDYukle();
            }
            else
            {
                MessageBox.Show("Ders eklemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void dersGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Ders SET CourseName = @P1, HaftalikSaat = @P2 WHERE CourseID = @P3", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxDersAdi.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", numericUpDownHaftalikSaati.Value);
                    sqlCommand.Parameters.AddWithValue("@P3", comboBoxTemporaryDersID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ders güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                dersleriGoster();
                dersIDYukle();
            }
            else
            {
                MessageBox.Show("Ders güncellemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void dersSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Ders WHERE CourseID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekDersID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ders silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                dersleriGoster();
                dersIDYukle();
            }
            else
            {
                MessageBox.Show("Ders silmeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }



        private void FormTchANDLessonMenu_Load(object sender, EventArgs e)
        {
            dersAdYukle();
            ogretmenAlanYukle();
            teacherIDYukle();
            dersIDYukle();
        }

        private void buttonOgretmenEkle_Click(object sender, EventArgs e)
        {
            ogretmenEkle();
        }

        private void buttonOgretmenGuncelle_Click(object sender, EventArgs e)
        {
            ogretmenGuncelle();
        }

        private void buttonOgretmenSil_Click(object sender, EventArgs e)
        {
            ogretmenSil();
        }

        private void buttonDersEkle_Click(object sender, EventArgs e)
        {
            dersEkle();
        }

        private void buttonDersGuncelle_Click(object sender, EventArgs e)
        {
            dersGuncelle();
        }

        private void buttonDersSil_Click(object sender, EventArgs e)
        {
            dersSil();
        }

        private void buttonOgretmenleriGoruntule_Click(object sender, EventArgs e)
        {
            ogretmenleriGoster();
        }

        private void buttonDersleriGoruntule_Click(object sender, EventArgs e)
        {
            dersleriGoster();
        }
    }
}
