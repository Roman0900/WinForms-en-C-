using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N2
{
    public partial class Ejercicio_4__2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                /// carga la pagina y pide al form anterior el .text
                String Usuario;
                Usuario = Request["txtUsuario"].ToString();


                lblUsuario.Text = Usuario + ".";
            }
        }

        protected void returnbtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
    }
}