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
}