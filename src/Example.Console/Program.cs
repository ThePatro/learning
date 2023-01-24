using Example.Console;

var myService = new Service();

Console.WriteLine($"Service.PerformCall: {myService.PerformCall()}");

Console.WriteLine($"Service.CalculateStuff(1, 2): {myService.CalculateStuff(1, 2)}");
