using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AplikasiKasirL
{
    class Koneksi
    {
        public SqlConnection Getconn()
        {
            SqlConnection Conn = new SqlConnection();
            Conn.ConnectionString = "Data Source = DESKTOP-R3O2C2H; Initial Catalog = KasirApp; Integrated Security = True";
            return Conn;
        }
    }
}
