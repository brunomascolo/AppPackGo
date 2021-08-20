using AppPackGo.Formularios;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppPackGo
{


    public partial class VentanaInterfazUsuario : Form
    {
        Gestor_de_Datos oBD = new Gestor_de_Datos();
        DataTable tablaUsuario = new DataTable();



        public VentanaInterfazUsuario(DataTable tablaUsuario)
        {
            InitializeComponent();
            habilitar(false);
            this.tablaUsuario = tablaUsuario;
        }

        //Desvanecer titulos de TB

        private void tbNpedido_Enter(object sender, EventArgs e)
        {
            if (tbNpedido.Text == "Numero de Pedido")
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
            if (tbDomicilio.Text == "Domicilio: (Calle, Numero)")
            {
                tbDomicilio.Text = "";
                tbDomicilio.ForeColor = Color.White;

            }
        }

        private void tbDomicilio_Leave(object sender, EventArgs e)
        {
            if (tbDomicilio.Text == "")
            {
                tbDomicilio.Text = "Domicilio: (Calle, Numero)";
                tbDomicilio.ForeColor = Color.White;
            }
        }

        private void tbCliente_Enter(object sender, EventArgs e)
        {
            if (tbCliente.Text == "Cliente")
            {
                tbCliente.Text = "";
                tbCliente.ForeColor = Color.White;

            }
        }

        private void tbCliente_Leave(object sender, EventArgs e)
        {
            if (tbCliente.Text == "")
            {
                tbCliente.Text = "Cliente";
                tbCliente.ForeColor = Color.White;
            }
        }

        private void tbLocalidad_Enter(object sender, EventArgs e)
        {
            if (tbLocalidad.Text == "Localidad")
            {
                tbLocalidad.Text = "";
                tbLocalidad.ForeColor = Color.White;

            }
        }

        private void tbLocalidad_Leave(object sender, EventArgs e)
        {
            if (tbLocalidad.Text == "")
            {
                tbLocalidad.Text = "Localidad";
                tbLocalidad.ForeColor = Color.White;
            }
        }

        private void tbCosto_Enter(object sender, EventArgs e)
        {
            if (tbCosto.Text == "Costo")
            {
                tbCosto.Text = "";
                tbCosto.ForeColor = Color.White;

            }
        }

        private void tbCosto_Leave(object sender, EventArgs e)
        {
            if (tbCosto.Text == "")
            {
                tbCosto.Text = "Costo";
                tbCosto.ForeColor = Color.White;
            }

        }

        private void tbPrecioVenta_Enter(object sender, EventArgs e)
        {
            if (tbPrecioVenta.Text == "Precio de Venta")
            {
                tbPrecioVenta.Text = "";
                tbPrecioVenta.ForeColor = Color.White;

            }
        }

        private void tbPrecioVenta_Leave(object sender, EventArgs e)
        {
            if (tbPrecioVenta.Text == "")
            {
                tbPrecioVenta.Text = "Precio de Venta";
                tbPrecioVenta.ForeColor = Color.White;
            }
        }

        private void tbProvincia_Enter(object sender, EventArgs e)
        {
            if (tbProvincia.Text == "Provincia")
            {
                tbProvincia.Text = "";
                tbProvincia.ForeColor = Color.White;

            }
        }

        private void tbProvincia_Leave(object sender, EventArgs e)
        {
            if (tbProvincia.Text == "")
            {
                tbProvincia.Text = "Provincia";
                tbProvincia.ForeColor = Color.White;
            }
        }

        private void tbProveedor_Enter(object sender, EventArgs e)
        {
            if (tbProveedor.Text == "Proveedor")
            {
                tbProveedor.Text = "";
                tbProveedor.ForeColor = Color.White;

            }
        }

        private void tbProveedor_Leave(object sender, EventArgs e)
        {
            if (tbProveedor.Text == "")
            {
                tbProveedor.Text = "Proveedor";
                tbProveedor.ForeColor = Color.White;
            }
        }

        //Termina metodos de desvanecimiento


        //movilizar ventana por el escritorio:

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
    

        private void VentanaInterfazUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Termina mmetodo para movilizar ventana

        private void VentanaInterfazUsuario_Load(object sender, EventArgs e)
        {
            habilitar(false);
            btnRegistrarPedido.Enabled = false;
        }

        //Metodo para habilitar y deshabilitar los TB
        public void habilitar(bool x)
        {       
            fechaEnvio.Enabled = x;
            tbNpedido.Enabled = x;
            tbDestinatario.Enabled = x;
            tbDNI.Enabled = x;
            tbDomicilio.Enabled = x;
            btnNuevoPedido.Enabled = !x;
            btnRegistrarPedido.Enabled = x;
            tbCliente.Enabled = x;
            tbCosto.Enabled = x;
            tbPrecioVenta.Enabled = x;
            tbProvincia.Enabled = x;
            tbLocalidad.Enabled = x;
            tbProveedor.Enabled = x;
        }
        //Termina metodo habilitar los TB

        //Metodo para limpiar e inicializar los TB despues de registrar pedido

        private void limpiar()
        {
            tbNpedido.Text = "";
            tbDestinatario.Text = "";
            tbDNI.Text = "";
            tbDomicilio.Text = "";            
            fechaEnvio.Value = DateTime.Now;
            tbCliente.Text = "";
            tbProvincia.Text = "";
            tbLocalidad.Text = "";
            tbCosto.Text = "";
            tbPrecioVenta.Text = "";
            tbProveedor.Text = "";

        }       

        private void inicializar()
        {
            tbNpedido.Text = "Numero de Pedido";
            tbDestinatario.Text = "Destinatario";
            tbDNI.Text = "DNI (Solo Numeros)";
            tbDomicilio.Text = "Domicilio: (Calle, Numero, Localidad)";            
            fechaEnvio.Value = DateTime.Now;
            tbCliente.Text = "Cliente";
            tbProvincia.Text = "Provincia";
            tbLocalidad.Text = "Localidad";
            tbCosto.Text = "Costo";
            tbPrecioVenta.Text = "Precio de Venta";
            tbProveedor.Text = "Proveedor";
        }

        //Termina metodo para limpiar e inicializar TB

        //Metodo para registrar un pedido nuevo

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            //Validaciones:

            if (tbDestinatario.Text == "")
            {
                MessageBox.Show("Debe ingresar un Destinatario");
                return;
            }
            if (tbProveedor.Text == "")
            {
                MessageBox.Show("Debe ingresar un Proveedor");
                return;
            }

            if (tbCliente.Text == "")
            {
                MessageBox.Show("Debe ingresar un Cliente");
                return;
            }

            if (tbProvincia.Text == "")
            {
                MessageBox.Show("Debe ingresar una Provincia");
                return;

            }

            if (tbCosto.Text == "")
            {
                MessageBox.Show("Debe ingresar el Costo");
                return;
            }

            if (tbPrecioVenta.Text == "")
            {
                MessageBox.Show("Debe ingresar un Precio de Venta");
                return;
            }

            if (tbLocalidad.Text == "")
            {
                MessageBox.Show("Debe ingresar una Localidad");
                return;
            }

            if (tbDomicilio.Text == "")
            {
                MessageBox.Show("Debe ingresar un domicilio");
                return;
            }
          
            try
            {               
                float costo = float.Parse(tbCosto.Text);
                float precio = float.Parse(tbPrecioVenta.Text);
            }

            catch (Exception)
            {
                MessageBox.Show("Las casillas Costo y Precio solo aceptan numeros");
                return;
            }
            try
            {
                string cliente = tbCliente.Text;
                string consulta1 = "SELECT * from CLIENTES where nombre_cliente like '" + cliente + "';";
                DataTable tablaCliente = new DataTable();
                tablaCliente = oBD.consultarBDD(consulta1);
                if (tablaCliente.Rows.Count != 0)
                {

                    //registro a la propiedad los campos ya validados

                    Viaje v = new Viaje();
                    v.pcliente = tbCliente.Text.ToUpper();                    
                    v.pfechaenvio = Convert.ToDateTime(fechaEnvio.Value);
                    v.pnpedido = (tbNpedido.Text);
                    v.pdestinatario = tbDestinatario.Text;
                    v.pdni = (tbDNI.Text);
                    v.pdomicilio = tbDomicilio.Text;
                    v.plocalidad = tbLocalidad.Text.ToUpper();
                    v.pprovincia = tbProvincia.Text.ToUpper();
                    v.pcosto = float.Parse(tbCosto.Text);
                    v.pprecio_venta = float.Parse(tbPrecioVenta.Text);
                    v.pusuario = tablaUsuario.Rows[0][0].ToString();



                    //Inserto en la BDD

                    string consulta = "insert into ENVIOS(cliente, fecha_envio, num_pedido, destinatario, dni, domicilio, localidad, provincia, costo, precio_venta, usuario, proveedor) values (@cliente, @fecha_envio, @num_pedido, @destinatario, @dni, @domicilio, @localidad, @provincia, @costo, @precio_venta, @usuario, @proveedor);";
                    oBD.actualizarConParametros(consulta, v);

                    habilitar(false);
                    limpiar();
                    inicializar();                    
                    btnRegistrarPedido.Enabled = false;
                    MessageBox.Show("Operacion Exitosa");

                }

                else
                {
                   DialogResult dialogo = MessageBox.Show("Cliente inexistente en la Base de Datos. Desea Crearlo?", "Cliente Inexistente", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if(dialogo == DialogResult.Yes)
                    {
                        ClienteNuevo clientenuevo = new ClienteNuevo();
                        clientenuevo.Show();

                    }

                    else
                    {
                        return;
                    }
                }
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }

        }

        //funcionalidades de los botones

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            habilitar(true);            
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

        private void btnMinimizarInterfaz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }       

        private void lnkConsultas1_Click(object sender, EventArgs e)
        {
            VentanaConsultas consultar = new VentanaConsultas(tablaUsuario);
            consultar.Show();
            this.Hide();
        }

        private void lnkImportar1_Click(object sender, EventArgs e)
        {
            VentanaImportar importar = new VentanaImportar(tablaUsuario);
            importar.Show();

            this.Hide();
        }

        private void lnkCrear1_Click(object sender, EventArgs e)
        {
            ClienteNuevo clientenuevo = new ClienteNuevo();
            clientenuevo.Show();
        }

       

        //Termina funcionalidades de los botones


    }
}
