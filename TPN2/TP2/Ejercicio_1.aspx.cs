using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Trabajo_Practico_N2
{
    public partial class Ejercicio_1 : System.Web.UI.Page
    {
 
        private Boolean InputNotLetters(string palabra)
        {
            //Funcion para que se obtenga false al ingresar un numero o caracteres que no sean letras

            return System.Text.RegularExpressions.Regex.IsMatch(palabra, @"[^A-Z  a-z\u00E0-\u00FC\u00f1\u00d1]{1,}");
        }


        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnTabla_Click(object sender, EventArgs e)
        {
            int i = 0;

            if (InputNotLetters(txtProducto1.Text.ToString()) == true || txtProducto1.Text.Trim() == "")
            {
                i++;

            }
            if (InputNotLetters(txtProducto2.Text.ToString()) == true || txtProducto2.Text.Trim() == "")
            {
                i++;
            }
            if (InputNotLetters(txtCantidad1.Text.ToString()) == false || txtCantidad1.Text.Trim() == "")
            {
                i++;
            }
            if (InputNotLetters(txtCantidad2.Text.ToString()) == false || txtCantidad2.Text.Trim() == "")
            {
                i++;
            }

            if (i > 0)
            {
                MessageBox.Show("Se ingresaron datos invalidos o vacios en los campos");
                txtProducto1.Text = "";
                txtProducto2.Text = "";
                txtCantidad1.Text = "";
                txtCantidad2.Text = "";
            }
            else
            {
                int numero = int.Parse(txtCantidad1.Text);
                int numero2 = int.Parse(txtCantidad2.Text);

                String tabla = "<table border= '1'>";
                tabla += "<tr> <td>Producto</td> <td>Cantidad</td> </tr>";

                tabla += "<tr>";
                tabla += "<td>" + txtProducto1.Text + "</td>";
                tabla += "<td>" + numero + "</td>";
                tabla += "</tr>";

                tabla += "<tr>";
                tabla += "<td>" + txtProducto2.Text + "</td>";
                tabla += "<td>" + numero2 + "</td>";
                tabla += "</tr>";

                tabla += "<tr>";
                tabla += "<td>" + "TOTAL" + "</td>";
                tabla += "<td>" + (numero + numero2) + "</td>";
                tabla += "</tr>";

                tabla += "</table>";
                lblTabla.Text = tabla;

                txtProducto1.Text = "";
                txtProducto2.Text = "";
                txtCantidad1.Text = "";
                txtCantidad2.Text = "";
            }


        }

        protected void return_Click(object sender, EventArgs e)
        {
            Server.Transfer("Menu.aspx");
        }
    }
}