namespace stoktakipotomasyon
{
    partial class frmKatagori
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
            txtKategori = new TextBox();
            label1 = new Label();
            btnEkle = new Button();
            SuspendLayout();
            // 
            // txtKategori
            // 
            txtKategori.Location = new Point(104, 56);
            txtKategori.Name = "txtKategori";
            txtKategori.Size = new Size(158, 27);
            txtKategori.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(24, 57);
            label1.Name = "label1";
            label1.Size = new Size(74, 23);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(168, 100);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // frmKatagori
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(367, 170);
            Controls.Add(btnEkle);
            Controls.Add(label1);
            Controls.Add(txtKategori);
            Name = "frmKatagori";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Kategori Sayfası";
            Load += frmKatagori_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtKategori;
        private Label label1;
        private Button btnEkle;
    }
}