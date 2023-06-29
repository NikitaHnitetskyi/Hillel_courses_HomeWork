using NUnit.Framework;

[TestFixture]
public class StringManipulatorTests
{
    private StringManipulator stringManipulator;

    [SetUp]
    public void Setup()
    {
        stringManipulator = new StringManipulator();
    }

    [Test]
    public void ConcatenateStrings_WithTwoStrings_ReturnsConcatenatedString()
    {
        // Arrange
        string str1 = "Hello";
        string str2 = "World";
        string expected = "HelloWorld";

        // Act
        string result = stringManipulator.ConcatenateStrings(str1, str2);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void GetStringLength_WithValidString_ReturnsStringLength()
    {
        // Arrange
        string str = "Hello";
        int expected = 5;

        // Act
        int result = stringManipulator.GetStringLength(str);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void ReverseString_WithValidString_ReturnsReversedString()
    {
        // Arrange
        string str = "Hello";
        string expected = "olleH";

        // Act
        string result = stringManipulator.ReverseString(str);

        // Assert
        Assert.AreEqual(expected, result);
    }

    [Test]
    public void IsPalindrome_WithPalindromeString_ReturnsTrue()
    {
       
        string str = "madam";

     
        bool result = stringManipulator.IsPalindrome(str);

       
        Assert.IsTrue(result);
    }

    [Test]
    public void IsPalindrome_WithNonPalindromeString_ReturnsFalse()
    {
       
        string str = "hello";

        
        bool result = stringManipulator.IsPalindrome(str);

        
        Assert.IsFalse(result);
    }
}

