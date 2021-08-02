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
    

        //;

   
        public void cargarConsulta(DataGridView consulta, string nombreconsulta)
        {
            Viaje v = new Viaje();

            v.pusuario = tablaUsuario.Rows[0][0].ToString();
            v.pidsucursal = Convert.ToInt32(tablaUsuario.Rows[0][2]);
            v.pidprov = Convert.ToInt32(tablaUsuario.Rows[0][3]);
            DataTable tabla = oBD.consultarBDD(consultaBDD: "SELECT e.fecha_creacion as 'Fecha de Creacion', e.fecha_envio as 'Fecha de Envio', e.num_pedido as 'Numero de Pedido', e.destinatario as 'Destinatario', e.dni as 'DNI', e.domicilio as 'Domicilio', e.usuario as 'Usuario de Carga', s.nombre as 'Sucursal', p.nombre as 'Provincia', a.accion as 'Operacion' FROM ENVIOS as e JOIN SUCURSALES as s ON e.id_sucursal = s.id_sucursal JOIN PROVINCIAS as p ON e.id_prov = p.id_prov JOIN ACCIONES as a ON e.id_accion = a.id_accion WHERE e.id_sucursal = " + v.pidsucursal + " order by e.fecha_creacion DESC ;"); // 
            dgvConsulta.DataSource = tabla;

        }




        private void btnMinimizarInterfaz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void VentanaConsultas_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
                        MessageBox.Show("La exportacion fue exitosa","Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }



                }
            }
        }

        private void lnkImportar2_Click(object sender, EventArgs e)
        {
            //VentanaImportar importar = new VentanaImportar(tablaUsuario);
            //importar.Show();

            //this.Hide();
        }

    
    }
}
    

