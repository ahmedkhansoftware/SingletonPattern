using System;

namespace SingletonPattern
{
    public class Program
    {
        static TableServersSingleton HostOne = TableServersSingleton.GetTableServers();
        static TableServersSingleton HostTwo = TableServersSingleton.GetTableServers();


        static void Main(string[] args)
        {
            TableServers Servers = new();
            Console.WriteLine(HostOne.GetNextServer());
            Console.WriteLine(HostTwo.GetNextServer());
        }
    }
}
