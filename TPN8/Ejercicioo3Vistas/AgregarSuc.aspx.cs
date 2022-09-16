using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;
using System.Data;

namespace Vistas
{
    public partial class AgregarSuc : System.Web.UI.Page
    {
        NegocioSucursal neg = new NegocioSucursal();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            this.Form.Attributes.Add("autocomplete", "off");
            if (IsPostBack == false)
            {
                CargarProvincias();
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ddlProvincia.SelectedIndex != 0)
            {
                Boolean estado = false;
                int seleccionado = ddlProvincia.SelectedIndex;
                estado = neg.NewSucursal(txtNombreSuc.Text, txtDesc.Text, txtDireccion.Text, seleccionado);
                if (estado == true)
                {
                    LimpiarCampos();
                    lblMensaje.Text = "Se agrego con exito la Sucursal";
                }
                else
                {
                    lblMensaje.Text = "ESA SUCURSAL YA EXISTE";
                }
            }
            else
            {
                lblMensaje.Text = "Tiene que seleccionar una provincia";
            }
        }


        public void LimpiarCampos()
        {
            txtDesc.Text = "";
            txtDireccion.Text = "";
            txtNombreSuc.Text = "";
            ddlProvincia.SelectedIndex = 0;

        }

        public void CargarProvincias()
        {
            DataTable tablaProvincia = neg.GetTablaProvincia();
            
            ddlProvincia.DataSource = tablaProvincia;
            ddlProvincia.DataTextField = "DescripcionProvincia";
            ddlProvincia.DataValueField = "Id_Provincia";
            ddlProvincia.DataBind();
            ddlProvincia.Items.Insert(0, new ListItem("--Seleccione Provincia--", "0"));

        }

    }
}