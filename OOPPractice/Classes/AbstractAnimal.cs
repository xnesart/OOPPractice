namespace OOPPractice.Classes;

public abstract class AbstractAnimal
{
    public string Name { get; protected set; }

    public bool IsSatisfied { get; protected set; }
    
    public int SatisfiedInPercent { get; set; }

    public bool IsPredator { get; protected set; }

    public int Square { get; protected set; }

    public string Type { get; protected set; }

    public string Biome { get; protected set; }

    public string Sound { get; protected set; }

    public string Food { get; protected set; }

    public string Possibility { get; protected set; }
    
    public int FoodBowlInPercent { get; set; }
    
    public abstract void GetEat(string food);
    protected abstract void Eating(string food);
    public abstract void DoSound();
    public abstract void Play();
    public abstract void PlayWithRelatives(string relative);
}