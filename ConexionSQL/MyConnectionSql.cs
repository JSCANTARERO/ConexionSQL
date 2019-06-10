using System.Data;
using System;
using System.Data.SqlClient;
namespace ConexionSQL
{
    class MyConnectionSql : MyConnection
    {
        public MyConnectionSql(DataProvider thedataprovider) : base (thedataprovider)
        {
            SqlConnection connectionstring = new SqlConnection(@"server = (local)\SQLEXPRESS; security integrated = true;");
            try
            {
                Console.WriteLine("Conexion establecida");
                connectionstring.Close();
                connectionstring.Open();

                this.Detalles(connectionstring);
            }
            catch(SqlException ex)
            {
                Console.WriteLine("Error {0} {1}", ex.Message, ex.StackTrace);
            }
            finally
            {
                connectionstring.Close();
                Console.WriteLine("Conexion finalziada");
            }
        }

        private void Detalles(SqlConnection connectionstring)
        {
            Console.WriteLine("Connection string: {0}", connectionstring);
            Console.WriteLine("\tBase de datos: {0}", connectionstring.Database);
            Console.WriteLine("\tFuente de datos {0}", connectionstring.DataSource);
            Console.WriteLine("\tVersion del servidor: {0}", connectionstring.ServerVersion);
            Console.WriteLine("\tEstado: {0}", connectionstring.State);
            Console.WriteLine("\tId estacion de trabajo: {0}", connectionstring.WorkstationId);
        }
    }
}