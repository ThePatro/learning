namespace Example.Console;

public interface IService
{
    public bool PerformCall();

    public int CalculateStuff(int a, int b);

    public string GetFirstName();

    public double GetRandomDouble();
    
    public string GetRandomDoubleAsString();

    public int GetRandomInt();
    
    public string GetRandomIntAsString();

    public float GetRandomFloat();
    
    public string GetRandomFloatAsString();
}