using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task4
{
    public class XmlDataAdapter : IDataAdapter
    {
        public IDataPrototype Convert(IDataPrototype sourceData)
        {
            Console.WriteLine("Converting XML to another format...");
            return new JsonData { JsonContent = "Converted JSON content" };
        }
    }
}
