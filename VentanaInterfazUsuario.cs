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
        bool nuevo = false;


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
            fechaCreacion.Enabled = x;
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
        }
        //Termina metodo habilitar los TB

        //Metodo para limpiar e inicializar los TB despues de registrar pedido

        private void limpiar()
        {
            tbNpedido.Text = "";
            tbDestinatario.Text = "";
            tbDNI.Text = "";
            tbDomicilio.Text = "";
            fechaCreacion.Value = DateTime.Now;
            fechaEnvio.Value = DateTime.Now;
            tbCliente.Text = "";
            tbProvincia.Text = "";
            tbLocalidad.Text = "";
            tbCosto.Text = "";
            tbPrecioVenta.Text = "";

        }       

        private void inicializar()
        {
            tbNpedido.Text = "Numero de Pedido";
            tbDestinatario.Text = "Destinatario";
            tbDNI.Text = "DNI (Solo Numeros)";
            tbDomicilio.Text = "Domicilio: (Calle, Numero, Localidad)";
            fechaCreacion.Value = DateTime.Now;
            fechaEnvio.Value = DateTime.Now;
            tbCliente.Text = "Cliente";
            tbProvincia.Text = "Provincia";
            tbLocalidad.Text = "Localidad";
            tbCosto.Text = "Costo";
            tbPrecioVenta.Text = "Precio de Venta";


        }

        //Termina metodo para limpiar e inicializar TB

        //Metodo para registrar un pedido nuevo

        private void btnRegistrarPedido_Click(object sender, EventArgs e)
        {
            //Validaciones:

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
                float costo = float.Parse(tbCosto.Text);
                float precio = float.Parse(tbPrecioVenta.Text);


            }

            catch (Exception)
            {
                MessageBox.Show("Las casillas DNI, Numero de Pedido, Costo y Precio solo aceptan numeros");
                return;
            }

            //registro a la propiedad los campos ya validados

            Viaje v = new Viaje();
            v.pcliente = tbCliente.Text.ToUpper();
            v.pfechacreacion = Convert.ToDateTime(fechaCreacion.Value);
            v.pfechaenvio = Convert.ToDateTime(fechaEnvio.Value);
            v.pnpedido = Convert.ToInt32(tbNpedido.Text);
            v.pdestinatario = tbDestinatario.Text;
            v.pdni = Convert.ToInt32(tbDNI.Text);
            v.pdomicilio = tbDomicilio.Text;
            v.plocalidad = tbLocalidad.Text.ToUpper();
            v.pprovincia = tbProvincia.Text.ToUpper();
            v.pcosto = float.Parse(tbCosto.Text);
            v.pprecio_venta = float.Parse(tbPrecioVenta.Text);
            v.pusuario = tablaUsuario.Rows[0][0].ToString();


            try
            {
                if (nuevo)

                    //Inserto en la BDD
                {
                    string consulta = "insert into ENVIOS(cliente, fecha_creacion, fecha_envio, num_pedido, destinatario, dni, domicilio, localidad, provincia, costo, precio_venta, usuario) values (@cliente, @fecha_creacion, @fecha_envio, @num_pedido, @destinatario, @dni, @domicilio, @localidad, @provincia, @costo, @precio_venta, @usuario);";
                    oBD.actualizarConParametros(consulta, v);

                    habilitar(false);
                    limpiar();
                    inicializar();
                    nuevo = true;
                    btnRegistrarPedido.Enabled = false;
                    MessageBox.Show("Operacion Exitosa");

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

        //Termina funcionalidades de los botones

       
    }
}
