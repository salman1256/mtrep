using System;

namespace MyMTEx
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public static void DisplayOne()
        {
            Console.WriteLine("Number List from 1-20");
            for (int i = 1; i <=20; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void DisplayTwo()
        {
            Console.WriteLine("Number List from 20-50");
            for (int i = 20; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
  
}
