using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N4
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEje1_Click1(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio_1.aspx");
        }

        protected void ButtonEje2_Click(object sender, EventArgs e)
        {
                Server.Transfer("Ejercicio_2.aspx");
            
        }

        protected void ButtonEje3_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio_3.aspx");
        }
    }
}