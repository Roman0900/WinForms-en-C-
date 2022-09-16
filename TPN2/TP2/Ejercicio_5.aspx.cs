using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N2
{
    public partial class Ejercicio_5 : System.Web.UI.Page
    { 

        protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnCalcularPrecio_Click(object sender, EventArgs e)
    {
        double pf = 0;



        foreach (ListItem l in cblAccesorios.Items)
        {
            if (l.Selected)
            {
                pf += Convert.ToDouble(l.Value);
            }
        }
        pf += Convert.ToDouble(ddlCantidadMemoria.SelectedValue);

        lblPrecioFinal.Text = "El precio final es " + pf.ToString() + " $";
         }

        protected void returnbtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
    }
}