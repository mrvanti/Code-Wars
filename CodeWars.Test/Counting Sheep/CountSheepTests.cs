namespace CodeWars.Test;

[TestFixture]
public class CountSheepsTests
{

    [Test]
    public void CountSheep_Mixed_Data()
    {
        var sheeps = new bool[] { true, false, true };

        Assert.AreEqual(2, CountingSheep.CountSheep(sheeps));
    }

    [Test]
    public void CountSheep_Only_True()
    {
        var sheeps = new bool[] { true, true, true, true, true };

        Assert.AreEqual(5, CountingSheep.CountSheep(sheeps));
    }

    [Test]
    public void CountSheep_Only_False()
    {
        var sheeps = new bool[] { false, false };

        Assert.AreEqual(0, CountingSheep.CountSheep(sheeps));
    }
    [Test]
    public void CountSheep_Instructions_Example()
    {
        Assert.AreEqual(17, CountingSheep.CountSheep(new[]
        {
          true, true, true, false,
          true, true, true, true,
          true, false, true, false,
          true, false, false, true,
          true, true, true, true,
          false, false, true, true
      }));
    }
}