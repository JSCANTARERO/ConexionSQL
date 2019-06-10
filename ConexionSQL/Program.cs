using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            MyConnection myconexion = new MyConnection(DataProvider.SqlServer);

            myconexion.Conectar();
            myconexion.TipoDeConeccion();
            Console.ReadLine();
        }
    }
}
