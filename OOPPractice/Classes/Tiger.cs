namespace OOPPractice.Classes;

public class Tiger : Animal
{
    public string Name { get; private set; }
    
    public bool IsSatisfied { get; private set; }
    
    public string Type
    {
        get;
        protected set;
    }

    public string Biome
    {
        get;
        protected set;
    }
    
    public string Square
    {
        get;
        protected set;
    }
    
    public string Sound
    {
        get;
        protected set;
    }

    public Tiger(string name, string biome, string type, string square)
    {
        Name = name;
        Biome = biome;
        Type = type;
        Square = square;
        Sound = "рррр";
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