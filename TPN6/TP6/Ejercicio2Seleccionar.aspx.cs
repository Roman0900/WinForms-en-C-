using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N6
{
    public partial class Ejercicio2Seleccionar : System.Web.UI.Page
    {
        

       
        
        private const String lblText = "Producto agregado: ";

        private void LoadGridView()
        {

            GestionProducto productos = new GestionProducto();
            gv_seleccionar.DataSource = productos.ObtenerTodosLosProductos();
            gv_seleccionar.DataBind();

        }


        private Boolean RepeatedProducto(List<Producto> lis, Producto pro)
        {


            foreach (var item in lis)
            {
                if (item.Id_Producto == pro.Id_Producto
                    && item.Nombre_Producto == pro.Nombre_Producto
                    && item.Cantidad_Por_Unidad == pro.Cantidad_Por_Unidad
                    && item.Precio_Unidad == pro.Precio_Unidad)
                    return true;

            }
            return false;

        }

        private void AddListProducto(GridViewRow row)
        {


            List<Producto> productos = new List<Producto>();

            productos = (List<Producto>)Session["Productos"];

            Producto producto = new Producto();

            producto.Id_Producto = Convert.ToInt32(row.Cells[2].Text);

            producto.Nombre_Producto = HttpUtility.HtmlDecode(row.Cells[3].Text);

            producto.Cantidad_Por_Unidad = row.Cells[4].Text;

            producto.Precio_Unidad = (float)Convert.ToDecimal(row.Cells[5].Text);

            if (productos.Count == 0)
            {
                productos.Add(producto);
            }
            else
            {

                if (!RepeatedProducto(productos, producto))
                {
                    productos.Add(producto);
                }
            }

            Session["Productos"] = productos;


        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadGridView();
            }
        }

        protected void gv_seleccionar_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            lbl_agregado.Text = lblText;

            GridViewRow row = gv_seleccionar.Rows[e.NewSelectedIndex];

            if (Session["Productos"] != null)
            {
                AddListProducto(row);
            }
            else
            {
                List<Producto> productos = new List<Producto>();

                Session["Productos"] = productos;

                AddListProducto(row);

            }

            lbl_agregado.Text += row.Cells[3].Text;

        }

        protected void gv_seleccionar_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gv_seleccionar.PageIndex = e.NewPageIndex;

            LoadGridView();
        }
    }
}