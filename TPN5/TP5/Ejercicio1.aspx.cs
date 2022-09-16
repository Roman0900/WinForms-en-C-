using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Trabajo_Practico_N5
{
    public partial class Ejercicio11 : System.Web.UI.Page
    {
        private string ruta = "Data Source = localhost\\sqlexpress;Initial Catalog = BDSucursales; Integrated Security = True";

        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            this.Form.Attributes.Add("autocomplete", "off");
            if (IsPostBack == false)
            {
                cargarProvinciaDdl();


            }

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string VALOR = ddlProvincia.SelectedItem.ToString();
            if (VALOR != "--Seleccione Provincia--")
            {
                String consulta = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal,DireccionSucursal, Id_ProvinciaSucursal) VALUES ('" + txtNombreSucursal.Text + "','" + txtDesripcion.Text + "','" + txtDireccion.Text + "','" + ddlProvincia.SelectedValue + "')";
                Conexiondb conectate = new Conexiondb(ruta);
                int i = conectate.ejecutaTransaccion(consulta,ruta);
                limpiarCampos();
                mensajeDeCarga(i);
            }
            else
            {
                lblMensajeAgregado.Text = "INGRESE UNA PROVINCIA";
                limpiarCampos();
            }

        }

        public void cargarProvinciaDdl()
        {
            SqlConnection conexion = new SqlConnection(ruta);
            conexion.Open();

            SqlCommand comando = new SqlCommand("SELECT * FROM Provincia", conexion);

            SqlDataReader dr = comando.ExecuteReader();


            ddlProvincia.DataSource = dr;
            ddlProvincia.DataTextField = "DescripcionProvincia";
            ddlProvincia.DataValueField = "Id_Provincia";
            ddlProvincia.DataBind();
            ddlProvincia.Items.Insert(0, new ListItem("--Seleccione Provincia--", "0"));

            conexion.Close();


        }

        public void limpiarCampos()
        {
            txtDesripcion.Text = "";
            txtDireccion.Text = "";
            txtNombreSucursal.Text = "";
            ddlProvincia.SelectedIndex = 0;
        }

        public void mensajeDeCarga(int i)
        {
            if (i > 0) lblMensajeAgregado.Text = "La sucursal se ha agregado con exito";
            else { lblMensajeAgregado.Text = "ERROR DE CARGA"; }
        }
    }
}