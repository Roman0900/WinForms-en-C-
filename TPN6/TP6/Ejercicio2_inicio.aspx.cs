using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N6
{
    public partial class Ejercicio2_inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lb_eliminar_Click(object sender, EventArgs e)
        {

            Session["Productos"] = null;

        }
    }
}