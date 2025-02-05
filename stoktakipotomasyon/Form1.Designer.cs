namespace stoktakipotomasyon
{
    partial class Form1
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
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            label3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            groupBox2 = new GroupBox();
            txtToplamFiyat = new TextBox();
            txtSatışFiyatı = new TextBox();
            txtMiktarı = new TextBox();
            txtÜrünAdı = new TextBox();
            txtBarkodNo = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            btnEkle = new Button();
            btnSatışYap = new Button();
            btnSil = new Button();
            btnSatışİptal = new Button();
            lblGenelToplam = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(334, 173);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(768, 337);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtTelefon);
            groupBox1.Controls.Add(txtAdSoyad);
            groupBox1.Controls.Add(txtTC);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lbl2);
            groupBox1.Controls.Add(lbl1);
            groupBox1.Location = new Point(47, 160);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 142);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Müşteri İşlemleri";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(109, 104);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(109, 64);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 4;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(109, 25);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(125, 27);
            txtTC.TabIndex = 3;
            txtTC.TextChanged += txtTC_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 107);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 2;
            label3.Text = "Telefon";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(9, 67);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(69, 20);
            lbl2.TabIndex = 1;
            lbl2.Text = "AdSoyad";
            lbl2.Click += label2_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(9, 28);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(25, 20);
            lbl1.TabIndex = 0;
            lbl1.Text = "TC";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtToplamFiyat);
            groupBox2.Controls.Add(txtSatışFiyatı);
            groupBox2.Controls.Add(txtMiktarı);
            groupBox2.Controls.Add(txtÜrünAdı);
            groupBox2.Controls.Add(txtBarkodNo);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(47, 308);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 237);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ürün İşlemleri";
            // 
            // txtToplamFiyat
            // 
            txtToplamFiyat.Location = new Point(109, 194);
            txtToplamFiyat.Name = "txtToplamFiyat";
            txtToplamFiyat.Size = new Size(125, 27);
            txtToplamFiyat.TabIndex = 10;
            // 
            // txtSatışFiyatı
            // 
            txtSatışFiyatı.Location = new Point(109, 157);
            txtSatışFiyatı.Name = "txtSatışFiyatı";
            txtSatışFiyatı.Size = new Size(125, 27);
            txtSatışFiyatı.TabIndex = 9;
            txtSatışFiyatı.TextChanged += txtSatışFiyatı_TextChanged;
            // 
            // txtMiktarı
            // 
            txtMiktarı.Location = new Point(109, 116);
            txtMiktarı.Name = "txtMiktarı";
            txtMiktarı.Size = new Size(125, 27);
            txtMiktarı.TabIndex = 8;
            txtMiktarı.Text = "1";
            txtMiktarı.TextAlign = HorizontalAlignment.Center;
            txtMiktarı.TextChanged += txtMiktarı_TextChanged;
            // 
            // txtÜrünAdı
            // 
            txtÜrünAdı.Location = new Point(109, 76);
            txtÜrünAdı.Name = "txtÜrünAdı";
            txtÜrünAdı.Size = new Size(125, 27);
            txtÜrünAdı.TabIndex = 7;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(109, 35);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(125, 27);
            txtBarkodNo.TabIndex = 6;
            txtBarkodNo.TextChanged += txtBarkodNo_TextChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 197);
            label8.Name = "label8";
            label8.Size = new Size(98, 20);
            label8.TabIndex = 5;
            label8.Text = "Toplam Fiyatı";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 160);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 4;
            label7.Text = "Satış Fiyatı";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 119);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 3;
            label6.Text = "Miktarı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 79);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 2;
            label5.Text = "Ürün Adı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 38);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 1;
            label4.Text = "BarkodNo";
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button9);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1214, 125);
            panel1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(1034, 31);
            button2.Name = "button2";
            button2.Size = new Size(94, 55);
            button2.TabIndex = 11;
            button2.Text = "Marka";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(934, 31);
            button1.Name = "button1";
            button1.Size = new Size(94, 55);
            button1.TabIndex = 10;
            button1.Text = "Kategori";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button9
            // 
            button9.Location = new Point(748, 31);
            button9.Name = "button9";
            button9.Size = new Size(146, 55);
            button9.TabIndex = 9;
            button9.Text = "Satışları Listele";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(562, 31);
            button8.Name = "button8";
            button8.Size = new Size(146, 55);
            button8.TabIndex = 8;
            button8.Text = "Ürün Listele";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(410, 31);
            button7.Name = "button7";
            button7.Size = new Size(146, 55);
            button7.TabIndex = 7;
            button7.Text = "Ürün Ekle";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(199, 31);
            button6.Name = "button6";
            button6.Size = new Size(146, 55);
            button6.TabIndex = 6;
            button6.Text = "Müşteri Listele";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(47, 31);
            button5.Name = "button5";
            button5.Size = new Size(146, 55);
            button5.TabIndex = 5;
            button5.Text = "Müşteri Ekle";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(334, 516);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSatışYap
            // 
            btnSatışYap.Location = new Point(906, 516);
            btnSatışYap.Name = "btnSatışYap";
            btnSatışYap.Size = new Size(94, 29);
            btnSatışYap.TabIndex = 5;
            btnSatışYap.Text = "Satış Yap";
            btnSatışYap.UseVisualStyleBackColor = true;
            btnSatışYap.Click += btnSatışYap_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(1108, 173);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 6;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnSatışİptal
            // 
            btnSatışİptal.Location = new Point(1108, 230);
            btnSatışİptal.Name = "btnSatışİptal";
            btnSatışİptal.Size = new Size(94, 29);
            btnSatışİptal.TabIndex = 7;
            btnSatışİptal.Text = "Satış İptal";
            btnSatışİptal.UseVisualStyleBackColor = true;
            btnSatışİptal.Click += btnSatışİptal_Click;
            // 
            // lblGenelToplam
            // 
            lblGenelToplam.AutoSize = true;
            lblGenelToplam.Location = new Point(654, 525);
            lblGenelToplam.Name = "lblGenelToplam";
            lblGenelToplam.Size = new Size(101, 20);
            lblGenelToplam.TabIndex = 8;
            lblGenelToplam.Text = "Genel Toplam";
            lblGenelToplam.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1214, 670);
            Controls.Add(lblGenelToplam);
            Controls.Add(btnSatışİptal);
            Controls.Add(btnSil);
            Controls.Add(btnSatışYap);
            Controls.Add(btnEkle);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Satış Sayfası";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel panel1;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button btnEkle;
        private Button btnSatışYap;
        private Button btnSil;
        private Button btnSatışİptal;
        private Label label3;
        private Label lbl2;
        private Label lbl1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private TextBox txtToplamFiyat;
        private TextBox txtSatışFiyatı;
        private TextBox txtMiktarı;
        private TextBox txtÜrünAdı;
        private TextBox txtBarkodNo;
        private Label lblGenelToplam;
        private Button button2;
        private Button button1;
    }
}
