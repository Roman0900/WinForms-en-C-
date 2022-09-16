using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Trabajo_Practico_N6
{
    public class GestionProducto
    {
        public GestionProducto()
        {

        }

        private DataTable ObtenerTabla(String Nombre, String Sql)
        {
            DataSet ds = new DataSet();
            ConexionDatos datos = new ConexionDatos();
            SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
            adp.Fill(ds, Nombre);
            return ds.Tables[Nombre];
        }
        public DataTable ObtenerTodosLosProductos()
        {
            return ObtenerTabla("Productos", "select IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad from Productos");
        }

        private void armarParametroEliminarProducto(ref SqlCommand Comando, Producto Producto)
        {
            SqlParameter Sqlparametros = new SqlParameter();
            Sqlparametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            Sqlparametros.Value = Producto.Id_Producto;

        }

        private void armarParametroProductos(ref SqlCommand Comando, Producto Producto)
        {
            SqlParameter SqlParametros = new SqlParameter();
            SqlParametros = Comando.Parameters.Add("@IdProducto", SqlDbType.Int);
            SqlParametros.Value = Producto.Id_Producto;
            SqlParametros = Comando.Parameters.Add("@NombreProducto", SqlDbType.NVarChar, 40);
            SqlParametros.Value = Producto.Nombre_Producto;
            SqlParametros = Comando.Parameters.Add("@CantidadPorUnidad", SqlDbType.NVarChar, 20);
            SqlParametros.Value = Producto.Cantidad_Por_Unidad;
            SqlParametros = Comando.Parameters.Add("@PrecioUnidad", SqlDbType.Money);
            SqlParametros.Value = Producto.Precio_Unidad;

        }

        public bool ActualizarProducto(Producto pro)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametroProductos(ref Comando, pro);
            ConexionDatos ad = new ConexionDatos();
            int filasInsertadas = ad.ejecutarProcedimiento(Comando, "spActualizarProducto");
            if (filasInsertadas == 1)
                return true;
            else
                return false;
        }



        public bool EliminarProducto(Producto pro)
        {
            SqlCommand Comando = new SqlCommand();
            armarParametroEliminarProducto(ref Comando, pro);
            ConexionDatos ad = new ConexionDatos();
            int FilasInsertadas = ad.ejecutarProcedimiento(Comando, "spEliminarProducto");
            if (FilasInsertadas == 1)
                return true;

            else

                return false;


        }








    }
}