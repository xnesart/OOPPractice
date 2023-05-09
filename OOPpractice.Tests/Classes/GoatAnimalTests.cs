using OOPPractice.Classes;

namespace OOPpractice.Tests.Classes;

public class GoatAnimalTests
{
    [TestCase(true,"фрукты")]
    [TestCase(false,"мясо")]
    public void GetEatTests(bool expected, string food)
    {
        GoatAnimal goatAnimal = new GoatAnimal("Симба");
        goatAnimal.GetEat(food);
        bool actual = goatAnimal.IsSatisfied;
        Assert.AreEqual(expected,actual);
    }
}