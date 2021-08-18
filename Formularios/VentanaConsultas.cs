using AppPackGo.Formularios;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppPackGo
{
    public partial class VentanaConsultas : Form
    {
        Gestor_de_Datos oBD = new Gestor_de_Datos();
        DataTable tablaUsuario = new DataTable();


        public VentanaConsultas(DataTable tablaUsuario)
        {
            InitializeComponent();
            this.tablaUsuario = tablaUsuario;
            cargarConsulta(dgvConsulta, "ENVIOS");
        }


        //movilizar ventana por el escritorio:

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void VentanaConsultas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //;

        //Cargar la lista

        public void cargarConsulta(DataGridView consulta, string nombreconsulta)
        {
            Viaje v = new Viaje();
                      
            DataTable tabla = oBD.consultarBDD(consultaBDD: "SELECT e.cliente as 'Cliente', e.proveedor as 'Proveedor', e.fecha_envio as 'Fecha de Envio', e.num_pedido as 'Numero de Pedido', e.destinatario as 'Destinatario', e.dni as 'DNI', e.domicilio as 'Domicilio', e.localidad as 'Localidad', e.provincia as 'Provincia', e.costo as 'Costo', e.precio_venta as 'Precio de Venta', e.usuario as 'Usuario de Carga' FROM ENVIOS as e order by e.fecha_creacion DESC ;"); // 
            dgvConsulta.DataSource = tabla;

        }
        //Termina cargar la lista

        //Funcionalidad de botones

        private void btnMinimizarInterfaz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }       

        private void btnSalir3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }

            else { this.Show(); }
        }

        private void lnkRegistrar2_Click(object sender, EventArgs e)
        {
            VentanaInterfazUsuario interfaz = new VentanaInterfazUsuario(tablaUsuario);
            interfaz.Show();

            this.Hide();
        }
        private void lnkImportar2_Click(object sender, EventArgs e)
        {
            VentanaImportar importar = new VentanaImportar(tablaUsuario);
            importar.Show();

            this.Hide();
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            DataTable exportar = (DataTable)(dgvConsulta.DataSource);


            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ClosedXML.Excel.XLWorkbook workbook = new ClosedXML.Excel.XLWorkbook())
                        {
                            workbook.Worksheets.Add(exportar, "Envios");
                            workbook.SaveAs(sfd.FileName);


                        }
                        MessageBox.Show("La exportacion fue exitosa", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }
        }

        private void lnkCrear1_Click(object sender, EventArgs e)
        {
            ClienteNuevo clientenuevo = new ClienteNuevo();
            clientenuevo.Show();
        }

        //Termina funcionalidades de los botones   


    }
}


