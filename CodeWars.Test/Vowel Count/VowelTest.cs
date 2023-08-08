namespace CodeWars.Test;

[TestFixture]
public class VowelTest
    {

    [TestCase("abracadabra", 5)]
    public void TestCase1(string word, int count)
    {
        Assert.AreEqual(count, Vowel_count.GetVowelCount(word), "Nope!");
    }
}

