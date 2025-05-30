using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonSim.Abstractions;
using PokemonSim.Actions;
using PokemonSim.Helpers;

namespace PokemonSim;

internal abstract class ElectricPokemon : Pokemon
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

    public override string Attack()
    {
        if (Attacks.Count == 0) return $"{Name} has not attacks!";
        return Attacks[0].Use(Level);
    }

    //public override string Attack()
    //{
    //    _ui.Print($"Pokemon {Name} is level {Level} and can"
    //        + " perform the following attacks");
    //    for (int i = 0; i < Attacks.Count; i++)
    //    {
    //        _ui.Print($"{i + 1}> {Attacks[i].Name}");
    //    }
    //    _ui.Print("Enter attack number: ");
    //    string choice = _ui.GetInput();
    //    if (uint.TryParse(choice, out uint index) && index <= Attacks.Count)
    //        return Attacks[((int)index - 1)].Use(Level);

    //    return $"{choice} is unvalid choice";
    //}

    public void Evolve()
    {
        string oldName = Name;
        Name += Util.GenerateRanomChars(1);
        Level += 10;
        _ui.Print($"{oldName} is evolving... Now it's {Name}! Level {Level}!");


    }

}