namespace CodeWars.Test;

[TestFixture]
public class Sum_of_positivesTests
{

    [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult = 15)]
    [TestCase(new int[] { 1, -2, 3, 4, 5 }, ExpectedResult = 13)]
    [TestCase(new int[] { -1, 2, 3, 4, -5 }, ExpectedResult = 9)]
    [TestCase(new int[] { }, ExpectedResult = 0)]
    [TestCase(new int[] { -1, -2, -3, -4, -5 }, ExpectedResult = 0)]
    public static int ExampleTest(int[] arr)
    {
        return Sum_of_positive.PositiveSum(arr);
    }

}

