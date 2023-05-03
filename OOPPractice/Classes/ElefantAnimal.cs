namespace OOPPractice.Classes;

public class ElefantAnimal : AbstractAnimal
{
    public ElefantAnimal(string name)
    {
        Name = name;
        Biome = "пустыня";
        Type = "слон";
        Square = "20 метров^2";
        IsSatisfied = false;
        Sound = "уууу";
        IsPredator = false;
        Food = "растения или фрукты";
        Possibility = "умеет дружить";
    }

    protected override void Eating(string food)
    {
        Random rnd = new Random();
        SatisfiedInPercent = rnd.Next(1, 100);
        if (SatisfiedInPercent >= 30)
        {
            Console.WriteLine($"{Name} поел(а)");
            IsSatisfied = true;
        }
        else
        {
            IsSatisfied = false;
            Console.WriteLine($"{Name}: Покорми меня ещё, я сыт на {SatisfiedInPercent}%");
        }
    }

    public override void DoSound()
    {
        Console.WriteLine($"{Name} издал {Sound}");
    }

    public override void GetEat(string food)
    {
        if (food == "мясо" || food == "рыба" || food == "рыба и мясо" || food == "мясо и рыба")
        {
            Console.WriteLine($"{Name} не стал(а) есть эту еду");
            IsSatisfied = false;
        }
        else if (food == "фрукты")
        {
            Eating(food);
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