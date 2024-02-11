using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocios;

namespace ejemplos_ado_net
{
    public partial class Form2 : Form
    {
        public List<Elemento> Elementos;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ElementoNegocio elemento = new ElementoNegocio();
            Elementos = elemento.listar();
            dataGridView1.DataSource = elemento.listar();

        }

        
    }
}
