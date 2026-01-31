using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class GarsonYonetimiForm : Form
    {

        private string connectionString = "Server=DESKTOP-RTLKELV;Database=ResToranProject;Trusted_Connection=True;Trust Server Certificate=True;";
        public GarsonYonetimiForm()
        {
            InitializeComponent();
            LoadGarsonlar();
        }

        private void LoadGarsonlar()
        {
            List<Garson> garsonListesi = new List<Garson>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Garson", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Garson garson = new Garson
                    {
                        GarsonID = Convert.ToInt32(row["GarsonID"]),
                        Ad = row["Ad"].ToString(),
                        Soyad = row["Soyad"].ToString()
                    };
                    garsonListesi.Add(garson);
                }
            }

            dataGridViewGarsonlar.DataSource = garsonListesi;
            dataGridViewGarsonlar.Columns["GarsonID"].Visible = false;
        }


        private void btnGarsonEkle_Click_1(object sender, EventArgs e)
        {

            string ad = txtAd.Text.Trim();
            string soyad = txtSoyad.Text.Trim();

            if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad))
            {
                MessageBox.Show("Lütfen hem ad hem de soyad girin.");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();


                using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Garson WHERE Ad = @ad AND Soyad = @soyad", connection))
                {
                    checkCmd.Parameters.AddWithValue("@ad", ad);
                    checkCmd.Parameters.AddWithValue("@soyad", soyad);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    if (count > 0)
                    {
                        MessageBox.Show("Bu garson zaten mevcut. Lütfen farklı bir ad ve soyad girin.");
                        return;
                    }
                }


                using (SqlCommand insertCmd = new SqlCommand("INSERT INTO Garson (Ad, Soyad) VALUES (@ad, @soyad)", connection))
                {
                    insertCmd.Parameters.AddWithValue("@ad", ad);
                    insertCmd.Parameters.AddWithValue("@soyad", soyad);
                    insertCmd.ExecuteNonQuery();
                }
            }

            LoadGarsonlar();

            txtAd.Clear();
            txtSoyad.Clear();
            txtAd.Focus();
        }

        private void btnGarsonSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewGarsonlar.SelectedRows.Count > 0)
            {
                int garsonID = Convert.ToInt32(dataGridViewGarsonlar.SelectedRows[0].Cells["GarsonID"].Value);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Garson WHERE GarsonID = @garsonID", connection);
                    cmd.Parameters.AddWithValue("@garsonID", garsonID);
                    cmd.ExecuteNonQuery();
                }
                LoadGarsonlar();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz garsonu seçin.");
            }

        }

        private void GarsonYonetimiForm_Load(object sender, EventArgs e)
        {

        }
    }

}
