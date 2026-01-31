namespace RestoranUygulaması
{
    partial class GarsonYonetimiForm
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
            dataGridViewGarsonlar = new DataGridView();
            btnGarsonEkle = new Button();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnGarsonSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGarsonlar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewGarsonlar
            // 
            dataGridViewGarsonlar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGarsonlar.Location = new Point(291, 12);
            dataGridViewGarsonlar.Name = "dataGridViewGarsonlar";
            dataGridViewGarsonlar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewGarsonlar.Size = new Size(408, 242);
            dataGridViewGarsonlar.TabIndex = 0;
            // 
            // btnGarsonEkle
            // 
            btnGarsonEkle.Location = new Point(12, 124);
            btnGarsonEkle.Name = "btnGarsonEkle";
            btnGarsonEkle.Size = new Size(172, 23);
            btnGarsonEkle.TabIndex = 1;
            btnGarsonEkle.Text = "Garson Ekle";
            btnGarsonEkle.UseVisualStyleBackColor = true;
            btnGarsonEkle.Click += btnGarsonEkle_Click_1;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(84, 22);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(100, 23);
            txtAd.TabIndex = 2;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(84, 64);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(100, 23);
            txtSoyad.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 3;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 3;
            label2.Text = "Soyad";
            // 
            // btnGarsonSil
            // 
            btnGarsonSil.Location = new Point(12, 168);
            btnGarsonSil.Name = "btnGarsonSil";
            btnGarsonSil.Size = new Size(172, 23);
            btnGarsonSil.TabIndex = 4;
            btnGarsonSil.Text = "Garson Sil";
            btnGarsonSil.UseVisualStyleBackColor = true;
            btnGarsonSil.Click += btnGarsonSil_Click;
            // 
            // GarsonYonetimiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(btnGarsonSil);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(btnGarsonEkle);
            Controls.Add(dataGridViewGarsonlar);
            Name = "GarsonYonetimiForm";
            Text = "GarsonYonetimiForm";
            Load += GarsonYonetimiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGarsonlar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewGarsonlar;
        private Button btnGarsonEkle;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label1;
        private Label label2;
        private Button btnGarsonSil;
    }
}