namespace OOPPractice.Classes;

public class SlothAnimal : AbstractAnimal
{
    public SlothAnimal(string name)
    {
        Name = name;
        Biome = "джунгли";
        Type = "ленивец";
        Square = "20 метров^2";
        IsSatisfied = false;
        Sound = "отстань, я сплю";
        IsPredator = false;
        Possibility = "умеет экономить ресурсы и распределять задачи";
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
        Console.WriteLine($"{Name} сообщил: {Sound}");
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