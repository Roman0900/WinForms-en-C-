using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class DatosSucursal
    {
        AccesoDatos ds = new AccesoDatos();

        public int eliminarSucursal(Sucursales suc)
        {
            SqlCommand comando = new SqlCommand();
            ArmarParametrosCategoriaEliminar(ref comando, suc);
            return ds.EjecutarProcedimientoAlmacenado(comando, "SP_ELIMINARSUCURSAL");
        }

        public DataTable GetProvincias()
        {
            DataTable tabla = ds.ObtenerTabla("Provincia", "Select * from Provincia");

            return tabla;
        }


        private void ArmarParametrosCategoriaEliminar(ref SqlCommand Comando, Sucursales suc)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IDSUCURSAL", SqlDbType.Int);
            SqlParametros.Value = suc.getIdSucursal();
        }


        public DataTable ObtenerTabla(string table, string query)
        {
            return ds.ObtenerTabla(table,query);
        }

        public bool ExisteSuc(Sucursales suc)
        {

            String consulta = "Select * from Sucursal where NombreSucursal='" + suc.GetNombre() + "'";
            return ds.existe(consulta);
        }

        public int AgregarSucursal(Sucursales suc)
        {
            SqlCommand comando = new SqlCommand();
            EnsambleSucNueva(ref comando, suc);
            return ds.EjecutarProcedimientoAlmacenado(comando, "spCrearSucursal");
        }

        private void EnsambleSucNueva(ref SqlCommand co, Sucursales suc)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = co.Parameters.Add("@Nombre", SqlDbType.VarChar);
            SqlParametros.Value = suc.GetNombre();
            SqlParametros = co.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            SqlParametros.Value = suc.GetDescripcion();
            SqlParametros = co.Parameters.Add("@ID_P", SqlDbType.Int);
            SqlParametros.Value = suc.GetID_prov();
            SqlParametros = co.Parameters.Add("@Direccion", SqlDbType.VarChar);
            SqlParametros.Value = suc.GetDireccion();


        }
    }
}
