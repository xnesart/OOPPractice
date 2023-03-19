namespace OOPPractice.Classes;

public abstract class Animal
{
    private string _type;

    public string Type
    {
        get => _type;
        protected set => _type = value;
    }

    private string _biome;

    public string Biome
    {
        get => _biome;
        protected set => _biome = value;
    }

    private string _square;

    public string Square
    {
        get => _square;
        protected set => _square = value;
    }

    private string _eat;
    private bool _isPredator;

    public bool IsPredator
    {
        get => _isPredator;
        protected set => _isPredator = value;
    }

    protected string _sound;
    public string Sound;
    private string _name;

    public string Name
    {
        get => _name;
        protected set => _name = value;
    }

    public Animal()
    {
    }

    public Animal(string name, string type)
    {
        Type = type;
        if (Type == "слон")
            Biome = "пустыня";
        else if (Type == "пингвин")
            Biome = "тундра";
        else if (Type == "тигр")
            Biome = "тропики";
        else
            throw new ArgumentException("введите: слон, пингвин или тигр");
    }

    public virtual void GetEat(string food)
    {
    }

    public virtual void DoSound()
    {
    }

    public virtual void Play()
    {
    }
}