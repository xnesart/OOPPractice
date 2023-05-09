namespace OOPPractice.Classes;

public class SlothAnimal : AbstractAnimal
{
    public SlothAnimal(string name)
    {
        Name = name;
        Biome = "джунгли";
        Type = "ленивец";
        Square = 20;
        IsSatisfied = false;
        Sound = "отстань, я сплю";
        IsPredator = false;
        Food = "растения или фрукты";
        Possibility = "умеет экономить ресурсы и распределять задачи";
        FoodBowlInPercent = 100;
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
        if (food == "мясо" || food == "рыба" || food == "рыба и мясо" || food == "мясо и рыба")
        {
            Console.WriteLine($"{Name} не стал есть эту еду");
            IsSatisfied = false;
        }
        else if (food == "фрукты" || food == "растения")
        {
            if (FoodBowlInPercent > 15)
            {
                Eating(food);
                FoodBowlInPercent -= 15;
            }
            else
            {
                Console.WriteLine("наполни мою миску!");
            }
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