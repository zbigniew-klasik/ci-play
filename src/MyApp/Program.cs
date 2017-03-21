using System;
using MyLib;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");

            MyHelper.DoSomething();

            Console.ReadKey();
        }
    }
}
