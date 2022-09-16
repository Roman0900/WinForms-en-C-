using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP7_PROG3_2021_1C
{
    public class GestionSucursales
    {
        public GestionSucursales() { }

        public DataTable ObtenerTabla(String Nombre, String Sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
            adp.Fill(ds, Nombre);
            
            return ds.Tables[Nombre];
        }

       

         public DataTable crearTablaSeleccionados()
        {
            DataTable dt = new DataTable();
            DataColumn columna = new DataColumn("ID SUCURSAL", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("NOMBRE", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            columna = new DataColumn("DESCRIPCION", System.Type.GetType("System.String"));
            dt.Columns.Add(columna);

            return dt;
        }

        public void agregarFilaSeleccionados(DataTable tabla, String id, String nombre, String descripcion)
        {
            DataRow dr = tabla.NewRow();
            dr["ID SUCURSAL"] = id;
            dr["NOMBRE"] = nombre;
            dr["DESCRIPCION"] = descripcion;
            tabla.Rows.Add(dr);
        }

       public DataTable ObtenerSucursalBuscador(string Palabra)
        {
            
            return ObtenerTabla("Sucursales", "SELECT[Id_Sucursal], [NombreSucursal],[Id_ProvinciaSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal] FROM[Sucursal] where[NombreSucursal] like '" + Palabra + "%'");
        }

        public DataTable ObtenerLosCamposDelEjercicio()
        {
            return ObtenerTabla("Sucursales", "SELECT [Id_Sucursal], [NombreSucursal],[Id_ProvinciaSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal] FROM [Sucursal]");
        }

        public DataTable FiltrarPorProvincia(String Sql)
        {
            return ObtenerTabla("Sucursales", Sql);
        }
    }
}