using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Solo_Cuero
{
    public partial class frm_Products : Form
    {

        CN_Products objetoCN = new CN_Products();
        public frm_Products()
        {
            InitializeComponent();
        }
           
        private void Products_Load(object sender, EventArgs e)
        {

            MostrarProductos();


        }

         public void MostrarProductos ()
        {
            DGV_Facturar.DataSource = objetoCN.MostrarProd();
            DGV_Facturar.Columns[0].Visible = false;

        }

        private void pb_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            frm_InsertProducts InsertProducts = new frm_InsertProducts();
            AddOwnedForm(InsertProducts);
            InsertProducts.ShowDialog();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
 