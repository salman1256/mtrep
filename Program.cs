using System;
using System.Threading;

namespace MyMTEx
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayOne();
            DisplayTwo();
            Console.ReadKey();
        }
        public static void DisplayOne()
        {
            Console.WriteLine("Number List from 1-20");
            for (int i = 1; i<=20; i++)
            {
                Console.Write(i+"\t");
                Thread.Sleep(1000);
            }
        }
        public static void DisplayTwo()
        {
            Console.WriteLine("Number List from 20-50");
            for (int i = 20; i <= 50; i++)
            {
                Console.Write(i+"\t");
                Thread.Sleep(2000);
            }
        }
    }
  
}
