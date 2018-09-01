public class FsLogger : ILogger
{
    public void Log(string message)
    {
        System.Console.WriteLine("Logging in FsLogger: " + message);
    }
}