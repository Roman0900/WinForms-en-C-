using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N_3
{
    public partial class Inicio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void UsuarioBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("Formulario.aspx");
        }
    }
}