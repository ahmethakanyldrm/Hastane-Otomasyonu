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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        Sql_Baglanti _Baglanti = new Sql_Baglanti();
        private void LnkUyeOl_Click(object sender, EventArgs e)
        {
            //Eğer Hasta Sisteme Kayıtlı değilse Üye Olması Gerekir Hasta Kayıt formuna geçiş yapılır
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            /*Hasta tc ve şifresiyle giriş yapar  eğer tc veya şifre hatalıysa giriş yapamaz */
            SqlCommand command = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2",_Baglanti.baglanti());
            command.Parameters.AddWithValue("@p1", txtTC.Text);
            command.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = txtTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı şifre veya TC girdiniz!!");
            }
            _Baglanti.baglanti().Close();
        }
    }
}
