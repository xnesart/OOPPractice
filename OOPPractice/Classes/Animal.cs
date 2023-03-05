namespace OOPPractice.Classes;

public class Animal
{

    
    public string _type;
    public string _biome;
    public int _square;
    public string _eat;
    public bool _isPredator;
    public string _sound;
    public string _name;
    public void GetEat(string food)
    {
        Console.WriteLine($"{_name} поел {food}");
    }
    public void DoSound(string sound)
    {
        Console.WriteLine($"{_name} издал {sound}");
    }

    public void Play()
    {
        Console.WriteLine($"{_name} поиграл");
    }
}

