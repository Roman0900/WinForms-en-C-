using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N2
{
    public partial class Ejercicio_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Color1_Click(object sender, EventArgs e)
        {
            Lblmensaje.ForeColor = Color.Red ;
           
        }

        protected void Color2_Click(object sender, EventArgs e)
        {
            Lblmensaje.ForeColor = Color.Blue;
        }

        protected void Color3_Click(object sender, EventArgs e)
        {
            Lblmensaje.ForeColor = Color.Green;
        }

        protected void Btnvolver_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
    }
}