using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpn1
{
    public partial class Ejercicio_1 : Form
    {
        public Ejercicio_1()
        {
            InitializeComponent();
        }

        private Boolean InputNotLetters()
        {
           //Funcion para que se obtenga false al ingresar un numero o caracteres que no sean letras

            return Regex.IsMatch(txtNombre.Text, @"[^A-Z  a-z\u00E0-\u00FC\u00f1\u00d1]{1,}");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {

          
            if (InputNotLetters() == true || txtNombre.Text.Trim() == "")
            {
                //Restriccion que no permite ingresar numeros, espacios en blanco o caracteres que no sean letras.
                //Al encontrar error borra el textbox y devuelve el foco a este para escribir.

                MessageBox.Show("No se Ingresan Numeros ni Espacios Vacios", "Atención");
                txtNombre.Text = "";
                txtNombre.Focus();

            }
            else
            {
                
                lbListaIzquierda.Items.Add(txtNombre.Text.Trim());
                txtNombre.Text = "";
            }

            //de haber pasado la restriccion corrobora que no esten en la lista 1 (izquierda) para que este no se repita.

            foreach (string aux in lbListaIzquierda.Items)
            {
                if (txtNombre.Text == aux)
                {
                    MessageBox.Show("El nombre ingresado ya se encuentra en la lista.", "Atención!");
                    txtNombre.Text = "";
                }
            }
            //Corrobora que el nombre del textbox no se repita en la lista 2 (derecha) para que no se repita.
            foreach (string aux in lbListaDerecha.Items)
            {
                if (txtNombre.Text == aux)
                {
                    MessageBox.Show("El nombre ingresado ya se encuentra en la lista.", "Atención!");
                    txtNombre.Text = "";
                }
            }

            
            
            
        }

        private void btnflecha_Click(object sender, EventArgs e)
        {
            // mueve elemento seleccionado a la lista derecha si no es null

            if (lbListaIzquierda.SelectedItem != null)
            {

                lbListaDerecha.Items.Add(lbListaIzquierda.SelectedItem);
                lbListaIzquierda.Items.RemoveAt(lbListaIzquierda.SelectedIndex);
            }

        }

        private void btndobleflecha_Click(object sender, EventArgs e)
        {
            // mueve todos los elementos de la lista izq a la derecha
            foreach (string aux in lbListaIzquierda.Items)
            {
                lbListaDerecha.Items.Add(aux);
            }
            foreach (string aux2 in lbListaDerecha.Items)
            {
                lbListaIzquierda.Items.Remove(aux2);
            }
        }

        private void return_inicio_Click(object sender, EventArgs e)
        {
            //Boton para volver al inicio de la aplicacion
            this.Hide();
            Form_Inicio f1 = new Form_Inicio();
            f1.ShowDialog();
            this.Close();
        }
    }
}
