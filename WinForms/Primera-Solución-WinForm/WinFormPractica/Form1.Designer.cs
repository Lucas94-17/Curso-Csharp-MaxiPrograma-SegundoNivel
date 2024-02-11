namespace WinFormPractica
{
    partial class Formulario
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
            this.label1 = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.Contrasenia = new System.Windows.Forms.TextBox();
            this.BotonEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(311, 116);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(100, 20);
            this.Nombre.TabIndex = 1;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(234, 168);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(67, 13);
            this.Contraseña.TabIndex = 2;
            this.Contraseña.Text = "Contraseña :";
            // 
            // Contrasenia
            // 
            this.Contrasenia.Location = new System.Drawing.Point(311, 165);
            this.Contrasenia.Name = "Contrasenia";
            this.Contrasenia.Size = new System.Drawing.Size(100, 20);
            this.Contrasenia.TabIndex = 3;
            // 
            // BotonEnviar
            // 
            this.BotonEnviar.Location = new System.Drawing.Point(311, 242);
            this.BotonEnviar.Name = "BotonEnviar";
            this.BotonEnviar.Size = new System.Drawing.Size(75, 23);
            this.BotonEnviar.TabIndex = 4;
            this.BotonEnviar.Text = "Enviar";
            this.BotonEnviar.UseVisualStyleBackColor = true;
            this.BotonEnviar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BotonEnviar);
            this.Controls.Add(this.Contrasenia);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.label1);
            this.Name = "Formulario";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.TextBox Contrasenia;
        private System.Windows.Forms.Button BotonEnviar;
    }
}

