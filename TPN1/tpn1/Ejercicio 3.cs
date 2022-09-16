using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpn1
{
    public partial class Ejercicio_3 : Form
    {
        public Ejercicio_3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Variable de texto para facilitar la carga a esta y poder mostrarlo
            string Mostrar;

            Mostrar = "Sexo: " + (string)(rbtnFemenino.Checked ? "Femenino" : "Masculino") + "\r\n";
            Mostrar += "Estado Civil: " + (string)(rbtnCasado.Checked ? "Casado" : "Soltero") + "\r\n";

            foreach (string s in checkedListBox1.CheckedItems)
            {
                Mostrar += s + "\n";
            }

            // despues de recolectar los datos que el usuario marcó se muestran en el label
            lblElementosSeleccionados.Text = Mostrar;

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
