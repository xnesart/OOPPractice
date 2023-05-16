using OOPPractice.Interfaces;

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
    
    public string SpecialAction { get; protected set; }

    public int FoodBowlInPercent { get; set; }
    
    public abstract void GetEat(string food);
    protected abstract void Eating(string food);
    public abstract void DoSound();
    public abstract void Play();
    public abstract void PlayWithRelatives(string relative);

    public void DoSpecialAction(string action)
    {
        if (action == "ходить")
        {
            if (this.Type == "слон" || this.Type == "тигр" || this.Type == "коза" || this.Type == "пингвин" || this.Type == "ленивец")
            {
                ((IWalker)this).Walk();
            }
            else
            {
                Console.WriteLine("это животное не может выполнить данное действие");
            }
        }
        else if (action == "летать")
        {
            if (this.Type == "чайка")
            {
                ((IFlyer)this).Fly();
            }
            else
            {
                Console.WriteLine("это животное не может выполнить данное действие");
            }
        }
        else
        {
            Console.WriteLine("животные могут или ходить или летать, введите ходить или летать");
        }
    }
}