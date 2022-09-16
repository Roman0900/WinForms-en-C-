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
    public partial class listadoSucursales : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
           {
               
              GestionSucursales sucu = new GestionSucursales();
              lvSucursales.DataSource = sucu.ObtenerLosCamposDelEjercicio();
              lvSucursales.DataBind();

            
              GestionProvincias pro = new GestionProvincias();
              dlProvincias.DataSource = pro.ObtenerTodasLasProvincias();
              dlProvincias.DataBind();

                LoadIntegrantes();
                

            }
        }

        protected void btnProvincia_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "comandoProvincia")
            {
               
                    if (e.CommandArgument.ToString() == "1")
                    {
                        (lvSucursales.FindControl("DataPager1") as DataPager).PageSize = 7;
                    }
                String sql = "SELECT[Id_Sucursal], [NombreSucursal],[Id_ProvinciaSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal] FROM[Sucursal]WHERE[Id_ProvinciaSucursal] = "+ e.CommandArgument.ToString() ;
                GestionSucursales sucu = new GestionSucursales();
                lvSucursales.DataSource = sucu.FiltrarPorProvincia(sql);
                lvSucursales.DataBind();


            }
        }

        protected void btnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "comandoSeleccionarLvSucurales")
            {
                GestionSucursales ta = new GestionSucursales();

                String[] vector = new string[3];
                vector = e.CommandArgument.ToString().Split('-');
                

                if (Session ["tabla"] == null)
                {
                    Session["tabla"] = ta.crearTablaSeleccionados();
                }

                ta.agregarFilaSeleccionados((DataTable)Session["tabla"], vector[0], vector[1], vector[2]);

            }
        }


        protected void lvSucursales_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
           
     
                (lvSucursales.FindControl("DataPager1") as DataPager).SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
                GestionSucursales sucu = new GestionSucursales();
                lvSucursales.DataSource = sucu.ObtenerLosCamposDelEjercicio();
                lvSucursales.DataBind();
          
            
        }

        private Boolean InputNotLetters(string palabra)
        {
            //Funcion para que se obtenga false al ingresar un numero o caracteres que no sean letras

            return System.Text.RegularExpressions.Regex.IsMatch(palabra, @"[^A-Z  a-z\u00E0-\u00FC\u00f1\u00d1]{1,}");
        }

        protected void Buscar_click(object sender, EventArgs e)
        {

            if (InputNotLetters(txbBuscarSuc.Text) == true)
            {
                txbBuscarSuc.Text = "";
                lblaviso.Text = "Solo se ingresan letras";

            }
            else
            {
                GestionSucursales sucu = new GestionSucursales();
                lvSucursales.DataSource = sucu.ObtenerSucursalBuscador(txbBuscarSuc.Text);
                lvSucursales.DataBind();
                lblaviso.Text = "";
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