using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task3
{
    class DualCamera : Camera
    {
        public override void Capture()
        {
            Console.WriteLine("Dual camera is capturing high-quality photos.");
        }
    }
}
