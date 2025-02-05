namespace stoktakipotomasyon
{
    partial class frmÜrünEkle
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
            groupBox1 = new GroupBox();
            cmbMarka = new ComboBox();
            cmbKategori = new ComboBox();
            txtSatışFiyatı = new TextBox();
            btnYeniEkle = new Button();
            txtMiktarı = new TextBox();
            txtÜrünAdı = new TextBox();
            txtBarkodNo = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            lblMiktar = new Label();
            btnVarOlanEkle = new Button();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            SatışFiyatxt = new TextBox();
            Miktarıtxt = new TextBox();
            ÜrünAdıtxt = new TextBox();
            Markatxt = new TextBox();
            Kategoritxt = new TextBox();
            BarkodNotxt = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbMarka);
            groupBox1.Controls.Add(cmbKategori);
            groupBox1.Controls.Add(txtSatışFiyatı);
            groupBox1.Controls.Add(btnYeniEkle);
            groupBox1.Controls.Add(txtMiktarı);
            groupBox1.Controls.Add(txtÜrünAdı);
            groupBox1.Controls.Add(txtBarkodNo);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(25, 65);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(258, 316);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Ürün";
            // 
            // cmbMarka
            // 
            cmbMarka.FormattingEnabled = true;
            cmbMarka.Location = new Point(109, 115);
            cmbMarka.Name = "cmbMarka";
            cmbMarka.Size = new Size(125, 28);
            cmbMarka.TabIndex = 24;
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(109, 75);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(125, 28);
            cmbKategori.TabIndex = 23;
            cmbKategori.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtSatışFiyatı
            // 
            txtSatışFiyatı.Location = new Point(109, 240);
            txtSatışFiyatı.Name = "txtSatışFiyatı";
            txtSatışFiyatı.Size = new Size(125, 27);
            txtSatışFiyatı.TabIndex = 22;
            // 
            // btnYeniEkle
            // 
            btnYeniEkle.Location = new Point(140, 273);
            btnYeniEkle.Name = "btnYeniEkle";
            btnYeniEkle.Size = new Size(94, 29);
            btnYeniEkle.TabIndex = 2;
            btnYeniEkle.Text = "Ekle";
            btnYeniEkle.UseVisualStyleBackColor = true;
            btnYeniEkle.Click += btnYeniEkle_Click;
            // 
            // txtMiktarı
            // 
            txtMiktarı.Location = new Point(109, 197);
            txtMiktarı.Name = "txtMiktarı";
            txtMiktarı.Size = new Size(125, 27);
            txtMiktarı.TabIndex = 20;
            // 
            // txtÜrünAdı
            // 
            txtÜrünAdı.Location = new Point(109, 156);
            txtÜrünAdı.Name = "txtÜrünAdı";
            txtÜrünAdı.Size = new Size(125, 27);
            txtÜrünAdı.TabIndex = 19;
            // 
            // txtBarkodNo
            // 
            txtBarkodNo.Location = new Point(109, 30);
            txtBarkodNo.Name = "txtBarkodNo";
            txtBarkodNo.Size = new Size(125, 27);
            txtBarkodNo.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 247);
            label7.Name = "label7";
            label7.Size = new Size(75, 20);
            label7.TabIndex = 8;
            label7.Text = "Satış Fiyat";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 200);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 6;
            label5.Text = "Miktarı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 159);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "Ürün Adı";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 118);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 4;
            label3.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 78);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 3;
            label2.Text = "Katagori";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "BarkodNo";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMiktar);
            groupBox2.Controls.Add(btnVarOlanEkle);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(SatışFiyatxt);
            groupBox2.Controls.Add(Miktarıtxt);
            groupBox2.Controls.Add(ÜrünAdıtxt);
            groupBox2.Controls.Add(Markatxt);
            groupBox2.Controls.Add(Kategoritxt);
            groupBox2.Controls.Add(BarkodNotxt);
            groupBox2.Location = new Point(322, 65);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(276, 316);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Var Olan Ürünler";
            // 
            // lblMiktar
            // 
            lblMiktar.AutoSize = true;
            lblMiktar.Location = new Point(18, 282);
            lblMiktar.Name = "lblMiktar";
            lblMiktar.Size = new Size(0, 20);
            lblMiktar.TabIndex = 25;
            // 
            // btnVarOlanEkle
            // 
            btnVarOlanEkle.Location = new Point(155, 269);
            btnVarOlanEkle.Name = "btnVarOlanEkle";
            btnVarOlanEkle.Size = new Size(94, 29);
            btnVarOlanEkle.TabIndex = 3;
            btnVarOlanEkle.Text = "Ekle";
            btnVarOlanEkle.UseVisualStyleBackColor = true;
            btnVarOlanEkle.Click += btnVarOlanEkle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 243);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 30;
            label8.Text = "Satış Fiyat";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 200);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 28;
            label10.Text = "Miktarı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 159);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 27;
            label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 118);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 26;
            label12.Text = "Marka";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 78);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 25;
            label13.Text = "Katagori";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 33);
            label14.Name = "label14";
            label14.Size = new Size(76, 20);
            label14.TabIndex = 24;
            label14.Text = "BarkodNo";
            // 
            // SatışFiyatxt
            // 
            SatışFiyatxt.Location = new Point(124, 236);
            SatışFiyatxt.Name = "SatışFiyatxt";
            SatışFiyatxt.Size = new Size(125, 27);
            SatışFiyatxt.TabIndex = 23;
            // 
            // Miktarıtxt
            // 
            Miktarıtxt.Location = new Point(124, 197);
            Miktarıtxt.Name = "Miktarıtxt";
            Miktarıtxt.Size = new Size(125, 27);
            Miktarıtxt.TabIndex = 21;
            // 
            // ÜrünAdıtxt
            // 
            ÜrünAdıtxt.Location = new Point(124, 156);
            ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            ÜrünAdıtxt.Size = new Size(125, 27);
            ÜrünAdıtxt.TabIndex = 20;
            // 
            // Markatxt
            // 
            Markatxt.Location = new Point(124, 115);
            Markatxt.Name = "Markatxt";
            Markatxt.Size = new Size(125, 27);
            Markatxt.TabIndex = 19;
            // 
            // Kategoritxt
            // 
            Kategoritxt.Location = new Point(124, 75);
            Kategoritxt.Name = "Kategoritxt";
            Kategoritxt.Size = new Size(125, 27);
            Kategoritxt.TabIndex = 18;
            // 
            // BarkodNotxt
            // 
            BarkodNotxt.Location = new Point(124, 30);
            BarkodNotxt.Name = "BarkodNotxt";
            BarkodNotxt.Size = new Size(125, 27);
            BarkodNotxt.TabIndex = 17;
            BarkodNotxt.TextChanged += BarkodNotxt_TextChanged;
            // 
            // frmÜrünEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(621, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "frmÜrünEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Ekleme Sayfası";
            Load += frmÜrünEkle_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox txtMiktarı;
        private TextBox txtÜrünAdı;
        private TextBox txtBarkodNo;
        private TextBox Miktarıtxt;
        private TextBox ÜrünAdıtxt;
        private TextBox Markatxt;
        private TextBox Kategoritxt;
        private TextBox BarkodNotxt;
        private Button btnYeniEkle;
        private Button btnVarOlanEkle;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private ComboBox cmbMarka;
        private ComboBox cmbKategori;
        private TextBox txtSatışFiyatı;
        private Label label7;
        private Label label8;
        private TextBox SatışFiyatxt;
        private Label lblMiktar;
    }
}