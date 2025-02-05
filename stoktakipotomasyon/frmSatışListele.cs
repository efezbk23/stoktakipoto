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
    public partial class frmSatışListele : Form
    {
        public frmSatışListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ASUS\\SQLEXPRESS;Initial Catalog=Stok_Takip;Integrated Security=True;");
        DataSet daset = new DataSet();
        private void satışlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];

            baglanti.Close();
        }

        private void frmSatışListele_Load(object sender, EventArgs e)
        {
            satışlistele();
        }

        private void btnGecmisiSil_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Tüm satış geçmişini silmek istediğinizden emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (onay == DialogResult.Yes)
            {
                try
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("DELETE FROM satis", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("Satış geçmişi başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    daset.Tables["satis"].Clear();
                    satışlistele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (baglanti.State == ConnectionState.Open)
                        baglanti.Close();
                }
            }
        }
    }
}
