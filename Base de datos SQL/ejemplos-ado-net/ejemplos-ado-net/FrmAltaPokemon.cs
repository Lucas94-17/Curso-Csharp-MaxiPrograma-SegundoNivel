using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocios;
using System.Configuration;

namespace ejemplos_ado_net
{
    public partial class FrmAltaPokemon : Form
    {
        private Pokemon pokemon = null;
        private OpenFileDialog archivo = null;
        public FrmAltaPokemon()
        {
            InitializeComponent();
        }
        public FrmAltaPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            this.pokemon = pokemon;
            Text = "Modificar Pokemon";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Pokemon poke = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();

            try
            {
                if (pokemon == null)
                    pokemon = new Pokemon();
                pokemon.Numero = int.Parse(txtnumero.Text);
                pokemon.Nombre = txtnombre.Text;
                pokemon.Descripcion = txtdescripcion.Text;
                pokemon.UrlImagen = txtboxUrlImagen.Text;
                pokemon.Tipo = (Elemento)cboTipo.SelectedItem;
                pokemon.Debilidad = (Elemento)cboDebilidad.SelectedItem;

                

                if (pokemon.Id != 0)
                {
                    negocio.modificar(pokemon);
                    MessageBox.Show("Modificado exitosamente ! ");
                }
                else
                {
                    negocio.agregar(pokemon);
                    MessageBox.Show("Agregado exitosamente ! ");
                }
                // Guardo la imagen si la levanto localmente :
                if (archivo != null && !(txtboxUrlImagen.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"]);
                }
                

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAltaPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                cboTipo.DataSource = elementoNegocio.listar();
                cboTipo.ValueMember = "Id";
                cboTipo.DisplayMember = "Descripcion";
                cboDebilidad.DataSource = elementoNegocio.listar();
                cboDebilidad.ValueMember = "Id";
                cboDebilidad.DisplayMember = "Descripcion";


                if (pokemon != null)
                {
                    txtnumero.Text = pokemon.Numero.ToString();
                    txtnombre.Text = pokemon.Nombre;
                    txtdescripcion.Text = pokemon.Descripcion;
                    txtboxUrlImagen.Text = pokemon.UrlImagen;
                    cargarImagen(pokemon.UrlImagen);
                    cboTipo.SelectedValue = pokemon.Tipo.Id;
                    cboDebilidad.SelectedValue = pokemon.Debilidad.Id;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAltaPokemon_Leave(object sender, EventArgs e)
        {
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                cboTipo.DataSource = elementoNegocio.listar();
                cboDebilidad.DataSource = elementoNegocio.listar();                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void txtboxUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtboxUrlImagen.Text);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbPokemon.Load(imagen);
            }
            catch (Exception )
            {

                pbPokemon.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQr64U1qrn_mnXFwQoOmiuJs1zp0aLvApc1WmtDk-_IywS0eg7pzlSCsqDNbUzJuPSRupo&usqp=CAU");
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            //Esto abre una ventana de dialogo y te permite subir un archivo
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg |*.jpg | png |*.png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtboxUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);

                //Guardo la imagen
                //File.Copy(archivo.FileName, ConfigurationManager.AppSettings["images-folder"] + archivo.SafeFileName);
            }
        }

        private void cboDebilidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pbPokemon_Click(object sender, EventArgs e)
        {

        }

        private void txtboxUrlImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
