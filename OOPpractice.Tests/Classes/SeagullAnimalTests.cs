using OOPPractice.Classes;

namespace OOPpractice.Tests.Classes;

public class SeagullAnimalTests
{
    [TestCase(false,"фрукты")]
    [TestCase(true,"мясо")]
    [TestCase(true,"мясо и рыба")]
    [TestCase(true,"рыба и мясо")]
    public void GetEatTests(bool expected, string food)
    {
        SeagullAnimal seagullAnimal = new SeagullAnimal("Симба");
        seagullAnimal.GetEat(food);
        bool actual = seagullAnimal.IsSatisfied;
        Assert.AreEqual(expected,actual);
    }
}