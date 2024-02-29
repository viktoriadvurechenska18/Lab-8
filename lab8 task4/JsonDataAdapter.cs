using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task4
{
    public class JsonDataAdapter : IDataAdapter
    {
        public IDataPrototype Convert(IDataPrototype sourceData)
        {
            Console.WriteLine("Converting JSON to another format...");
            return new CsvData { CsvContent = "Converted CSV content" };
        }
    }
}
