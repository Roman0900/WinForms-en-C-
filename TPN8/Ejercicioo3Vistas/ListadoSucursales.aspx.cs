using System;
using Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicioo3Vistas
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {

        private NegocioSucursal negsuc = new NegocioSucursal();

        private const String query_default = "select s.Id_Sucursal, s.NombreSucursal, s.DescripcionSucursal as 'Descripcion', p.DescripcionProvincia  as 'Provincia', s.DireccionSucursal as 'Dirección' from dbo.Sucursal as s inner join dbo.Provincia as p on s.Id_ProvinciaSucursal= p.Id_Provincia ";


        private void LoadGridView(string query)
        {

            gv_sucursales.DataSource = negsuc.ObtenerTablaSucursal("Sucursales", query);

            gv_sucursales.DataBind();

        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) LoadGridView(query_default);
            lblMensaje.Text = "";
        }

        protected void bttn_filtrar_Click(object sender, EventArgs e)
        {
           
            LoadGridView(query_default + " WHERE s.Id_Sucursal = " + txt_busqueda.Text + " ;");

            if (gv_sucursales.Rows.Count == 0)//Comprueba si el GridView esta vacio contando las filas
            {
                
                lblMensaje.Text =  "El ID no existe o ya habia sido borrado, Intente de nuevo" ;
            }
            
        }

        protected void bttn_mostrar_Click(object sender, EventArgs e)
        {

            LoadGridView(query_default);

            txt_busqueda.Text = String.Empty;

        }
    }
}