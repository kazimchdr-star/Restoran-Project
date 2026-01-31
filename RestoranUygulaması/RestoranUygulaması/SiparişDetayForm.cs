using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RestoranUygulaması
{
    public partial class SiparisDetayForm : Form
    {
        private int masaID;
        private string masaNumarasi;
        private List<SeciliUrun> urunler;


        public SiparisDetayForm(string masaNumarasi, List<SeciliUrun> seciliUrunler)
        {
            InitializeComponent();

            this.masaNumarasi = masaNumarasi;
            this.urunler = seciliUrunler ?? new List<SeciliUrun>();


            InitializeDetaylar();
        }

        private void InitializeDetaylar()
        {

            lblMasa.Text = $"Masa: {masaNumarasi}";


            panelUrunler.Controls.Clear();

            decimal toplam = 0m;
            foreach (var u in urunler)
            {

                var lbl = new Label();
                lbl.AutoSize = false;
                lbl.Width = panelUrunler.ClientSize.Width - 10;
                lbl.Height = 30;
                lbl.Margin = new Padding(3);
                lbl.TextAlign = ContentAlignment.MiddleLeft;
                lbl.Text = $"{u.UrunAdi} x{u.Adet} - {u.Fiyat:C2} / adet  = {(u.Fiyat * u.Adet):C2}";
                lbl.BorderStyle = BorderStyle.None;

                panelUrunler.Controls.Add(lbl);

                toplam += u.Fiyat * u.Adet;
            }

            lblToplamHesap.Text = toplam.ToString("C2");
        }

        private void btnHesapOde_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ödeme alındı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}


