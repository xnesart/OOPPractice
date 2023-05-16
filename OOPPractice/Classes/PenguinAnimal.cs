namespace OOPPractice.Classes;

public class PenguinAnimal : AbstractAnimal, IWalker
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