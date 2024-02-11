using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemplosControlers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string element = txtNombre.Text;
            lwElementos.Items.Add(element);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            cboColor.Items.Add("Rojo");
            cboColor.Items.Add("Azul");
            cboColor.Items.Add("Verde");
        }

        private void cboColor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerPerfil_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            DateTime fecha = dtpFechaNacimiento.Value;
            string chocolate = Chocolate.Checked == true ? "Le gusta el chocolate" : "Odia el chocolate";
            string tipo;
            if (rbtMuggle.Checked)
            {
                tipo = "Muggle";
            }else if (rbtWizzard.Checked)
            {
                tipo = "Wizzard";
            }
            else
            {
                tipo = "Squibs";
            }

            string ColorFav = cboColor.SelectedItem.ToString();
            string NumeroFav = numNumeroFav.Value.ToString();

            MessageBox.Show(nombre + fecha + chocolate + tipo + ColorFav + NumeroFav);
        }

        
    }
}
