namespace RestoranUygulaması
{
    partial class MenuYonetimiForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewUrunler = new DataGridView();
            btnUrunEkle = new Button();
            btnUrunSil = new Button();
            numericUpDownFiyat = new NumericUpDown();
            txtUrunAd = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFiyat).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUrunler
            // 
            dataGridViewUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUrunler.Location = new Point(272, 3);
            dataGridViewUrunler.Name = "dataGridViewUrunler";
            dataGridViewUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewUrunler.Size = new Size(530, 369);
            dataGridViewUrunler.TabIndex = 0;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(12, 130);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(75, 23);
            btnUrunEkle.TabIndex = 1;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click_1;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(93, 130);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(75, 23);
            btnUrunSil.TabIndex = 2;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click_1;
            // 
            // numericUpDownFiyat
            // 
            numericUpDownFiyat.Location = new Point(93, 36);
            numericUpDownFiyat.Name = "numericUpDownFiyat";
            numericUpDownFiyat.Size = new Size(75, 23);
            numericUpDownFiyat.TabIndex = 3;
            // 
            // txtUrunAd
            // 
            txtUrunAd.Location = new Point(93, 83);
            txtUrunAd.Name = "txtUrunAd";
            txtUrunAd.Size = new Size(75, 23);
            txtUrunAd.TabIndex = 4;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 5;
            label1.Text = "Fiyat";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 91);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 5;
            label2.Text = "Ürün Adı";
            // 
            // MenuYonetimiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUrunAd);
            Controls.Add(numericUpDownFiyat);
            Controls.Add(btnUrunSil);
            Controls.Add(btnUrunEkle);
            Controls.Add(dataGridViewUrunler);
            Name = "MenuYonetimiForm";
            Text = "MenuYonetimiForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownFiyat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUrunler;
        private Button btnUrunEkle;
        private Button btnUrunSil;
        private NumericUpDown numericUpDownFiyat;
        private TextBox txtUrunAd;
        private Label label1;
        private Label label2;
    }
}