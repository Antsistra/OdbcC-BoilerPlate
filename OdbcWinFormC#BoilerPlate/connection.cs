using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace OdbcWinFormC_BoilerPlate
{
    internal class connection
    {
        OdbcCommand dml;

        public static OdbcDataReader dr;
        public static OdbcConnection conn;

        public void OpenConn()
        {
            conn = new OdbcConnection("DSN=name+db");
            conn.Open();
        }
    }
}
