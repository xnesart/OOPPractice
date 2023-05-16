namespace OOPPractice.Classes;

public class ElefantAnimal : AbstractAnimal, IWalker
{
    public ElefantAnimal(string name)
    {
        Name = name;
        Biome = "пустыня";
        Type = "слон";
        Square = 20;
        IsSatisfied = false;
        Sound = "уууу";
        IsPredator = false;
        Food = "растения или фрукты";
        Possibility = "умеет дружить";
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