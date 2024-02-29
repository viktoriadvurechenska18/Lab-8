using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the type of tech product (1 - Phone):");
            int choice = Convert.ToInt32(Console.ReadLine());

            TechProductFactory factory = null;

            switch (choice)
            {
                case 1:
                    factory = new PhoneFactory();
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }

            TechProductAssembler assembler = new TechProductAssembler(factory);
            assembler.AssembleProduct();
        }
    }
}
