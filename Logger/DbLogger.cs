public class DbLogger : ILogger
{
    public void Log(string message)
    {
        System.Console.WriteLine("Logging in DbLogger: "+ message);
    }
}