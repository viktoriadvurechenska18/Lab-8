using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task4
{
    public class XmlData : IDataPrototype
    {
        public string XmlContent { get; set; }

        public IDataPrototype Clone()
        {
            return new XmlData { XmlContent = this.XmlContent };
        }
    }
}
