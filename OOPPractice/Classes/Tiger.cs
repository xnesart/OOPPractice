namespace OOPPractice.Classes;

public class Tiger : Animal
{
    public override string Name { get; protected set; }

    public override bool IsSatisfied { get; protected set; }
    
    public override bool IsPredator { get; protected set; }

    public override string Type { get; protected set; }

    public override string Biome { get; protected set; }

    public override string Square { get; protected set; }

    public string Sound { get; protected set; }

    public Tiger(string name, string biome, string type, string square)
    {
        Name = name;
        Biome = biome;
        Type = type;
        Square = square;
        Sound = "рррр";
        IsPredator = true;
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