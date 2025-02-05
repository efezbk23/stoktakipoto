namespace stoktakipotomasyon
{
    partial class frmmüşterilisteleme
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
            txtEmail = new TextBox();
            txtAdres = new TextBox();
            label2 = new Label();
            label4 = new Label();
            txtTelefon = new TextBox();
            txtAdSoyad = new TextBox();
            txtTC = new TextBox();
            label3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            btnSil = new Button();
            txtTcAra = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(298, 114);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(441, 238);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // btnGüncelle
            // 
            btnGüncelle.Location = new Point(182, 323);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new Size(94, 29);
            btnGüncelle.TabIndex = 28;
            btnGüncelle.Text = "Güncelle";
            btnGüncelle.UseVisualStyleBackColor = true;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(151, 275);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(125, 27);
            txtEmail.TabIndex = 27;
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(151, 236);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(125, 27);
            txtAdres.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 278);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 25;
            label2.Text = "E-Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 239);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 24;
            label4.Text = "Adres";
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(151, 193);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(125, 27);
            txtTelefon.TabIndex = 23;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(151, 153);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(125, 27);
            txtAdSoyad.TabIndex = 22;
            // 
            // txtTC
            // 
            txtTC.Location = new Point(151, 114);
            txtTC.Name = "txtTC";
            txtTC.Size = new Size(125, 27);
            txtTC.TabIndex = 21;
            txtTC.TextChanged += txtTC_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 196);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 20;
            label3.Text = "Telefon";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(51, 156);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(69, 20);
            lbl2.TabIndex = 19;
            lbl2.Text = "AdSoyad";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(51, 117);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(25, 20);
            lbl1.TabIndex = 18;
            lbl1.Text = "TC";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(745, 117);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(94, 29);
            btnSil.TabIndex = 29;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // txtTcAra
            // 
            txtTcAra.Location = new Point(508, 53);
            txtTcAra.Name = "txtTcAra";
            txtTcAra.Size = new Size(125, 27);
            txtTcAra.TabIndex = 30;
            txtTcAra.TextChanged += txtTcAra_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(434, 49);
            label1.Name = "label1";
            label1.Size = new Size(68, 28);
            label1.TabIndex = 31;
            label1.Text = "TC Ara";
            // 
            // frmmüşterilisteleme
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(850, 450);
            Controls.Add(label1);
            Controls.Add(txtTcAra);
            Controls.Add(btnSil);
            Controls.Add(btnGüncelle);
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
            Controls.Add(dataGridView1);
            Name = "frmmüşterilisteleme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Müşteri Listeleme Sayfası";
            Load += frmmüşterilisteleme_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGüncelle;
        private TextBox txtEmail;
        private TextBox txtAdres;
        private Label label2;
        private Label label4;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTC;
        private Label label3;
        private Label lbl2;
        private Label lbl1;
        private Button btnSil;
        private TextBox txtTcAra;
        private Label label1;
    }
}