
namespace AppPackGo
{
    partial class VentanaImportar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaImportar));
            this.tituloImportar = new System.Windows.Forms.Label();
            this.lnkImportar3 = new System.Windows.Forms.Button();
            this.lnkConsultas3 = new System.Windows.Forms.Button();
            this.lnkRegistrar3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tbUbicacion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizarInterfaz = new System.Windows.Forms.PictureBox();
            this.dgvImportar = new System.Windows.Forms.DataGridView();
            this.btnSalir4 = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destinatario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precioventa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarInterfaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportar)).BeginInit();
            this.SuspendLayout();
            // 
            // tituloImportar
            // 
            this.tituloImportar.AutoSize = true;
            this.tituloImportar.BackColor = System.Drawing.Color.Transparent;
            this.tituloImportar.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloImportar.ForeColor = System.Drawing.Color.White;
            this.tituloImportar.Location = new System.Drawing.Point(650, 35);
            this.tituloImportar.Name = "tituloImportar";
            this.tituloImportar.Size = new System.Drawing.Size(253, 38);
            this.tituloImportar.TabIndex = 23;
            this.tituloImportar.Text = "Importar Envios";
            // 
            // lnkImportar3
            // 
            this.lnkImportar3.BackColor = System.Drawing.Color.Silver;
            this.lnkImportar3.FlatAppearance.BorderSize = 0;
            this.lnkImportar3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lnkImportar3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.lnkImportar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lnkImportar3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkImportar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.lnkImportar3.Location = new System.Drawing.Point(12, 290);
            this.lnkImportar3.Name = "lnkImportar3";
            this.lnkImportar3.Size = new System.Drawing.Size(234, 43);
            this.lnkImportar3.TabIndex = 29;
            this.lnkImportar3.Text = "Importar";
            this.lnkImportar3.UseVisualStyleBackColor = false;
            // 
            // lnkConsultas3
            // 
            this.lnkConsultas3.BackColor = System.Drawing.Color.Gainsboro;
            this.lnkConsultas3.FlatAppearance.BorderSize = 0;
            this.lnkConsultas3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lnkConsultas3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.lnkConsultas3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lnkConsultas3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultas3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.lnkConsultas3.Location = new System.Drawing.Point(12, 220);
            this.lnkConsultas3.Name = "lnkConsultas3";
            this.lnkConsultas3.Size = new System.Drawing.Size(234, 43);
            this.lnkConsultas3.TabIndex = 28;
            this.lnkConsultas3.Text = "Consultar Envios";
            this.lnkConsultas3.UseVisualStyleBackColor = false;
            this.lnkConsultas3.Click += new System.EventHandler(this.lnkConsultas3_Click);
            // 
            // lnkRegistrar3
            // 
            this.lnkRegistrar3.BackColor = System.Drawing.Color.Gainsboro;
            this.lnkRegistrar3.FlatAppearance.BorderSize = 0;
            this.lnkRegistrar3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lnkRegistrar3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.lnkRegistrar3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lnkRegistrar3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegistrar3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.lnkRegistrar3.Location = new System.Drawing.Point(12, 150);
            this.lnkRegistrar3.Name = "lnkRegistrar3";
            this.lnkRegistrar3.Size = new System.Drawing.Size(234, 43);
            this.lnkRegistrar3.TabIndex = 27;
            this.lnkRegistrar3.Text = "Registrar Envios";
            this.lnkRegistrar3.UseVisualStyleBackColor = false;
            this.lnkRegistrar3.Click += new System.EventHandler(this.lnkRegistrar3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lnkImportar3);
            this.panel1.Controls.Add(this.lnkConsultas3);
            this.panel1.Controls.Add(this.lnkRegistrar3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 655);
            this.panel1.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPackGo.Properties.Resources.LOGO_PGO_FINAL_chico;
            this.pictureBox1.Location = new System.Drawing.Point(-41, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(332, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.LightGray;
            this.btnBuscar.Location = new System.Drawing.Point(1135, 124);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(60, 33);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "...";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // tbUbicacion
            // 
            this.tbUbicacion.BackColor = System.Drawing.Color.White;
            this.tbUbicacion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUbicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tbUbicacion.Location = new System.Drawing.Point(477, 125);
            this.tbUbicacion.Name = "tbUbicacion";
            this.tbUbicacion.Size = new System.Drawing.Size(641, 32);
            this.tbUbicacion.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(361, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 33;
            this.label1.Text = "Archivo:";
            // 
            // btnMinimizarInterfaz
            // 
            this.btnMinimizarInterfaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizarInterfaz.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarInterfaz.Image")));
            this.btnMinimizarInterfaz.Location = new System.Drawing.Point(1414, 0);
            this.btnMinimizarInterfaz.Name = "btnMinimizarInterfaz";
            this.btnMinimizarInterfaz.Size = new System.Drawing.Size(42, 34);
            this.btnMinimizarInterfaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizarInterfaz.TabIndex = 39;
            this.btnMinimizarInterfaz.TabStop = false;
            this.btnMinimizarInterfaz.Click += new System.EventHandler(this.btnMinimizarInterfaz_Click);
            // 
            // dgvImportar
            // 
            this.dgvImportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cliente,
            this.FechaCreacion,
            this.FechaEnvio,
            this.NumeroPedido,
            this.Destinatario,
            this.DNI,
            this.Domicilio,
            this.Localidad,
            this.Provincia,
            this.Costo,
            this.Precioventa});
            this.dgvImportar.Location = new System.Drawing.Point(294, 189);
            this.dgvImportar.Name = "dgvImportar";
            this.dgvImportar.RowHeadersWidth = 62;
            this.dgvImportar.RowTemplate.Height = 28;
            this.dgvImportar.Size = new System.Drawing.Size(1162, 348);
            this.dgvImportar.TabIndex = 40;
            // 
            // btnSalir4
            // 
            this.btnSalir4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.btnSalir4.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSalir4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSalir4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir4.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalir4.Location = new System.Drawing.Point(1135, 589);
            this.btnSalir4.Name = "btnSalir4";
            this.btnSalir4.Size = new System.Drawing.Size(243, 43);
            this.btnSalir4.TabIndex = 42;
            this.btnSalir4.Text = "Salir";
            this.btnSalir4.UseVisualStyleBackColor = false;
            this.btnSalir4.Click += new System.EventHandler(this.btnSalir4_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.btnImportar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnImportar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnImportar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnImportar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.LightGray;
            this.btnImportar.Location = new System.Drawing.Point(294, 589);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(243, 43);
            this.btnImportar.TabIndex = 41;
            this.btnImportar.Text = "Importar Excel";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.MinimumWidth = 8;
            this.Cliente.Name = "Cliente";
            this.Cliente.Width = 150;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.HeaderText = "Fecha de Creacion";
            this.FechaCreacion.MinimumWidth = 8;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.Width = 150;
            // 
            // FechaEnvio
            // 
            this.FechaEnvio.HeaderText = "Fecha de Envio";
            this.FechaEnvio.MinimumWidth = 8;
            this.FechaEnvio.Name = "FechaEnvio";
            this.FechaEnvio.Width = 150;
            // 
            // NumeroPedido
            // 
            this.NumeroPedido.HeaderText = "Numero de Pedido";
            this.NumeroPedido.MinimumWidth = 8;
            this.NumeroPedido.Name = "NumeroPedido";
            this.NumeroPedido.Width = 150;
            // 
            // Destinatario
            // 
            this.Destinatario.HeaderText = "Destinatario";
            this.Destinatario.MinimumWidth = 8;
            this.Destinatario.Name = "Destinatario";
            this.Destinatario.Width = 150;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.MinimumWidth = 8;
            this.DNI.Name = "DNI";
            this.DNI.Width = 150;
            // 
            // Domicilio
            // 
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 8;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.Width = 150;
            // 
            // Localidad
            // 
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.MinimumWidth = 8;
            this.Localidad.Name = "Localidad";
            this.Localidad.Width = 150;
            // 
            // Provincia
            // 
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.MinimumWidth = 8;
            this.Provincia.Name = "Provincia";
            this.Provincia.Width = 150;
            // 
            // Costo
            // 
            this.Costo.HeaderText = "Costo";
            this.Costo.MinimumWidth = 8;
            this.Costo.Name = "Costo";
            this.Costo.Width = 150;
            // 
            // Precioventa
            // 
            this.Precioventa.HeaderText = "Precio de Venta";
            this.Precioventa.MinimumWidth = 8;
            this.Precioventa.Name = "Precioventa";
            this.Precioventa.Width = 150;
            // 
            // VentanaImportar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.ClientSize = new System.Drawing.Size(1800, 650);
            this.Controls.Add(this.btnSalir4);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.dgvImportar);
            this.Controls.Add(this.btnMinimizarInterfaz);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.tbUbicacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tituloImportar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaImportar";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaImportar";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VentanaImportar_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarInterfaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloImportar;
        private System.Windows.Forms.Button lnkImportar3;
        private System.Windows.Forms.Button lnkConsultas3;
        private System.Windows.Forms.Button lnkRegistrar3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox tbUbicacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnMinimizarInterfaz;
        private System.Windows.Forms.DataGridView dgvImportar;
        private System.Windows.Forms.Button btnSalir4;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEnvio;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destinatario;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precioventa;
    }
}