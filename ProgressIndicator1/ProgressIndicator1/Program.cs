using System;
using System.Threading;

namespace ProgressIndicator1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                //Console.WriteLine(i);
                //Console.Write(i);

                //Console.WriteLine($"\n{i}");
                //Console.Write($"\n{i}");

                //Console.WriteLine($"\r{i}");
                //Console.Write($"\r{i}");

                //Console.WriteLine($"\t{i}");
                //Console.Write($"\t{i}");

                Console.Write($"\rProgress Indicator    ");
                Thread.Sleep(500);
                Console.Write($"\rProgress Indicator .");
                Thread.Sleep(500);
                Console.Write($"\rProgress Indicator ..");
                Thread.Sleep(500);
                Console.Write($"\rProgress Indicator ...");
                Thread.Sleep(500);
                Console.Write($"\rProgress Indicator ...");
                Thread.Sleep(500);
            }
        }
    }
}
