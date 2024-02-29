using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task4
{
    public class CsvDataAdapter : IDataAdapter
    {
        public IDataPrototype Convert(IDataPrototype sourceData)
        {
            Console.WriteLine("Converting CSV to another format...");
            return new XmlData { XmlContent = "Converted XML content" };
        }
    }
}
