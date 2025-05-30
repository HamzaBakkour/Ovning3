using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using PokemonSim.Helpers;

namespace PokemonSim.Actions;

public interface IAttack
{

    string Name { get; }
    public ElementType Type { get; }
    int BasePower { get; set; }
    string Use(int level);

}

public class Attack : IAttack
{
    private string _name;
    private int _basePower;
    private static bool IsValidLevel(int level) => level < 0;

    public string Name
    {
        get => _name;
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Name can not be empty or white space");
            }
            _name = value;
        }
    }

    public ElementType Type { get; }
    public int BasePower
    {
        get => _basePower;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Base Power can not be negative.");
            }
            _basePower = value;

        }
    }

    public Attack(string name, ElementType type, int basePower)
    {
        this.Name = name;
        this.Type = type;
        this.BasePower = basePower;
    }

    public string Use(int level)
    {
        if (IsValidLevel(level)) throw new ArgumentException("Level can not be negative.");
        return $"{Name} hits with total power {BasePower + level}";
    }

}
