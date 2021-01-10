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
    public partial class FrmDoktorBilgiDuzenle : Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        Sql_Baglanti _Baglanti = new Sql_Baglanti();
        public string TC_No;
        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            /*Giriş Yapan doktorun TC sine göre ad soyad branş ve şifre  bilgilerini ekrana getirmek*/
            txtTC.Text = TC_No;
            SqlCommand command = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@p1", txtTC.Text);

            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text= dr[2].ToString();
                cmbBrans.Text= dr[3].ToString();
                txtSifre.Text= dr[5].ToString();
            }
            _Baglanti.baglanti().Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            /*Bilgi Güncelleme İşlemi*/
            SqlCommand command = new SqlCommand("Update  Tbl_Doktorlar set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p4 where DoktorTC=@p5", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", cmbBrans.Text);
            command.Parameters.AddWithValue("@p4", txtSifre.Text);
            command.Parameters.AddWithValue("@p5", txtTC.Text);
            command.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }

      
    }
}
