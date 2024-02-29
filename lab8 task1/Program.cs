using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConfigurationManager configManager = ConfigurationManager.Instance;

            configManager.LoggingMode = "Verbose";
            configManager.DatabaseConnectionString = "Server=myserver;Database=mydatabase;User=myuser;Password=mypassword;";

            ConfigurationManager anotherInstance = ConfigurationManager.Instance;
            Console.WriteLine("Logging mode from another instance: " + anotherInstance.LoggingMode);
            Console.WriteLine("Database connection string from another instance: " + anotherInstance.DatabaseConnectionString);
        }
    }
}
