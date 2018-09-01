public class DbFactory : IFactory
{
    public ILogger GetLogger()
    {
        return new DbLogger();
    }
}