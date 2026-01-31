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
    public partial class SiparisYonetimiForm : Form
    {

        private string connectionString = "Server=DESKTOP-RTLKELV;Database=ResToranProject;Trusted_Connection=True;Trust Server Certificate=True;";

        public SiparisYonetimiForm()
        {
            InitializeComponent();
            LoadUrunler();
            LoadSiparisler();
            LoadMasalar();

          
            this.FormClosing += SiparisYonetimiForm_FormClosing;
        }

        private void LoadMasalar()
        {
            List<Masa> masaListesi = new List<Masa>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT MasaID, MasaNumarası FROM Masa WHERE Durum = 'Açık'", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    Masa masa = new Masa
                    {
                        MasaID = Convert.ToInt32(row["MasaID"]),
                        MasaNumarası = row["MasaNumarası"].ToString()
                    };
                    masaListesi.Add(masa);
                }
            }

          
            comboBoxMasa.DataSource = masaListesi;
            comboBoxMasa.DisplayMember = "MasaNumarası"; 
            comboBoxMasa.ValueMember = "MasaID"; 
        }

        private void LoadUrunler()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ürün", connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBoxUrun.DataSource = dt;
                comboBoxUrun.DisplayMember = "ÜrünAdı";
                comboBoxUrun.ValueMember = "ÜrünID";
            }
        }

        private void LoadSiparisler()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
               
                string query = @"
            SELECT 
                s.SiparişID AS [Sipariş No], 
                m.MasaNumarası AS [Masa Numarası], 
                u.ÜrünAdı AS [Ürün Adı], 
                s.Adet AS [Adet]
            FROM 
                Sipariş s
            INNER JOIN 
                Masa m ON s.MasaID = m.MasaID
            INNER JOIN 
                Ürün u ON s.ÜrünID = u.ÜrünID";

                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewSiparisler.DataSource = dt;
                dataGridViewSiparisler.Columns["Sipariş No"].Visible = false;
            }
        }

        

        private void btnSiparisVer_Click_1(object sender, EventArgs e)
        {
            
            if (comboBoxMasa.SelectedValue == null)
            {
                MessageBox.Show("Lütfen bir masa seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (seciliUrunler == null || seciliUrunler.Count == 0)
            {
                MessageBox.Show("Lütfen önce ürün ekleyin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int masaID = Convert.ToInt32(comboBoxMasa.SelectedValue);
            string masaNumarasi = comboBoxMasa.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmdDelete = new SqlCommand("DELETE FROM Sipariş WHERE MasaID = @masaID", connection);
                cmdDelete.Parameters.AddWithValue("@masaID", masaID);
                cmdDelete.ExecuteNonQuery();
            }

            LoadSiparisler();

            var detayForm = new SiparisDetayForm(masaNumarasi, new List<SeciliUrun>(seciliUrunler));
            if (detayForm.ShowDialog() == DialogResult.OK)
            {
                seciliUrunler.Clear();
                dataGridViewSiparisler.DataSource = null;
                LoadSiparisler();
            }
        }

        private List<SeciliUrun> seciliUrunler = new List<SeciliUrun>(); 

        private decimal GetUrunFiyat(int urunID)
        {
            decimal fiyat = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SELECT Fiyat FROM Ürün WHERE ÜrünID = @urunID", connection);
                cmd.Parameters.AddWithValue("@urunID", urunID);
                fiyat = (decimal)cmd.ExecuteScalar(); 
            }
            return fiyat;
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
             
            int urunID = Convert.ToInt32(comboBoxUrun.SelectedValue);
            string urunAdi = comboBoxUrun.Text;
            decimal fiyat = GetUrunFiyat(urunID); 
            int adet = (int)numericUpDownAdet.Value;

            
            SeciliUrun seciliUrun = new SeciliUrun
            {
                UrunID = urunID,
                UrunAdi = urunAdi,
                Fiyat = fiyat,
                Adet = adet
            };

           
            seciliUrunler.Add(seciliUrun);

        
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO Sipariş (MasaID, ÜrünID, Adet) VALUES (@masaID, @urunID, @adet)", connection);
                cmd.Parameters.AddWithValue("@masaID", comboBoxMasa.SelectedValue);
                cmd.Parameters.AddWithValue("@urunID", seciliUrun.UrunID);
                cmd.Parameters.AddWithValue("@adet", seciliUrun.Adet);
                cmd.ExecuteNonQuery();
            }

            LoadSiparisler(); 
            MessageBox.Show($"{seciliUrun.UrunAdi} başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewSiparisler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Silmek için bir sipariş seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow row = dataGridViewSiparisler.SelectedRows[0];

            
            object cellValue = null;
            if (dataGridViewSiparisler.Columns.Contains("SiparişID"))
            {
                cellValue = row.Cells["SiparişID"].Value;
            }
            else if (dataGridViewSiparisler.Columns.Contains("Sipariş No"))
            {
                cellValue = row.Cells["Sipariş No"].Value;
            }
            else if (row.Cells.Count > 0)
            {
                cellValue = row.Cells[0].Value;
            }

            if (cellValue == null || !int.TryParse(Convert.ToString(cellValue), out int siparisID))
            {
                MessageBox.Show("Seçilen satırdan sipariş ID alınamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Sipariş WHERE SiparişID = @siparisID", connection);
                cmd.Parameters.AddWithValue("@siparisID", siparisID);
                cmd.ExecuteNonQuery();
            }

            LoadSiparisler();
            MessageBox.Show("Sipariş başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void SiparisYonetimiForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (comboBoxMasa?.SelectedValue != null)
            {
                int masaID = Convert.ToInt32(comboBoxMasa.SelectedValue);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    
                    connection.Open();

                   
                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM Sipariş WHERE MasaID = @masaID", connection);
                    cmdDelete.Parameters.AddWithValue("@masaID", masaID);

                   
                    int rowsAffected = cmdDelete.ExecuteNonQuery();
                }

                LoadSiparisler();
            }
        }
    }
}
