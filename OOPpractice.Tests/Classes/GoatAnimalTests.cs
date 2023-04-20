using OOPPractice.Classes;

namespace OOPpractice.Tests.Classes;

public class GoatAnimalTests
{
    [TestCase(true,"фрукты")]
    [TestCase(true,"растения")]
    [TestCase(false,"мясо")]
    [TestCase(false,"мясо и рыба")]
    [TestCase(false,"рыба и мясо")]
    public void GetEatTests(bool expected, string food)
    {
        GoatAnimal goatAnimal = new GoatAnimal("Симба");
        goatAnimal.GetEat(food);
        bool actual = goatAnimal.IsSatisfied;
        Assert.AreEqual(expected,actual);
    }
}