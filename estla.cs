using NUnit.Framework;

[TestFixture]
public class TestClass
{
    [Test]
    public void TestMethod()
    {
        // Arrange
        var obj = new SomeClass();
        
        // Act
        var savedObj = obj.Save();

        // Assert
        Assert.Null(savedObj);
    }
}
