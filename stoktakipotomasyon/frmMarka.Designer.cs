namespace stoktakipotomasyon
{
    partial class frmMarka
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
            cmbKategori = new ComboBox();
            txtmarka = new TextBox();
            lanbel1 = new Label();
            label2 = new Label();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // cmbKategori
            // 
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(80, 43);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(151, 28);
            cmbKategori.TabIndex = 0;
            // 
            // txtmarka
            // 
            txtmarka.Location = new Point(80, 77);
            txtmarka.Name = "txtmarka";
            txtmarka.Size = new Size(151, 27);
            txtmarka.TabIndex = 1;
            // 
            // lanbel1
            // 
            lanbel1.AutoSize = true;
            lanbel1.Location = new Point(12, 43);
            lanbel1.Name = "lanbel1";
            lanbel1.Size = new Size(66, 20);
            lanbel1.TabIndex = 2;
            lanbel1.Text = "Kategori";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 80);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 3;
            label2.Text = "Marka";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(137, 110);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 4;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // frmMarka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(277, 180);
            Controls.Add(btnEkle);
            Controls.Add(label2);
            Controls.Add(lanbel1);
            Controls.Add(txtmarka);
            Controls.Add(cmbKategori);
            Name = "frmMarka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMarka";
            Load += frmMarka_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbKategori;
        private TextBox txtmarka;
        private Label lanbel1;
        private Label label2;
        private Button btnEkle;
    }
}