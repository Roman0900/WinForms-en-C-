using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N2
{
    public partial class Ejercicio_4__3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void returnbtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
    }
}