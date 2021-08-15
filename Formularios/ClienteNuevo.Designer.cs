
namespace AppPackGo.Formularios
{
    partial class ClienteNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteNuevo));
            this.tituloConsultaEnvios = new System.Windows.Forms.Label();
            this.tbCrearCliente = new System.Windows.Forms.TextBox();
            this.comboProvincias = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tituloConsultaEnvios
            // 
            this.tituloConsultaEnvios.AutoSize = true;
            this.tituloConsultaEnvios.BackColor = System.Drawing.Color.Transparent;
            this.tituloConsultaEnvios.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloConsultaEnvios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.tituloConsultaEnvios.Location = new System.Drawing.Point(197, 20);
            this.tituloConsultaEnvios.Name = "tituloConsultaEnvios";
            this.tituloConsultaEnvios.Size = new System.Drawing.Size(332, 38);
            this.tituloConsultaEnvios.TabIndex = 27;
            this.tituloConsultaEnvios.Text = "Crear Nuevo Cliente";
            // 
            // tbCrearCliente
            // 
            this.tbCrearCliente.BackColor = System.Drawing.Color.Gainsboro;
            this.tbCrearCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCrearCliente.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCrearCliente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.tbCrearCliente.Location = new System.Drawing.Point(38, 127);
            this.tbCrearCliente.Name = "tbCrearCliente";
            this.tbCrearCliente.Size = new System.Drawing.Size(337, 25);
            this.tbCrearCliente.TabIndex = 23;
            this.tbCrearCliente.Text = "Nombre:";
            this.tbCrearCliente.Enter += new System.EventHandler(this.tbCrearCliente_Enter);
            this.tbCrearCliente.Leave += new System.EventHandler(this.tbCrearCliente_Leave);
            // 
            // comboProvincias
            // 
            this.comboProvincias.BackColor = System.Drawing.Color.Gainsboro;
            this.comboProvincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProvincias.ForeColor = System.Drawing.Color.MidnightBlue;
            this.comboProvincias.FormattingEnabled = true;
            this.comboProvincias.Location = new System.Drawing.Point(394, 127);
            this.comboProvincias.Name = "comboProvincias";
            this.comboProvincias.Size = new System.Drawing.Size(291, 28);
            this.comboProvincias.TabIndex = 24;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCrear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.btnCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.btnCrear.Location = new System.Drawing.Point(38, 216);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(121, 43);
            this.btnCrear.TabIndex = 25;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(50)))), ((int)(((byte)(110)))));
            this.btnSalir.Location = new System.Drawing.Point(562, 216);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 43);
            this.btnSalir.TabIndex = 26;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ClienteNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(732, 271);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.comboProvincias);
            this.Controls.Add(this.tbCrearCliente);
            this.Controls.Add(this.tituloConsultaEnvios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClienteNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClienteNuevo";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClienteNuevo_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tituloConsultaEnvios;
        private System.Windows.Forms.TextBox tbCrearCliente;
        private System.Windows.Forms.ComboBox comboProvincias;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnSalir;
    }
}