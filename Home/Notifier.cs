using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    internal class Notifier
    {
        public static void SendTemperatyreAlert(string message)
        {
            Console.WriteLine($"[Уведомление] {message}");
        }
        public static void LogMotionEvent(string message)
        {
            Console.WriteLine($"[Лог] {message} (время: {DateTime.Now})");
        }
    }
}
