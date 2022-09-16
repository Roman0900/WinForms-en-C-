
namespace tpn1
{
    partial class Ejercicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.group_datos = new System.Windows.Forms.GroupBox();
            this.button_agregar = new System.Windows.Forms.Button();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.label_apellido = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.groupBox_elementos = new System.Windows.Forms.GroupBox();
            this.button_borrar = new System.Windows.Forms.Button();
            this.listBox_elementos = new System.Windows.Forms.ListBox();
            this.volver = new System.Windows.Forms.Button();
            this.group_datos.SuspendLayout();
            this.groupBox_elementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_datos
            // 
            this.group_datos.Controls.Add(this.button_agregar);
            this.group_datos.Controls.Add(this.textBox_apellido);
            this.group_datos.Controls.Add(this.textBox_nombre);
            this.group_datos.Controls.Add(this.label_apellido);
            this.group_datos.Controls.Add(this.label_nombre);
            this.group_datos.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_datos.Location = new System.Drawing.Point(58, 45);
            this.group_datos.Name = "group_datos";
            this.group_datos.Size = new System.Drawing.Size(292, 347);
            this.group_datos.TabIndex = 0;
            this.group_datos.TabStop = false;
            this.group_datos.Text = "Ingreso de Datos";
            // 
            // button_agregar
            // 
            this.button_agregar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_agregar.Location = new System.Drawing.Point(133, 216);
            this.button_agregar.Name = "button_agregar";
            this.button_agregar.Size = new System.Drawing.Size(100, 30);
            this.button_agregar.TabIndex = 4;
            this.button_agregar.Text = "Agregar";
            this.button_agregar.UseVisualStyleBackColor = true;
            this.button_agregar.Click += new System.EventHandler(this.button_agregar_Click);
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(133, 163);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(100, 23);
            this.textBox_apellido.TabIndex = 3;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(133, 122);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 23);
            this.textBox_nombre.TabIndex = 2;
            // 
            // label_apellido
            // 
            this.label_apellido.AutoSize = true;
            this.label_apellido.Location = new System.Drawing.Point(56, 163);
            this.label_apellido.Name = "label_apellido";
            this.label_apellido.Size = new System.Drawing.Size(57, 15);
            this.label_apellido.TabIndex = 1;
            this.label_apellido.Text = "Apellido:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Location = new System.Drawing.Point(56, 125);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(55, 15);
            this.label_nombre.TabIndex = 0;
            this.label_nombre.Text = "Nombre:";
            // 
            // groupBox_elementos
            // 
            this.groupBox_elementos.Controls.Add(this.button_borrar);
            this.groupBox_elementos.Controls.Add(this.listBox_elementos);
            this.groupBox_elementos.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_elementos.Location = new System.Drawing.Point(373, 45);
            this.groupBox_elementos.Name = "groupBox_elementos";
            this.groupBox_elementos.Size = new System.Drawing.Size(361, 347);
            this.groupBox_elementos.TabIndex = 1;
            this.groupBox_elementos.TabStop = false;
            this.groupBox_elementos.Text = "Elementos";
            // 
            // button_borrar
            // 
            this.button_borrar.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_borrar.Location = new System.Drawing.Point(115, 288);
            this.button_borrar.Name = "button_borrar";
            this.button_borrar.Size = new System.Drawing.Size(132, 30);
            this.button_borrar.TabIndex = 1;
            this.button_borrar.Text = "Borrar";
            this.button_borrar.UseVisualStyleBackColor = true;
            this.button_borrar.Click += new System.EventHandler(this.button_borrar_Click);
            // 
            // listBox_elementos
            // 
            this.listBox_elementos.FormattingEnabled = true;
            this.listBox_elementos.ItemHeight = 15;
            this.listBox_elementos.Location = new System.Drawing.Point(35, 19);
            this.listBox_elementos.Name = "listBox_elementos";
            this.listBox_elementos.Size = new System.Drawing.Size(299, 229);
            this.listBox_elementos.TabIndex = 0;
            // 
            // volver
            // 
            this.volver.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volver.Location = new System.Drawing.Point(488, 413);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(132, 23);
            this.volver.TabIndex = 2;
            this.volver.Text = "Volver Al Inicio";
            this.volver.UseVisualStyleBackColor = true;
            this.volver.Click += new System.EventHandler(this.volver_Click);
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.volver);
            this.Controls.Add(this.groupBox_elementos);
            this.Controls.Add(this.group_datos);
            this.Name = "Ejercicio2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.Load += new System.EventHandler(this.Ejercicio2_Load);
            this.group_datos.ResumeLayout(false);
            this.group_datos.PerformLayout();
            this.groupBox_elementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_datos;
        private System.Windows.Forms.Label label_apellido;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.Button button_agregar;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.GroupBox groupBox_elementos;
        private System.Windows.Forms.Button button_borrar;
        private System.Windows.Forms.ListBox listBox_elementos;
        private System.Windows.Forms.Button volver;
    }
}