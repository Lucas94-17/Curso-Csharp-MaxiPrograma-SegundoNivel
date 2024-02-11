using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, r;
            try
            {
                
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                r = a / b;
                label1.Text = (" = " + r);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Hubo un error , ingrese unicamente numeros ");
                //throw;
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Hubo un error , no divida por 0");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
