using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class MasaYonetimiForm : Form
    {
        private string connectionString = "Server=DESKTOP-RTLKELV;Database=ResToranProject;Trusted_Connection=True;Trust Server Certificate=True;";

        public MasaYonetimiForm()
        {
            InitializeComponent();
            LoadMasalar();
        }

        private void LoadMasalar()
        {
            List<Masa> masaListesi = new List<Masa>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Masa", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Masa masa = new Masa
                    {
                        MasaID = Convert.ToInt32(row["MasaID"]),
                        MasaNumarası = row["MasaNumarası"].ToString(),
                        Durum = row["Durum"].ToString()
                    };
                    masaListesi.Add(masa);
                }
            }

            
            dataGridViewMasalar.DataSource = masaListesi;
            dataGridViewMasalar.Columns["MasaID"].Visible = false;
        }

       

        private void btnMasaEkle_Click_1(object sender, EventArgs e)
        {
            string masaNo = txtMasaNumarasi.Text.Trim();

            if (string.IsNullOrEmpty(masaNo))
            {
                MessageBox.Show("Lütfen bir masa numarası girin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

               
                using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Masa WHERE MasaNumarası = @masaNum", connection))
                {
                    checkCmd.Parameters.AddWithValue("@masaNum", masaNo);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Bu masa numarası zaten mevcut. Lütfen farklı bir numara girin.");
                        return;
                    }
                }

                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Masa (MasaNumarası, Durum) VALUES (@masaNumarası, 'Açık')", connection))
                {
                    insertCmd.Parameters.AddWithValue("@masaNumarası", masaNo);
                    insertCmd.ExecuteNonQuery();
                }
            }

            LoadMasalar();

          
            txtMasaNumarasi.Clear();
            txtMasaNumarasi.Focus();
        }

        private void btnMasaKapat_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewMasalar.SelectedRows.Count > 0)
            {
                int masaID = Convert.ToInt32(dataGridViewMasalar.SelectedRows[0].Cells["MasaID"].Value);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Masa SET Durum = 'Kapalı' WHERE MasaID = @masaID", connection);
                    cmd.Parameters.AddWithValue("@masaID", masaID);
                    cmd.ExecuteNonQuery();
                }
                LoadMasalar();
            }
            else
            {
                MessageBox.Show("Lütfen kapatmak istediğiniz masayı seçin.");
            }
        }

        private void btnMasaSil_Click_1(object sender, EventArgs e)
        {

        }

        private void btnMasaSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewMasalar.SelectedRows.Count > 0)
            {
                var selected = dataGridViewMasalar.SelectedRows[0].DataBoundItem as Masa; 
                if (selected == null)
                {
                    MessageBox.Show("Seçilen satırdan veri alınamadı.");
                    return;
                }

                int masaID = selected.MasaID; 

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    
                    SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Sipariş WHERE MasaID = @masaID", connection);
                    checkCmd.Parameters.AddWithValue("@masaID", masaID);
                    int relatedCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (relatedCount > 0)
                    {
                        MessageBox.Show("Bu masa silinemez çünkü siparişlerde referansı var.");
                        return;
                    }

                    
                    SqlCommand cmd = new SqlCommand("DELETE FROM Masa WHERE MasaID = @masaID", connection);
                    cmd.Parameters.AddWithValue("@masaID", masaID);
                    cmd.ExecuteNonQuery();
                }

                LoadMasalar(); 
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz masayı seçin.");
            }
        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            if (dataGridViewMasalar.SelectedRows.Count > 0)
            {
                var selected = dataGridViewMasalar.SelectedRows[0].DataBoundItem as Masa; 
                if (selected == null)
                {
                    MessageBox.Show("Seçilen satırdan veri alınamadı.");
                    return;
                }

                int masaID = selected.MasaID; 

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    
                    SqlCommand cmd = new SqlCommand("UPDATE Masa SET Durum = 'Açık' WHERE MasaID = @masaID", connection);
                    cmd.Parameters.AddWithValue("@masaID", masaID);
                    cmd.ExecuteNonQuery();
                }

                LoadMasalar(); 
            }
            else
            {
                MessageBox.Show("Lütfen açmak istediğiniz masayı seçin.");
            }
        }
    }
}
