using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace Trabajo_Practico_N5
{   
    public partial class Ejercicio2 : System.Web.UI.Page
    {

        String querydb = "select s.Id_Sucursal, s.NombreSucursal, s.DescripcionSucursal as 'Descripcion', p.DescripcionProvincia  as 'Provincia', s.DireccionSucursal as 'Dirección' from dbo.Sucursal as s inner join dbo.Provincia as p on s.Id_ProvinciaSucursal= p.Id_Provincia ";

        Conexiondb conexiondb = new Conexiondb("Data Source=localhost\\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True");

        private void LoadGridView(String querydb)
        {

            conexiondb.Open();

            gv_sucursales.DataSource = conexiondb.GetDataset(querydb, "sucursales").Tables["sucursales"];

            gv_sucursales.DataBind();

            conexiondb.Close();


        }

        protected void Page_Load(object sender, EventArgs e)
        {
             this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            this.Form.Attributes.Add("autocomplete", "off");
            if (!IsPostBack)
            {
                LoadGridView(querydb);
            }
        }

        private String GetInput()
        {
            return txt_sucursal.Text;
        }

        private void ClearInput()
        {
            txt_sucursal.Text = String.Empty;
        }

        protected void bttn_filtar_Click(object sender, EventArgs e)
        {
            LoadGridView(querydb + " WHERE s.Id_Sucursal = " + GetInput() + " ;");
        }

        protected void bttn_mostrar_Click(object sender, EventArgs e)
        {
            LoadGridView(querydb);

            ClearInput();
        }
    }
}