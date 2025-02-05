namespace stoktakipotomasyon
{
    partial class frmSatışListele
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
            btnGecmisiSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(117, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(571, 266);
            dataGridView1.TabIndex = 0;
            // 
            // btnGecmisiSil
            // 
            btnGecmisiSil.Location = new Point(594, 363);
            btnGecmisiSil.Name = "btnGecmisiSil";
            btnGecmisiSil.Size = new Size(94, 29);
            btnGecmisiSil.TabIndex = 1;
            btnGecmisiSil.Text = "Geçmişi Sil";
            btnGecmisiSil.UseVisualStyleBackColor = true;
            btnGecmisiSil.Click += btnGecmisiSil_Click;
            // 
            // frmSatışListele
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGecmisiSil);
            Controls.Add(dataGridView1);
            Name = "frmSatışListele";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Satış Listeleme Sayfası";
            Load += frmSatışListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnGecmisiSil;
    }
}