using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonSim.Abstractions;
using PokemonSim.Actions;


namespace PokemonSim;

internal class Main
{

    private IUI _ui;
    private List<Pokemon>  _pokemons;


    public Main(List<Pokemon> pokemons,IUI ui) {
        this._ui = ui;
        this._pokemons = pokemons;
    }

    public void Run() {

        foreach (var pokemon in _pokemons)
        {
            _ui.Print(pokemon.Attack());
        }

        _ui.Print();

        foreach (var pokemon in _pokemons) {
            if (pokemon is IEvolvable castedToEvolvable)
            {
                castedToEvolvable.Evolve();
            }
            else {
                _ui.Print($"{pokemon.Name} is not evolvable");
            }
        }

        _ui.Print();

        foreach (var pokemon in _pokemons)
        {
            _ui.Print(pokemon.Attack());
        }
    }
}
