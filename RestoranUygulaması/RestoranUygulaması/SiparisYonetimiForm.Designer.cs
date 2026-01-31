namespace RestoranUygulaması
{
    partial class SiparisYonetimiForm
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
            comboBoxUrun = new ComboBox();
            dataGridViewSiparisler = new DataGridView();
            numericUpDownAdet = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btnSiparisVer = new Button();
            comboBoxMasa = new ComboBox();
            label4 = new Label();
            btnUrunEkle = new Button();
            btnUrunSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSiparisler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdet).BeginInit();
            SuspendLayout();
            // 
            // comboBoxUrun
            // 
            comboBoxUrun.FormattingEnabled = true;
            comboBoxUrun.Location = new Point(112, 12);
            comboBoxUrun.Name = "comboBoxUrun";
            comboBoxUrun.Size = new Size(121, 23);
            comboBoxUrun.TabIndex = 0;
            // 
            // dataGridViewSiparisler
            // 
            dataGridViewSiparisler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSiparisler.Location = new Point(266, 12);
            dataGridViewSiparisler.Name = "dataGridViewSiparisler";
            dataGridViewSiparisler.Size = new Size(508, 320);
            dataGridViewSiparisler.TabIndex = 1;
            // 
            // numericUpDownAdet
            // 
            numericUpDownAdet.Location = new Point(113, 41);
            numericUpDownAdet.Name = "numericUpDownAdet";
            numericUpDownAdet.Size = new Size(120, 23);
            numericUpDownAdet.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 15);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 4;
            label1.Text = "Ürün Seç";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 43);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 4;
            label2.Text = "Adet";
            // 
            // btnSiparisVer
            // 
            btnSiparisVer.Location = new Point(113, 204);
            btnSiparisVer.Name = "btnSiparisVer";
            btnSiparisVer.Size = new Size(120, 23);
            btnSiparisVer.TabIndex = 5;
            btnSiparisVer.Text = "Sipariş Ver";
            btnSiparisVer.UseVisualStyleBackColor = true;
            btnSiparisVer.Click += btnSiparisVer_Click_1;
            // 
            // comboBoxMasa
            // 
            comboBoxMasa.FormattingEnabled = true;
            comboBoxMasa.Location = new Point(113, 70);
            comboBoxMasa.Name = "comboBoxMasa";
            comboBoxMasa.Size = new Size(121, 23);
            comboBoxMasa.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 73);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 7;
            label4.Text = "Masa Numarası";
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.Location = new Point(113, 130);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(120, 23);
            btnUrunEkle.TabIndex = 8;
            btnUrunEkle.Text = "Ürün Ekle";
            btnUrunEkle.UseVisualStyleBackColor = true;
            btnUrunEkle.Click += btnUrunEkle_Click;
            // 
            // btnUrunSil
            // 
            btnUrunSil.Location = new Point(113, 165);
            btnUrunSil.Name = "btnUrunSil";
            btnUrunSil.Size = new Size(120, 23);
            btnUrunSil.TabIndex = 9;
            btnUrunSil.Text = "Ürün Sil";
            btnUrunSil.UseVisualStyleBackColor = true;
            btnUrunSil.Click += btnUrunSil_Click;
            // 
            // SiparisYonetimiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 327);
            Controls.Add(btnUrunSil);
            Controls.Add(btnUrunEkle);
            Controls.Add(label4);
            Controls.Add(comboBoxMasa);
            Controls.Add(btnSiparisVer);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDownAdet);
            Controls.Add(dataGridViewSiparisler);
            Controls.Add(comboBoxUrun);
            Name = "SiparisYonetimiForm";
            Text = "SiparisYonetimiForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewSiparisler).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxUrun;
        private DataGridView dataGridViewSiparisler;
        private NumericUpDown numericUpDownAdet;
        private Label label1;
        private Label label2;
        private Button btnSiparisVer;
        private ComboBox comboBoxMasa;
        private Label label4;
        private Button btnUrunEkle;
        private Button btnUrunSil;
    }
}