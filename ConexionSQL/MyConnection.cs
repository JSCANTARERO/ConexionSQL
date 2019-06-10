using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Odbc;

namespace ConexionSQL
{
    public enum DataProvider { SqlServer, OleDb, Odbc, None}
    class MyConnection
    {
        protected DataProvider dataProvider;
        public MyConnection(DataProvider theDataProvider)
        {
            dataProvider = theDataProvider;
        }

        public void Conectar()
        {

        }
    }
}
