using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP7_PROG3_2021_1C
{
    public class GestionProvincias
    {
        public GestionProvincias() { }

        public DataTable ObtenerTabla(String Nombre, String Sql)
        {
            DataSet ds = new DataSet();
            AccesoDatos datos = new AccesoDatos();
            SqlDataAdapter adp = datos.ObtenerAdaptador(Sql);
            adp.Fill(ds, Nombre);
            return ds.Tables[Nombre];
        }

        public DataTable ObtenerTodasLasProvincias()
        {
            return ObtenerTabla("Provincias", "SELECT [Id_Provincia], [DescripcionProvincia] FROM [Provincia]");
        }
    }
}