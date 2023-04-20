namespace OOPPractice.Classes;

public class TigerAnimal : AbstractAnimal
{
    public TigerAnimal(string name)
    {
        Name = name;
        Biome = "тропики";
        Type = "тигр";
        Square = "20 метров^2";
        IsSatisfied = false;
        Sound = "ррр";
        IsPredator = true;
        Possibility = "крайне активен, хорошо слышит, видит и чует";
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

    public override void PlayWithRelatives(string relative)
    {
        Console.WriteLine($"{Name} поиграл с {relative}");
    }
}