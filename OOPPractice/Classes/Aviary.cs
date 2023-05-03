namespace OOPPractice.Classes;

public class Aviary
{
    public string Name { get; set; }
    public string Biome { get; set; }
    public string Square { get; protected set; }
    public bool IsPredator { get; protected set; }
    public List<AbstractAnimal> Animals { get; set; }

    public Aviary(string name, string biome, string square, bool isPredator)
    {
        Name = name;
        Biome = biome;
        Square = square;
        IsPredator = isPredator;
        Animals = new List<AbstractAnimal>();
    }

    public void ShowAnimals()
    {
        Console.WriteLine("Список животных в вольере:");
        for (int i = 0; i < Animals.Count; i++)
        {
            Console.WriteLine($"{Animals[i].Type}" + $" {Animals[i].Name}");
        }
        if (Animals.Count == 0)
        {
            Console.WriteLine("Вольер пуст"); 
        }
        Console.WriteLine();
    }

    public void AddAnimalInAviary(AbstractAnimal animal)
    {
        if (animal.IsPredator == IsPredator)
        {
            if (animal.Biome == Biome)
            {
                Animals.Add(animal);
            }
            else
            {
                Console.WriteLine($"{animal.Type}, {animal.Name}: подселить животное не удалось");
            }
        }
        else
        {
            Console.WriteLine($"{animal.Type}, {animal.Name}: подселить животное не удалось");
        }

    }

    public void RemoveAnimalInAviary(string name, string type)
    {
        for (int i = 0; i < Animals.Count; i++)
        {
            if (Animals[i].Type == type)
            {
                if (Animals[i].Name == name)
                {
                    Animals.Remove(Animals[i]);

                }
                else
                {
                    Console.WriteLine("в этом вольере животное не найдено");
                }
            }
        }
    }

    public void CheckAnimalSatisfied()
    {
        for (int i = 0; i < Animals.Count; i++)
        {
            Console.WriteLine($"животное тип {Animals[i].Type}, имя:{Animals[i].Name}, не голодное: {Animals[i].IsSatisfied}");
            if (Animals[i].IsSatisfied == false)
            {
                Console.WriteLine($"{Animals[i].Name}: я голодный(ая), мне нужно:{Animals[i].Food}");
            }
        }
    }
    public void AnimalsFeedInAviary(string food)
    {
        for (int i = 0; i < Animals.Count; i++)
        {
            Animals[i].GetEat(food);
        }
    }

    public void AnimalsDoSound()
    {
        for (int i = 0; i < Animals.Count; i++)
        {
            Animals[i].DoSound();
        }
    }

    // public List<AbstractAnimal> RemoveAnimalInAviary(string name)
    // {
    //     for (int i = 0; i < Animals.Count; i++)
    //     {
    //         if (Animals[i].Name == name)
    //         {
    //             Animals.RemoveAt(i);
    //             return Animals;
    //         }
    //     }
    //     foreach (var animal in Animals)
    //     {
    //      
    //     }
    //
    // }

    // public override string ToString()
    // {
    //     return string.Format("Название:{0} \nВид:{1}", Name);
    // }
}