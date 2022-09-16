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
    public partial class Ejercicio_2 : System.Web.UI.Page
    {
        private void LoadDll()
        {

            ListItem optiona = new ListItem();

            optiona.Text = "Igual a :";
            optiona.Value = "=";

            ListItem optionb = new ListItem();
            optionb.Text = "Mayor a :";
            optionb.Value = ">";


            ListItem optionc = new ListItem();
            optionc.Text = "Menor  a:";
            optionc.Value = "<";

            dll_categoria.Items.Add(optiona);
            dll_categoria.Items.Add(optionb);
            dll_categoria.Items.Add(optionc);


            dll_producto.Items.Add(optiona);
            dll_producto.Items.Add(optionb);
            dll_producto.Items.Add(optionc);

        }

        private void LoadDataset(String querydb)
        {
            const string stringdb = "Data Source=localhost\\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";

            SqlConnection connection = new SqlConnection(stringdb);

            connection.Open();

            DataSet dataset = new DataSet();

            SqlDataAdapter adapter = new SqlDataAdapter(querydb, connection);


            adapter.Fill(dataset, "Productos-Categorias");

            gv_neptuno.DataSource = dataset.Tables["Productos-Categorias"];

            gv_neptuno.DataBind();

            connection.Close();

        }


        private String QueryDB()
        {
            string querydb = QueryDefault();
            string end = ";";

            //preguntamos si los input de productos y categorias están vacios
            if (String.Equals(GetInputProductos(), String.Empty) && String.Equals(GetInputCategorias(), String.Empty))
            {
                querydb += end;

            }//preguntamos si ambos input están completos 
            else if (!String.Equals(GetInputProductos(), String.Empty) && !String.Equals(GetInputCategorias(), String.Empty))
            {
                querydb += "WHERE p.IdProducto" + SelectValueProducto() + GetInputProductos()
                + "AND " + "c.IdCategoría " + SelectValueCategoria() + GetInputCategorias() + end;
            }//en este caso evaluamos que el input de productos esté lleno y el input de categoria esté vacio
            else if (!String.Equals(GetInputProductos(), String.Empty) && String.Equals(GetInputCategorias(), String.Empty))
            {
                querydb += "WHERE p.IdProducto " + SelectValueProducto() + GetInputProductos() + end;
            }//evaluamos que el input de productos este vacio , pero esté lleno el de categoria
            else if (String.Equals(GetInputProductos(), String.Empty) && !String.Equals(GetInputCategorias(), String.Empty))
            {
                querydb += "WHERE c.IdCategoría " + SelectValueCategoria() + GetInputCategorias() + end;
            }

            return querydb;
        }

        private String SelectValueProducto()
        {
            foreach (ListItem item in dll_producto.Items)
            {
                if (item.Selected) return item.Value;
            }

            return dll_producto.Items[0].Value;
        }

        private String SelectValueCategoria()
        {
            foreach (ListItem item in dll_categoria.Items)
            {
                if (item.Selected) return item.Value;
            }

            return dll_categoria.Items[0].Value;

        }




        private void ClearInput()
        {

            txt_categoria.Text = String.Empty;
            txt_producto.Text = txt_categoria.Text;

        }

        private String GetInputProductos()
        {
            return txt_producto.Text;
        }

        private String GetInputCategorias()
        {
            return txt_categoria.Text;
        }

        private String QueryDefault()
        {
            return "select p.IdProducto,p.NombreProducto,c.IdCategoría,p.CantidadPorUnidad,p.PrecioUnidad from dbo.Productos as p inner join dbo.Categorías as c on p.IdCategoría = c.IdCategoría ";
        }


        private protected void Page_Load(object sender, EventArgs e)
        {
            this.UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            this.Form.Attributes.Add("autocomplete", "off");
            if (!IsPostBack)
            {
                LoadDll();
                LoadDataset(QueryDefault());
            }
        }

        protected void bttn_filtrar_Click(object sender, EventArgs e)
        {
            LoadDataset(QueryDB());

            ClearInput();
        }

        protected void bttn_quitarfiltro_Click(object sender, EventArgs e)
        {
            LoadDataset(QueryDefault());
        }

        protected void Backtomenu_Click(object sender, EventArgs e)
        {
       
                Server.Transfer("Menu.aspx");
            
        }
    }
}