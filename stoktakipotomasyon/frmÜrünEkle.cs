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
    public partial class frmÜrünEkle : Form
    {
        public frmÜrünEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");
        bool durum;

        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString() ||  txtBarkodNo.Text=="")
                {
                    durum = false;
                }
            }
            baglanti.Close();
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
        private void frmÜrünEkle_Load(object sender, EventArgs e)
        {
            kategorigetir();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();
            cmbMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from marka where kategori='" + cmbKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                cmbMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnYeniEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if(durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into urun(barkodno,kategori,marka,urunadi,miktari,satisfiyati,tarih) values(@barkodno,@kategori,@marka,@urunadi,@miktari,@satisfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                komut.Parameters.AddWithValue("@marka", cmbMarka.Text);
                komut.Parameters.AddWithValue("@urunadi", txtÜrünAdı.Text);
                komut.Parameters.AddWithValue("miktari", int.Parse(txtMiktarı.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSatışFiyatı.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Ürün Eklendi"); 
            }
            else
            {
                MessageBox.Show("Böyle Bir Barkodno Var","Uyarı");
            }            
            
            cmbMarka.Items.Clear();
            foreach (Control Item in groupBox1.Controls)
            {
                if (Item is TextBox)
                {
                    Item.Text = "";
                }
                if (Item is ComboBox)
                {
                    Item.Text = "";
                }
            }
        }

        private void btnVarOlanEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set miktari=miktari+'"+int.Parse(Miktarıtxt.Text)+"' where barkodno='" + BarkodNotxt.Text + "'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("Var Olan Ürün Ekleme Yapıldı");
        }

        private void BarkodNotxt_TextChanged(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text == "")
            {
                lblMiktar.Text = "";
                foreach(Control Item in groupBox2.Controls)
                {
                    if (Item is TextBox)
                    {
                        Item.Text = "";                    
                    }
                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '"+BarkodNotxt.Text+"'", baglanti);
            SqlDataReader reader = komut.ExecuteReader();
            while(reader.Read())
            {
                Kategoritxt.Text = reader["kategori"].ToString();
                Markatxt.Text = reader["marka"].ToString();
                ÜrünAdıtxt.Text = reader["urunadi"].ToString();
                Miktarıtxt.Text = reader["miktari"].ToString();
                SatışFiyatxt.Text = reader["satisfiyati"].ToString();
                
            }
            baglanti.Close() ;
        }
    }
}
