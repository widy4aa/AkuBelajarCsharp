using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasMandiriPBO
{
    internal class Laptop
    {
        public string Merek;
        public bool isLaptopTurnOn;

        public Laptop(String Merek)
        {
            this.Merek = Merek;
            this.isLaptopTurnOn = false;
        }

        public void TrunOnLaptop()
        {
            this.isLaptopTurnOn = true;
        }

    }
}
