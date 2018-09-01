using System;

public static class FactoryProvider
{
    public static IFactory GetFactory(string mode)
    {
        switch (mode)
        {
            case "db":
                return new DbFactory();

            case "fs":
                return new FsFactory();

            default:
                throw new InvalidOperationException("Factory mode does not exist");
        }
    }
}