// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.Logger = new DatabaseLogger();
       // customerManager.Logger = new FileLogger();
        customerManager.Add();
        Console.ReadLine();
    }
}


class CustomerManager
{
    public ILogger Logger { get; set; }
    public void Add()
    {
        Logger.Log();
        Console.WriteLine();
    }

   
}
class DatabaseLogger : ILogger  //Database logger
{
    public void Log()
    {
        Console.WriteLine("Logged to database.");
    }
}

class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to File.");
    }
}


interface ILogger
{
    void Log();
}
