using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace tpn1
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void ClearInput()
        {
            this.textBox_apellido.Clear();
            this.textBox_nombre.Clear();

        }

        private string GetInput()
        {
            //Obtiene el texto del textbox correspondiente sacandole sus espacios con la funcion Trim()
            return textBox_nombre.Text.Trim() + " " + textBox_apellido.Text.Trim();
        }

        private Boolean EmptyInput()
        {//Restriccion para saber si los textbox se encuentran vacios
           return  textBox_nombre.Text.Trim() != "" && textBox_apellido.Text.Trim() != "" ?  true : false;
        }

        private Boolean InputNotLetters()
        {
            //Restrccion para numeros y caracteres que no sean letras
            return Regex.IsMatch(GetInput(), @"[^A-Z  a-z\u00E0-\u00FC\u00f1\u00d1]{1,}");
        }

        private Boolean CompareInput()
        {
            //funcion para comparar la lista con lo que se quiere ingresar
            foreach (var item in listBox_elementos.Items)
            {
                if (String.Equals(this.GetInput(), Convert.ToString(item))) return true;
            }
            return false;

        }
            
        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            //funcion que limpia todo el ejercio al principio de este
            this.ClearInput();
            this.listBox_elementos.Items.Clear();
            this.listBox_elementos.Sorted = true;

        }

        private void button_agregar_Click(object sender, EventArgs e)
        {
           //Primera restriccion para que no ingrese numeros, espacios vacios o caracteres que no sean letras
            if (this.EmptyInput() && !this.InputNotLetters())
            {
              
                //Segunda restriccion para que no se ingresen nombres que ya fueron ingresados anteriormente
                if (listBox_elementos.Items.Count == 0)
                {
                    listBox_elementos.Items.Add(this.GetInput());
                    this.ClearInput();

                }
                else
                {
                    if (!this.CompareInput())
                    { 
                        listBox_elementos.Items.Add(this.GetInput());             
                        this.ClearInput();

                    }
                    else
                    {
                        MessageBox.Show("El elemento está repetido");
                        this.ClearInput();
                    }
                   

                }
            }          
            else if (this.InputNotLetters())
            {
                MessageBox.Show("El input sólo debe contener letras y espacios");
                this.ClearInput();
            }         
            else
            {
                MessageBox.Show("Ambos campos deben estar completos");
            }

        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
       //Borra el elemento seleccionado por el usuario

            if (listBox_elementos.SelectedIndex>=0){

                listBox_elementos.Items.RemoveAt(listBox_elementos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un elemento");
            }
            

        }

        private void volver_Click(object sender, EventArgs e)
        {
            //Boton para volver al inicio de la aplicacion
            this.Hide();
            Form_Inicio f1 = new Form_Inicio();
            f1.ShowDialog();
            this.Close();
        }
    }


}
