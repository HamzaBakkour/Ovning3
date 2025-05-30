using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonSim.Abstractions;
using PokemonSim.Actions;
using PokemonSim.Helpers;

namespace PokemonSim;

internal class ElectricPokemon : Pokemon
{
    public ElectricPokemon(string name, int level, List<IAttack> attacks, IUI ui)
            : base(name, level, ElementType.Electric, attacks, ui)
    {
    }
}


internal class Pikachu : ElectricPokemon, IEvolvable
{

    public Pikachu(int level, List<IAttack> attacks, IUI ui)
            : base("Pikachu", level, attacks, ui)
    {
    }

    public void Evolve()
    {
        string oldName = Name;
        Name += Util.GenerateRanomChars(1);
        Level += 10;
        _ui.Print($"{oldName} is evolving... Now it's {Name}! Level {Level}!");


    }

}