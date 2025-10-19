using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Home.SmartHome;

namespace Home
{
    internal class TemperatureSensor
    {
        public event TemperetureEventHandler OnOberheat;
        public void CheckTemperature(int currentTemp)
        {
            if (currentTemp > 30)
                OnOberheat?.Invoke($"!! Температура критическая: {currentTemp}°C!");
        }
    }
}
