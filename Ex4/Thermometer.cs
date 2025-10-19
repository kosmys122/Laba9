using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    internal class Thermometer
    {
        public event Action TemperatureTooHigh;
        public int temp = 0;
        public void Measure(int amoynt)
        {
            temp += amoynt;
            if (temp > 100)
            {
                MaxTemp();
            }
            else
                Console.WriteLine($"Температура: {temp}");
        }
        private void MaxTemp()
        {
            Console.WriteLine("Температура превысела ограничение!");
            TemperatureTooHigh?.Invoke();
        }
    }
}
