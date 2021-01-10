using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace HastaneOtomasyonu
{
    class Sql_Baglanti
    {
      public  SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-TR33C9R\\MSSQLSERVER01;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
