using OOPPractice.Classes;
namespace OOPpractice.Tests.Classes;

public class AviaryTests
{
    [TestCase(true,"фрукты")]
    [TestCase(false,"мясо")]
    [TestCase(false,"мясо и рыба")]
    [TestCase(false,"рыба и мясо")]
    public void AnimalsFeedInAviaryTests(bool expected, string food)
    {
        Aviary aviary = new Aviary("слоновий", "пустыня", 100, false);
        aviary.AddAnimalInAviary(new ElefantAnimal("Миша"));
        aviary.AnimalsFeedInAviary(food);
        bool actual = aviary.Animals[0].IsSatisfied;
        Assert.AreEqual(expected,actual);
    }
    
    [Test]
    public void AddAnimalInAviaryElefantTest()
    {
        Aviary aviary = new Aviary("слоновий", "пустыня", 100, false);
        aviary.AddAnimalInAviary(new ElefantAnimal("Миша"));
        int expected = 1;
        int actual = aviary.Animals.Count;
        Assert.AreEqual(expected,actual);
    }
    [Test]
    public void AddAnimalInAviaryTigerTest()
    {
        Aviary aviary = new Aviary("тигры", "джунгли", 100, true);
        aviary.AddAnimalInAviary(new TigerAnimal("Миша"));
        int expected = 1;
        int actual = aviary.Animals.Count;
        Assert.AreEqual(expected,actual);
    }
    [Test]
    public void AddAnimalInAviaryPredatorAndHerbivoreTest()
    {
        Aviary aviary = new Aviary("тигры", "джунгли", 100, true);
        aviary.AddAnimalInAviary(new TigerAnimal("Миша"));
        aviary.AddAnimalInAviary(new ElefantAnimal("Муму"));
        int expected = 1;
        int actual = aviary.Animals.Count;
        Assert.AreEqual(expected,actual);
    }
    [Test]
    public void RemoveAnimalInAviaryTigerTest()
    {
        Aviary aviary = new Aviary("тигры", "джунгли", 100, true);
        aviary.AddAnimalInAviary(new TigerAnimal("Миша"));
        aviary.RemoveAnimalInAviary("Миша", "тигр");
        Assert.IsEmpty(aviary.Animals);
    }
    [Test]
    public void RemoveAnimalInAviaryTwoTigersTest()
    {
        Aviary aviary = new Aviary("тигры", "джунгли", 100, true);
        aviary.AddAnimalInAviary(new TigerAnimal("Миша"));
        aviary.AddAnimalInAviary(new TigerAnimal("Шарик"));
        aviary.RemoveAnimalInAviary("Миша", "тигр");
        int expected = 1;
        int actual = aviary.Animals.Count;
        Assert.AreEqual(expected,actual);
    }
}