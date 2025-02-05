using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace stoktakipotomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");
        DataSet daset = new DataSet();
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from sepet", baglanti);
            adtr.Fill(daset, "sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            baglanti.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmM��teriekle ekle = new frmM��teriekle();
            ekle.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmm��terilisteleme listele = new frmm��terilisteleme();
            listele.ShowDialog();

        }
        private void hesapla()
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select sum(toplamfiyati) from sepet", baglanti);
                lblGenelToplam.Text = komut.ExecuteScalar() + "TL";
                baglanti.Close();
            }
            catch (Exception)
            {
                ;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frm�r�nEkle ekle = new frm�r�nEkle();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmKatagori katagori = new frmKatagori();
            katagori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT urunadi, miktari FROM urun WHERE miktari <= 50", baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            StringBuilder uyarilar = new StringBuilder();

            while (reader.Read())
            {
                uyarilar.AppendLine($"�r�n: {reader["urunadi"]}, Stok: {reader["miktari"]}");
            }

            baglanti.Close();

            if (uyarilar.Length > 0)
            {
                MessageBox.Show("D���k Stok Uyar�s�:\n\n" + uyarilar.ToString(), "Stok Uyar�s�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            frm�r�n_Listele listele = new frm�r�n_Listele();
            listele.ShowDialog();
        }


        private void txtTC_TextChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from m��teri where tc like '" + txtTC.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktar�)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from urun where barkodno like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt�r�nAd�.Text = read["urunadi"].ToString();
                txtSat��Fiyat�.Text = read["satisfiyati"].ToString();
            }
            baglanti.Close();
        }

        private void Temzile()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtMiktar�)
                        {
                            item.Text = "";
                        }
                    }

                }
            }
        }
        bool durum;
        private void barkodkontrol()
        {
            durum = true;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from sepet", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (txtBarkodNo.Text == read["barkodno"].ToString())
                {
                    durum = false;
                }
            }
            baglanti.Close();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            barkodkontrol();
            if (durum == true)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into sepet(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
                komut.Parameters.AddWithValue("@urunadi", txt�r�nAd�.Text);
                komut.Parameters.AddWithValue("@miktari", int.Parse(txtMiktar�.Text));
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(txtSat��Fiyat�.Text));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(txtToplamFiyat.Text));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update sepet set miktari=miktari+'" + int.Parse(txtMiktar�.Text) + "'where barkodno='" + txtBarkodNo.Text + "'", baglanti);
                komut2.ExecuteNonQuery();
                SqlCommand komut3 = new SqlCommand("update sepet set toplamfiyati=miktari*satisfiyati where barkodno='" + txtBarkodNo.Text + "'", baglanti);
                komut3.ExecuteNonQuery();

                baglanti.Close();
            }
            txtMiktar�.Text = "1";
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
            foreach (Control item in groupBox2.Controls)
            {
                if (item is TextBox)
                {
                    if (item != txtMiktar�)
                    {
                        item.Text = "";
                    }
                }

            }
        }

        private void txtMiktar�_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar�.Text) * double.Parse(txtSat��Fiyat�.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void txtSat��Fiyat�_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktar�.Text) * double.Parse(txtSat��Fiyat�.Text)).ToString();
            }
            catch (Exception)
            {
                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("�r�n Sepetten ��kar�ld�");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void btnSat���ptal_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet ", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("�r�nler Sepetten ��kar�ld�");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmSat��Listele listele = new frmSat��Listele();
            listele.ShowDialog();
        }

        private void btnSat��Yap_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string barkodno = dataGridView1.Rows[i].Cells["barkodno"].Value.ToString();
                int satilanMiktar = int.Parse(dataGridView1.Rows[i].Cells["miktari"].Value.ToString());

                // Stok kontrol�
                baglanti.Open();
                SqlCommand stokKontrolKomut = new SqlCommand("select miktari from urun where barkodno=@barkodno", baglanti);
                stokKontrolKomut.Parameters.AddWithValue("@barkodno", barkodno);
                int mevcutStok = Convert.ToInt32(stokKontrolKomut.ExecuteScalar());
                baglanti.Close();

                if (satilanMiktar > mevcutStok)
                {
                    MessageBox.Show($"Barkod No: {barkodno} - Yetersiz stok! Mevcut stok: {mevcutStok}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Sat�� i�lemi
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into satis(tc,adsoyad,telefon,barkodno,urunadi,miktari,satisfiyati,toplamfiyati,tarih) values(@tc,@adsoyad,@telefon,@barkodno,@urunadi,@miktari,@satisfiyati,@toplamfiyati,@tarih)", baglanti);
                komut.Parameters.AddWithValue("@tc", txtTC.Text);
                komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                komut.Parameters.AddWithValue("@barkodno", barkodno);
                komut.Parameters.AddWithValue("@urunadi", dataGridView1.Rows[i].Cells["urunadi"].Value.ToString());
                komut.Parameters.AddWithValue("@miktari", satilanMiktar);
                komut.Parameters.AddWithValue("@satisfiyati", double.Parse(dataGridView1.Rows[i].Cells["satisfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@toplamfiyati", double.Parse(dataGridView1.Rows[i].Cells["toplamfiyati"].Value.ToString()));
                komut.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());
                komut.ExecuteNonQuery();

                SqlCommand komut2 = new SqlCommand("update urun set miktari=miktari-@satilanMiktar where barkodno=@barkodno", baglanti);
                komut2.Parameters.AddWithValue("@satilanMiktar", satilanMiktar);
                komut2.Parameters.AddWithValue("@barkodno", barkodno);
                komut2.ExecuteNonQuery();
                baglanti.Close();
            }

            // Sepeti temizle
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("delete from sepet", baglanti);
            komut3.ExecuteNonQuery();
            baglanti.Close();

            daset.Tables["sepet"].Clear();
            sepetlistele();
            hesapla();

            // Sat�� sonras� kalan stok miktarlar�n� bildir
            StringBuilder stokBilgi = new StringBuilder();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string barkodno = dataGridView1.Rows[i].Cells["barkodno"].Value.ToString();

                baglanti.Open();
                SqlCommand kalanStokKomut = new SqlCommand("select miktari from urun where barkodno=@barkodno", baglanti);
                kalanStokKomut.Parameters.AddWithValue("@barkodno", barkodno);
                int kalanStok = Convert.ToInt32(kalanStokKomut.ExecuteScalar());
                baglanti.Close();

                stokBilgi.AppendLine($"Barkod No: {barkodno} - Kalan Stok: {kalanStok}");
            }

            MessageBox.Show("Sat�� i�lemi tamamland�.\n\n" + stokBilgi.ToString(), "Sat�� Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }

}
