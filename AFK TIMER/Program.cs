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
            Thread.Sleep (0);
            if (minutes == 0)
            {
                Console.WriteLine($"Я сижу афк {seconds} секунд");
            }
            else if (hours == 0){
                Console.WriteLine($"Я сижу афк {minutes} минут {seconds} секунд");
            }

            else
            {
                Console.WriteLine($"Я сижу афк {hours} часов {minutes} минут {seconds} секунд");
            }
            

            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
                Console.WriteLine($"Прошло: {minutes} минут");
            }
            if (minutes == 60)
            {
                hours++;
                minutes = 0;
                Console.WriteLine($"Прошло: {hours} часов");
            }
            
        }
    }
}
