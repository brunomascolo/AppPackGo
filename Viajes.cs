using System;

namespace AppPackGo
{

    class Viaje
    {
        private DateTime fechacreacion;
        private DateTime fechaenvio;
        private int npedido;
        private string destinatario;
        private string domicilio;
        private int dni;
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


        public Viaje()
        {
            this.fechacreacion = DateTime.Today;
            this.fechaenvio = DateTime.Today;
            this.npedido = 0;
            this.destinatario = "";
            this.domicilio = "";
            this.dni = 0;
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

        }

        public Viaje(DateTime fechacreacion, DateTime fechaenvio, int npedido, string destinatario, string domicilio, int dni, int accion, string cliente, float costo, float precio_venta, string localidad, string provincia)
        {
            this.fechacreacion = fechacreacion;
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

        }

        public DateTime pfechacreacion
        {
            get { return fechacreacion; }
            set { fechacreacion = value; }

        }

        public DateTime pfechaenvio
        {
            get { return fechaenvio; }
            set { fechaenvio = value; }

        }

        public int pnpedido
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

        public int pdni
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
    }


}
