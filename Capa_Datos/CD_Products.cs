using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Capa_Datos
{
    public class CD_Products
    {

        private CD_Conexion Conexion = new CD_Conexion();

        // Este es para que se puedean leer las tablas
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        // Metodo para mostrar los registros de la tabla producto

        public DataTable Mostrar()
        {
              
           

            comando.Connection = Conexion.abrirConexion();
            comando.CommandText = "sp_MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            Conexion.Cerrarconexion();
            return tabla;

        }
  
         public void insert ( string Nombre, string Descripcion, int Stock, string Categoria ,double Precio , string size, string color )

        {
            comando.Connection = Conexion.abrirConexion();
            comando.CommandText = "sp_InsertProducts";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@Descripcion", Descripcion);
            comando.Parameters.AddWithValue("@Stock", Stock);
            comando.Parameters.AddWithValue("@Categoria", Categoria);
            comando.Parameters.AddWithValue("@Precio", Precio);
            comando.Parameters.AddWithValue("@Size", size);
            comando.Parameters.AddWithValue("@Color", color);


            comando.ExecuteNonQuery();

        }






    }
}
