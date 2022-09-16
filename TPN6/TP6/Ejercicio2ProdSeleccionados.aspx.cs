using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N6
{
    public partial class Ejercicio2ProdSeleccionados : System.Web.UI.Page
    {
        private DataTable GetTable()
        {
            DataTable table = new DataTable("Productos");

            List<Producto> listado = new List<Producto>();

            listado = (List<Producto>)Session["Productos"];

            table.Columns.Add("idProducto", typeof(int));

            table.Columns.Add("NombreProducto", typeof(String));

            table.Columns.Add("IdProveedor", typeof(String));

            table.Columns.Add("PrecioUnidad", typeof(Decimal));


            foreach (Producto item in listado)
            {
                table.Rows.Add(item.Id_Producto, item.Nombre_Producto, item.Cantidad_Por_Unidad, item.Precio_Unidad);

            }

            return table;

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Productos"] != null)
                {
                    gv_mostrar.DataSource = GetTable();

                    gv_mostrar.DataBind();

                }
            }
        }
    }
}