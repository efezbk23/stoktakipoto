namespace stoktakipotomasyon
{
    partial class frmürün_Listele
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
            dataGridView1 = new DataGridView();
            btnGüncelle = new Button();
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
            btnSil = new Button();
            label1 = new Label();
            txtBarkodNoAra = new TextBox();
            comboKategori = new ComboBox();
            comboMarka = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            btnMarkaGüncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(242, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(533, 268);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(142, 335);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(94, 29);
            btnGüncelle.TabIndex = 31;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(5, 309);
            label8.Name = "label8";
            label8.Size = new Size(75, 20);
            label8.TabIndex = 43;
            label8.Text = "Satış Fiyat";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 266);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 42;
            label10.Text = "Miktarı";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(5, 225);
            label11.Name = "label11";
            label11.Size = new Size(67, 20);
            label11.TabIndex = 41;
            label11.Text = "Ürün Adı";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 184);
            label12.Name = "label12";
            label12.Size = new Size(50, 20);
            label12.TabIndex = 40;
            label12.Text = "Marka";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 144);
            label13.Name = "label13";
            label13.Size = new Size(66, 20);
            label13.TabIndex = 39;
            label13.Text = "Katagori";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(5, 99);
            label14.Name = "label14";
            label14.Size = new Size(76, 20);
            label14.TabIndex = 38;
            label14.Text = "BarkodNo";
            // 
            // SatışFiyatxt
            // 
            SatışFiyatxt.Location = new Point(111, 302);
            SatışFiyatxt.Name = "SatışFiyatxt";
            SatışFiyatxt.Size = new Size(125, 27);
            SatışFiyatxt.TabIndex = 37;
            // 
            // Miktarıtxt
            // 
            Miktarıtxt.Location = new Point(111, 263);
            Miktarıtxt.Name = "Miktarıtxt";
            Miktarıtxt.Size = new Size(125, 27);
            Miktarıtxt.TabIndex = 36;
            // 
            // ÜrünAdıtxt
            // 
            ÜrünAdıtxt.Location = new Point(111, 222);
            ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            ÜrünAdıtxt.Size = new Size(125, 27);
            ÜrünAdıtxt.TabIndex = 35;
            // 
            // Markatxt
            // 
            Markatxt.Location = new Point(111, 181);
            Markatxt.Name = "Markatxt";
            Markatxt.ReadOnly = true;
            Markatxt.Size = new Size(125, 27);
            Markatxt.TabIndex = 34;
            // 
            // Kategoritxt
            // 
            Kategoritxt.Location = new Point(111, 141);
            Kategoritxt.Name = "Kategoritxt";
            Kategoritxt.ReadOnly = true;
            Kategoritxt.Size = new Size(125, 27);
            Kategoritxt.TabIndex = 33;
            // 
            // BarkodNotxt
            // 
            BarkodNotxt.Location = new Point(111, 96);
            BarkodNotxt.Name = "BarkodNotxt";
            BarkodNotxt.Size = new Size(125, 27);
            BarkodNotxt.TabIndex = 32;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(781, 96);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(72, 29);
            btnSil.TabIndex = 44;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(356, 50);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 45;
            label1.Text = "BarkodNo ya Göre Ara";
            // 
            // txtBarkodNoAra
            // 
            txtBarkodNoAra.Location = new Point(520, 47);
            txtBarkodNoAra.Name = "txtBarkodNoAra";
            txtBarkodNoAra.Size = new Size(125, 27);
            txtBarkodNoAra.TabIndex = 46;
            txtBarkodNoAra.TextChanged += txtBarkodNoAra_TextChanged;
            // 
            // comboKategori
            // 
            comboKategori.FormattingEnabled = true;
            comboKategori.Location = new Point(393, 382);
            comboKategori.Name = "comboKategori";
            comboKategori.Size = new Size(121, 28);
            comboKategori.TabIndex = 47;
            comboKategori.SelectedIndexChanged += comboKategori_SelectedIndexChanged;
            // 
            // comboMarka
            // 
            comboMarka.FormattingEnabled = true;
            comboMarka.Location = new Point(393, 436);
            comboMarka.Name = "comboMarka";
            comboMarka.Size = new Size(121, 28);
            comboMarka.TabIndex = 48;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 439);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 50;
            label2.Text = "Marka";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(301, 385);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 49;
            label3.Text = "Katagori";
            // 
            // btnMarkaGüncelle
            // 
            btnMarkaGüncelle.Location = new Point(530, 382);
            btnMarkaGüncelle.Name = "btnMarkaGüncelle";
            btnMarkaGüncelle.Size = new Size(94, 82);
            btnMarkaGüncelle.TabIndex = 51;
            btnMarkaGüncelle.Text = "Kategori Marka Güncelle";
            btnMarkaGüncelle.UseVisualStyleBackColor = true;
            btnMarkaGüncelle.Click += btnMarkaGüncelle_Click;
            // 
            // frmürün_Listele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(864, 479);
            Controls.Add(btnMarkaGüncelle);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(comboMarka);
            Controls.Add(comboKategori);
            Controls.Add(txtBarkodNoAra);
            Controls.Add(label1);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(SatışFiyatxt);
            Controls.Add(Miktarıtxt);
            Controls.Add(ÜrünAdıtxt);
            Controls.Add(Markatxt);
            Controls.Add(Kategoritxt);
            Controls.Add(BarkodNotxt);
            Controls.Add(dataGridView1);
            Name = "frmürün_Listele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ürün Listeleme Sayfası";
            Load += frmürün_Listele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGüncelle;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox SatışFiyatxt;
        private TextBox Miktarıtxt;
        private TextBox ÜrünAdıtxt;
        private TextBox Markatxt;
        private TextBox Kategoritxt;
        private TextBox BarkodNotxt;
        private Button btnSil;
        private Label label1;
        private TextBox txtBarkodNoAra;
        private ComboBox comboKategori;
        private ComboBox comboMarka;
        private Label label2;
        private Label label3;
        private Button btnMarkaGüncelle;
    }
}