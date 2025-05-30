using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonSim.Helpers;

public class Util
{
    private static readonly Random _random = new Random();

    public static string GenerateRanomChars(int num) {
        const string chars = "abcdefghijklmnopqrstuvwxyz";
        if (num >= chars.Length) return "Number of chars must be" +
                $" between 0 and {chars.Length - 1}";
        List<char> randomChars = [];
        for (int i = 0; i < num; i++)
        {
            randomChars.Add(chars[_random.Next(0, chars.Length)]);
        }
        return new string([.. randomChars]);
    }

}
