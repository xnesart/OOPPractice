namespace OOPPractice.Classes;

public class Aviary
{
    public string Name { get; set; } 
    public string Biome { get; set; }
    public string Square { get; protected set; }
    public bool IsPredator { get; protected set; }
    public List<object> Animals { get; set; }
    
    public List<object> AviaryList { get; set; }


    public Aviary(string name, string biome, string square, bool isPredator)
    {
        Name = name;
        Biome = biome;
        Square = square;
        IsPredator = isPredator;
        Animals = new List<object>();
    }
    
    public void ShowAnimals()
    {
        foreach (var animal in Animals)
        {
            //Console.WriteLine($"{animal.Name} - {animal.Type}");
        }
        for (int i = 0; i < Animals.Count; i++)
        {
            Console.WriteLine(Animals[i]);
        }
    }

    public void AddAnimalInAviary()
    {
        
    }
    public void AddAnimalInList(object animal)
    {
       
        Animals.Add(animal);
    }

    public override string ToString()
    {
        return string.Format("Название:{0} \nВид:{1}",Name);
    }
  
}