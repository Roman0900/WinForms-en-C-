using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Trabajo_Practico_N6
{
    public class ConexionDatos
    {
        public String rutaProductos = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";

        public ConexionDatos()
        {

        }

        public SqlConnection ObtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(rutaProductos);

            try
            {
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public SqlDataAdapter ObtenerAdaptador(String consultaSql)
        {
            SqlDataAdapter adaptador;
            try
            {
                adaptador = new SqlDataAdapter(consultaSql, ObtenerConexion());
                return adaptador;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public int ejecutarProcedimiento(SqlCommand Comando, String NombreSP)
        {
            int filasCambiadas;
            SqlConnection Conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = Comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSP;

            filasCambiadas = cmd.ExecuteNonQuery();
            Conexion.Close();
            return filasCambiadas;
        }







    }
}