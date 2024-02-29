using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task4
{
    public class JsonData : IDataPrototype
    {
        public string JsonContent { get; set; }

        public IDataPrototype Clone()
        {
            return new JsonData { JsonContent = this.JsonContent };
        }
    }
}
