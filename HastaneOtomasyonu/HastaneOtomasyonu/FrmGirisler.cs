using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneOtomasyonu
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();

        }

        private void btnHastaGirisi_Click(object sender, EventArgs e)
        {
            //Hasta Giriş Paneline Geçiş Yapılır
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            /*this.Hide(); paneli kapatmanın işi zorlaştırdığını düşündüm her seferinde yeniden çalıştırmak mecburiyetinde kalıyorduk
              o yüzden yorum  haline aldım */

        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            //Doktor Giriş Paneline Geçiş Yapılır
            FrmDoktorGiris fr = new FrmDoktorGiris();
            fr.Show();
         //   this.Hide();
        }

        private void btnSekreterGirisi_Click(object sender, EventArgs e)
        {
            //Sekreter Giriş Paneline Geçiş Yapılır
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
    //        this.Hide();
        }

      
    }
}
