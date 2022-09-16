using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Trabajo_Practico_N5
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        private String ruta = "Data Source=localhost\\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            this.Form.Attributes.Add("autocomplete", "off");

        }

        private bool Checktxt()
        {
            return System.Text.RegularExpressions.Regex.IsMatch(txtID.Text, "^[0-9 ]+$");
        }


        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Checktxt() == true)
            {
                String consulta = "delete from Sucursal where ID_Sucursal =" + txtID.Text;
                SqlConnection conexion = new SqlConnection(ruta);
                conexion.Open();
                SqlCommand comando = new SqlCommand(consulta, conexion);

                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    lblAviso.Text = "ID inexistente";
                }
                else
                {
                    lblAviso.Text = "Se elimino correctamente";
                }
                txtID.Text = "";

                conexion.Close();
            }
            else
            {
                lblAviso.Text = ("SOLO INGRESE NUMEROS");
                txtID.Text = "";
            }
        }
    }
}