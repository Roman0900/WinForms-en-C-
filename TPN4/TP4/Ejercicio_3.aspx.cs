using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Trabajo_Practico_N4
{
    public partial class Ejercicio_3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True");

                cn.Open();

                SqlDataAdapter adap = new SqlDataAdapter("Select * from Temas", cn);
                DataSet ds = new DataSet();
                adap.Fill(ds, "Temas");

                ddlTema.DataSource = ds.Tables["Temas"];

                ddlTema.DataTextField = "Tema";
                ddlTema.DataValueField = "IdTema";
                ddlTema.DataBind();

            }
        }

        protected void link1_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio_3.2.aspx");

        }

        protected void Backmenu3_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
    }
}