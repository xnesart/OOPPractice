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