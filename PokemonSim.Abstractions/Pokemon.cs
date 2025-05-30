using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonSim.Helpers;
using PokemonSim.Actions;
using System.Xml.Linq;

namespace PokemonSim.Abstractions;

public abstract class Pokemon
{
    private string _name;
    private int _level;
    protected IUI _ui;
    protected const int _levelIncreasement = 10;


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

    public abstract string Attack();

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
