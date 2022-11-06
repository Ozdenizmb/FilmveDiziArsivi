using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _102.ORN.Film_Arsivi
{
    class Connection
    {
        public SqlConnection Baglanti()
        {
            SqlConnection Baglan = new SqlConnection(@"Data Source=DESKTOP-TO6PJTR;Initial Catalog=FilmveDizi_Arsivi;Integrated Security=True");
            Baglan.Open();

            return Baglan;
        }
    }
}
