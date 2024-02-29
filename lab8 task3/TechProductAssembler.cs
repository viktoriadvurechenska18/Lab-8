using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task3
{
    class TechProductAssembler
    {
        private TechProductFactory factory;

        public TechProductAssembler(TechProductFactory factory)
        {
            this.factory = factory;
        }

        public void AssembleProduct()
        {
            Screen screen = factory.CreateScreen();
            Processor processor = factory.CreateProcessor();
            Camera camera = factory.CreateCamera();

            Console.WriteLine("Assembling tech product:");
            screen.Display();
            processor.PerformOperation();
            camera.Capture();
        }
    }
}
