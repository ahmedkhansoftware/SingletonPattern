using System;
using System.Collections.Generic;

namespace SingletonPattern
{
    public class TableServers
    {
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        public TableServers()
        {
            servers.Add("Ahmed");
            servers.Add("Jeremy");
            servers.Add("Zack");
        }

        public string GetNextServer()
        {
            if (servers.Count == 0)
                return "Out of Servers :( ";

            string output = servers[nextServer];
            nextServer += 1;

            if (nextServer >= servers.Count)
            {
                nextServer = 0;
            }
            return output;
        }
    }
}