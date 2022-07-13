using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DAO_QLKS
{
    public class DBConnect
    {
        protected SqlConnection _conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=QLKS;Integrated Security=True");
    }
}
