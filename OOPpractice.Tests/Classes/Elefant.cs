using OOPPractice.Classes;

namespace OOPpractice.Tests.Classes;

public class ElefantTests
{
    [TestCase(true,"фрукты")]
    [TestCase(false,"мясо")]
    [TestCase(false,"мясо и рыба")]
    [TestCase(false,"рыба и мясо")]
    public void GetEatTests(bool expected, string food)
    {
        Elefant elefant = new Elefant("Миша","пустыня","слон","10 квадратных метров");
        elefant.GetEat(food);
        bool actual = elefant.IsSatisfied;
        Assert.AreEqual(expected,actual);
    }
}