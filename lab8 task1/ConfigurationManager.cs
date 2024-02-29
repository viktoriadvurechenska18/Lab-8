using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task1
{
    public class ConfigurationManager
    {
        private static ConfigurationManager instance;
        private string loggingMode;
        private string databaseConnectionString;

        private ConfigurationManager()
        {
        }

        public static ConfigurationManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
                return instance;
            }
        }

        public string LoggingMode
        {
            get { return loggingMode; }
            set
            {
                loggingMode = value;
                Console.WriteLine("Logging mode set to: " + value);
            }
        }

        public string DatabaseConnectionString
        {
            get { return databaseConnectionString; }
            set
            {
                databaseConnectionString = value;
                Console.WriteLine("Database connection string set to: " + value);
            }
        }
    }
}
