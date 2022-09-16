using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N2
{
    public partial class Ejercicio_4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
            /// si la contraseña y usuario son correctas carga el formulario de bienvenida
            /// si no, carga el formulario del error.
            protected void btnValidar_Click(object sender, EventArgs e)
            {
                if (String.Compare(txtUsuario.Text, "Claudio") == 0 && String.Compare(txtClave.Text, "Casas") == 0)
                {
                    Server.Transfer("ejercicio_4.2.aspx");
                }
                else
                {
                    Server.Transfer("ejercicio_4.3.aspx");
                }
            }

            protected void TextBox2_TextChanged(object sender, EventArgs e)
            {

            }

        protected void returnbtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
    }
}