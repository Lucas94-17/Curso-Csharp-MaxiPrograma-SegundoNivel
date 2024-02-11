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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(string nombre , string contraseña)
        {
            InitializeComponent();
            label2.Text = "Este es mi nombre : " + nombre + " y esta es mi contraseña :" + contraseña;
        }


    }
}
