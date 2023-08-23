using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace University
{
    class sqlcont
    {
        public SqlConnection connect()
        {
            SqlConnection cont = new SqlConnection(@"Data Source=ATALAY\SQLEXPRESS;Initial Catalog=dbo.Uni;Integrated Security=True");
            cont.Open();
            return cont;
        }
    }
}
