using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TestRest
{
    public class Connection
    {
        public SqlConnection openConnection()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-1FMQCPV; Initial Catalog=YR; User Id=sa; Password=qwerty");
            return con;
        }
    }
}