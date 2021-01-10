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
    public partial class FrmBransPaneli : Form
    {
        public FrmBransPaneli()
        {
            InitializeComponent();
        }
        Sql_Baglanti _Baglanti = new Sql_Baglanti();

        private void FrmBransPaneli_Load(object sender, EventArgs e)
        {
            //Datagridwiev da branşları listeliyoruz
            DataTable dt = new DataTable();
            SqlDataAdapter da=new SqlDataAdapter("Select * From Tbl_Branslar",_Baglanti.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
           
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //Branş Ekleme İşlemi
            SqlCommand command = new SqlCommand("insert into Tbl_Branslar(BransAd) values (@b1)", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@b1", txtBransAd.Text);
            command.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Branş Eklendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
         
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            /*
                Branşları silme İşlemi
             */
            SqlCommand command = new SqlCommand("Delete From Tbl_Branslar where Bransid=@b1", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@b1", txtId.Text);
            command.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Branş Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            /*Branşı Güncelleme*/
            SqlCommand command = new SqlCommand("Update  Tbl_Branslar set Bransad=@b1 where Bransid=@b2", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@b1", txtBransAd.Text);
            command.Parameters.AddWithValue("@b2", txtId.Text);
            command.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Branş Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

       
    }
}
