using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonSim.Abstractions;
using PokemonSim.UI;


namespace PokemonSim.UI;

internal class ConsoleUI: IUI
{
    public void Print(string message) {
        Console.WriteLine(message);
    }

    public void Print()
    {
        Console.WriteLine();
    }

    public string GetInput() {
        return Console.ReadLine() ?? string.Empty;
    }

}
