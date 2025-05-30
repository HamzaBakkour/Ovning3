namespace PokemonSim.Abstractions;

public interface IUI
{
    string GetInput();
    void Print(string message);
    void Print();

}
