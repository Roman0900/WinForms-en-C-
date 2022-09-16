using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N6
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                cargarGridView();
            }
        }


        public void cargarGridView()
        {
            GestionProducto productos = new GestionProducto();
            grdProductos.DataSource = productos.ObtenerTodosLosProductos();
            grdProductos.DataBind();
        }

        protected void grdProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            Producto pro = new Producto();
            pro.Id_Producto = Convert.ToInt32(((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_it_id")).Text);
            GestionProducto gPro = new GestionProducto();
            gPro.EliminarProducto(pro);
            grdProductos.EditIndex = -1;
            cargarGridView();
        }

        protected void grdProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdProductos.EditIndex = e.NewEditIndex;
            cargarGridView();

        }

        protected void grdProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdProductos.EditIndex = -1;
            cargarGridView();
        }
        protected void grdProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            String s_IdProducto = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_id")).Text;
            String s_Nombre = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_nombre")).Text;
            String s_Cantidad = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_cantidad")).Text;
            String s_Precio = ((Label)grdProductos.Rows[e.NewSelectedIndex].FindControl("lbl_it_precio")).Text;
        }
        protected void grdProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if (ValidarCampos(e) == true)
            {
                String s_IdProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_edit_id")).Text;
                String s_Nombre = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_edit_nombre")).Text;
                String s_Cantidad = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_edit_cantidad")).Text;
                String s_Precio = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_edit_pu")).Text;
                Producto pro = new Producto();
                pro.Id_Producto = Convert.ToInt32(s_IdProducto);
                pro.Nombre_Producto = s_Nombre;
                pro.Cantidad_Por_Unidad = s_Cantidad;
                pro.Precio_Unidad = Convert.ToSingle(s_Precio);

                GestionProducto g = new GestionProducto();
                g.ActualizarProducto(pro);
                grdProductos.EditIndex = -1;
                cargarGridView();
            }
            else
            {
                lblmensaje.Text = "Ingreso incorrecto de datos";
                
            }

            if (grdProductos.EditIndex == -1)
            {
                lblmensaje.Text = "";
            }
            
           

        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            cargarGridView();
        }

        public Boolean ValidarCampos(GridViewUpdateEventArgs e)
        {
         if(((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_edit_id")).Text== "")
            {
                return false;
            }
         if (((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_edit_cantidad")).Text == "")
           {
                return false;
           }
         if(System.Text.RegularExpressions.Regex.IsMatch(((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_edit_pu")).Text, @"^[0-9\, ]+$") == false)
            {
                return false;
            }

            return true;


        }

    }

}