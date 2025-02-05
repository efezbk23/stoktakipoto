namespace stoktakipotomasyon
{
    partial class frmMüşteriekle
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
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            label3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            label2 = new Label();
            label4 = new Label();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(147, 156);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 11;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(147, 116);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 10;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(147, 77);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(125, 27);
            txtTC.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 159);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 8;
            label3.Text = "Telefon";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(47, 119);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(69, 20);
            lbl2.TabIndex = 7;
            lbl2.Text = "AdSoyad";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(47, 80);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(25, 20);
            lbl1.TabIndex = 6;
            lbl1.Text = "TC";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 238);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 16;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(147, 199);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(125, 27);
            txtAdres.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 241);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 13;
            label2.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 202);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 12;
            label4.Text = "Adres";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(178, 286);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 17;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // frmMüşteriekle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(306, 386);
            Controls.Add(btnEkle);
            Controls.Add(txtEmail);
            Controls.Add(txtAdres);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTC);
            Controls.Add(label3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "frmMüşteriekle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMüşteriekle";
            Load += frmMüşteriekle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private Label label3;
        private Label lbl2;
        private Label lbl1;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private Label label2;
        private Label label4;
        private Button btnEkle;
    }
}