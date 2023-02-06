using FluentAssertions;

namespace Example.Console.Tests;

public class ServiceTests
{
    [Fact]
    public void PerformCallTest()
    {
        var service = new Service();

        var result = service.PerformCall();
        
        Assert.True(result);
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    public void CalculateStuffTest(int a, int b, int expected)
    {
        var service = new Service();

        var result = service.CalculateStuff(a, b);
        
        Assert.Equal(result, expected);
    }
    
    [Fact]
    public void GetFirstNameTest()
    {
        const string expectedResult = "Patryk";
        
        var service = new Service();

        var result = service.GetFirstName();

        result.Should().Be(expectedResult);
    }
}
