using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stoktakipotomasyon
{
    public partial class frmMarka : Form
    {
        public frmMarka()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");
        bool durum;

        private void markakontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from marka", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (cmbKategori.Text==read["kategori"].ToString() && txtmarka.Text == read["marka"].ToString() || cmbKategori.Text == "" || txtmarka.Text == "")
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            markakontrol();
            if (durum == true)  
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into marka(kategori,marka) values('" + cmbKategori.Text + "','" + txtmarka.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori Ve Marka VAR");
            }
            txtmarka.Text = "";
            cmbKategori.Text = "";
            
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
    }
}
