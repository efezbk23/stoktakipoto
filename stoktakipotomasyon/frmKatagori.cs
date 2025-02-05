using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace stoktakipotomasyon
{
    public partial class frmKatagori : Form
    {
        public frmKatagori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");
        bool durum;

        private void katagorikontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri ",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                if (txtKategori.Text == read["kategori"].ToString() || txtKategori.Text=="")
                {
                    durum=false;
                }            
            }
            baglanti.Close();
        }        
        private void frmKatagori_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            katagorikontrol();
            if(durum==true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kategoribilgileri(kategori) values('" + txtKategori.Text + "')", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kategori Eklendi");
            }
            else
            {
                MessageBox.Show("Böyle Bir Kategori Var", "Uyarı");
            }
            txtKategori.Text = "";
        }
    }
}
