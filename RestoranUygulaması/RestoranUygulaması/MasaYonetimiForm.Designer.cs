namespace RestoranUygulaması
{
    partial class MasaYonetimiForm
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
            dataGridViewMasalar = new DataGridView();
            btnMasaEkle = new Button();
            btnMasaKapat = new Button();
            label1 = new Label();
            btnMasaSil = new Button();
            btnMasaAc = new Button();
            txtMasaNumarasi = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasalar).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMasalar
            // 
            dataGridViewMasalar.AllowUserToOrderColumns = true;
            dataGridViewMasalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMasalar.Location = new Point(331, 0);
            dataGridViewMasalar.Name = "dataGridViewMasalar";
            dataGridViewMasalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMasalar.Size = new Size(382, 450);
            dataGridViewMasalar.TabIndex = 0;
            // 
            // btnMasaEkle
            // 
            btnMasaEkle.Location = new Point(8, 12);
            btnMasaEkle.Name = "btnMasaEkle";
            btnMasaEkle.Size = new Size(75, 23);
            btnMasaEkle.TabIndex = 1;
            btnMasaEkle.Text = "Masa Ekle";
            btnMasaEkle.UseVisualStyleBackColor = true;
            btnMasaEkle.Click += btnMasaEkle_Click_1;
            // 
            // btnMasaKapat
            // 
            btnMasaKapat.Location = new Point(113, 41);
            btnMasaKapat.Name = "btnMasaKapat";
            btnMasaKapat.Size = new Size(104, 23);
            btnMasaKapat.TabIndex = 2;
            btnMasaKapat.Text = "Masa Kapat";
            btnMasaKapat.UseVisualStyleBackColor = true;
            btnMasaKapat.Click += btnMasaKapat_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(5, 105);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 4;
            label1.Text = "Masa Numarası";
            // 
            // btnMasaSil
            // 
            btnMasaSil.Location = new Point(5, 41);
            btnMasaSil.Name = "btnMasaSil";
            btnMasaSil.Size = new Size(78, 23);
            btnMasaSil.TabIndex = 5;
            btnMasaSil.Text = "MasaSil";
            btnMasaSil.UseVisualStyleBackColor = true;
            btnMasaSil.Click += btnMasaSil_Click;
            // 
            // btnMasaAc
            // 
            btnMasaAc.Location = new Point(113, 12);
            btnMasaAc.Name = "btnMasaAc";
            btnMasaAc.Size = new Size(104, 23);
            btnMasaAc.TabIndex = 6;
            btnMasaAc.Text = "Masa Aç";
            btnMasaAc.UseVisualStyleBackColor = true;
            btnMasaAc.Click += btnMasaAc_Click;
            // 
            // txtMasaNumarasi
            // 
            txtMasaNumarasi.Location = new Point(113, 97);
            txtMasaNumarasi.Mask = "00";
            txtMasaNumarasi.Name = "txtMasaNumarasi";
            txtMasaNumarasi.Size = new Size(104, 23);
            txtMasaNumarasi.TabIndex = 7;
            txtMasaNumarasi.ValidatingType = typeof(int);
            // 
            // MasaYonetimiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 450);
            Controls.Add(txtMasaNumarasi);
            Controls.Add(btnMasaAc);
            Controls.Add(btnMasaSil);
            Controls.Add(label1);
            Controls.Add(btnMasaKapat);
            Controls.Add(btnMasaEkle);
            Controls.Add(dataGridViewMasalar);
            Name = "MasaYonetimiForm";
            Text = "MasaYonetimiForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMasalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMasalar;
        private Button btnMasaEkle;
        private Button btnMasaKapat;
        private Label label1;
        private Button btnMasaSil;
        private Button btnMasaAc;
        private MaskedTextBox txtMasaNumarasi;
    }
}