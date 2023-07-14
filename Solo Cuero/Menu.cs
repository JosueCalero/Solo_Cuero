using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Solo_Cuero
{
    public partial class frm_menu : Form
    {
        public frm_menu()
        {
            InitializeComponent();
        }



        [DllImport("user32.Dll", EntryPoint =  "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll" , EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd
            , int msg, IntPtr wParam, IntPtr lParam);

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            DialogResult res;
            res = MessageBox.Show("Quiere cerrar el progama", "exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)

            {
                Application.Exit();
            }

            else
            {
                this.Show();
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pb_Maximizar.Visible = false;
            pb_restaurar.Visible = true;
            
        }

        private void pb_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pb_Maximizar.Visible = true;
            pb_restaurar.Visible = false;
        }

        private void pb_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnl_TopBar_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle,0x112, (IntPtr)0xf012, (IntPtr)0);



        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }



        private void AbrirForminPanel(object formhijo)

        {

            if (this.pnl_Contenedor.Controls.Count > 0)
                this.pnl_Contenedor.Controls.RemoveAt(0);

            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnl_Contenedor.Controls.Add(fh);
            this.pnl_Contenedor.Tag = fh;
            fh.Show();


        }
            



        private void btn_Products_Click(object sender, EventArgs e)
        {
            

            AbrirForminPanel(new frm_Products());


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

