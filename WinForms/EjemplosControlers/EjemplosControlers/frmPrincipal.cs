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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void perfilPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Application.OpenForms//Dentro de esta coleccion de formularios van a estar todos los formularios q esten abiertos en ese momento ( EN MEMORIA )
            foreach (var item  in Application.OpenForms)
            {
                if (item.GetType() == typeof(Form1))
                {
                    MessageBox.Show("Ya existe esta ventana abierta ");
                    return;
                }
            }

            Form1 ventana = new Form1(); // Crea un objeto
            ventana.MdiParent = this;
            ventana.Show();

        }

        private void toolStripButtonPerfilPersona_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1(); // Crea un objeto
            ventana.ShowDialog();
        }
    }
}
