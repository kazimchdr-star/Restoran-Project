namespace RestoranUygulaması
{
    partial class SiparisDetayForm
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
            lblMasa = new Label();
            lblToplamHesap = new Label();
            btnHesapOde = new Button();
            panelUrunler = new FlowLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblMasa
            // 
            lblMasa.AutoSize = true;
            lblMasa.Font = new Font("Segoe UI", 12F);
            lblMasa.Location = new Point(250, 19);
            lblMasa.Name = "lblMasa";
            lblMasa.Size = new Size(52, 21);
            lblMasa.TabIndex = 0;
            lblMasa.Text = "label1";
            // 
            // lblToplamHesap
            // 
            lblToplamHesap.AutoSize = true;
            lblToplamHesap.Font = new Font("Segoe UI", 12F);
            lblToplamHesap.Location = new Point(250, 65);
            lblToplamHesap.Name = "lblToplamHesap";
            lblToplamHesap.Size = new Size(52, 21);
            lblToplamHesap.TabIndex = 1;
            lblToplamHesap.Text = "label2";
            // 
            // btnHesapOde
            // 
            btnHesapOde.Location = new Point(169, 311);
            btnHesapOde.Name = "btnHesapOde";
            btnHesapOde.Size = new Size(92, 23);
            btnHesapOde.TabIndex = 2;
            btnHesapOde.Text = "Hesap Öde";
            btnHesapOde.UseVisualStyleBackColor = true;
            btnHesapOde.Click += btnHesapOde_Click;
            // 
            // panelUrunler
            // 
            panelUrunler.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            panelUrunler.Location = new Point(111, 133);
            panelUrunler.Name = "panelUrunler";
            panelUrunler.Size = new Size(199, 159);
            panelUrunler.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(108, 61);
            label2.Name = "label2";
            label2.Size = new Size(130, 21);
            label2.TabIndex = 4;
            label2.Text = "Toplam Hesap : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(111, 19);
            label1.Name = "label1";
            label1.Size = new Size(113, 21);
            label1.TabIndex = 4;
            label1.Text = "Masa Bilgisi : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(162, 109);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 5;
            label3.Text = "Ürün Bilgisi";
            label3.Click += label3_Click;
            // 
            // SiparisDetayForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 463);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(panelUrunler);
            Controls.Add(btnHesapOde);
            Controls.Add(lblToplamHesap);
            Controls.Add(lblMasa);
            Name = "SiparisDetayForm";
            Text = "SiparisDetayForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMasa;
        private Label lblToplamHesap;
        private Button btnHesapOde;
        private FlowLayoutPanel panelUrunler;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}