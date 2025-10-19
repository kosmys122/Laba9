using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Home.SmartHome;

namespace Home
{
    internal class MotionSensor
    {
        public event MotionEventHandler OnMotionDetected;
        public void DetectMotion(bool isMotion)
        {
            if (isMotion)
                OnMotionDetected?.Invoke("!! Обнаружено движение в коридоре!");
        }
    }
}
