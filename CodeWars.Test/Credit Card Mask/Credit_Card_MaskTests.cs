namespace CodeWars.Test;

[TestFixture]
public class Credit_Card_MaskTests
{
    [Test]
    public void ExamplesTests()
    {
        Assert.AreEqual("############5616", Credit_Card_Mask.Maskify("4556364607935616"));
        Assert.AreEqual("1", Credit_Card_Mask.Maskify("1"));
        Assert.AreEqual("#1111", Credit_Card_Mask.Maskify("11111"));
    }
}


