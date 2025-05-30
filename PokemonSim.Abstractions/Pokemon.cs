using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonSim.Helpers;
using PokemonSim.Actions;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace PokemonSim.Abstractions;

public abstract class Pokemon
{
    private string _name;
    private int _level;
    protected IUI _ui;
    protected const int _levelIncreasement = 10;
    private static readonly Random _random = new Random();


    public string Name { get => _name;
        protected set {
            if (value.Length < 2 || value.Length > 15 || string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name must be between 2-15 characters");
            _name = value;
        } }
    public int Level { get => _level;
        protected set {
            if (value < 1)
                throw new ArgumentException("Level must be >= 1");
            _level = value;
        } }
    public readonly ElementType Type;
    public List<IAttack> Attacks { get; private set; }

    public void RanodmAttack()
    {
        if (Attacks.Count == 0) _ui.Print($"{Name} Does not have attacks!");
        _ui.Print(Attacks[_random.Next(0, Attacks.Count)].Use(Level));
    }


    public void Attack()
    {
        _ui.Print();
        _ui.Print($"Pokemon {Name} is level {Level} and can"
            + " perform the following attacks");
        for (int i = 0; i < Attacks.Count; i++)
        {
            _ui.Print($"{i + 1}> {Attacks[i].Name}");
        }
        _ui.Print("Enter attack number: ");
        string choice = _ui.GetInput();
        if (uint.TryParse(choice, out uint index) && index <= Attacks.Count)
             _ui.Print(Attacks[((int)index - 1)].Use(Level));
        else
            _ui.Print($"{choice} is unvalid choice");
    }

    public Pokemon(string name, int level, ElementType type, List<IAttack> attacks, IUI ui) {
        this.Name = name;
        this.Level = level;
        this.Type = type;
        this.Attacks = attacks ?? throw new ArgumentNullException(nameof(attacks)); ;
        this._ui = ui;
    }
    
    public void RaiseLevel() {
        Level++;
        _ui.Print($"{Name} leveled up to {Level}");
    }

}
