using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of chart (line/bar/pie):");
            string chartType = Console.ReadLine().ToLower();

            GraphFactory factory = null;

            switch (chartType)
            {
                case "line":
                    factory = new LineChartFactory();
                    break;
                case "bar":
                    factory = new BarChartFactory();
                    break;
                case "pie":
                    factory = new PieChartFactory();
                    break;
                default:
                    Console.WriteLine("Invalid chart type.");
                    return;
            }

            Console.WriteLine("Enter chart data:");
            string chartData = Console.ReadLine();

            ChartVisualizer visualizer = new ChartVisualizer(factory);
            visualizer.VisualizeChart();
        }
    }
    
}
