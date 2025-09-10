

namespace StringCalculator;
public class CalculatorTests
{
    // 1) An empty string returns 0
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    // 2) A string with a single integer in it is converted to an integer and returned
    [Theory]
    [InlineData("3", 3)]
    [InlineData("4", 4)]
    public void CanAddSingleInteger(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
    }

    // 3) It can take a string with two integers, separated by a comma. So `Add("1,2")` would produce 3
    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("2,3", 5)]
    public void CanAddTwoStrings(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);
        
    }

    // 4) It can take an arbitrary length string
    [Theory]
    [InlineData("1,2", 3)]
    [InlineData("1,2,3", 6)]
    [InlineData("1,2,3,4,5,6,7,8,9", 45)]
    public void CanAddMultipleStrings(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);

    }

    // 5) We can "mix" delimeters
    [Theory]
    [InlineData("1\n2", 3)]
    [InlineData("1\n2,3", 6)]
    public void CanAddMixDelimiters(string value, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(value);
        Assert.Equal(expected, result);

    }
}
