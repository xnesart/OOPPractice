using OOPPractice.Interfaces;

namespace OOPPractice.Classes;

public class SlothAnimal : AbstractAnimal, IWalker
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
        SpecialAction = "может ходить";

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
    public void Walk()
    {
        Console.WriteLine($"{Name} походил");
    }
}