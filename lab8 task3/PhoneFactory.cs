using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab8_task3
{
    class PhoneFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new OLED();
        }

        public override Processor CreateProcessor()
        {
            return new Snapdragon();
        }

        public override Camera CreateCamera()
        {
            return new DualCamera();
        }
    }
}
