using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N2
{
    public partial class Ejercicio_2__2 : System.Web.UI.Page
    {

        private void GetMaterias()
        {

            CheckBoxList aux_materias = new CheckBoxList();
            aux_materias = (CheckBoxList)PreviousPage.FindControl("CheckBoxList_materias");

            foreach (ListItem item in aux_materias.Items)
            {
                if (item.Selected)
                {
                    Label_temas.Text += "<p>" + item.Text + "</p>";
                }

            }




        }

        private void GetInput()
        {

            Label_nombre.Text += Request["TextBox_nombre"].ToString();

            Label_apellido.Text += Request["TextBox_apellido"].ToString();

        }

        private void GetCiudades()
        {
            DropDownList aux_ciudades = new DropDownList();
            aux_ciudades = (DropDownList)PreviousPage.FindControl("DropDownList_ciudad");


            foreach (ListItem item in aux_ciudades.Items)
            {

                if (item.Selected)
                {

                    Label_zona.Text += aux_ciudades.SelectedItem.Value;
                }
            }


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.GetCiudades();
                this.GetInput();
                this.GetMaterias();

            }


        }

        protected void returnbtn_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
    }
}