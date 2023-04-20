using OOPPractice.Classes;

namespace OOPpractice.Tests.Classes;

public class PenguinTests
{
    [TestCase(false,"фрукты")]
    [TestCase(true,"мясо")]
    [TestCase(true,"мясо и рыба")]
    [TestCase(true,"рыба и мясо")]
    public void GetEatTests(bool expected, string food)
    {
        PenguinAnimal penguinAnimal = new PenguinAnimal("Симба");
        penguinAnimal.GetEat(food);
        bool actual = penguinAnimal.IsSatisfied;
        Assert.AreEqual(expected,actual);
    }
}