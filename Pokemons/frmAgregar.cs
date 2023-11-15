using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace Pokemons
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
                
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Pokemon poke = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();  

            try
            {
                poke.Numero = int.Parse(tbxNumero.Text);
                poke.Nombre = txbNombre.Text;
                poke.Descripcion = txbDescripcion.Text;

                negocio.agregar(poke);

                MessageBox.Show("Pokemon agregado satisfactoriamente");
                Close();

            }
            catch (Exception ex)
            {

                throw ex;
            }



        }
    }
}
