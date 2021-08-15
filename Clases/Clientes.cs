using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPackGo.Clases
{
    class Clientes
    {
        private string cliente;
        private int provincia;

        public Clientes()
        {
            this.cliente = "";
            this.provincia = 0;
        }

        public Clientes(string cliente, int provincia)
        {
            this.cliente = cliente;
            this.provincia = provincia;
        }

        public int pProvincia { get => provincia; set => provincia = value; }
        public string pCliente { get => cliente; set => cliente = value; }
    }
}
