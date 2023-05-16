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

    public void GetEat(string food)
    {
        if(this is ElefantAnimal || this is GoatAnimal || this is SlothAnimal)
        {
            if (food == "мясо" || food == "рыба" || food == "рыба и мясо" || food == "мясо и рыба")
            {
                Console.WriteLine($"{Name} не стал(а) есть эту еду");
                IsSatisfied = false;
            }
            else if (food == "фрукты" || food == "растения")
            {
                if (FoodBowlInPercent > 30)
                {
                    Eating(food);
                    FoodBowlInPercent -= 30;
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
        else if (this is TigerAnimal || this is PenguinAnimal || this is SeagullAnimal)
        {
            if (food == "фрукты")
            {
                Console.WriteLine($"{Name} не стал есть эту еду");
                IsSatisfied = false;
            }
            else if (food == "мясо" || food == "рыба" || food == "рыба и мясо" || food == "мясо и рыба")
            {
                if (FoodBowlInPercent > 30)
                {
                    Eating(food);
                    FoodBowlInPercent -= 30;
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
        else
        {
            Console.WriteLine("животное отсутсвует, добавьте животное");
        }
    }

    protected void Eating(string food)
    {
        SatisfiedInPercent += 30;
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