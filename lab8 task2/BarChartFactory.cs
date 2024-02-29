using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class BarChartFactory : GraphFactory
    {
        public override IChart CreateChart()
        {
            return new BarChart();
        }
    }
}
