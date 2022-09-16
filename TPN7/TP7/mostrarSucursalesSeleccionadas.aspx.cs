using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP7_PROG3_2021_1C
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadIntegrantes();

            if (Session["tabla"]!= null)
            {
                grdSucursalesSeleccionadas.DataSource =(DataTable) Session["tabla"];
                grdSucursalesSeleccionadas.DataBind();

                
            }

            
        }
        private void LoadIntegrantes()
        {
            String espacio = "";

            List<Integrante> Listado = new List<Integrante>();

            Listado.Add(new Integrante { Nombre = "Carlos", Apellido = "Gomez" });

            Listado.Add(new Integrante { Nombre = "Santiago", Apellido = "Britos" });

            Listado.Add(new Integrante { Nombre = "Pablo Sebastián", Apellido = "Castañeda" });

            Listado.Add(new Integrante { Nombre = "Federico Román", Apellido = "Pereyra" });

            Listado.Add(new Integrante { Nombre = "Leandro", Apellido = "Soraire" });
            lblIntegrantes.Text = "Integrantes: ";
            foreach (var item in Listado)
            {
                lblIntegrantes.Text += item.Apellido + espacio.PadRight(2) + item.Nombre + ',';
            }

        }
    }
}