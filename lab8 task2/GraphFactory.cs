using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    class ChartVisualizer
    {
        private GraphFactory _factory;

        public ChartVisualizer(GraphFactory factory)
        {
            _factory = factory;
        }

        public void VisualizeChart()
        {
            IChart chart = _factory.CreateChart();
            chart.Draw();
        }
    }
}
