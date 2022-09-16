using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP7_PROG3_2021_1C
{
    public class AccesoDatos
    {
        String rutaBDSucursales = "Data Source=localhost\\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";

        public AccesoDatos (){}


        public SqlConnection ObtenerConexion()
        {
            SqlConnection cn = new SqlConnection(rutaBDSucursales);

            try
            {
                cn.Open();
                return cn;
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
                
                adaptador = new SqlDataAdapter(consultaSql, ObtenerConexion()) ;

                
                return adaptador;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public int EjecutarProcedimientoAlmacenado (SqlCommand comando, String NombreSp)
        {
            int FilasCambiadas;
            SqlConnection conexion = ObtenerConexion();
            SqlCommand cmd = new SqlCommand();
            cmd = comando;
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = NombreSp;
            FilasCambiadas = cmd.ExecuteNonQuery();
            conexion.Close();
            return FilasCambiadas;
        }

    }
}