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
        Penguin penguin = new Penguin("Симба","тундра","пингвин","10 квадратных метров");
        penguin.GetEat(food);
        bool actual = penguin.IsSatisfied;
        Assert.AreEqual(expected,actual);
    }
}