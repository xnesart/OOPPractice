using OOPPractice.Classes;

namespace OOPpractice.Tests.Classes;

public class TigerTests
{
    [TestCase(false,"фрукты")]
    [TestCase(true,"мясо")]
    [TestCase(true,"мясо и рыба")]
    [TestCase(true,"рыба и мясо")]
    public void GetEatTests(bool expected, string food)
    {
        Tiger tiger = new Tiger("Миша");
        tiger.GetEat(food);
         bool actual = tiger.IsSatisfied;
         Assert.AreEqual(expected,actual);
    }
}