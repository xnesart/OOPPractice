using OOPPractice.Classes;

namespace OOPpractice.Tests.Classes;

public class ElefantTests
{
    [TestCase(true,"фрукты")]
    [TestCase(false,"мясо")]
    public void GetEatTests(bool expected, string food)
    {
        ElefantAnimal elefantAnimal = new ElefantAnimal("Миша");
        elefantAnimal.GetEat(food);
        bool actual = elefantAnimal.IsSatisfied;
        Assert.AreEqual(expected,actual);
    }
}