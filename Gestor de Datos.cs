using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace AppPackGo
{
    class Gestor_de_Datos
    {

        MySqlConnection conexion;
        MySqlCommand comando;
        MySqlDataReader lector;
        string cadenaConexion;

        public string pCadenaConexion { get => cadenaConexion; set => cadenaConexion = value; }
        public MySqlDataReader pLector { get => lector; set => lector = value; }


        public Gestor_de_Datos()
        {
            this.conexion = new MySqlConnection();
            this.comando = new MySqlCommand();
            this.lector = null;
            this.cadenaConexion = @"server=db-control-viajes.cygq7hk3yovz.us-east-2.rds.amazonaws.com;user id=admin;password = packgo1234;database=AppPackGo";
        }

        public Gestor_de_Datos(string cadenaConexion)
        {
            this.conexion = new MySqlConnection();
            this.comando = new MySqlCommand();
            this.lector = null;
            this.cadenaConexion = cadenaConexion;
        }


        public void conectarBD()
        {
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();
            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
        }

        public void desconectarBD()
        {
            conexion.Close();
            conexion.Dispose();
        }

        public DataTable consultarTabla(string nombreTabla)
        {
            conectarBD();

            comando.CommandText = "select * from " + nombreTabla;

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            desconectarBD();

            return tabla;
        }

        public DataTable consultarBDD(string consultaBDD)
        {
            this.conectarBD();

            this.comando.CommandText = consultaBDD;

            DataTable tabla = new DataTable();
            tabla.Load(comando.ExecuteReader());

            this.desconectarBD();

            return tabla;
        }

        public void leer(string consultaSQL)
        {
            conectarBD();

            comando.CommandText = consultaSQL;

            lector = comando.ExecuteReader();
        }

        public void actualizar(string consultaSQL)
        {
            conectarBD();

            comando.CommandText = consultaSQL;

            comando.ExecuteNonQuery();

            desconectarBD();
        }


        public void actualizarConParametros(string consultaSQL, Viaje v)
        {
            conectarBD();

            this.comando.CommandText = consultaSQL;

            this.comando.Parameters.Clear();

            this.comando.Parameters.AddWithValue("@fechaenvio", v.pfechaenvio);
            this.comando.Parameters.AddWithValue("@numpedido", v.pnpedido);
            this.comando.Parameters.AddWithValue("@destinatario", v.pdestinatario);
            this.comando.Parameters.AddWithValue("@dni", v.pdni);
            this.comando.Parameters.AddWithValue("@domicilio", v.pdomicilio);
            this.comando.Parameters.AddWithValue("@usuario", v.pusuario);
            this.comando.Parameters.AddWithValue("@idsucursal", v.pidsucursal);
            this.comando.Parameters.AddWithValue("@idprov", v.pidprov);
            this.comando.Parameters.AddWithValue("@fechacreacion", v.pfechacreacion);
            this.comando.Parameters.AddWithValue("@idaccion", v.paccion);

            this.comando.ExecuteNonQuery();

            this.desconectarBD();
        }

       



    }

}
