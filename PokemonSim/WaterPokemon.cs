using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonSim.Abstractions;
using PokemonSim.Actions;
using PokemonSim.Helpers;

namespace PokemonSim;

internal class WaterPokemon : Pokemon
{
    public WaterPokemon(string name, int level, List<IAttack> attacks, IUI ui)
        : base(name, level, ElementType.Water, attacks, ui)
    {
    }
}


internal class Squirtle : WaterPokemon, IEvolvable
{
    public Squirtle(int level, List<IAttack> attacks, IUI ui)
        : base("Squirtle", level, attacks, ui)
    {
    }


    public void Evolve()
    {
        string oldName = Name;
        Name += Util.GenerateRanomChars(2);
        Level += 10;
        _ui.Print($"{oldName} is evolving... Now it's {Name}! Level {Level}!");


    }
}