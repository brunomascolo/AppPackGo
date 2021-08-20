using System;

namespace AppPackGo
{

    class Viaje
    {      
        private DateTime fechaenvio;
        private string npedido;
        private string destinatario;
        private string domicilio;
        private string dni;
        private int accion;
        private string usuario;
        private string contrasena;
        private int idSucursal;
        private int idProv;
        private string cliente;
        private float costo;
        private float precio_venta;
        private string localidad;
        private string provincia;
        private string proveedor;


        public Viaje()
        {            
            this.fechaenvio = DateTime.Today;
            this.npedido = "";
            this.destinatario = "";
            this.domicilio = "";
            this.dni = "";
            this.accion = 0;
            this.usuario = "";
            this.contrasena = "";
            this.idSucursal = 0;
            this.idProv = 0;
            this.cliente = "";
            this.costo = 0;
            this.precio_venta = 0;
            this.localidad = "";
            this.provincia = "";
            this.proveedor = "";
        }

        public Viaje(DateTime fechaenvio, string npedido, string destinatario, string domicilio, string dni, int accion, string cliente, float costo, float precio_venta, string localidad, string provincia, string proveedor)
        {            
            this.fechaenvio = fechaenvio;
            this.npedido = npedido;
            this.destinatario = destinatario;
            this.domicilio = domicilio;
            this.dni = dni;
            this.accion = accion;
            this.cliente = cliente;
            this.precio_venta = precio_venta;
            this.costo = costo;
            this.localidad = localidad;
            this.provincia = provincia;
            this.proveedor = proveedor;
        }

      

        public DateTime pfechaenvio
        {
            get { return fechaenvio; }
            set { fechaenvio = value; }

        }

        public string pnpedido
        {
            get { return npedido; }
            set { npedido = value; }

        }

        public string pdestinatario
        {
            get { return destinatario; }
            set { destinatario = value; }

        }

        public string pdomicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        public string pdni
        {
            get { return dni; }
            set { dni = value; }
        }

        public int paccion
        {
            get { return accion; }
            set { accion = value; }
        }

        public string pusuario { get => usuario; set => usuario = value; }
        public string pcontrasena { get => contrasena; set => contrasena = value; }
        public int pidsucursal { get => idSucursal; set => idSucursal = value; }
        public int pidprov { get => idProv; set => idProv = value; }
        public string pcliente { get => cliente; set => cliente = value; }
        public float pcosto { get => costo; set => costo = value; }
        public float pprecio_venta { get => precio_venta; set => precio_venta = value; }
        public string plocalidad { get => localidad; set => localidad = value; }
        public string pprovincia { get => provincia; set => provincia = value; }
        public string pproveedor { get => proveedor; set => proveedor = value; }
    }


}
