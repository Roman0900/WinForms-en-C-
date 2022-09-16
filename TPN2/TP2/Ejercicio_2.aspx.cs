using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico_N2
{
    public partial class Ejercicio_2 : System.Web.UI.Page
    {
        private void ChargeItems()
        {

            ListItem item_a = new ListItem();
            ListItem item_b = new ListItem();
            ListItem item_c = new ListItem();

            item_a.Text = "Gral Pacheco";
            item_a.Value = "zona norte";
            item_b.Text = "San Miguel";
            item_b.Value = "zona oeste";
            item_c.Text = "Boedo";
            item_c.Value = "zona sur";

            DropDownList_ciudad.Items.Add(item_a);
            DropDownList_ciudad.Items.Add(item_b);
            DropDownList_ciudad.Items.Add(item_c);

            CheckBoxList_materias.Items.Add("Ciencias");
            CheckBoxList_materias.Items.Add("Literatura");
            CheckBoxList_materias.Items.Add("Historia");
        }

        private Boolean EmptyInput()
        {//Restriccion para saber si los textbox se encuentran vacios
            return TextBox_nombre.Text.Trim() != "" && TextBox_apellido.Text.Trim() != "" ? true : false;
        }

        private string GetInput()
        {

            return TextBox_nombre.Text.Trim() + " " + TextBox_apellido.Text.Trim();
        }

        private Boolean InputNotLetters()
        {
            return System.Text.RegularExpressions.Regex.IsMatch(GetInput(), @"[^A-Z  a-z\u00E0-\u00FC\u00f1\u00d1]{1,}");
        }



        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                this.ChargeItems();
            }


        }

        protected void Button_resumen_Click(object sender, EventArgs e)
        {
            this.Label_message.Text = String.Empty;

            if (!EmptyInput())
            {
                this.Label_message.Text += "Debe completarse el nombre y apellido";

            }
            else if (!InputNotLetters())
            {


                Server.Transfer("Ejercicio_2.2.aspx");

            }
            else
            {
                this.Label_message.Text = String.Empty;
                this.Label_message.Text += "Debe ingresar sólo letras";
            }


        }

        protected void returnbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Menu.aspx");
        }
    }
}