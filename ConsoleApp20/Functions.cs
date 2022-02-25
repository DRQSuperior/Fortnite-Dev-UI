using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    public class function
    {
        public static void log(string message)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("+");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("] ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(message + "\n");
        }

        public static void launch()
        {

        }

        public static void verify()
        {

        }

        public static void update()
        {

        }

        public static void settings()
        {

        }

        public static void exit()
        {
            log("Exiting!");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
    }
}
