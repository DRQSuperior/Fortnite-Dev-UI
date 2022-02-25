using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp20;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void restartoptions()
            {
                Console.Clear();
                loadmain();
            }
            void optionhandler()
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\n> ");
                string option = Console.ReadLine();
                if (option == "")
                {
                    function.log("You didnt select a option!");
                    Thread.Sleep(1000);
                    restartoptions();
                }
                if (option == "1")
                {
                    function.log("You Picked "+option);
                    function.launch();
                    Thread.Sleep(2000);
                    restartoptions();
                }
                if (option == "2")
                {
                    function.log("You Picked "+option);
                    function.verify();
                    Thread.Sleep(2000);
                    restartoptions();
                }
                if (option == "3")
                {
                    function.log("You Picked "+option);
                    function.update();
                    Thread.Sleep(2000);
                    restartoptions();
                }
                if (option == "4")
                {
                    function.log("You Picked "+option);
                    function.settings();
                    Thread.Sleep(2000);
                    restartoptions();
                }
                if (option == "5")
                {
                    function.log("You Picked "+option);
                    function.exit();
                    Thread.Sleep(2000);
                    restartoptions();
                }
            }

            void loadoptions()
            {
                function.log("Please Select A Option\n\n");
                function.log("1. Launch");
                function.log("2. Verify");
                function.log("3. Update");
                function.log("4. Settings");
                function.log("5. Exit");
                optionhandler();
            }

            void loadmain()
            {
                Console.Title = "StrikeFN | Made by DRQSuperior";
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("  ██████ ▄▄▄█████▓ ██▀███   ██▓ ██ ▄█▀▓█████   █████▒███▄    █");
                Console.WriteLine("▒██    ▒ ▓  ██▒ ▓▒▓██ ▒ ██▒▓██▒ ██▄█▒ ▓█   ▀ ▓██   ▒ ██ ▀█   █ ");
                Console.WriteLine("░ ▓██▄   ▒ ▓██░ ▒░▓██ ░▄█ ▒▒██▒▓███▄░ ▒███   ▒████ ░▓██  ▀█ ██▒");
                Console.WriteLine("  ▒   ██▒░ ▓██▓ ░ ▒██▀▀█▄  ░██░▓██ █▄ ▒▓█  ▄ ░▓█▒  ░▓██▒  ▐▌██▒");
                Console.WriteLine("▒██████▒▒  ▒██▒ ░ ░██▓ ▒██▒░██░▒██▒ █▄░▒████▒░▒█░   ▒██░   ▓██░");
                Console.WriteLine("▒ ▒▓▒ ▒ ░  ▒ ░░   ░ ▒▓ ░▒▓░░▓  ▒ ▒▒ ▓▒░░ ▒░ ░ ▒ ░   ░ ▒░   ▒ ▒ ");
                Console.WriteLine("░ ░▒  ░ ░    ░      ░▒ ░ ▒░ ▒ ░░ ░▒ ▒░ ░ ░  ░ ░     ░ ░░   ░ ▒░");
                Console.WriteLine("░  ░  ░    ░        ░░   ░  ▒ ░░ ░░ ░    ░    ░ ░      ░   ░ ░ ");
                Console.WriteLine("      ░              ░      ░  ░  ░      ░  ░                ░ ");
                Console.WriteLine("");
                Console.WriteLine("");
                loadoptions();
            }

            for (int i = 0; i < 5; i++)
            {
                function.log("Loading.");
                Console.Title = "Loading.";
                Thread.Sleep(500);
                Console.Clear();
                function.log("Loading..");
                Console.Title = "Loading..";
                Thread.Sleep(500);
                Console.Clear();
                function.log("Loading...");
                Console.Title = "Loading...";
                Thread.Sleep(500);
                Console.Clear();
            }
            function.log("Finished Loading!");
            Console.Title = "Finished Loading!";
            Thread.Sleep(2000);
            Console.Clear();
            loadmain();
            Console.ReadLine();
        }
    }
}
