using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Model.Connection
{
    public class DBConnection
    {
        SqlConnection conectn = new SqlConnection("Data Source=AJAY;Initial Catalog=LMS;Integrated Security=True");

        public SqlConnection ActiveCon()
        {
            if (conectn.State == ConnectionState.Closed)
            {
                conectn.Open();
            }
            return conectn;
        }

        public void CloseCon()
        {
            if (conectn.State == ConnectionState.Open)
            {
                conectn.Close();
            }
        }

    }
}
