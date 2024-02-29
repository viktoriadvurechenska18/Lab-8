using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task4
{
    public class DataConverter
    {
        public IDataPrototype ConvertData(IDataPrototype sourceData, IDataAdapter adapter)
        {
            return adapter.Convert(sourceData);
        }
    }
}
