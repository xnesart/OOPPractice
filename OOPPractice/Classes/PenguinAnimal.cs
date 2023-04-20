namespace OOPPractice.Classes;

public class PenguinAnimal : AbstractAnimal
{
    public PenguinAnimal(string name)
    {
        Name = name;
        Biome = "ледник";
        Type = "пингвин";
        Square = "20 метров^2";
        IsSatisfied = false;
        Sound = "кря-кря";
        IsPredator = true;
        Possibility = "умеет различать слова, состоящие из 2х-3х слогов";
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

    public override void DoSound()
    {
        Console.WriteLine($"{Name} издал {Sound}");
    }

    public override void Play()
    {
        Console.WriteLine($"{Name} поиграл");
    }

    public override void PlayWithRelatives(string relative)
    {
        Console.WriteLine($"{Name} поиграл с {relative}");
    }
}