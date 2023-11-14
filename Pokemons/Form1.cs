using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            pbxPokemons.Load(pokemons[0].UrlImagen);


        }
    }
}
