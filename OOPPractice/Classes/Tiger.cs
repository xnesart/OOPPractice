namespace OOPPractice.Classes;

public class Tiger : Animal
{
    public bool IsSatisfied { get; private set; }
    public string Name { get; private set; }

    private string _sound = "рррр";

    public string Sound
    {
        get => _sound;
        private set => _sound = value;
    }

    public Tiger(string name)
    {
        Name = name;
        Biome = "тропики";
        Type = "тигр";
        Square = "10 квадратных метров";
    }

    public override void DoSound()
    {
        Console.WriteLine($"{Name} издал {Sound}");
    }

    public override void GetEat(string food)
    {
        if (food == "фрукты")
        {
            Console.WriteLine($"{Name} не стал есть эту еду");
            IsSatisfied = false;
        }
        else if (food == "мясо" || food == "рыба" || food == "рыба и мясо" || food == "мясо и рыба")
        {
            Console.WriteLine($"{Name} поел");
            IsSatisfied = true;
        }
        else
        {
            Console.WriteLine($"{Name} такое не ест");
            IsSatisfied = false;
        }
    }

    public override void Play()
    {
        Console.WriteLine($"{Name} поиграл");
    }
}