using System;
using System.Threading;
using static coreMethod.Ultilities;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        //what runs
        {
            var rndConsole = Console.ForegroundColor = GetRandomConsoleColor();
            while (true)
            {
                
                nameFr();
                Console.ReadKey();
                RandomNum(Tpoints);
            }
        }
    }
}