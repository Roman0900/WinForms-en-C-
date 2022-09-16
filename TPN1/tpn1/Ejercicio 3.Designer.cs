
namespace tpn1
{
    partial class Ejercicio_3
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
            this.gboxSexo = new System.Windows.Forms.GroupBox();
            this.rbtnMasculino = new System.Windows.Forms.RadioButton();
            this.rbtnFemenino = new System.Windows.Forms.RadioButton();
            this.gboxEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbtnSoltero = new System.Windows.Forms.RadioButton();
            this.rbtnCasado = new System.Windows.Forms.RadioButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lblElementosSeleccionados = new System.Windows.Forms.Label();
            this.return_inicio = new System.Windows.Forms.Button();
            this.gboxSexo.SuspendLayout();
            this.gboxEstadoCivil.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxSexo
            // 
            this.gboxSexo.Controls.Add(this.rbtnMasculino);
            this.gboxSexo.Controls.Add(this.rbtnFemenino);
            this.gboxSexo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxSexo.Location = new System.Drawing.Point(19, 14);
            this.gboxSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxSexo.Name = "gboxSexo";
            this.gboxSexo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxSexo.Size = new System.Drawing.Size(292, 150);
            this.gboxSexo.TabIndex = 1;
            this.gboxSexo.TabStop = false;
            this.gboxSexo.Text = "Sexo";
            // 
            // rbtnMasculino
            // 
            this.rbtnMasculino.AutoSize = true;
            this.rbtnMasculino.Location = new System.Drawing.Point(89, 84);
            this.rbtnMasculino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnMasculino.Name = "rbtnMasculino";
            this.rbtnMasculino.Size = new System.Drawing.Size(86, 19);
            this.rbtnMasculino.TabIndex = 0;
            this.rbtnMasculino.Text = "Masculino";
            this.rbtnMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtnFemenino
            // 
            this.rbtnFemenino.AutoSize = true;
            this.rbtnFemenino.Checked = true;
            this.rbtnFemenino.Location = new System.Drawing.Point(89, 35);
            this.rbtnFemenino.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnFemenino.Name = "rbtnFemenino";
            this.rbtnFemenino.Size = new System.Drawing.Size(84, 19);
            this.rbtnFemenino.TabIndex = 0;
            this.rbtnFemenino.TabStop = true;
            this.rbtnFemenino.Text = "Femenino";
            this.rbtnFemenino.UseVisualStyleBackColor = true;
            // 
            // gboxEstadoCivil
            // 
            this.gboxEstadoCivil.Controls.Add(this.rbtnSoltero);
            this.gboxEstadoCivil.Controls.Add(this.rbtnCasado);
            this.gboxEstadoCivil.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxEstadoCivil.Location = new System.Drawing.Point(685, 15);
            this.gboxEstadoCivil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxEstadoCivil.Name = "gboxEstadoCivil";
            this.gboxEstadoCivil.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gboxEstadoCivil.Size = new System.Drawing.Size(292, 149);
            this.gboxEstadoCivil.TabIndex = 2;
            this.gboxEstadoCivil.TabStop = false;
            this.gboxEstadoCivil.Text = "Estado Civil";
            // 
            // rbtnSoltero
            // 
            this.rbtnSoltero.AutoSize = true;
            this.rbtnSoltero.Location = new System.Drawing.Point(89, 83);
            this.rbtnSoltero.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnSoltero.Name = "rbtnSoltero";
            this.rbtnSoltero.Size = new System.Drawing.Size(68, 19);
            this.rbtnSoltero.TabIndex = 0;
            this.rbtnSoltero.Text = "Soltero";
            this.rbtnSoltero.UseVisualStyleBackColor = true;
            // 
            // rbtnCasado
            // 
            this.rbtnCasado.AutoSize = true;
            this.rbtnCasado.Checked = true;
            this.rbtnCasado.Location = new System.Drawing.Point(89, 34);
            this.rbtnCasado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbtnCasado.Name = "rbtnCasado";
            this.rbtnCasado.Size = new System.Drawing.Size(67, 19);
            this.rbtnCasado.TabIndex = 0;
            this.rbtnCasado.TabStop = true;
            this.rbtnCasado.Text = "Casado";
            this.rbtnCasado.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Data Entry",
            "Operador De PC",
            "Programador",
            "Reparador De PC",
            "Tester"});
            this.checkedListBox1.Location = new System.Drawing.Point(348, 98);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(300, 151);
            this.checkedListBox1.TabIndex = 4;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(348, 255);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(301, 54);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar Lo Que Se Selecciono";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(3, 312);
            this.lblMensaje.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(323, 19);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "Usted selecciono los siguientes Elementos: ";
            // 
            // lblElementosSeleccionados
            // 
            this.lblElementosSeleccionados.AutoSize = true;
            this.lblElementosSeleccionados.Location = new System.Drawing.Point(13, 351);
            this.lblElementosSeleccionados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblElementosSeleccionados.Name = "lblElementosSeleccionados";
            this.lblElementosSeleccionados.Size = new System.Drawing.Size(0, 15);
            this.lblElementosSeleccionados.TabIndex = 7;
            // 
            // return_inicio
            // 
            this.return_inicio.Location = new System.Drawing.Point(756, 226);
            this.return_inicio.Name = "return_inicio";
            this.return_inicio.Size = new System.Drawing.Size(133, 23);
            this.return_inicio.TabIndex = 8;
            this.return_inicio.Text = "Volver Inicio";
            this.return_inicio.UseVisualStyleBackColor = true;
            this.return_inicio.Click += new System.EventHandler(this.return_inicio_Click);
            // 
            // Ejercicio_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 519);
            this.Controls.Add(this.return_inicio);
            this.Controls.Add(this.lblElementosSeleccionados);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.gboxEstadoCivil);
            this.Controls.Add(this.gboxSexo);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Ejercicio_3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.gboxSexo.ResumeLayout(false);
            this.gboxSexo.PerformLayout();
            this.gboxEstadoCivil.ResumeLayout(false);
            this.gboxEstadoCivil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxSexo;
        private System.Windows.Forms.RadioButton rbtnMasculino;
        private System.Windows.Forms.RadioButton rbtnFemenino;
        private System.Windows.Forms.GroupBox gboxEstadoCivil;
        private System.Windows.Forms.RadioButton rbtnSoltero;
        private System.Windows.Forms.RadioButton rbtnCasado;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Label lblElementosSeleccionados;
        private System.Windows.Forms.Button return_inicio;
    }
}