﻿namespace CodeWars.Test;

[TestFixture]
public class Highest_and_LowestTest
{

    [Test]
    public void Test1()
    {
        Assert.AreEqual("42 -9", Highest_and_Lowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
    }
    [Test]
    public void Test2()
    {
        Assert.AreEqual("3 1", Highest_and_Lowest.HighAndLow("1 2 3"));
    }
}

