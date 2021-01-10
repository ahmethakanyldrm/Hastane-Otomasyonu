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
    public partial class FrmSekreterDetay : Form
    {
        public string Tc_Numara;
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

     
    

        Sql_Baglanti _Baglanti = new Sql_Baglanti();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblSekreterTC.Text = Tc_Numara;
          

            // Ad Soyad

            SqlCommand command = new SqlCommand("Select  SekreterAdSoyad From Tbl_Sekreter where SekreterTC=@p1", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@p1", lblSekreterTC.Text);
            SqlDataReader dr1 = command.ExecuteReader();
            while (dr1.Read())
            {
                lblSekreterAdSoyad.Text = dr1[0].ToString();
            }

            _Baglanti.baglanti().Close();


            // Branşları Datagride Aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Branslar", _Baglanti.baglanti());
            da.Fill(dt1);
            dataGridView1.DataSource = dt1;


            // Doktorları Datagride aktarma
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("Select (DoktorAd + ' ' +  DoktorSoyad) as 'Doktorlar', DoktorBrans from Tbl_Doktorlar", _Baglanti.baglanti());
            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


            //Branşı comboboxa aktarma

            SqlCommand command2 = new SqlCommand("Select BransAd From Tbl_Branslar", _Baglanti.baglanti());
            SqlDataReader dataReader = command2.ExecuteReader();
            while (dataReader.Read())
            {
                cmbBrans.Items.Add(dataReader[0]);
            }
            _Baglanti.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Sekreter Doktorun durumuna göre randevu oluşturup kaydeder
            SqlCommand command3 = new SqlCommand("insert into Tbl_Randevular(RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)", _Baglanti.baglanti());
            command3.Parameters.AddWithValue("@p1", txtTarih.Text);
            command3.Parameters.AddWithValue("@p2", txtSaat.Text);
            command3.Parameters.AddWithValue("@p3", cmbBrans.Text);
            command3.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            command3.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand command4 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorBrans=@p1", _Baglanti.baglanti());
            command4.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dataReader2 = command4.ExecuteReader();
            while (dataReader2.Read())
            {
                cmbDoktor.Items.Add(dataReader2[0] + " " + dataReader2[1]);
            }
            _Baglanti.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            //Sekreter Duyuru Oluşturur
            SqlCommand command5 = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1) ", _Baglanti.baglanti());
            command5.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            command5.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            //Doktor Panelini görüntüler
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();

        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            //Branş Panelini görüntüler
            FrmBransPaneli frb = new FrmBransPaneli();
            frb.Show();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            //Randevu Listesini Görüntüler
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            //Duyuru Panelini görüntüler
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}