using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class MenuYonetimiForm : Form
    {
        private string connectionString = "Server=DESKTOP-RTLKELV;Database=ResToranProject;Trusted_Connection=True;Trust Server Certificate=True;";

        public MenuYonetimiForm()
        {
            InitializeComponent();
            LoadUrunler();
        }



        private void LoadUrunler()
        {
            List<Menu> urunListesi = new List<Menu>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ürün", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);


                foreach (DataRow row in dt.Rows)
                {
                    Menu urun = new Menu
                    {
                        UrunID = Convert.ToInt32(row["ÜrünID"]),
                        UrunAdı = row["ÜrünAdı"].ToString(),
                        Fiyat = Convert.ToDecimal(row["Fiyat"])
                    };
                    urunListesi.Add(urun);
                }
            }

            dataGridViewUrunler.DataSource = urunListesi;
            dataGridViewUrunler.Columns["UrunID"].Visible = false;
        }




        
        

        private void btnUrunEkle_Click_1(object sender, EventArgs e)
        {
            string urunAd = txtUrunAd.Text.Trim();
            decimal fiyat = numericUpDownFiyat.Value;

            if (string.IsNullOrEmpty(urunAd))
            {
                MessageBox.Show("Lütfen ürün adını girin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                
                using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Ürün WHERE ÜrünAdı = @urunAd", connection))
                {
                    checkCmd.Parameters.AddWithValue("@urunAd", urunAd);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Bu ürün adı zaten mevcut. Lütfen farklı bir ad girin.");
                        return;
                    }
                }

                
                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Ürün (ÜrünAdı, Fiyat) VALUES (@urunAdı, @fiyat)", connection))
                {
                    insertCmd.Parameters.AddWithValue("@urunAdı", urunAd);
                    insertCmd.Parameters.AddWithValue("@fiyat", fiyat);
                    insertCmd.ExecuteNonQuery();
                }
            }

            
            LoadUrunler();

            
            txtUrunAd.Clear();
            numericUpDownFiyat.Value = 0; 
            txtUrunAd.Focus();
        }



       
     

      

        private void btnUrunSil_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewUrunler.SelectedRows.Count > 0)
            {
                var selected = dataGridViewUrunler.SelectedRows[0].DataBoundItem as Menu;
                if (selected == null)
                {
                    MessageBox.Show("Seçilen satırdan veri alınamadı.");
                    return;
                }

                int urunID = selected.UrunID;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Ürün WHERE ÜrünID = @urunID", connection);
                    cmd.Parameters.AddWithValue("@urunID", urunID);
                    cmd.ExecuteNonQuery();
                }

                LoadUrunler();
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir ürün seçin.");
            }
        }
    }
}
