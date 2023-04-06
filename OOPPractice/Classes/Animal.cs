namespace OOPPractice.Classes;

public abstract class Animal
{
    public abstract string Name { get; protected set; }

    public abstract bool IsSatisfied { get; protected set; }

    public abstract bool IsPredator { get; protected set; }

    public abstract string Square { get; protected set; }

    public abstract string Type { get; protected set; }

    public abstract string Biome { get; protected set; }

    public Animal()
    {
    }
    public abstract void GetEat(string food);
    public abstract void DoSound();
    public abstract void Play();
}



