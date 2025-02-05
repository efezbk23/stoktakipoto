using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace stoktakipotomasyon
{
    public partial class frmGirişEkranı : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;

        public frmGirişEkranı()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");
            com= new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "Select*From Kullanici_Bilgi where kullanici_adi='" + textBox1.Text + "'And sifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                Form1 gecis = new Form1();
                gecis.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Hatalı Kullancı Adı veya Şifre");
            }
            con.Close();
        }

        private void frmGirişEkranı_Load(object sender, EventArgs e)
        {

        }
    }
}
