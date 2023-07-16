using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    internal class CD_Conexion
    {
        private SqlConnection Conexion = new SqlConnection("server=(local);DataBase=Solo_Cueros;Integrated security=true");

        public SqlConnection abrirConexion()
        {

            if (Conexion.State == System.Data.ConnectionState.Closed)
                  Conexion.Open();
            return Conexion;

        }


        public SqlConnection Cerrarconexion()
        {

            if (Conexion.State == System.Data.ConnectionState.Open)
                Conexion.Close();
            return Conexion;


        }




    }
}
