namespace OOPPractice.Classes;

public class GoatAnimal : AbstractAnimal
{
    public GoatAnimal(string name)
    {
        Name = name;
        Biome = "поля";
        Type = "коза";
        Square = "20 метров^2";
        IsSatisfied = false;
        Sound = "мееее";
        IsPredator = false;
        Possibility = "умеет предупреждать сородичей об опасности, меняя тон крика";
    }

    public override void GetEat(string food)
    {
        if (food == "мясо" || food == "рыба" || food == "рыба и мясо" || food == "мясо и рыба")
        {
            Console.WriteLine($"{Name} не стал есть эту еду");
            IsSatisfied = false;
        }
        else if (food == "фрукты" || food == "растения")
        {
            Console.WriteLine($"{Name} поела");
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
        Console.WriteLine($"{Name} издала {Sound}");
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