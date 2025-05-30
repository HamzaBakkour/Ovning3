using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonSim.Abstractions;
using PokemonSim.Actions;
using PokemonSim.Helpers;

namespace PokemonSim;

internal class FirePokemon: Pokemon
{
    public FirePokemon(string name, int level, List<IAttack> attacks, IUI ui)
            :base(name, level, ElementType.Fire, attacks, ui) {
    }
}


internal class Charmander : FirePokemon
{

    public Charmander(int level, List<IAttack> attacks, IUI ui)
            : base("Charmander", level, attacks, ui)
    {
    }

}