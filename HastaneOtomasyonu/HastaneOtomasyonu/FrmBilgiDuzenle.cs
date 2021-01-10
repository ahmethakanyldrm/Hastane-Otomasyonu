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
    public partial class FrmBilgiDuzenle : Form
    {
        public FrmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TC_no;
        Sql_Baglanti _Baglanti = new Sql_Baglanti();
        private void FrmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            //Amaç Veri Tabanında bulunan hasta bilgilerinin hepsini getirmeyi yani hastanın adını soyadını tc sini telefonunu şifresini getirmek
            txtTC.Text = TC_no;
            SqlCommand command = new SqlCommand("Select * From Tbl_Hastalar where HastaTC=@p1",_Baglanti.baglanti());
            command.Parameters.AddWithValue("@p1",txtTC.Text);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                txtTelefon.Text = dr[4].ToString();
                txtSifre.Text = dr[5].ToString();
                cmbxCinsiyet.Text = dr[6].ToString();

            }
            _Baglanti.baglanti().Close();

        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            //Hastanın kendi girdiği bilgileri Güncellemesini sağlar 
            SqlCommand command2 = new SqlCommand("update Tbl_Hastalar set HastaAd=@p1,HastaSoyad=@p2,HastaTelefon=@p3,HastaSifre=@p4,HastaCinsiyet=@p5 where HastaTC=@p6",_Baglanti.baglanti());
            command2.Parameters.AddWithValue("@p1", txtAd.Text);
            command2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command2.Parameters.AddWithValue("@p3", txtTelefon.Text);
            command2.Parameters.AddWithValue("@p4", txtSifre.Text);
            command2.Parameters.AddWithValue("@p5", cmbxCinsiyet.Text);
            command2.Parameters.AddWithValue("@p6", txtTC.Text);
            command2.ExecuteNonQuery();
            _Baglanti.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
