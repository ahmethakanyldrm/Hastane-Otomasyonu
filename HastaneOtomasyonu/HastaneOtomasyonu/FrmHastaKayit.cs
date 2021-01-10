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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }
        Sql_Baglanti _baglanti = new Sql_Baglanti();
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            /*Eğer Hasta kayıtlı değilse üye  olma formuna gelir ve bilgilerini girerek kayıt olur */
            SqlCommand command = new SqlCommand("insert into Tbl_Hastalar  (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)",_baglanti.baglanti());
            command.Parameters.AddWithValue("@p1", txtAd.Text);
            command.Parameters.AddWithValue("@p2", txtSoyad.Text);
            command.Parameters.AddWithValue("@p3", txtTC.Text);
            command.Parameters.AddWithValue("@p4", txtTelefon.Text);
            command.Parameters.AddWithValue("@p5", txtSifre.Text);
            command.Parameters.AddWithValue("@p6", cmbxCinsiyet.Text);
            command.ExecuteNonQuery();
            _baglanti.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir \n Şifreniz :"+txtSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

      
    }
}
