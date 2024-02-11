namespace EjemplosControlers
{
    partial class Form1
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lwElementos = new System.Windows.Forms.ListView();
            this.lbNombre = new System.Windows.Forms.Label();
            this.FechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.Chocolate = new System.Windows.Forms.CheckBox();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.rbtWizzard = new System.Windows.Forms.RadioButton();
            this.rbtMuggle = new System.Windows.Forms.RadioButton();
            this.rbtSquibs = new System.Windows.Forms.RadioButton();
            this.gbxTipo = new System.Windows.Forms.GroupBox();
            this.lbColor = new System.Windows.Forms.Label();
            this.cboColor = new System.Windows.Forms.ComboBox();
            this.lbNumeroFavorito = new System.Windows.Forms.Label();
            this.numNumeroFav = new System.Windows.Forms.NumericUpDown();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFav)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(237, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(132, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(176, 587);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lwElementos
            // 
            this.lwElementos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwElementos.HideSelection = false;
            this.lwElementos.Location = new System.Drawing.Point(176, 463);
            this.lwElementos.Name = "lwElementos";
            this.lwElementos.Size = new System.Drawing.Size(198, 104);
            this.lwElementos.TabIndex = 7;
            this.lwElementos.UseCompatibleStateImageBehavior = false;
            this.lwElementos.View = System.Windows.Forms.View.Tile;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(173, 110);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(50, 13);
            this.lbNombre.TabIndex = 3;
            this.lbNombre.Text = "Nombre :";
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.AutoSize = true;
            this.FechaNacimiento.Location = new System.Drawing.Point(108, 144);
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.Size = new System.Drawing.Size(115, 13);
            this.FechaNacimiento.TabIndex = 4;
            this.FechaNacimiento.Text = "Fecha de nacimiento : ";
            this.FechaNacimiento.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(237, 144);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(132, 20);
            this.dtpFechaNacimiento.TabIndex = 1;
            // 
            // Chocolate
            // 
            this.Chocolate.AutoSize = true;
            this.Chocolate.Location = new System.Drawing.Point(237, 182);
            this.Chocolate.Name = "Chocolate";
            this.Chocolate.Size = new System.Drawing.Size(138, 17);
            this.Chocolate.TabIndex = 2;
            this.Chocolate.Text = "Te gusta el chocolate ?";
            this.Chocolate.UseVisualStyleBackColor = true;
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LabelTitulo.Location = new System.Drawing.Point(108, 49);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(184, 31);
            this.LabelTitulo.TabIndex = 7;
            this.LabelTitulo.Text = "Perfil Persona";
            // 
            // rbtWizzard
            // 
            this.rbtWizzard.AutoSize = true;
            this.rbtWizzard.Checked = true;
            this.rbtWizzard.Location = new System.Drawing.Point(42, 36);
            this.rbtWizzard.Name = "rbtWizzard";
            this.rbtWizzard.Size = new System.Drawing.Size(58, 17);
            this.rbtWizzard.TabIndex = 8;
            this.rbtWizzard.TabStop = true;
            this.rbtWizzard.Text = "Wizard";
            this.rbtWizzard.UseVisualStyleBackColor = true;
            // 
            // rbtMuggle
            // 
            this.rbtMuggle.AutoSize = true;
            this.rbtMuggle.Location = new System.Drawing.Point(152, 36);
            this.rbtMuggle.Name = "rbtMuggle";
            this.rbtMuggle.Size = new System.Drawing.Size(60, 17);
            this.rbtMuggle.TabIndex = 9;
            this.rbtMuggle.Text = "Muggle";
            this.rbtMuggle.UseVisualStyleBackColor = true;
            // 
            // rbtSquibs
            // 
            this.rbtSquibs.AutoSize = true;
            this.rbtSquibs.Location = new System.Drawing.Point(261, 36);
            this.rbtSquibs.Name = "rbtSquibs";
            this.rbtSquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtSquibs.TabIndex = 10;
            this.rbtSquibs.Text = "Squibs";
            this.rbtSquibs.UseVisualStyleBackColor = true;
            // 
            // gbxTipo
            // 
            this.gbxTipo.Controls.Add(this.rbtMuggle);
            this.gbxTipo.Controls.Add(this.rbtSquibs);
            this.gbxTipo.Controls.Add(this.rbtWizzard);
            this.gbxTipo.Location = new System.Drawing.Point(161, 219);
            this.gbxTipo.Name = "gbxTipo";
            this.gbxTipo.Size = new System.Drawing.Size(396, 84);
            this.gbxTipo.TabIndex = 3;
            this.gbxTipo.TabStop = false;
            this.gbxTipo.Text = "Tipo";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(145, 317);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(78, 13);
            this.lbColor.TabIndex = 12;
            this.lbColor.Text = "Color Favorito :";
            // 
            // cboColor
            // 
            this.cboColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboColor.FormattingEnabled = true;
            this.cboColor.Location = new System.Drawing.Point(237, 314);
            this.cboColor.Name = "cboColor";
            this.cboColor.Size = new System.Drawing.Size(137, 21);
            this.cboColor.TabIndex = 4;
            this.cboColor.SelectedIndexChanged += new System.EventHandler(this.cboColor_SelectedIndexChanged);
            // 
            // lbNumeroFavorito
            // 
            this.lbNumeroFavorito.AutoSize = true;
            this.lbNumeroFavorito.Location = new System.Drawing.Point(132, 369);
            this.lbNumeroFavorito.Name = "lbNumeroFavorito";
            this.lbNumeroFavorito.Size = new System.Drawing.Size(91, 13);
            this.lbNumeroFavorito.TabIndex = 14;
            this.lbNumeroFavorito.Text = "Numero Favorito :";
            // 
            // numNumeroFav
            // 
            this.numNumeroFav.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numNumeroFav.Location = new System.Drawing.Point(237, 369);
            this.numNumeroFav.Name = "numNumeroFav";
            this.numNumeroFav.Size = new System.Drawing.Size(137, 20);
            this.numNumeroFav.TabIndex = 5;
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnVerPerfil.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerPerfil.Location = new System.Drawing.Point(176, 411);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(75, 23);
            this.btnVerPerfil.TabIndex = 6;
            this.btnVerPerfil.Text = "Ver perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(763, 654);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.numNumeroFav);
            this.Controls.Add(this.lbNumeroFavorito);
            this.Controls.Add(this.cboColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.gbxTipo);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.Chocolate);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.FechaNacimiento);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lwElementos);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxTipo.ResumeLayout(false);
            this.gbxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numNumeroFav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView lwElementos;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label FechaNacimiento;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox Chocolate;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.RadioButton rbtWizzard;
        private System.Windows.Forms.RadioButton rbtMuggle;
        private System.Windows.Forms.RadioButton rbtSquibs;
        private System.Windows.Forms.GroupBox gbxTipo;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.ComboBox cboColor;
        private System.Windows.Forms.Label lbNumeroFavorito;
        private System.Windows.Forms.NumericUpDown numNumeroFav;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

