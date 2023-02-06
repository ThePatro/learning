namespace Example.Console;

public class Service : IService
{
    public bool PerformCall()
    {
        return true;
    }

    public int CalculateStuff(int a, int b)
    {
        return a + b;
    }

    public string GetFirstName()
    {
        return "Patryk";
    }

    public double GetRandomDouble()
    {
        var rand = new Random();

        var randDouble = rand.NextDouble();

        return randDouble;
    }
    
    public string GetRandomDoubleAsString()
    {
        var randDouble = this.GetRandomDouble();

        return $"Random double: {randDouble}";
    }

    public int GetRandomInt()
    {
        var rand = new Random();

        var randInt = rand.Next(0, 100);

        return randInt;
    }

    public string GetRandomIntAsString()
    {
        var randInt = this.GetRandomInt();
        
        return $"Random int: {randInt}";
    }

    public float GetRandomFloat()
    {
        var rand = new Random();

        var randFloat = rand.NextSingle();

        return randFloat;
    }
    
    public string GetRandomFloatAsString()
    {
        var randFloat = this.GetRandomFloat();
        
        return $"Random float: {randFloat}";
    }
}