namespace CodeWars.Test;

[TestFixture]
public class Char_Code_CalculationTests
{
    [Test]
    public void Test1()
    {
        Assert.AreEqual(0, Char_Code_Calculation.Calc(""));
    }
    [Test]
    public void Test2()
    {
        Assert.AreEqual(6, Char_Code_Calculation.Calc("abc"));
    }
    [Test]
    public void Test3()
    {
        Assert.AreEqual(6, Char_Code_Calculation.Calc("ABC"));
    }
    [Test]
    public void Test4()
    {
        Assert.AreEqual(6, Char_Code_Calculation.Calc("abcdef"));
    }
    [Test]
    public void Test5()
    {
        Assert.AreEqual(6, Char_Code_Calculation.Calc("ifkhchlhfd"));
    }
    [Test]
    public void Test6()
    {
        Assert.AreEqual(6, Char_Code_Calculation.Calc("jfmgklf8hglbe"));
    }
    [Test]
    public void Test7()
    {
        Assert.AreEqual(12, Char_Code_Calculation.Calc("jaam"));
    }
    [Test]
    public void Test8()
    {
        Assert.AreEqual(18, Char_Code_Calculation.Calc("AFHJD"));
    }
    [Test]
    public void Test9()
    {
        Assert.AreEqual(18, Char_Code_Calculation.Calc("CodeWars"));
    }
    [Test]
    public void Test10()
    {
        Assert.AreEqual(24, Char_Code_Calculation.Calc("FVJFVDF"));
    }
    [Test]
    public void Test11()
    {
        Assert.AreEqual(24, Char_Code_Calculation.Calc("AOUCUAOF"));
    }
    [Test]
    public void Test12()
    {
     
       Assert.AreEqual(30, Char_Code_Calculation.Calc("aaaaaddddr"));
    }
    [Test]
    public void Test13()
    {
        Assert.AreEqual(36, Char_Code_Calculation.Calc("XLdNDcAbUkMnkV"));
    }
    [Test]
    public void Test14()
    {
        Assert.AreEqual(42, Char_Code_Calculation.Calc("cSuLifxDQkOiypJsxOJSE"));
    }
    [Test]
    public void Test15()
    {
        Assert.AreEqual(48, Char_Code_Calculation.Calc("ZHAUnSGoIbgPSezhjePIbHFrHUOv"));
    }
    [Test]
    public void Test16()
    {
        Assert.AreEqual(54, Char_Code_Calculation.Calc("VFhSMbZETZVHxYiiYsBMrWuecDN"));
    }
    [Test]
    public void Test17()
    {
        Assert.AreEqual(60, Char_Code_Calculation.Calc("sphPoGbicTCLbiuUcwFMEGaFmy"));
    }
    [Test]
    public void Test18()
    {
        Assert.AreEqual(72, Char_Code_Calculation.Calc("oXoQKiCflHIHFyGizCYCuaHhX"));
    }
    [Test]
    public void Test19()
    {
        Assert.AreEqual(84, Char_Code_Calculation.Calc("sUuPmNnnJOOCAGOuyzmcHQGJhXHYgZLY"));
    }
}