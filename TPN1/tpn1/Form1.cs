using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace tpn1
{
    public partial class Form_Inicio : Form
    {
        
        public Form_Inicio()
        {
            InitializeComponent();
        }
        public void Cargar_Listado()
        {
            //Se establecen variables de Intengrantes que contienen sus nombres y apellidos
            String espacio = "";
            List < Integrante > Listado = new List<Integrante>();
            Listado.Add(new Integrante { Nombre = "Carlos", Apellido = "Gomez" });
            Listado.Add(new Integrante { Nombre = "Santiago", Apellido = "Britos" });
            Listado.Add(new Integrante { Nombre = "Pablo Sebastián", Apellido = "Castañeda" });
            Listado.Add(new Integrante { Nombre = "Federico Román", Apellido = "Pereyra" });
            Listado.Add(new Integrante { Nombre = "Leandro", Apellido = "Soraire" });
           
            foreach (var item in Listado)
            {
                
                listado_grupo.Items.Add(item.Apellido + espacio.PadRight(2)+item.Nombre);
               
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Carga el listado de integrantes al listbox cuando el inicia la aplicacion
            this.Cargar_Listado();
        }

     
        private void Ejercicio2_Click(object sender, EventArgs e)
        {
            //Controla el boton para que el click lo dirija al ejercicio

            this.Hide();
            Ejercicio2 f1 = new Ejercicio2();
            f1.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Controla el boton para que el click lo dirija al ejercicio
            this.Hide();
            Ejercicio_1 f1 = new Ejercicio_1();
            f1.ShowDialog();
            this.Close();
        }

        private void Ejercicio3_Click(object sender, EventArgs e)
        {
            //Controla el boton para que el click lo dirija al ejercicio
            this.Hide();
            Ejercicio_3 f1 = new Ejercicio_3();
            f1.ShowDialog();
            this.Close();
        }
    }
}
