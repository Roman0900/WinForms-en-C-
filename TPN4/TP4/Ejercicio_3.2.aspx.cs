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
    public partial class Ejercicio_3__2 : System.Web.UI.Page
    {
        private String SelectValueTema()
        {
            DropDownList aux_libros = new DropDownList();
            aux_libros = (DropDownList)PreviousPage.FindControl("ddlTema");
            foreach (ListItem item in aux_libros.Items)
            {

                if (item.Selected == true)
                {
                    return item.Value;
                }

            }
            return aux_libros.Items[0].Value;
        }


        private String QueryDB()
        {
            string end = ";";
            string querydb = "Select * from Libros where IdTema =" + SelectValueTema() + end;

            return querydb;
        }


        private void LoadDataset(String querydb)
        {
            SqlConnection cn = new SqlConnection("Data Source=localhost\\sqlexpress;Initial Catalog=Libreria;Integrated Security=True");

            cn.Open();

            SqlDataAdapter adap = new SqlDataAdapter(querydb, cn);
            DataSet ds = new DataSet();
            adap.Fill(ds, "Libritos");

            gvTemas.DataSource = ds.Tables["Libritos"];
            gvTemas.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadDataset(QueryDB());

            }
        }

        protected void link2_Click(object sender, EventArgs e)
        {
          
            Server.Transfer("Ejercicio_3.aspx");
        }
    }
}