namespace OOPPractice.Classes;

public class PenguinAnimal : AbstractAnimal
{
    public PenguinAnimal(string name)
    {
        Name = name;
        Biome = "ледник";
        Type = "пингвин";
        Square = 20;
        IsSatisfied = false;
        Sound = "кря-кря";
        IsPredator = true;
        Food = "мясо или рыба";
        Possibility = "умеет различать слова, состоящие из 2х-3х слогов";
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