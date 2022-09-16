
namespace tpn1
{
    partial class Form_Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Ejercicio2 = new System.Windows.Forms.Button();
            this.listado_grupo = new System.Windows.Forms.ListBox();
            this.lbl_Grupo = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Ejercicio3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Ejercicio2
            // 
            this.Ejercicio2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejercicio2.Location = new System.Drawing.Point(386, 57);
            this.Ejercicio2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ejercicio2.Name = "Ejercicio2";
            this.Ejercicio2.Size = new System.Drawing.Size(88, 27);
            this.Ejercicio2.TabIndex = 1;
            this.Ejercicio2.Text = "Ejercicio 2";
            this.Ejercicio2.UseVisualStyleBackColor = true;
            this.Ejercicio2.Click += new System.EventHandler(this.Ejercicio2_Click);
            // 
            // listado_grupo
            // 
            this.listado_grupo.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listado_grupo.FormattingEnabled = true;
            this.listado_grupo.ItemHeight = 14;
            this.listado_grupo.Location = new System.Drawing.Point(201, 186);
            this.listado_grupo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listado_grupo.Name = "listado_grupo";
            this.listado_grupo.Size = new System.Drawing.Size(452, 130);
            this.listado_grupo.TabIndex = 3;
            // 
            // lbl_Grupo
            // 
            this.lbl_Grupo.AutoSize = true;
            this.lbl_Grupo.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Grupo.Location = new System.Drawing.Point(355, 103);
            this.lbl_Grupo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Grupo.Name = "lbl_Grupo";
            this.lbl_Grupo.Size = new System.Drawing.Size(143, 15);
            this.lbl_Grupo.TabIndex = 4;
            this.lbl_Grupo.Text = "Listado de Integrantes";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(104, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 27);
            this.button1.TabIndex = 5;
            this.button1.Text = "Ejercicio 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ejercicio3
            // 
            this.Ejercicio3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejercicio3.Location = new System.Drawing.Point(648, 57);
            this.Ejercicio3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Ejercicio3.Name = "Ejercicio3";
            this.Ejercicio3.Size = new System.Drawing.Size(88, 27);
            this.Ejercicio3.TabIndex = 6;
            this.Ejercicio3.Text = "Ejercicio 3";
            this.Ejercicio3.UseVisualStyleBackColor = true;
            this.Ejercicio3.Click += new System.EventHandler(this.Ejercicio3_Click);
            // 
            // Form_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 424);
            this.Controls.Add(this.Ejercicio3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Grupo);
            this.Controls.Add(this.listado_grupo);
            this.Controls.Add(this.Ejercicio2);
            this.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Ejercicio2;
        private System.Windows.Forms.ListBox listado_grupo;
        private System.Windows.Forms.Label lbl_Grupo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Ejercicio3;
    }
}

