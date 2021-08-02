using MySql.Data.MySqlClient;
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
using AppPackGo;

namespace AppLibertad
{
    public partial class VentanaAcceso : Form
    {

        Gestor_de_Datos oBD = new Gestor_de_Datos();


        public VentanaAcceso()
        {
            InitializeComponent();           
        }

        //movilizar ventana por el escritorio:

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //;

      

        private void btnIngresar_Click(object sender, EventArgs e)
        {            
            try
            {
                var usuario = tbUsuario.Text.Trim();
                var contrasena = tbContra.Text;
                var consulta = "SELECT * from USUARIOS where usuario like '" + usuario + "' and passw like '" + contrasena + "' limit 1 ;";

               
                DataTable tablaUsuario = new DataTable();
                tablaUsuario = oBD.consultarBDD(consulta);
                
                if (tablaUsuario.Rows.Count != 0)     
                {              
                    VentanaInterfazUsuario interfaz = new VentanaInterfazUsuario(tablaUsuario);
                    interfaz.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales Incorrectas. Intente nuevamente.", "Error de Credenciales", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalirAcceso_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Seguro de abandonar la aplicación ?",
           "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
             MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "USUARIO:")
            {
                tbUsuario.Text = "";
                tbUsuario.ForeColor = Color.MidnightBlue;

            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if (tbUsuario.Text == "")
            {
                tbUsuario.Text = "USUARIO:";
                tbUsuario.ForeColor = Color.MidnightBlue;
            }
        }

        private void tbContra_Enter(object sender, EventArgs e)
        {
            if (tbContra.Text == "CONTRASEÑA:")
            {
                tbContra.Text = "";
                tbContra.ForeColor = Color.MidnightBlue;
                tbContra.UseSystemPasswordChar = true;

            }
        }

        private void tbContra_Leave(object sender, EventArgs e)
        {
            if (tbContra.Text == "")
            {
                tbContra.Text = "CONTRASEÑA:";
                tbContra.ForeColor = Color.MidnightBlue;
                tbContra.UseSystemPasswordChar = false;
            }
        }

        private void btnMinimizarAcceso_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void VentanaAcceso_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
