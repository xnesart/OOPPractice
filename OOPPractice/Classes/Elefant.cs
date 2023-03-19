namespace OOPPractice.Classes;

public class Elefant : Animal
{
    private bool _isSatisfied;

    public bool IsSatisfied
    {
        get => _isSatisfied;
        private set => _isSatisfied = value;
    }

    public string Name { get; private set; }

    public Elefant(string name)
    {
        Name = name;
        Biome = "пустыня";
        Type = "слон";
        Square = "10 квадратных метров";
        _isSatisfied = false;
    }

    private string _sound = "ауф";

    public string Sound
    {
        get => _sound;
        private set => _sound = value;
    }

    public override void DoSound()
    {
        Console.WriteLine($"{Name} издал {Sound}");
    }

    public override void GetEat(string food)
    {
        if (food == "мясо" || food == "рыба" || food == "рыба и мясо" || food == "мясо и рыба")
        {
            Console.WriteLine($"{Name} не стал есть эту еду");
            _isSatisfied = false;
        }
        else if (food == "фрукты")
        {
            Console.WriteLine($"{Name} поел");
            _isSatisfied = true;
        }
        else
        {
            Console.WriteLine($"{Name} такое не ест");
            _isSatisfied = false;
        }
    }

    public override void Play()
    {
        Console.WriteLine($"{Name} поиграл");
    }
}