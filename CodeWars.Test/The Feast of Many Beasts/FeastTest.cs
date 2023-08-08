namespace CodeWars.Test;

[TestFixture]
public class FeastTest
{
    [TestCase("great blue heron", "garlic naan")]
    [TestCase("chickadee", "chocolate cake")]
    public void BasicTestsTrue(string beast, string dish)
    {
        Assert.IsTrue(Feast_of_many_beasts.Feast(beast, dish));
    }

    [TestCase("brown bear", "bear claw")]
    public void BasicTestsFalse(string beast, string dish)
    {
        Assert.IsFalse(Feast_of_many_beasts.Feast(beast, dish));
    }
}