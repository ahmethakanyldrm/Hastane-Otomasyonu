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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }
        Sql_Baglanti _Baglanti = new Sql_Baglanti();
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            //Sekreter Giriş Yapar şifre veya tc hatalı ise giriş yapamaz
            SqlCommand command = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC=@p1 and SekreterSifre=@p2",_Baglanti.baglanti());
            command.Parameters.AddWithValue("@p1", txtTC.Text);
            command.Parameters.AddWithValue("@p2", txtSifre.Text);

            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.Tc_Numara = txtTC.Text;
                frs.Show();
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
