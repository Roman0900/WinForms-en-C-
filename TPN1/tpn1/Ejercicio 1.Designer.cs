
namespace tpn1
{
    partial class Ejercicio_1
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
            this.lblingresenombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lbListaIzquierda = new System.Windows.Forms.ListBox();
            this.btnflecha = new System.Windows.Forms.Button();
            this.btndobleflecha = new System.Windows.Forms.Button();
            this.lbListaDerecha = new System.Windows.Forms.ListBox();
            this.return_inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblingresenombre
            // 
            this.lblingresenombre.AutoSize = true;
            this.lblingresenombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblingresenombre.Location = new System.Drawing.Point(63, 73);
            this.lblingresenombre.Name = "lblingresenombre";
            this.lblingresenombre.Size = new System.Drawing.Size(150, 19);
            this.lblingresenombre.TabIndex = 1;
            this.lblingresenombre.Text = "Ingrese Un Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(266, 62);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 31);
            this.txtNombre.TabIndex = 8;
            // 
            // btnagregar
            // 
            this.btnagregar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.Location = new System.Drawing.Point(597, 63);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(153, 30);
            this.btnagregar.TabIndex = 9;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lbListaIzquierda
            // 
            this.lbListaIzquierda.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaIzquierda.FormattingEnabled = true;
            this.lbListaIzquierda.ItemHeight = 15;
            this.lbListaIzquierda.Location = new System.Drawing.Point(67, 145);
            this.lbListaIzquierda.Name = "lbListaIzquierda";
            this.lbListaIzquierda.Size = new System.Drawing.Size(202, 199);
            this.lbListaIzquierda.TabIndex = 10;
            // 
            // btnflecha
            // 
            this.btnflecha.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnflecha.Location = new System.Drawing.Point(362, 145);
            this.btnflecha.Name = "btnflecha";
            this.btnflecha.Size = new System.Drawing.Size(75, 40);
            this.btnflecha.TabIndex = 11;
            this.btnflecha.Text = ">";
            this.btnflecha.UseVisualStyleBackColor = true;
            this.btnflecha.Click += new System.EventHandler(this.btnflecha_Click);
            // 
            // btndobleflecha
            // 
            this.btndobleflecha.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndobleflecha.Location = new System.Drawing.Point(362, 297);
            this.btndobleflecha.Name = "btndobleflecha";
            this.btndobleflecha.Size = new System.Drawing.Size(75, 43);
            this.btndobleflecha.TabIndex = 12;
            this.btndobleflecha.Text = ">>";
            this.btndobleflecha.UseVisualStyleBackColor = true;
            this.btndobleflecha.Click += new System.EventHandler(this.btndobleflecha_Click);
            // 
            // lbListaDerecha
            // 
            this.lbListaDerecha.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListaDerecha.FormattingEnabled = true;
            this.lbListaDerecha.ItemHeight = 15;
            this.lbListaDerecha.Location = new System.Drawing.Point(548, 145);
            this.lbListaDerecha.Name = "lbListaDerecha";
            this.lbListaDerecha.Size = new System.Drawing.Size(202, 199);
            this.lbListaDerecha.TabIndex = 13;
            // 
            // return_inicio
            // 
            this.return_inicio.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_inicio.Location = new System.Drawing.Point(338, 397);
            this.return_inicio.Name = "return_inicio";
            this.return_inicio.Size = new System.Drawing.Size(124, 23);
            this.return_inicio.TabIndex = 14;
            this.return_inicio.Text = "Volver Inicio";
            this.return_inicio.UseVisualStyleBackColor = true;
            this.return_inicio.Click += new System.EventHandler(this.return_inicio_Click);
            // 
            // Ejercicio_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.return_inicio);
            this.Controls.Add(this.lbListaDerecha);
            this.Controls.Add(this.btndobleflecha);
            this.Controls.Add(this.btnflecha);
            this.Controls.Add(this.lbListaIzquierda);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblingresenombre);
            this.Name = "Ejercicio_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblingresenombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ListBox lbListaIzquierda;
        private System.Windows.Forms.Button btnflecha;
        private System.Windows.Forms.Button btndobleflecha;
        private System.Windows.Forms.ListBox lbListaDerecha;
        private System.Windows.Forms.Button return_inicio;
    }
}