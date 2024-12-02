using DershaneYonetimSistemi.Models;
using OfficeOpenXml;
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
using Xceed.Words.NET;

namespace DershaneYonetimSistemi
{
    public partial class FormSinifMenu : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-T90QPC7\SQLEXPRESS;Initial Catalog=DERSHANE;Integrated Security=True;TrustServerCertificate=True");

        private KullaniciYetkileri kullaniciYetkileri;
        public FormSinifMenu(KullaniciYetkileri yetkiler)
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
        }
        private void sinifIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT ClassID FROM Sinif", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // Öğeleri bir listeye kaydediyoruz
                List<string> classIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    classIDs.Add(reader["ClassID"].ToString());
                }

                comboBoxSinifID.Items.Clear();
                comboBoxSinifID.Items.AddRange(classIDs.ToArray());

                comboBoxSilinecekSinifID.Items.Clear();
                comboBoxSilinecekSinifID.Items.AddRange(classIDs.ToArray());

                comboBoxTemporarySinifID.Items.Clear();
                comboBoxTemporarySinifID.Items.AddRange(classIDs.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sınıf ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
        }
        private void sinifDersIDYukle()
        {
            try
            {
                // Bağlantıyı açıyoruz
                baglanti.Open();

                // SQL sorgusu ile rolleri çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT SinifDersID FROM SinifDers", baglanti);
                SqlDataReader reader = komut.ExecuteReader();

                // Öğeleri bir listeye kaydediyoruz
                List<string> classLessonIDs = new List<string>();

                // Gelen verileri listeye ekliyoruz
                while (reader.Read())
                {
                    classLessonIDs.Add(reader["SinifDersID"].ToString());
                }

                comboBoxTemporarySinifDersID.Items.Clear();
                comboBoxTemporarySinifDersID.Items.AddRange(classLessonIDs.ToArray());

                comboBoxSilinecekSinifDersID.Items.Clear();
                comboBoxSilinecekSinifDersID.Items.AddRange(classLessonIDs.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sınıf Ders ID'ler yüklenirken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapatıyoruz
                baglanti.Close();
            }
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

                comboBoxOgretmenID.Items.Clear();
                comboBoxOgretmenID.Items.AddRange(teacherIDs.ToArray());

                comboBoxTeacherID.Items.Clear();
                comboBoxTeacherID.Items.AddRange(teacherIDs.ToArray());
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
        private void sinifAdYukle()
        {
            string[] sinifAdlari = { "Say1", "Say2", "Say3", "Söz1", "Söz2", "Söz3", "EA1", "EA2", "EA3", "Dil1", "Dil2", "Dil3" };
            comboBoxSinifIsimleri.Items.AddRange(sinifAdlari);
        }


        private void siniflariGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM Sinif";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewSiniflar.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Sınıfları görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void sinifDersleriGoster()
        {
            if (kullaniciYetkileri.CanRead)
            {
                string query = "SELECT * FROM SinifDers";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, baglanti);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);


                if (dataTable.Rows.Count >= 0) //DataTable içerisinde veri var ise
                {
                    dataGridViewSinifDersler.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("Sınıf dersleri görüntüleme yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }


        private void sinifEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO Sinif (TeacherID, ClassName, Capacity, CreationDate) VALUES (@P1, @P2, @P3,  @P4)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxTeacherID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxSinifIsimleri.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", numericUpDownCapacity.Value);
                    sqlCommand.Parameters.AddWithValue("@P4", dateTimePickerOlusturulmaTarihi.Value);

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınıf eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinifIDYukle();
            }
            else
            {
                MessageBox.Show("Sınıf eklemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void sinifGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Sinif SET TeacherID = @P1, ClassName = @P2, Capacity = @P3, CreationDate = @P4 WHERE ClassID = @P5", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxTeacherID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxSinifIsimleri.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", numericUpDownCapacity.Value);
                    sqlCommand.Parameters.AddWithValue("@P4", dateTimePickerOlusturulmaTarihi.Value);
                    sqlCommand.Parameters.AddWithValue("@P5", comboBoxTemporarySinifID.SelectedItem.ToString());

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınıf güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinifIDYukle();
            }
            else
            {
                MessageBox.Show("Sınıf güncellemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void sinifSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM Sinif WHERE ClassID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekSinifID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınıf silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Sınıf silmeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
            sinifIDYukle();
        }

        private void sinifDersEkle()
        {
            if (kullaniciYetkileri.CanInsert)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO SinifDers (ClassID, CourseID, TeacherID) VALUES (@P1, @P2, @P3)", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSinifID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxCourseID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", comboBoxOgretmenID.SelectedItem.ToString());

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınıf Ders eklenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinifDersIDYukle();

            }
            else
            {
                MessageBox.Show("Sınıf Ders eklemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
        }
        private void sinifDersGuncelle()
        {
            if (kullaniciYetkileri.CanUpdate)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE SinifDers SET ClassID = @P1, CourseID = @P2, TeacherID = @P3 WHERE SinifDersID = @P4", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSinifID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P2", comboBoxCourseID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P3", comboBoxOgretmenID.SelectedItem.ToString());
                    sqlCommand.Parameters.AddWithValue("@P4", comboBoxTemporarySinifDersID.SelectedItem.ToString());

                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınıf Ders güncellenirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
                sinifDersIDYukle();
            }
            else
            {
                MessageBox.Show("Sınıf Ders güncellemeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }

        }
        private void sinifDersSil()
        {
            if (kullaniciYetkileri.CanDelete)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand sqlCommand = new SqlCommand("DELETE FROM SinifDers WHERE SinifDersID = @P1", baglanti);
                    sqlCommand.Parameters.AddWithValue("@P1", comboBoxSilinecekSinifDersID.SelectedItem.ToString());
                    sqlCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sınıf Ders silinirken hata oluştu ! " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }
            else
            {
                MessageBox.Show("Sınıf Ders silmeye yetkiniz yok. Lütfen yöneticinizle iletişime geçiniz ! ");
            }
            sinifDersIDYukle();
        }


        private void FormSinifMenu_Load(object sender, EventArgs e)
        {
            courseIDYukle();
            sinifIDYukle();
            sinifDersIDYukle();
            teacherIDYukle();
            sinifAdYukle();
        }


        private void SaveAsWordClasses(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewSiniflar.Rows.Count;
                int colCount = dataGridViewSiniflar.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewSiniflar.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewSiniflar.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }
        private void SaveAsWordClassLessons(string filePath)
        {
            using (var doc = DocX.Create(filePath))
            {
                int rowCount = dataGridViewSinifDersler.Rows.Count;
                int colCount = dataGridViewSinifDersler.Columns.Count;

                var table = doc.AddTable(rowCount + 1, colCount);

                for (int col = 0; col < colCount; col++)
                {
                    table.Rows[0].Cells[col].Paragraphs[0].Append(dataGridViewSinifDersler.Columns[col].HeaderText).Bold();
                }

                for (int row = 0; row < rowCount; row++)
                {
                    for (int col = 0; col < colCount; col++)
                    {
                        var cellValue = dataGridViewSinifDersler.Rows[row].Cells[col].Value?.ToString() ?? string.Empty;
                        table.Rows[row + 1].Cells[col].Paragraphs[0].Append(cellValue);
                    }
                }

                doc.InsertTable(table);
                doc.Save();
            }

            MessageBox.Show("Word belgesi başarıyla kaydedildi.");
        }

        private void buttonSaveAsWordSinif_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordClasses(filePath);
            }
        }
        private void buttonSaveAsWordSinifDers_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Word Documents (*.docx)|*.docx",
                Title = "Raporu Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                SaveAsWordClassLessons(filePath);
            }
        }





        private void buttonSiniflariGoruntule_Click(object sender, EventArgs e)
        {
            siniflariGoster();
        }
        private void buttonSinifEkle_Click(object sender, EventArgs e)
        {
            sinifEkle();
        }
        private void buttonSinifGuncelle_Click(object sender, EventArgs e)
        {
            sinifGuncelle();
        }

        private void buttonSinifSil_Click(object sender, EventArgs e)
        {
            sinifSil();
        }



        private void buttonSinifDersleriGoruntule_Click(object sender, EventArgs e)
        {
            sinifDersleriGoster();
        }
        private void buttonSinifDersEkle_Click(object sender, EventArgs e)
        {
            sinifDersEkle();
        }

        private void buttonSinifDersGuncelle_Click(object sender, EventArgs e)
        {
            sinifDersGuncelle();
        }

        private void buttonSinifDersSil_Click(object sender, EventArgs e)
        {
            sinifDersSil();
        }






        private void ImportClasses(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TeacherID", typeof(string));
                dataTable.Columns.Add("ClassName", typeof(string));
                dataTable.Columns.Add("Capacity", typeof(byte));
                dataTable.Columns.Add("CreationDate", typeof(DateTime));


                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["TeacherID"] = worksheet.Cells[row, 1].Text;
                    dataRow["ClassName"] = worksheet.Cells[row, 2].Text;
                    dataRow["Capacity"] = byte.Parse(worksheet.Cells[row, 3].Text);
                    dataRow["CreationDate"] = DateTime.Parse(worksheet.Cells[row, 4].Text);
                    dataTable.Rows.Add(dataRow);
                }

                if (dataGridViewSiniflar.DataSource != null)
                {
                    DataTable existingTable = (DataTable)dataGridViewSiniflar.DataSource;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        existingTable.ImportRow(row);
                    }
                    dataGridViewSiniflar.DataSource = existingTable;
                }
                else
                {
                    dataGridViewSiniflar.DataSource = dataTable;
                }

                AddClassToDatabase(dataTable);
            }
        } //İMPORT ETMEDEN ÖNCE DATAGRİDVİEW'DA VERİLERİN GÖRÜNTÜLENMESİ GEREKİYOR DİĞER TÜRLÜ PK EN SON KOLONA GEÇİYOR
        private void AddClassToDatabase(DataTable dataTable)
        {
            SqlCommand command = null;
            try
            {
                baglanti.Open();
                foreach (DataRow row in dataTable.Rows)
                {
                    try
                    {
                        command = new SqlCommand("INSERT INTO Sinif (TeacherID, ClassName, Capacity, CreationDate) VALUES (@TeacherID, @ClassName, @Capacity, @CreationDate)", baglanti);
                        command.Parameters.AddWithValue("@TeacherID", row["TeacherID"]);
                        command.Parameters.AddWithValue("@ClassName", row["ClassName"]);
                        command.Parameters.AddWithValue("@Capacity", row["Capacity"]);
                        command.Parameters.AddWithValue("@CreationDate", row["CreationDate"]);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Satır hatalarını yakala
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}\nHatalı veri: {row["TeacherID"]}, {row["ClassName"]}, {row["Capacity"]}, {row["CreationDate"]}",
                                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Genel hataları yakala
                MessageBox.Show($"Veritabanı bağlantısı sırasında bir hata oluştu: {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void buttonVeriAlSinif_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportClasses(openFileDialog.FileName);
            }
        }
        private void ExportToExcelSiniflar(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    // Yeni bir çalışma sayfası oluştur
                    var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    // DataGridView'in kolon başlıklarını yaz
                    for (int col = 0; col < dataGridViewSiniflar.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewSiniflar.Columns[col].HeaderText;
                    }

                    // DataGridView'in verilerini yaz
                    for (int row = 0; row < dataGridViewSiniflar.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewSiniflar.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewSiniflar.Rows[row].Cells[col].Value;
                        }
                    }

                    // Excel dosyasını kaydet
                    package.SaveAs(new FileInfo(filePath));

                    MessageBox.Show("Veriler başarıyla Excel'e aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveExcelSinif_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcelSiniflar(saveFileDialog.FileName);
            }
        }



        private void ImportClassLessons(string filePath)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("ClassID", typeof(int));
                dataTable.Columns.Add("CourseID", typeof(short)); //Ogretmen tablosundan bak
                dataTable.Columns.Add("TeacherID", typeof(string));


                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["ClassID"] = worksheet.Cells[row, 1].Text;
                    dataRow["CourseID"] = worksheet.Cells[row, 2].Text;
                    dataRow["TeacherID"] = worksheet.Cells[row, 3].Text;
                    dataTable.Rows.Add(dataRow);
                }

                if (dataGridViewSinifDersler.DataSource != null)
                {
                    DataTable existingTable = (DataTable)dataGridViewSinifDersler.DataSource;
                    foreach (DataRow row in dataTable.Rows)
                    {
                        existingTable.ImportRow(row);
                    }
                    dataGridViewSinifDersler.DataSource = existingTable;
                }
                else
                {
                    dataGridViewSinifDersler.DataSource = dataTable;
                }

                AddClassLessonToDatabase(dataTable);
            }
        } //İMPORT ETMEDEN ÖNCE DATAGRİDVİEW'DA VERİLERİN GÖRÜNTÜLENMESİ GEREKİYOR DİĞER TÜRLÜ PK EN SON KOLONA GEÇİYOR
        private void AddClassLessonToDatabase(DataTable dataTable)
        {
            SqlCommand command = null;
            try
            {
                baglanti.Open();
                foreach (DataRow row in dataTable.Rows)
                {
                    try
                    {
                        command = new SqlCommand("INSERT INTO SinifDers (ClassID, CourseID, TeacherID) VALUES (@ClassID, @CourseID, @TeacherID)", baglanti);
                        command.Parameters.AddWithValue("@ClassID", row["ClassID"]);
                        command.Parameters.AddWithValue("@CourseID", row["CourseID"]);
                        command.Parameters.AddWithValue("@TeacherID", row["TeacherID"]);
                        command.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Satır hatalarını yakala
                        MessageBox.Show($"Bir hata oluştu: {ex.Message}\nHatalı veri: {row["ClassID"]}, {row["CourseID"]}, {row["TeacherID"]}",
                                        "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                // Genel hataları yakala
                MessageBox.Show($"Veritabanı bağlantısı sırasında bir hata oluştu: {ex.Message}",
                                "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }
        private void buttonVeriAlSinifDers_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyası Seç"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImportClassLessons(openFileDialog.FileName);
            }
        }
        private void ExportToExcelSinifDersler(string filePath)
        {
            try
            {
                using (var package = new ExcelPackage())
                {
                    // Yeni bir çalışma sayfası oluştur
                    var worksheet = package.Workbook.Worksheets.Add("ExportedData");

                    // DataGridView'in kolon başlıklarını yaz
                    for (int col = 0; col < dataGridViewSinifDersler.Columns.Count; col++)
                    {
                        worksheet.Cells[1, col + 1].Value = dataGridViewSinifDersler.Columns[col].HeaderText;
                    }

                    // DataGridView'in verilerini yaz
                    for (int row = 0; row < dataGridViewSinifDersler.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridViewSinifDersler.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 2, col + 1].Value = dataGridViewSinifDersler.Rows[row].Cells[col].Value;
                        }
                    }

                    // Excel dosyasını kaydet
                    package.SaveAs(new FileInfo(filePath));

                    MessageBox.Show("Veriler başarıyla Excel'e aktarıldı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveExcelSinifDers_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Excel Files (*.xlsx)|*.xlsx",
                Title = "Excel Dosyasını Kaydet"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcelSinifDersler(saveFileDialog.FileName);
            }
        }
    }
}
