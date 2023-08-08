namespace CodeWars.Test;

[TestFixture]
public class SqureAreaTests
{
    private static double[][] testCases = new double[][]
    {
      new double[] {2, 1.62},
      new double[] {0, 0},
      new double[] {14.05, 80},
    };

    [Test, TestCaseSource("testCases")]
    public void SampleTest(double A, double expected)
    {
        Assert.AreEqual(expected, Area_of_a_Square.SquareArea(A));
    }
}
