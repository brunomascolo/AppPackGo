
namespace AppPackGo
{
    partial class VentanaInterfazUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaInterfazUsuario));
            this.fechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.tituloPortalEnvios = new System.Windows.Forms.Label();
            this.tituloFechaCreacion = new System.Windows.Forms.Label();
            this.tituloFechaEnvio = new System.Windows.Forms.Label();
            this.fechaEnvio = new System.Windows.Forms.DateTimePicker();
            this.tbNpedido = new System.Windows.Forms.TextBox();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.tbDestinatario = new System.Windows.Forms.TextBox();
            this.tbDNI = new System.Windows.Forms.TextBox();
            this.btnRegistrarPedido = new System.Windows.Forms.Button();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lnkImportar1 = new System.Windows.Forms.Button();
            this.lnkConsultas1 = new System.Windows.Forms.Button();
            this.lnkRegistrar1 = new System.Windows.Forms.Button();
            this.tbCliente = new System.Windows.Forms.TextBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.tbCosto = new System.Windows.Forms.TextBox();
            this.tbPrecioVenta = new System.Windows.Forms.TextBox();
            this.lnkCrear1 = new System.Windows.Forms.Button();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMinimizarInterfaz = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarInterfaz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechaCreacion.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechaCreacion.CalendarTrailingForeColor = System.Drawing.SystemColors.Control;
            this.fechaCreacion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaCreacion.Location = new System.Drawing.Point(532, 259);
            this.fechaCreacion.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.fechaCreacion.MinDate = new System.DateTime(2021, 7, 13, 0, 0, 0, 0);
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.Size = new System.Drawing.Size(347, 32);
            this.fechaCreacion.TabIndex = 1;
            // 
            // tituloPortalEnvios
            // 
            this.tituloPortalEnvios.AutoSize = true;
            this.tituloPortalEnvios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tituloPortalEnvios.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloPortalEnvios.ForeColor = System.Drawing.Color.White;
            this.tituloPortalEnvios.Location = new System.Drawing.Point(650, 35);
            this.tituloPortalEnvios.Name = "tituloPortalEnvios";
            this.tituloPortalEnvios.Size = new System.Drawing.Size(394, 38);
            this.tituloPortalEnvios.TabIndex = 0;
            this.tituloPortalEnvios.Text = "Registrar Envios Unitarios";
            // 
            // tituloFechaCreacion
            // 
            this.tituloFechaCreacion.AutoSize = true;
            this.tituloFechaCreacion.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloFechaCreacion.ForeColor = System.Drawing.Color.White;
            this.tituloFechaCreacion.Location = new System.Drawing.Point(305, 268);
            this.tituloFechaCreacion.Name = "tituloFechaCreacion";
            this.tituloFechaCreacion.Size = new System.Drawing.Size(206, 23);
            this.tituloFechaCreacion.TabIndex = 4;
            this.tituloFechaCreacion.Text = "Fecha de Creacion:";
            // 
            // tituloFechaEnvio
            // 
            this.tituloFechaEnvio.AutoSize = true;
            this.tituloFechaEnvio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloFechaEnvio.ForeColor = System.Drawing.Color.White;
            this.tituloFechaEnvio.Location = new System.Drawing.Point(909, 268);
            this.tituloFechaEnvio.Name = "tituloFechaEnvio";
            this.tituloFechaEnvio.Size = new System.Drawing.Size(168, 23);
            this.tituloFechaEnvio.TabIndex = 5;
            this.tituloFechaEnvio.Text = "Fecha de Envio:";
            // 
            // fechaEnvio
            // 
            this.fechaEnvio.CalendarForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechaEnvio.CalendarTitleForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechaEnvio.CalendarTrailingForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fechaEnvio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEnvio.Location = new System.Drawing.Point(1083, 261);
            this.fechaEnvio.Name = "fechaEnvio";
            this.fechaEnvio.Size = new System.Drawing.Size(343, 32);
            this.fechaEnvio.TabIndex = 2;
            // 
            // tbNpedido
            // 
            this.tbNpedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tbNpedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNpedido.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNpedido.ForeColor = System.Drawing.Color.White;
            this.tbNpedido.Location = new System.Drawing.Point(309, 374);
            this.tbNpedido.Name = "tbNpedido";
            this.tbNpedido.Size = new System.Drawing.Size(304, 25);
            this.tbNpedido.TabIndex = 3;
            this.tbNpedido.Text = "Numero de Pedido";
            this.tbNpedido.Enter += new System.EventHandler(this.tbNpedido_Enter);
            this.tbNpedido.Leave += new System.EventHandler(this.tbNpedido_Leave);
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tbDomicilio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDomicilio.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDomicilio.ForeColor = System.Drawing.Color.White;
            this.tbDomicilio.Location = new System.Drawing.Point(309, 478);
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.Size = new System.Drawing.Size(379, 25);
            this.tbDomicilio.TabIndex = 6;
            this.tbDomicilio.Text = "Domicilio: (Calle, Numero)";
            this.tbDomicilio.Enter += new System.EventHandler(this.tbDomicilio_Enter);
            this.tbDomicilio.Leave += new System.EventHandler(this.tbDomicilio_Leave);
            // 
            // tbDestinatario
            // 
            this.tbDestinatario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tbDestinatario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDestinatario.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestinatario.ForeColor = System.Drawing.Color.White;
            this.tbDestinatario.Location = new System.Drawing.Point(740, 374);
            this.tbDestinatario.Name = "tbDestinatario";
            this.tbDestinatario.Size = new System.Drawing.Size(304, 25);
            this.tbDestinatario.TabIndex = 4;
            this.tbDestinatario.Text = "Destinatario";
            this.tbDestinatario.Enter += new System.EventHandler(this.tbDestinatario_Enter);
            this.tbDestinatario.Leave += new System.EventHandler(this.tbDestinatario_Leave);
            // 
            // tbDNI
            // 
            this.tbDNI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tbDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDNI.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNI.ForeColor = System.Drawing.Color.White;
            this.tbDNI.Location = new System.Drawing.Point(1118, 374);
            this.tbDNI.Name = "tbDNI";
            this.tbDNI.Size = new System.Drawing.Size(204, 25);
            this.tbDNI.TabIndex = 5;
            this.tbDNI.Text = "DNI (Solo Numeros)";
            this.tbDNI.Enter += new System.EventHandler(this.tbDNI_Enter);
            this.tbDNI.Leave += new System.EventHandler(this.tbDNI_Leave);
            // 
            // btnRegistrarPedido
            // 
            this.btnRegistrarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.btnRegistrarPedido.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnRegistrarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnRegistrarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarPedido.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPedido.ForeColor = System.Drawing.Color.LightGray;
            this.btnRegistrarPedido.Location = new System.Drawing.Point(744, 589);
            this.btnRegistrarPedido.Name = "btnRegistrarPedido";
            this.btnRegistrarPedido.Size = new System.Drawing.Size(243, 43);
            this.btnRegistrarPedido.TabIndex = 9;
            this.btnRegistrarPedido.Text = "Registrar Pedido";
            this.btnRegistrarPedido.UseVisualStyleBackColor = false;
            this.btnRegistrarPedido.Click += new System.EventHandler(this.btnRegistrarPedido_Click);
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.btnNuevoPedido.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnNuevoPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnNuevoPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.ForeColor = System.Drawing.Color.LightGray;
            this.btnNuevoPedido.Location = new System.Drawing.Point(313, 589);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(243, 43);
            this.btnNuevoPedido.TabIndex = 8;
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.UseVisualStyleBackColor = false;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.LightGray;
            this.btnSalir.Location = new System.Drawing.Point(1135, 589);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(243, 43);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.lnkCrear1);
            this.panel1.Controls.Add(this.lnkImportar1);
            this.panel1.Controls.Add(this.lnkConsultas1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lnkRegistrar1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 655);
            this.panel1.TabIndex = 20;
            // 
            // lnkImportar1
            // 
            this.lnkImportar1.BackColor = System.Drawing.Color.Gainsboro;
            this.lnkImportar1.FlatAppearance.BorderSize = 0;
            this.lnkImportar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lnkImportar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.lnkImportar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lnkImportar1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkImportar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.lnkImportar1.Location = new System.Drawing.Point(12, 290);
            this.lnkImportar1.Name = "lnkImportar1";
            this.lnkImportar1.Size = new System.Drawing.Size(234, 43);
            this.lnkImportar1.TabIndex = 30;
            this.lnkImportar1.Text = "Importar";
            this.lnkImportar1.UseVisualStyleBackColor = false;
            this.lnkImportar1.Click += new System.EventHandler(this.lnkImportar1_Click);
            // 
            // lnkConsultas1
            // 
            this.lnkConsultas1.BackColor = System.Drawing.Color.Gainsboro;
            this.lnkConsultas1.FlatAppearance.BorderSize = 0;
            this.lnkConsultas1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lnkConsultas1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.lnkConsultas1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lnkConsultas1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkConsultas1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.lnkConsultas1.Location = new System.Drawing.Point(12, 220);
            this.lnkConsultas1.Name = "lnkConsultas1";
            this.lnkConsultas1.Size = new System.Drawing.Size(234, 43);
            this.lnkConsultas1.TabIndex = 30;
            this.lnkConsultas1.Text = "Consultar Envios";
            this.lnkConsultas1.UseVisualStyleBackColor = false;
            this.lnkConsultas1.Click += new System.EventHandler(this.lnkConsultas1_Click);
            // 
            // lnkRegistrar1
            // 
            this.lnkRegistrar1.BackColor = System.Drawing.Color.Silver;
            this.lnkRegistrar1.FlatAppearance.BorderSize = 0;
            this.lnkRegistrar1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lnkRegistrar1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.lnkRegistrar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lnkRegistrar1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkRegistrar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.lnkRegistrar1.Location = new System.Drawing.Point(12, 150);
            this.lnkRegistrar1.Name = "lnkRegistrar1";
            this.lnkRegistrar1.Size = new System.Drawing.Size(234, 43);
            this.lnkRegistrar1.TabIndex = 29;
            this.lnkRegistrar1.Text = "Registrar Envios";
            this.lnkRegistrar1.UseVisualStyleBackColor = false;
            // 
            // tbCliente
            // 
            this.tbCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tbCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCliente.ForeColor = System.Drawing.Color.White;
            this.tbCliente.Location = new System.Drawing.Point(309, 189);
            this.tbCliente.Name = "tbCliente";
            this.tbCliente.Size = new System.Drawing.Size(304, 25);
            this.tbCliente.TabIndex = 30;
            this.tbCliente.Text = "Cliente";
            this.tbCliente.Enter += new System.EventHandler(this.tbCliente_Enter);
            this.tbCliente.Leave += new System.EventHandler(this.tbCliente_Leave);
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tbLocalidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbLocalidad.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLocalidad.ForeColor = System.Drawing.Color.White;
            this.tbLocalidad.Location = new System.Drawing.Point(740, 478);
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.Size = new System.Drawing.Size(308, 25);
            this.tbLocalidad.TabIndex = 32;
            this.tbLocalidad.Text = "Localidad";
            this.tbLocalidad.Enter += new System.EventHandler(this.tbLocalidad_Enter);
            this.tbLocalidad.Leave += new System.EventHandler(this.tbLocalidad_Leave);
            // 
            // tbProvincia
            // 
            this.tbProvincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tbProvincia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbProvincia.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProvincia.ForeColor = System.Drawing.Color.White;
            this.tbProvincia.Location = new System.Drawing.Point(1118, 478);
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.Size = new System.Drawing.Size(295, 25);
            this.tbProvincia.TabIndex = 34;
            this.tbProvincia.Text = "Provincia";
            this.tbProvincia.Enter += new System.EventHandler(this.tbProvincia_Enter);
            this.tbProvincia.Leave += new System.EventHandler(this.tbProvincia_Leave);
            // 
            // tbCosto
            // 
            this.tbCosto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tbCosto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCosto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCosto.ForeColor = System.Drawing.Color.White;
            this.tbCosto.Location = new System.Drawing.Point(740, 189);
            this.tbCosto.Name = "tbCosto";
            this.tbCosto.Size = new System.Drawing.Size(304, 25);
            this.tbCosto.TabIndex = 36;
            this.tbCosto.Text = "Costo";
            this.tbCosto.Enter += new System.EventHandler(this.tbCosto_Enter);
            this.tbCosto.Leave += new System.EventHandler(this.tbCosto_Leave);
            // 
            // tbPrecioVenta
            // 
            this.tbPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tbPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.tbPrecioVenta.Location = new System.Drawing.Point(1118, 189);
            this.tbPrecioVenta.Name = "tbPrecioVenta";
            this.tbPrecioVenta.Size = new System.Drawing.Size(304, 25);
            this.tbPrecioVenta.TabIndex = 38;
            this.tbPrecioVenta.Text = "Precio de Venta";
            this.tbPrecioVenta.Enter += new System.EventHandler(this.tbPrecioVenta_Enter);
            this.tbPrecioVenta.Leave += new System.EventHandler(this.tbPrecioVenta_Leave);
            // 
            // lnkCrear1
            // 
            this.lnkCrear1.BackColor = System.Drawing.Color.Gainsboro;
            this.lnkCrear1.FlatAppearance.BorderSize = 0;
            this.lnkCrear1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.lnkCrear1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.lnkCrear1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lnkCrear1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkCrear1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.lnkCrear1.Location = new System.Drawing.Point(12, 360);
            this.lnkCrear1.Name = "lnkCrear1";
            this.lnkCrear1.Size = new System.Drawing.Size(234, 43);
            this.lnkCrear1.TabIndex = 31;
            this.lnkCrear1.Text = "Crear Nuevo Cliente";
            this.lnkCrear1.UseVisualStyleBackColor = false;
            this.lnkCrear1.Click += new System.EventHandler(this.lnkCrear1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(1097, 220);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(329, 15);
            this.pictureBox10.TabIndex = 39;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(719, 220);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(329, 15);
            this.pictureBox9.TabIndex = 37;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(1097, 509);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(329, 18);
            this.pictureBox8.TabIndex = 35;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(719, 509);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(329, 18);
            this.pictureBox7.TabIndex = 33;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(284, 220);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(329, 15);
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(284, 509);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(405, 18);
            this.pictureBox5.TabIndex = 29;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(1097, 405);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(243, 15);
            this.pictureBox4.TabIndex = 28;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(719, 405);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(329, 15);
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(284, 405);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(329, 15);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // btnMinimizarInterfaz
            // 
            this.btnMinimizarInterfaz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnMinimizarInterfaz.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarInterfaz.Image")));
            this.btnMinimizarInterfaz.Location = new System.Drawing.Point(1414, 0);
            this.btnMinimizarInterfaz.Name = "btnMinimizarInterfaz";
            this.btnMinimizarInterfaz.Size = new System.Drawing.Size(42, 34);
            this.btnMinimizarInterfaz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMinimizarInterfaz.TabIndex = 25;
            this.btnMinimizarInterfaz.TabStop = false;
            this.btnMinimizarInterfaz.Click += new System.EventHandler(this.btnMinimizarInterfaz_Click);
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
            // VentanaInterfazUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1800, 650);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.tbPrecioVenta);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.tbCosto);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.tbProvincia);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.tbLocalidad);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.tbCliente);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnMinimizarInterfaz);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevoPedido);
            this.Controls.Add(this.btnRegistrarPedido);
            this.Controls.Add(this.tbDNI);
            this.Controls.Add(this.tbDestinatario);
            this.Controls.Add(this.tbDomicilio);
            this.Controls.Add(this.tbNpedido);
            this.Controls.Add(this.fechaEnvio);
            this.Controls.Add(this.tituloFechaEnvio);
            this.Controls.Add(this.tituloFechaCreacion);
            this.Controls.Add(this.tituloPortalEnvios);
            this.Controls.Add(this.fechaCreacion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaInterfazUsuario";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaInterfazUsuario";
            this.Load += new System.EventHandler(this.VentanaInterfazUsuario_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VentanaInterfazUsuario_MouseDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizarInterfaz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker fechaCreacion;
        private System.Windows.Forms.Label tituloPortalEnvios;
        private System.Windows.Forms.Label tituloFechaCreacion;
        private System.Windows.Forms.Label tituloFechaEnvio;
        private System.Windows.Forms.DateTimePicker fechaEnvio;
        private System.Windows.Forms.TextBox tbNpedido;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.TextBox tbDestinatario;
        private System.Windows.Forms.TextBox tbDNI;
        private System.Windows.Forms.Button btnRegistrarPedido;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMinimizarInterfaz;
        private System.Windows.Forms.Button lnkConsultas1;
        private System.Windows.Forms.Button lnkRegistrar1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button lnkImportar1;
        private System.Windows.Forms.TextBox tbCliente;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.TextBox tbCosto;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.TextBox tbPrecioVenta;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Button lnkCrear1;
    }
}