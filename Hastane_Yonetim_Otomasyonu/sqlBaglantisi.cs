using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hastane_Yonetim_Otomasyonu
{
    class sqlBaglantisi
    {
        public SqlConnection connection()
        {
            SqlConnection conn = new SqlConnection("Data Source=ISMAILAVCI\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
