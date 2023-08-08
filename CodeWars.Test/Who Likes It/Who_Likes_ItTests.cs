namespace CodeWars.Test;
[TestFixture]
    public class Who_Likes_ItTests
{
        [Test, Description("It should return correct text")]
        public void SampleTest()
        {
            Assert.AreEqual("no one likes this", Who_Likes_It.Likes(new string[0]));
            Assert.AreEqual("Peter likes this", Who_Likes_It.Likes(new string[] { "Peter" }));
            Assert.AreEqual("Jacob and Alex like this", Who_Likes_It.Likes(new string[] { "Jacob", "Alex" }));
            Assert.AreEqual("Max, John and Mark like this", Who_Likes_It.Likes(new string[] { "Max", "John", "Mark" }));
            Assert.AreEqual("Alex, Jacob and 2 others like this", Who_Likes_It.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));
        }
    }

