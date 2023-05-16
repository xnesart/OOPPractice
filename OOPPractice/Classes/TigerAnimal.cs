namespace OOPPractice.Classes;

public class TigerAnimal : AbstractAnimal, IWalker
{
    public TigerAnimal(string name)
    {
        Name = name;
        Biome = "джунгли";
        Type = "тигр";
        Square = 20;
        IsSatisfied = false;
        Sound = "ррр";
        IsPredator = true;
        Food = "мясо или рыба";
        Possibility = "крайне активен, хорошо слышит, видит и чует";
        FoodBowlInPercent = 100;
        SpecialAction = "может ходить";
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
            Console.WriteLine($"{Name} не стал есть эту еду");
            IsSatisfied = false;
        }
        else if (food == "мясо" || food == "рыба" || food == "рыба и мясо" || food == "мясо и рыба")
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

    public override void Play()
    {
        Console.WriteLine($"{Name} поиграл");
    }

    public override void PlayWithRelatives(string relative)
    {
        Console.WriteLine($"{Name} поиграл с {relative}");
    }
    public void Walk()
    {
        Console.WriteLine($"{Name} походил");
    }
}