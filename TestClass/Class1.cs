using NUnit.Framework;
using NUnitDemo;

[TestFixture]
public class TriangleTests
{
    // Fenil's Lab 
    [Test]
    public void TestValidTriangle()
    {
        Assert.AreEqual("The triangle is valid.", Triangle.ValidTriangle(60, 60, 60));
        Assert.AreEqual("The triangle is valid.", Triangle.ValidTriangle(90, 45, 45));
    }

    [Test]
    public void TestInvalidTriangle()
    {
        Assert.AreEqual("The triangle is NOT valid.", Triangle.ValidTriangle(30, 60, 90));
        Assert.AreEqual("The triangle is NOT valid.", Triangle.ValidTriangle(0, 0, 0));
    }
}
