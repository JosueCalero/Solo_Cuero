using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Capa_Datos;
using System.Data; 



namespace Capa_Negocio
{
      public class CN_Products
    {

        public CD_Products objetoCD = new CD_Products();

        // Metodo Tipo Datateable 

        public DataTable MostrarProd()
        {
            DataTable table = new DataTable();
            table = objetoCD.Mostrar();
            return table;
           
        }

        public void InsertProducts(string Nombre, string Descripcion, string Stock, string Categoria, string Precio, string size, string color)
        {

            objetoCD.insert(Nombre, Descripcion, Convert.ToInt32(Stock), Categoria, Convert.ToDouble(Precio), size , color);
        
        
        
        }


        

        
      





    }
}
    