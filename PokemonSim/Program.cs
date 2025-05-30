namespace PokemonSim;

using PokemonSim.Abstractions;
using PokemonSim.Helpers;
using PokemonSim.UI;
using PokemonSim.Actions;
internal class Program
{

    private static IAttack _flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
    private static IAttack _ember = new Attack("Ember", ElementType.Fire, 6);
    private static IUI _ui = new ConsoleUI();


    static void Main(string[] args)
    {
        IAttack flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
        IAttack ember = new Attack("Ember", ElementType.Fire, 6);
        IUI ui = new ConsoleUI();

        List<Pokemon> pokemons = new  List<Pokemon>
        {
            new Charmander(4, new List<IAttack> { flamethrower }, ui),
            new Squirtle(1, new List<IAttack> { ember }, ui),
            new Squirtle(2, new List<IAttack> { ember }, ui),
            new Pikachu(3, new List<IAttack> { ember, flamethrower }, ui),
            new Pikachu(6, new List<IAttack> { ember, flamethrower }, ui)
        };

        Main main = new Main(pokemons, ui);
        main.Run();
    }
}
