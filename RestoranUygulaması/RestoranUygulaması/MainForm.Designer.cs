namespace RestoranUygulaması
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMasaYonetimi = new Button();
            btnSiparisYonetimi = new Button();
            btnGarsonYonetimi = new Button();
            btnMenuYonetimi = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnMasaYonetimi
            // 
            btnMasaYonetimi.Location = new Point(305, 92);
            btnMasaYonetimi.Name = "btnMasaYonetimi";
            btnMasaYonetimi.Size = new Size(107, 23);
            btnMasaYonetimi.TabIndex = 0;
            btnMasaYonetimi.Text = "Masa Yönetimi";
            btnMasaYonetimi.UseVisualStyleBackColor = true;
            btnMasaYonetimi.Click += btnMasaYonetimi_Click;
            // 
            // btnSiparisYonetimi
            // 
            btnSiparisYonetimi.Location = new Point(305, 267);
            btnSiparisYonetimi.Name = "btnSiparisYonetimi";
            btnSiparisYonetimi.Size = new Size(107, 23);
            btnSiparisYonetimi.TabIndex = 1;
            btnSiparisYonetimi.Text = "Sipariş Ver";
            btnSiparisYonetimi.UseVisualStyleBackColor = true;
            btnSiparisYonetimi.Click += btnSiparisYonetimi_Click;
            // 
            // btnGarsonYonetimi
            // 
            btnGarsonYonetimi.Location = new Point(305, 148);
            btnGarsonYonetimi.Name = "btnGarsonYonetimi";
            btnGarsonYonetimi.Size = new Size(107, 23);
            btnGarsonYonetimi.TabIndex = 2;
            btnGarsonYonetimi.Text = "Garson Yönetimi";
            btnGarsonYonetimi.UseVisualStyleBackColor = true;
            btnGarsonYonetimi.Click += btnGarsonYonetimi_Click;
            // 
            // btnMenuYonetimi
            // 
            btnMenuYonetimi.Location = new Point(305, 203);
            btnMenuYonetimi.Name = "btnMenuYonetimi";
            btnMenuYonetimi.Size = new Size(107, 23);
            btnMenuYonetimi.TabIndex = 3;
            btnMenuYonetimi.Text = "Menü Yönetimi";
            btnMenuYonetimi.UseVisualStyleBackColor = true;
            btnMenuYonetimi.Click += btnMenuYonetimi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(269, 28);
            label1.Name = "label1";
            label1.Size = new Size(186, 30);
            label1.TabIndex = 4;
            label1.Text = "Restoran Yönetimi";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(799, 374);
            Controls.Add(label1);
            Controls.Add(btnMenuYonetimi);
            Controls.Add(btnGarsonYonetimi);
            Controls.Add(btnSiparisYonetimi);
            Controls.Add(btnMasaYonetimi);
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMasaYonetimi;
        private Button btnSiparisYonetimi;
        private Button btnGarsonYonetimi;
        private Button btnMenuYonetimi;
        private Label label1;
    }
}
