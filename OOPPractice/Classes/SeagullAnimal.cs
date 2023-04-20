namespace OOPPractice.Classes;

public class SeagullAnimal : AbstractAnimal
{
    public SeagullAnimal(string name)
    {
        Name = name;
        Biome = "побережье";
        Type = "чайка";
        Square = "20 метров^2";
        IsSatisfied = false;
        Sound = "кар-кар";
        IsPredator = true;
        Possibility = "умеет преодолевать сильный ветер, пролетать большие расстояния";
    }

    public override void DoSound()
    {
        Console.WriteLine($"{Name} издал {Sound}");
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
            Console.WriteLine($"{Name} поела");
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