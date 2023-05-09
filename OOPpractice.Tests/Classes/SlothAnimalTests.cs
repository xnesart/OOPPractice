using OOPPractice.Classes;

namespace OOPpractice.Tests.Classes;

public class SlothAnimalTests
{
    [TestCase(true,"фрукты")]
    [TestCase(true,"растения")]
    public void GetEatTests(bool expected, string food)
    {
        SlothAnimal slothAnimal = new SlothAnimal("Симба");
        slothAnimal.GetEat(food);
        bool actual = slothAnimal.IsSatisfied;
        Assert.AreEqual(expected,actual);
    }
}