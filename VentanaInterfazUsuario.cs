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


    public partial class VentanaInterfazUsuario : Form
    {
        Gestor_de_Datos oBD = new Gestor_de_Datos();
        bool nuevo = false;
        

        DataTable tablaUsuario = new DataTable();

        public VentanaInterfazUsuario(DataTable tablaUsuario)
        {
            InitializeComponent();
            habilitar(false);
            this.tablaUsuario = tablaUsuario;
        }

        //movilizar ventana por el escritorio:

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        //;

        private void VentanaInterfazUsuario_Load(object sender, EventArgs e)
        {
            habilitar(false);
            cargardesplegable(desplegableAccion, "ACCIONES");
            btnRegistrarPedido.Enabled = false;
        }

        public void habilitar(bool x)
        {
            fechaCreacion.Enabled = x;
            fechaEnvio.Enabled = x;
            tbNpedido.Enabled = x;
            tbDestinatario.Enabled = x;
            tbDNI.Enabled = x;
            tbDomicilio.Enabled = x;
            desplegableAccion.Enabled = x;
            btnNuevoPedido.Enabled = !x;
            btnRegistrarPedido.Enabled = x;

        }


        private void limpiar()
        {
            tbNpedido.Text = "";
            tbDestinatario.Text = "";
            tbDNI.Text = "";
            tbDomicilio.Text = "";
            fechaCreacion.Value = DateTime.Now;
            fechaEnvio.Value = DateTime.Now;
            desplegableAccion.SelectedIndex = 0;

        }

        private void inicializar ()
        {
            tbNpedido.Text = "Numero de Pedido";           
            tbDestinatario.Text = "Destinatario";
            tbDNI.Text = "DNI (Solo Numeros)";
            tbDomicilio.Text = "Domicilio: (Calle, Numero, Localidad)";
            fechaCreacion.Value = DateTime.Now;
            fechaEnvio.Value = DateTime.Now;
            desplegableAccion.SelectedIndex = 0;

        }
    
        private void cargardesplegable(ComboBox combo, string acciones)
        {
            DataTable tabla = oBD.consultarBDD("select * from " + acciones);
            combo.DataSource = tabla;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {

            if (tbNpedido.Text == "")
            {
                MessageBox.Show("Debe ingresar un numero de pedido");
                return;
            }

            if (tbDestinatario.Text == "")
            {
                MessageBox.Show("Debe ingresar un Destinatario");
                return;
            }
            if (desplegableAccion.SelectedIndex < 0)
            {
                MessageBox.Show("Debe ingresar una accion");
                return;
            }
            if (tbDNI.Text == "")
            {
                MessageBox.Show("Debe ingresar un DNI");
                return;
            }
          
            if (tbDomicilio.Text == "")
            {
                MessageBox.Show("Debe ingresar un domicilio");
                return;
            }
            if (fechaEnvio.Value < fechaCreacion.Value)
            {
                MessageBox.Show("La fecha de Envio no puede ser menor que la fecha de creacion.");
                return;

            }
            try
            {
                int DNI = Convert.ToInt32(tbDNI.Text);
                int npedido = Convert.ToInt32(tbNpedido.Text);

            }

            catch (Exception)
            {
                MessageBox.Show("El numero de pedido y el DNI solo deben contener numeros");
                return;
            }

            Viaje v = new Viaje();
            v.pnpedido = Convert.ToInt32(tbNpedido.Text);
            v.pdomicilio = tbDomicilio.Text;
            v.paccion = Convert.ToInt32(desplegableAccion.SelectedValue);
            v.pfechacreacion = Convert.ToDateTime(fechaCreacion.Value);
            v.pfechaenvio = Convert.ToDateTime(fechaEnvio.Value);
            v.pdestinatario = tbDestinatario.Text;
            v.pdni = Convert.ToInt32(tbDNI.Text);
            v.pusuario = tablaUsuario.Rows[0][0].ToString();
            v.pidsucursal = Convert.ToInt32(tablaUsuario.Rows[0][2]);
            v.pidprov = Convert.ToInt32(tablaUsuario.Rows[0][3]);

            try
            {
                if (nuevo && v.paccion == 1 || v.paccion == 3)
                {
                    string consulta = "insert into ENVIOS(fecha_envio, num_pedido, destinatario, dni, domicilio, usuario, id_sucursal, id_prov, fecha_creacion, id_accion) values (@fechaenvio, @numpedido, @destinatario, @dni, @domicilio, @usuario, @idsucursal, @idprov, @fechacreacion, @idaccion);";
                    oBD.actualizarConParametros(consulta, v);                  

                    habilitar(false);
                    limpiar();
                    inicializar();
                    nuevo = true;
                    btnRegistrarPedido.Enabled = false;
                    MessageBox.Show("Operacion Exitosa");

                }

                else
                {
                    int pedido = Convert.ToInt32(tbNpedido.Text);
                    var consulta = "SELECT * from ENVIOS where num_pedido = " + pedido + ";";

                    DataTable tablacheck = new DataTable();
                    tablacheck = oBD.consultarBDD(consulta);

                    if (tablacheck.Rows.Count != 0)
                    {                      

                        string actualizar = "UPDATE ENVIOS SET fecha_envio = @fechaenvio, destinatario = @destinatario, dni = @dni, domicilio = @domicilio, usuario = @usuario, id_sucursal = @idsucursal, id_prov = @idprov, fecha_creacion = @fechacreacion, id_accion = @idaccion where num_pedido = " + pedido + ";";
                        oBD.actualizarConParametros(actualizar, v);                       

                        habilitar(false);
                        limpiar();
                        inicializar();
                        nuevo = true;
                        btnRegistrarPedido.Enabled = false;
                        MessageBox.Show("Operacion Exitosa");
                    }
                    else
                    {
                        MessageBox.Show("Pedido inexistente");
                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }  

        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            habilitar(true);
            nuevo = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }

            else { this.Show(); }
            
        }

        private void tbNpedido_Enter(object sender, EventArgs e)
        {
            if(tbNpedido.Text == "Numero de Pedido")
            {
                tbNpedido.Text = "";
                tbNpedido.ForeColor = Color.White; 

            }
        }

        private void tbNpedido_Leave(object sender, EventArgs e)
        {
            if (tbNpedido.Text == "")
            {
                tbNpedido.Text = "Numero de Pedido";
                tbNpedido.ForeColor = Color.White;
            }
        }

        private void tbDestinatario_Enter(object sender, EventArgs e)
        {
            if (tbDestinatario.Text == "Destinatario")
            {
                tbDestinatario.Text = "";
                tbDestinatario.ForeColor = Color.White;

            }
        }

        private void tbDestinatario_Leave(object sender, EventArgs e)
        {
            if (tbDestinatario.Text == "")
            {
                tbDestinatario.Text = "Destinatario";
                tbDestinatario.ForeColor = Color.White;
            }
        }

        private void tbDNI_Enter(object sender, EventArgs e)
        {
            if (tbDNI.Text == "DNI (Solo Numeros)")
            {
                tbDNI.Text = "";
                tbDNI.ForeColor = Color.White;

            }
        }

        private void tbDNI_Leave(object sender, EventArgs e)
        {
            if (tbDNI.Text == "")
            {
                tbDNI.Text = "DNI (Solo Numeros)";
                tbDNI.ForeColor = Color.White;
            }
        }

        private void tbDomicilio_Enter(object sender, EventArgs e)
        {
            if (tbDomicilio.Text == "Domicilio: (Calle, Numero, Localidad)")
            {
                tbDomicilio.Text = "";
                tbDomicilio.ForeColor = Color.White;

            }
        }

        private void tbDomicilio_Leave(object sender, EventArgs e)
        {
            if (tbDomicilio.Text == "")
            {
                tbDomicilio.Text = "Domicilio: (Calle, Numero, Localidad)";
                tbDomicilio.ForeColor = Color.White;
            }
        }

        private void btnMinimizarInterfaz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; 
        }

        private void VentanaInterfazUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lnkConsultas1_Click(object sender, EventArgs e)
        {
            VentanaConsultas consultar = new VentanaConsultas(tablaUsuario);
            consultar.Show();
            this.Hide();
        }

        private void lnkImportar1_Click(object sender, EventArgs e)
        {
            //VentanaImportar importar = new VentanaImportar(tablaUsuario);
            //importar.Show();

            //this.Hide();
        }
    }
}
