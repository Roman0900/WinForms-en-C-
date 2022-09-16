using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Entidades;
using Negocio;

namespace Ejercicioo3Vistas
{
    public partial class FormularioSucursales : System.Web.UI.Page
    {
        NegocioSucursal neg = new NegocioSucursal();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            
            Boolean estado = false;
            estado = neg.eliminarSucursal(Convert.ToInt32(txtID.Text));
            if (estado == true)
            {
                lblAviso.Text= "Se borro exitosamente ";
            }
            else { lblAviso.Text = "El ID ingresado no existe o ya fue borraro"; }
            

        }
    }
}