using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            DateTime currentTime = DateTime.Now;

            string dayOfWeek = currentTime.ToString("dddd");
            string date = currentTime.ToString("dd/MM/yyyy");
            string time = currentTime.ToString("HH:mm:ss");

            // Console.Clear();
            Console.WriteLine($"Thoi gian hien tai: {dayOfWeek}, ngay {date}, thoi gian: {time}");

            Thread.Sleep(1000);
        }
    }
}
