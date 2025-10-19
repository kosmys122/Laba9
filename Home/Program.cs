namespace Home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tempSensor = new TemperatureSensor();
            var motionSensor = new MotionSensor();
            var smartLight = new SmartLight();
            tempSensor.OnOberheat += Notifier.SendTemperatyreAlert;
            motionSensor.OnMotionDetected += Notifier.LogMotionEvent;
            motionSensor.OnMotionDetected += smartLight.TurnOn;
        
            Console.WriteLine("=== Симуляция умного дома ===");
            motionSensor.DetectMotion(true);
            smartLight.TurnOn("Обнаруженно движение");
            Thread.Sleep(3000);
            smartLight.TurnOff();
        }
    }
}
