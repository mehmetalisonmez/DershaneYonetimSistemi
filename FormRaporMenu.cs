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
    public partial class FormRaporMenu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T90QPC7\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");

        private KullaniciYetkileri kullaniciYetkileri;
        public FormRaporMenu(KullaniciYetkileri yetkiler)
        {
            InitializeComponent();
            kullaniciYetkileri = yetkiler;
        }

        private void SearchGrades()
        {
            string firstName = textBoxOgrenciAd.Text;

            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Stored Procedure çağrısı için SqlCommand
                SqlCommand sqlCommand = new SqlCommand("GetStudentGradesByName", baglanti);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FirstName", firstName);

                // DataTable ile sonuçları tut
                DataTable dataTable = new DataTable();

                // SqlDataAdapter ile Stored Procedure'ün döndürdüğü sonuçları al
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);

                // DataGridView'e sonuçları ata
                dataGridViewGetStudentGradesByName.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }
        }
        private void SearchPayments()
        {
            string firstName = textBoxOgrenciAd2.Text;
            string lastName = textBoxOgrenciSoyad.Text;
            string odemeTuru = textBoxOdemeTuru.Text;

            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Stored Procedure çağrısı için SqlCommand
                SqlCommand sqlCommand = new SqlCommand("GetStudentsByPaymentDetails", baglanti);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                sqlCommand.Parameters.AddWithValue("@LastName", lastName);
                sqlCommand.Parameters.AddWithValue("@PaymentType", odemeTuru);

                // DataTable ile sonuçları tut
                DataTable dataTable = new DataTable();

                // SqlDataAdapter ile Stored Procedure'ün döndürdüğü sonuçları al
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);

                // DataGridView'e sonuçları ata
                dataGridViewGetPayments.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }
        }
        private void SearchAttendances()
        {
            string firstName = textBoxOgrenciAd3.Text;
            string lastName = textBoxOgrenciSoyad2.Text;
            string dersAdi = textBoxDersAdi.Text;

            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Stored Procedure çağrısı için SqlCommand
                SqlCommand sqlCommand = new SqlCommand("GetStudentAttendanceReport", baglanti);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@FirstName", firstName);
                sqlCommand.Parameters.AddWithValue("@LastName", lastName);
                sqlCommand.Parameters.AddWithValue("@CourseName", dersAdi);

                // DataTable ile sonuçları tut
                DataTable dataTable = new DataTable();

                // SqlDataAdapter ile Stored Procedure'ün döndürdüğü sonuçları al
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);

                // DataGridView'e sonuçları ata
                dataGridViewGetAttendances.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }
        }
        private void SearchTeachers()
        {
            string firstName = textBoxOgretmenAdi.Text;
            string ogretmenAlan = textBoxOgretmenAlan.Text;
            try
            {
                // Bağlantıyı aç
                baglanti.Open();

                // Stored Procedure çağrısı için SqlCommand
                SqlCommand sqlCommand = new SqlCommand("GetTeacherBranch", baglanti);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@TeacherName", firstName);
                sqlCommand.Parameters.AddWithValue("@OgretmenAlan", ogretmenAlan);
                // DataTable ile sonuçları tut
                DataTable dataTable = new DataTable();

                // SqlDataAdapter ile Stored Procedure'ün döndürdüğü sonuçları al
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);

                // DataGridView'e sonuçları ata
                dataGridViewGetTeachers.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                // Hata durumunda kullanıcıya bilgi ver
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                baglanti.Close();
            }
        }

        private void buttonSearchGrades_Click(object sender, EventArgs e)
        {
            SearchGrades();
        }

        private void buttonSearchPayments_Click(object sender, EventArgs e)
        {
            SearchPayments();
        }

        private void buttonSearchAttendance_Click(object sender, EventArgs e)
        {
            SearchAttendances();
        }

        private void buttonSearchTeachers_Click(object sender, EventArgs e)
        {
            SearchTeachers();
        }
    }
}
