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
    public partial class FrmRandevuListesi : Form
    {
        public FrmRandevuListesi()
        {
            InitializeComponent();
        }
        Sql_Baglanti _Baglanti = new Sql_Baglanti();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            //Randevuların Listesini Görüntüleriz
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular", _Baglanti.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        
     
    }
}
