using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class PieChartFactory : GraphFactory
    {
        public override IChart CreateChart()
        {
            return new PieChart();
        }
    }
}
