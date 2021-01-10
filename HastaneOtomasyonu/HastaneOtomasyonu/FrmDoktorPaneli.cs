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
namespace HastaneOtomasyonu
{
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }
        Sql_Baglanti _Baglanti = new Sql_Baglanti();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Doktorlar", _Baglanti.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşı comboboxa aktarma

            SqlCommand command2 = new SqlCommand("Select BransAd From Tbl_Branslar", _Baglanti.baglanti());
            SqlDataReader dataReader = command2.ExecuteReader();
            while (dataReader.Read())
            {
                cmbBrans.Items.Add(dataReader[0]);
            }
            _Baglanti.baglanti().Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Doktor Ekleme İşlemi
            SqlCommand command = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)  ", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@d1", txtAd.Text);
            command.Parameters.AddWithValue("@d2", txtSoyad.Text);
            command.Parameters.AddWithValue("@d3", cmbBrans.Text);
            command.Parameters.AddWithValue("@d4", txtTC.Text);
            command.Parameters.AddWithValue("@d5", txtSifre.Text);
            command.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //dataGridView da kayıtlı doktorları listeleme 
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //Doktor Silme İşlemi
            SqlCommand command = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC=@p1", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@p1", txtTC.Text);
            command.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            //Doktor Güncelleme İşlemi
            SqlCommand command = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorBrans=@d3,DoktorSifre=@d5 where DoktorTC=@d4  ", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@d1", txtAd.Text);
            command.Parameters.AddWithValue("@d2", txtSoyad.Text);
            command.Parameters.AddWithValue("@d3", cmbBrans.Text);
            command.Parameters.AddWithValue("@d4", txtTC.Text);
            command.Parameters.AddWithValue("@d5", txtSifre.Text);
            command.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
