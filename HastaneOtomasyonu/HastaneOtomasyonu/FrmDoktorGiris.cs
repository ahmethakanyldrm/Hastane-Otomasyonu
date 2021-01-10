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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        Sql_Baglanti _Baglanti = new Sql_Baglanti();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            /*Bu kısımda doktor tc ve şifresine göre giriş yapar eğer şifre veya tc hatalıysa giriş yapamaz
             Giriş Yapınca da doktor detay Formuna geçiş yapılır*/
            SqlCommand command = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTC=@p1 and DoktorSifre=@p2", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@p1", txtTC.Text);
            command.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader dr1 = command.ExecuteReader();
            if (dr1.Read())
            {
                FrmDoktorDetay frm = new FrmDoktorDetay();
                frm.TC = txtTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya Şifre");
            }
            _Baglanti.baglanti().Close();
        }

       
    }
}