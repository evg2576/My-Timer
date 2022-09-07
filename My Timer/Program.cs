using System;

namespace My_Timer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyTimer.SetTimeout(3000, () => Console.WriteLine("Method 1"));
            MyTimer.SetInterval(1000, () => Console.WriteLine("Method 2"), 4);
            Console.ReadKey();
        }
    }
}
