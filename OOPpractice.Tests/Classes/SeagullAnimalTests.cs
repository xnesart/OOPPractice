using OOPPractice.Classes;

namespace OOPpractice.Tests.Classes;

public class SeagullAnimalTests
{
    [TestCase(false,"фрукты")]
    [TestCase(true,"мясо")]
    public void GetEatTests(bool expected, string food)
    {
        SeagullAnimal seagullAnimal = new SeagullAnimal("Симба");
        seagullAnimal.GetEat(food);
        bool actual = seagullAnimal.IsSatisfied;
        Assert.AreEqual(expected,actual);
    }
}