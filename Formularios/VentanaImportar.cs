using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AppPackGo
{
    public partial class VentanaImportar : Form
    {
        Gestor_de_Datos oBD = new Gestor_de_Datos();
        DataTable tablaUsuario = new DataTable();

        public VentanaImportar(System.Data.DataTable tablaUsuario)
        {
            InitializeComponent();
            this.tablaUsuario = tablaUsuario;
            dgvImportar.Visible = false;
        }

        //Movilizar ventana en el escritorio

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void VentanaImportar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Termina movilizar ventana en el escritorio

        //Funcionalidades de los botones

        private void btnMinimizarInterfaz_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lnkConsultas3_Click(object sender, EventArgs e)
        {
            VentanaConsultas consultas = new VentanaConsultas(tablaUsuario);
            consultas.Show();
            this.Hide();
        }

        private void lnkRegistrar3_Click(object sender, EventArgs e)
        {
            VentanaInterfazUsuario interfaz = new VentanaInterfazUsuario(tablaUsuario);
            interfaz.Show();
            this.Hide();
        }     

        private void btnSalir4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro de abandonar la aplicación ?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Close();
                System.Windows.Forms.Application.Exit();
            }
            else { this.Show(); }
        }

        //Termina funcionalidades de los botones


        //Metodo para buscar el archivo excel e importarlo al DGV
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strfilename;

            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "Excel Office | *.xls; *.xlsx";
            fd.ShowDialog();
            strfilename = fd.FileName;

            try
            {

                if (strfilename != string.Empty)
                {
                    dgvImportar.Visible = true;
                    xlApp = new Microsoft.Office.Interop.Excel.Application();
                    xlWorkbook = xlApp.Workbooks.Open(strfilename);
                    xlWorksheet = xlWorkbook.Worksheets[1];
                    xlRange = xlWorksheet.UsedRange;

                    for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                    {
                        dgvImportar.Rows.Add(xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text, xlRange.Cells[xlRow, 5].Text, xlRange.Cells[xlRow, 6].Text, xlRange.Cells[xlRow, 7].Text, xlRange.Cells[xlRow, 8].Text, xlRange.Cells[xlRow, 9].Text, xlRange.Cells[xlRow, 10].Text, xlRange.Cells[xlRow, 11].Text);

                    }
                    xlWorkbook.Close();
                    xlApp.Quit();

                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Termina metodo para buscar el archivo excel e importarlo al DGV

        private void btnImportar_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < dgvImportar.Rows.Count; i++)
                {
                    var n = dgvImportar.Rows[i].Cells[4].Value;
                    if (n != null) //destinatario NO PUEDE SER NULO//
                    {
                        Viaje v = new Viaje();
                        v.pcliente = (dgvImportar.Rows[i].Cells[0].Value).ToString().ToUpper();
                        v.pfechacreacion = Convert.ToDateTime(dgvImportar.Rows[i].Cells[1].Value);
                        v.pfechaenvio = Convert.ToDateTime(dgvImportar.Rows[i].Cells[2].Value);
                        v.pnpedido = Convert.ToInt32(dgvImportar.Rows[i].Cells[3].Value);
                        v.pdestinatario = (dgvImportar.Rows[i].Cells[4].Value).ToString();
                        v.pdni = Convert.ToInt32(dgvImportar.Rows[i].Cells[5].Value);
                        v.pdomicilio = (dgvImportar.Rows[i].Cells[6].Value).ToString();
                        v.plocalidad = (dgvImportar.Rows[i].Cells[7].Value).ToString().ToUpper();
                        v.pprovincia = (dgvImportar.Rows[i].Cells[8].Value).ToString().ToUpper();
                        v.pcosto = float.Parse((string)dgvImportar.Rows[i].Cells[9].Value);
                        v.pprecio_venta = float.Parse((string)dgvImportar.Rows[i].Cells[10].Value);
                        v.pusuario = (tablaUsuario.Rows[0][0]).ToString();


                        string consulta = "insert into ENVIOS(cliente, fecha_creacion, fecha_envio, num_pedido, destinatario, dni, domicilio, localidad, provincia, costo, precio_venta, usuario) values (@cliente, @fecha_creacion, @fecha_envio, @num_pedido, @destinatario, @dni, @domicilio, @localidad, @provincia, @costo, @precio_venta, @usuario);";
                        oBD.actualizarConParametros(consulta, v);


                    }
                }
                MessageBox.Show("Importacion Exitosa!");
                dgvImportar.DataSource = null;
                dgvImportar.Visible = false;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
