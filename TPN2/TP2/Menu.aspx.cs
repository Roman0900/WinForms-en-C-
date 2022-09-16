using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N2
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonEje1_Click(object sender, EventArgs e)
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

        protected void ButtonEje4_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio_4.aspx");
        }

        protected void ButtonEje5_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio_5.aspx");
        }

    
    }
}