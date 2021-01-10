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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;
        Sql_Baglanti _Baglanti = new Sql_Baglanti();
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblHastaTC.Text = tc;

            // Ad Soyad Veri Çekme
            SqlCommand command = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",_Baglanti.baglanti());
            command.Parameters.AddWithValue("@p1", lblHastaTC.Text);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                lblHastaAdSoyad.Text = dr[0] + " " + dr[1];
            }
            _Baglanti.baglanti().Close();

            //Randevu Geçmişi 
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC="+tc,_Baglanti.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


            //Branşları Çekme
            SqlCommand command2 = new SqlCommand("Select BransAd From Tbl_Branslar", _Baglanti.baglanti());
            SqlDataReader dr2 = command2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            _Baglanti.baglanti().Close();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand command3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", _Baglanti.baglanti());
            command3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = command3.ExecuteReader();
            while(dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            _Baglanti.baglanti().Close();
                }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuBrans='" + cmbBrans.Text + "'" + " and RandevuDoktor= '"+cmbDoktor.Text +"' and RandevuDurum=0", _Baglanti.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void lnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Bilgi Düzenleme Formuna Geçiş Yapılır
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TC_no = lblHastaTC.Text;
            fr.Show();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            //Randevu Alma işlemi Yapılır 
            SqlCommand command4 = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTC=@p1,HastaSikayet=@p2 where Randevuid=@p3", _Baglanti.baglanti());
            command4.Parameters.AddWithValue("@p1", lblHastaTC.Text);
            command4.Parameters.AddWithValue("@p2", rchSikayet.Text);
            command4.Parameters.AddWithValue("@p3", txtId.Text);
            command4.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Randevu Alındı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Alınabilecek Randevuları Listeleriz 
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
