namespace CodeWars.Test;

[TestFixture]
public class Sum_of_SequenceTest
{
    [Test]
    public void BasicTest()
    {
        Assert.AreEqual(12, SumOfSequence.SequenceSum(2, 6, 2));
        Assert.AreEqual(15, SumOfSequence.SequenceSum(1, 5, 1));
        Assert.AreEqual(5, SumOfSequence.SequenceSum(1, 5, 3));
        Assert.AreEqual(45, SumOfSequence.SequenceSum(0, 15, 3));
        Assert.AreEqual(0, SumOfSequence.SequenceSum(16, 15, 3));
        Assert.AreEqual(26, SumOfSequence.SequenceSum(2, 24, 22));
        Assert.AreEqual(2, SumOfSequence.SequenceSum(2, 2, 2));
        Assert.AreEqual(2, SumOfSequence.SequenceSum(2, 2, 1));
        Assert.AreEqual(35, SumOfSequence.SequenceSum(1, 15, 3));
        Assert.AreEqual(0, SumOfSequence.SequenceSum(15, 1, 3));
    }
}