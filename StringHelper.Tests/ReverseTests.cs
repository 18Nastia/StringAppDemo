using Xunit;
using StringHelper;

public class ReverseTests
{
    [Fact]
    public void Reverse_NormalString_ReturnsReversed()
    {
        string input = "hello";
        string expected = "olleh";
        Assert.Equal(expected, Helper.ReverseString(input));
    }

    [Fact]
    public void Reverse_EmptyString_ReturnsEmpty()
    {
        Assert.Equal("", Helper.ReverseString(""));
    }

    [Fact]
    public void Reverse_SingleChar_ReturnsSame()
    {
        Assert.Equal("a", Helper.ReverseString("a"));
    }
}
