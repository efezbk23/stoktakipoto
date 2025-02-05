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
    public partial class frmürün_Listele : Form
    {
        public frmürün_Listele()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");
        DataSet daset = new DataSet();

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }

        private void frmürün_Listele_Load(object sender, EventArgs e)
        {
            ÜrünListele();
            kategorigetir();
            // CellFormatting event'ını ekleyelim
            dataGridView1.CellFormatting += new DataGridViewCellFormattingEventHandler(dataGridView1_CellFormatting);
        }

        private void ÜrünListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            BarkodNotxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            Kategoritxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            Markatxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            ÜrünAdıtxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            Miktarıtxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            SatışFiyatxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi,miktari=@miktari,satisfiyati=@satisfiyati where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
            komut.Parameters.AddWithValue("@urunadi", ÜrünAdıtxt.Text);
            komut.Parameters.AddWithValue("@miktari", int.Parse(Miktarıtxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati", double.Parse(SatışFiyatxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Güncelleme Yapıldı");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaGüncelle_Click(object sender, EventArgs e)
        {
            if (BarkodNotxt.Text != "")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori,marka=@marka where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", BarkodNotxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme Yapıldı");
                daset.Tables["urun"].Clear();
                ÜrünListele();
            }
            else
            {
                MessageBox.Show("Barkodno Yazılı Değil");
            }
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from marka where kategori='" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            ÜrünListele();
            MessageBox.Show("Kayıt Silindi");
        }

        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from urun where barkodno like '%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (dataGridView1.Columns[e.ColumnIndex].Name == "miktari")
            {
                
                if (e.Value != null && int.TryParse(e.Value.ToString(), out int miktar))
                {
                    
                    if (miktar >= 250)
                    {
                        e.CellStyle.BackColor = Color.Green;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (miktar >= 150 && miktar <= 249)
                    {
                        e.CellStyle.BackColor = Color.Yellow;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                    else if (miktar >= 100 && miktar <= 149)
                    {
                        e.CellStyle.BackColor = Color.Orange;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (miktar >= 51 && miktar <= 99)
                    {
                        e.CellStyle.BackColor = Color.DarkOrange;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else if (miktar <= 50)
                    {
                        e.CellStyle.BackColor = Color.Red;
                        e.CellStyle.ForeColor = Color.White;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.White;
                        e.CellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }
    }
}
