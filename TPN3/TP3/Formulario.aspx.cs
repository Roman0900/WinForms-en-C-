using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Trabajo_Practico_N_3
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            this.Form.Attributes.Add("autocomplete", "off");
        }

        protected void cusvaliCP_ServerValidate(object source, ServerValidateEventArgs args)
        {
            
            if( args.Value.Length == 4)
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }

        protected void btnSaveLocalidad_Click(object sender, EventArgs e)
        {
             Boolean CompareInput()
            {
             

                foreach (var item in ddlLocalidades.Items)
                {
                    string palabra1 = txtLocalidad.Text.ToLower();
                    string palabra2 = item.ToString();
                     palabra2 = palabra2.ToLower();
                    if (String.Equals(palabra1, palabra2)) return true;
                }
                return false;

            }

            

            if  (CompareInput() == false)
            {
                ListItem localidad = new ListItem();
                localidad.Text = txtLocalidad.Text;
                localidad.Value = txtLocalidad.Text;
                ddlLocalidades.Items.Add(localidad);
                txtLocalidad.Text = "";
            }
            else
            {
                MessageBox.Show("Localidad Ya Agregada");
                txtLocalidad.Text = "";
            }
        }

        protected void btnUsuario_Click(object sender, EventArgs e)
        {
            lblBinevenida.Text = "BIENVENIDO USUARIO/A " + txtUsuario.Text;
        }

        protected void btnVolverInicio_Click(object sender, EventArgs e)
        {
            Server.Transfer("Inicio.aspx");
        }
    }
}