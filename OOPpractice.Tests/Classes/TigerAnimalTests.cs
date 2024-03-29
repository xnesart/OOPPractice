using OOPPractice.Classes;

namespace OOPpractice.Tests.Classes;

public class TigerTests
{
    [TestCase(false,"фрукты")]
    [TestCase(true,"мясо")]
    public void GetEatTests(bool expected, string food)
    {
        TigerAnimal tigerAnimal = new TigerAnimal("Миша");
        tigerAnimal.GetEat(food);
         bool actual = tigerAnimal.IsSatisfied;
         Assert.AreEqual(expected,actual);
    }
}