namespace OOPPractice.Classes;

public class GoatAnimal : AbstractAnimal, IWalker
{
    public GoatAnimal(string name)
    {
        Name = name;
        Biome = "джунгли";
        Type = "коза";
        Square = 20;
        IsSatisfied = false;
        Sound = "мееее";
        IsPredator = false;
        Food = "растения или фрукты";
        Possibility = "умеет предупреждать сородичей об опасности, меняя тон крика";
        FoodBowlInPercent = 100;
        SpecialAction = "может ходить";
    }
    public override void DoSound()
    {
        Console.WriteLine($"{Name} издала {Sound}");
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