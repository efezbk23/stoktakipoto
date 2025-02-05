namespace stoktakipotomasyon
{
    partial class frmGirişEkranı
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(98, 20);
            label1.Name = "label1";
            label1.Size = new Size(173, 32);
            label1.TabIndex = 0;
            label1.Text = "Giriş Ekranı ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label2.Location = new Point(3, 102);
            label2.Name = "label2";
            label2.Size = new Size(128, 23);
            label2.TabIndex = 1;
            label2.Text = "Kullanıcı Adı:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.Location = new Point(74, 154);
            label3.Name = "label3";
            label3.Size = new Size(58, 23);
            label3.TabIndex = 2;
            label3.Text = "Şifre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(137, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 27);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Location = new Point(137, 231);
            button1.Name = "button1";
            button1.Size = new Size(100, 32);
            button1.TabIndex = 5;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmGirişEkranı
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(380, 314);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmGirişEkranı";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGirişEkranı";
            Load += frmGirişEkranı_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}