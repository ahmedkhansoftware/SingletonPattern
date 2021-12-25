using System;
using System.Collections.Generic;

namespace SingletonPattern
{
    public class TableServersSingleton
    {
        private static readonly TableServersSingleton _instance = new TableServersSingleton();
        private List<string> servers = new List<string>();
        private int nextServer = 0;

        private TableServersSingleton()
        {
            servers.Add("Ahmed");
            servers.Add("Jeremy");
            servers.Add("Zack");
        }


        public static TableServersSingleton GetTableServers()
        {
            return _instance;
        }

        public void AddServer(string name)
        {
            servers.Add(name);
        }

        public void RemoveServer(string name)
        {
            servers.Remove(name);
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