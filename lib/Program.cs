using System;

namespace lib
{
    class Program
    {
        static void Main(string[] args)
        {
            getStuWorkDetail();
            Console.WriteLine("Hello World!");
        }

        static void getStuWorkDetail()
        {
            Console.WriteLine($"{System.Reflection.MethodBase.GetCurrentMethod().Name}");
        }
    }
}
