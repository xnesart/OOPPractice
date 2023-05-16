using OOPPractice.Interfaces;

namespace OOPPractice.Classes;

public class SeagullAnimal : AbstractAnimal, IFlyer
{
    public SeagullAnimal(string name)
    {
        Name = name;
        Biome = "ледник";
        Type = "чайка";
        Square = 20;
        IsSatisfied = false;
        Sound = "кар-кар";
        IsPredator = true;
        Food = "мясо или рыба";
        Possibility = "умеет преодолевать сильный ветер, пролетать большие расстояния";
        FoodBowlInPercent = 100;
        SpecialAction = "может летать";
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

    public void Fly()
    {
        Console.WriteLine($"{Name} полетала");
    }
}