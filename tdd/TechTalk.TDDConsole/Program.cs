using System;
using TechTalk.TDDTests;

namespace TechTalk.TDDConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
                Console.WriteLine(FizzBuzzer.GetValue(i));
        }
    }
}
