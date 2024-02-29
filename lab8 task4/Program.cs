using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lab8_task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var csvData = new CsvData { CsvContent = "CSV data" };
            var xmlData = new XmlData { XmlContent = "XML data" };
            var jsonData = new JsonData { JsonContent = "JSON data" };

            Console.WriteLine("Choose source format (CSV, XML, JSON):");
            string sourceFormat = Console.ReadLine();

            Console.WriteLine("Choose target format (CSV, XML, JSON):");
            string targetFormat = Console.ReadLine();

            IDataAdapter adapter = null;

            if (sourceFormat.ToLower() == "csv")
                adapter = new CsvDataAdapter();
            else if (sourceFormat.ToLower() == "xml")
                adapter = new XmlDataAdapter();
            else if (sourceFormat.ToLower() == "json")
                adapter = new JsonDataAdapter();
            else
            {
                Console.WriteLine("Invalid source format");
                return;
            }

            DataConverter converter = new DataConverter();
            var convertedData = converter.ConvertData(csvData, adapter);

            Console.WriteLine($"Converted data in {targetFormat} format: {convertedData}");
        }
    }
    
}
