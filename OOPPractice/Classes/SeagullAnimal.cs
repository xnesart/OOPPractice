namespace OOPPractice.Classes;

public class SeagullAnimal : AbstractAnimal
{
    public SeagullAnimal(string name)
    {
        Name = name;
        Biome = "ледник";
        Type = "чайка";
        Square = "20 метров^2";
        IsSatisfied = false;
        Sound = "кар-кар";
        IsPredator = true;
        Food = "мясо или рыба";
        Possibility = "умеет преодолевать сильный ветер, пролетать большие расстояния";
    }

    public override void DoSound()
    {
        Console.WriteLine($"{Name} издал {Sound}");
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
    
    public override void GetEat(string food)
    {
        if (food == "фрукты")
        {
            Console.WriteLine($"{Name} не стала есть эту еду");
            IsSatisfied = false;
        }
        else if (food == "мясо" || food == "рыба" || food == "рыба и мясо" || food == "мясо и рыба")
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