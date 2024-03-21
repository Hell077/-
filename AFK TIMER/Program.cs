using System;
using System.Threading;

class Program
{
    static void Main()
    {
        int seconds = 0;
        int minutes = 0;
        int hours = 0;

        while (true)
        {
            seconds++;
            Console.WriteLine($"Я сижу афк {hours} часов {minutes} минут {seconds} секунд");
            Thread.Sleep(1000);

            if (seconds >= 60)
            {
                minutes++;
                seconds = 0;
                Console.WriteLine($"Прошло: {minutes} минут");
            }

            if (minutes >= 60)
            {
                hours++;
                minutes = 0;
                Console.WriteLine($"Прошло: {hours} часов");
            }
        }
    }
}
