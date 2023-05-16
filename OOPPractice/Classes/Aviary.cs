using OOPPractice.Interfaces;

namespace OOPPractice.Classes;

public class Aviary
{
    public string Name { get; set; }
    public string Biome { get; set; }
    public int Square { get; protected set; }
    public bool IsPredator { get; protected set; }
    public List<AbstractAnimal> Animals { get; set; }

    public Aviary(string name, string biome, int square, bool isPredator)
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
        int freeSquare = Square;
        //проверка на хищника, если животное хищник, и вольер для хищников,
        //а так же биом соответствует, то добавляем
        if (animal.IsPredator == IsPredator && IsPredator == true && animal.Biome == Biome)
        {
            if (Animals.Count > 0)
            {
                if (Animals[0].Type != animal.Type)
                {
                    Console.WriteLine($"{animal.Type}, {animal.Name}: подселить животное не удалось");
                }
                else
                {
                    if (freeSquare >= animal.Square)
                    {
                        Animals.Add(animal);
                        Square -= animal.Square;
                        Console.WriteLine($"{animal.Type}, {animal.Name}: животное добавлено в вольер");
                    }
                    else
                    {
                        Console.WriteLine($"нет свободного места для животного {animal.Type}, {animal.Name}");
                    }
                }
            }
            else
            {
                if (freeSquare >= animal.Square)
                {
                    Animals.Add(animal);
                    Square -= animal.Square;
                    Console.WriteLine($"{animal.Type}, {animal.Name}: животное добавлено в вольер");
                }
                else
                {
                    Console.WriteLine($"нет свободного места для животного {animal.Type}, {animal.Name}");
                }
            }
        }
        //если животное травоядное и вольер совпадает с его средой обитания, добавляем 
        else if (animal.Biome == this.Biome && animal.IsPredator == false)
        {
            if (freeSquare >= animal.Square)
            {
                Animals.Add(animal);
                Square -= animal.Square;
                Console.WriteLine($"{animal.Type}, {animal.Name}: животное добавлено в вольер");
            }
            else
            {
                Console.WriteLine($"нет свободного места для животного {animal.Type}, {animal.Name}");
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
                    Square += Animals[i].Square;
                    Animals.Remove(Animals[i]);
                    break;
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
            if (Animals[i].FoodBowlInPercent < 30)
            {
                Console.WriteLine("нужно наполнить миску!");
            }
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
    public void ShowFreeSquare()
    {
        Console.WriteLine($"Свободная площадь вольера = {Square}");
    }
    private void FillBowlWithFood()
    {
        for (int i = 0; i < Animals.Count; i++)
        {
            Animals[i].FoodBowlInPercent = 100;
        }
    }

    public void DoAction(string name, string action)
    {
        for (int i = 0; i < Animals.Count; i++)
        {
            if (Animals[i].Name == name)
            {
                Animals[i].DoSpecialAction(action);  
            }
        }
    }
}