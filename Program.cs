using System;

namespace consolePrograming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("What is your name? : ");
            string name = Console.ReadLine();

            Console.Write("What is your surname? : ");
            string surname = Console.ReadLine();

            Console.WriteLine("Nice to meet you " + name + " "+surname);

        }
    }
}
