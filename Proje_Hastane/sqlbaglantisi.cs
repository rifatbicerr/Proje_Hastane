using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    internal class sqlbaglantisi //sınıfımızın adı
    {
        public SqlConnection baglanti() //metodumuzun adı
        {
            //baglan nesnemizin adı
            SqlConnection baglan = new SqlConnection("Data Source=RIFAT;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
    
}
