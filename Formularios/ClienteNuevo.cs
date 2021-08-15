using AppPackGo.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPackGo.Formularios
{
    public partial class ClienteNuevo : Form
    {
        Gestor_de_Datos oBD = new Gestor_de_Datos();

        //movilizar ventana por el escritorio:

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        public ClienteNuevo()
        {
            InitializeComponent();
            cargarCombo(comboProvincias, "PROVINCIAS");
        }

        private void ClienteNuevo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Termina movilizar por el escritorio

        private void cargarCombo(ComboBox combo, string PROVINCIAS)
        {
            DataTable tabla = oBD.consultarBDD("select * from " + PROVINCIAS + " order by 2");
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Clientes c = new Clientes();

                c.pCliente = tbCrearCliente.Text.ToUpper();
                c.pProvincia = Convert.ToInt32(comboProvincias.SelectedValue);

                string consulta = "INSERT INTO CLIENTES(nombre_cliente, id_prov) VALUES (@cliente, @provincia);";
                oBD.actualizarConParametrosCliente(consulta, c);

                MessageBox.Show("Operacion Exitosa");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbCrearCliente_Enter(object sender, EventArgs e)
        {
            if (tbCrearCliente.Text == "Nombre:")
            {
                tbCrearCliente.Text = "";
                tbCrearCliente.ForeColor = Color.MidnightBlue;

            }
        }

        private void tbCrearCliente_Leave(object sender, EventArgs e)
        {
            if (tbCrearCliente.Text == "")
            {
                tbCrearCliente.Text = "Nombre:";
                tbCrearCliente.ForeColor = Color.MidnightBlue;
            }
        }
    }
}
