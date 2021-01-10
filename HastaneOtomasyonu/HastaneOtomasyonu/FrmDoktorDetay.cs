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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }
        Sql_Baglanti _Baglanti = new Sql_Baglanti();
        public string TC;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'hastaneProjeDataSet.Tbl_Randevular' table. You can move, or remove it, as needed.
            this.tbl_RandevularTableAdapter.Fill(this.hastaneProjeDataSet.Tbl_Randevular);
            lblDoktorTC.Text = TC;

            //Doktor Ad Soyad 
            SqlCommand command = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1", _Baglanti.baglanti());
            command.Parameters.AddWithValue("@p1", lblDoktorTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblDoktorAdSoyad.Text = dr[0] + "  " + dr[1];
            }
            _Baglanti.baglanti().Close();

         
           
        }

        private void btnBilgiDuzenleme_Click(object sender, EventArgs e)
        {
            //Bilgi Düzenleme Formuna Geçiş Yapar
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TC_No = lblDoktorTC.Text;
            fr.Show();
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            //Duyuru Formunu Açar
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            // Çıkış Yapar
            Application.Exit();
        }

      

      
    }

    }

