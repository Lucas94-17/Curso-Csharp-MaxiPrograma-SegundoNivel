using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormPractica
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string texto = "Hola " + Nombre.Text + " estas registrado , tu contraseña es : " + Contrasenia.Text;
            string nombre = Nombre.Text;
            string contraseña = Contrasenia.Text;
            //MessageBox.Show(texto);
            Form2 m = new Form2(nombre, contraseña);
            m.Visible = true;

        }
    }
}
