using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task4
{
    public class CsvData : IDataPrototype
    {
        public string CsvContent { get; set; }

        public IDataPrototype Clone()
        {
            return new CsvData { CsvContent = this.CsvContent };
        }
    }

}
