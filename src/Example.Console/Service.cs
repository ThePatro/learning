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
}