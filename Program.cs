using System;
using System.Threading;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = Segundos => 10s = 10 segundos");
            Console.WriteLine("M = Minutos => 1m = 1 minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar");

            string data = Console.ReadLine().ToLower();
            Char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if (type == 'm')
            {
                multiplier = 60;
            }
            if (time == 0)
            {
                System.Environment.Exit(0);
            }
            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Preparar");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Apontar");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Fogo");
            Thread.Sleep(1000);

            Start(time);
        }

        static void Start(int time)
        {
            Console.Clear();

            //int currentTime = 0;

            // while (currentTime != time)
            // {
            //     Console.Clear();
            //     currentTime++;
            //     Console.WriteLine(currentTime);
            //     Thread.Sleep(1000);
            // }
            ////////////////////////////////////////////////////////////////////////////////
            // for (int currentTime = time; currentTime >= 1; currentTime--)
            // {
            //     Console.Clear();
            //     Console.WriteLine(currentTime);
            //     Thread.Sleep(1000);
            // }

            ////////////////////////////////////////////////////////////////////

            int currentTime = time;

            while (currentTime != 0)
            {
                Console.Clear();
                Console.WriteLine(currentTime);
                currentTime--;
                Thread.Sleep(1000);
            }


            Console.Clear();
            Console.WriteLine("Stopwatch finalizado...");
            Thread.Sleep(2500);
            Menu();

        }
    }
}
