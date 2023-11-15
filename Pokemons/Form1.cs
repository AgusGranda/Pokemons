using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace Pokemons
{
    public partial class frmPokemons : Form
    {

        List<Pokemon> pokemons;

        public frmPokemons()
        {
            InitializeComponent();
        }

        private void frmPokemons_Load(object sender, EventArgs e)
        {

            PokemonNegocio pokemonNegocio = new PokemonNegocio();

            pokemons = pokemonNegocio.listar();
            dgvPokemons.DataSource = pokemons;
            dgvPokemons.Columns["UrlImagen"].Visible = false;

            cambiarImagen(pokemons[0].UrlImagen);


        }

        private void dgvPokemons_SelectionChanged(object sender, EventArgs e)
        {
            Pokemon selected = (Pokemon)dgvPokemons.CurrentRow.DataBoundItem;

            cambiarImagen(selected.UrlImagen);

        }


        public void cambiarImagen(string imagen)
        {
            try
            {
                pbxPokemons.Load(imagen);
            }
            catch(Exception ex)
            {
                pbxPokemons.Load("https://t3.ftcdn.net/jpg/02/48/42/64/360_F_248426448_NVKLywWqArG2ADUxDq6QprtIzsF82dMF.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
        }
    }
}
