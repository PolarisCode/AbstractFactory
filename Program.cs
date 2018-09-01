using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace C_
{
    public class Program
    {
        static void Main(string[] args)
        {
           IFactory f = FactoryProvider.GetFactory("fs");
           f.GetLogger().Log("Hello");

           IFactory f2 = FactoryProvider.GetFactory("db");
           f2.GetLogger().Log("Hallo");
        }

    }
}