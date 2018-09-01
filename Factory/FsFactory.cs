public class FsFactory : IFactory
{
    public ILogger GetLogger()
    {
       return new FsLogger();
    }
}