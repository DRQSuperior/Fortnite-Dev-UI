using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
                    log("You didnt select a option!");
                    Thread.Sleep(1000);
                    restartoptions();
                }
                if (option == "1")
                {
                    log("You Picked "+option);
                    launch();
                    Thread.Sleep(2000);
                    restartoptions();
                }
                if (option == "2")
                {
                    log("You Picked "+option);
                    verify();
                    Thread.Sleep(2000);
                    restartoptions();
                }
                if (option == "3")
                {
                    log("You Picked "+option);
                    update();
                    Thread.Sleep(2000);
                    restartoptions();
                }
                if (option == "4")
                {
                    log("You Picked "+option);
                    settings();
                    Thread.Sleep(2000);
                    restartoptions();
                }
                if (option == "5")
                {
                    log("You Picked "+option);
                    exit();
                    Thread.Sleep(2000);
                    restartoptions();
                }
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

            void launch()
            {

            }

            void verify()
            {

            }

            void update()
            {

            }

            void settings()
            {

            }

            void exit()
            {
                log("Exiting!");
                Thread.Sleep(2000);
                Environment.Exit(0);
            }

            void loadoptions()
            {
                log("Please Select A Option\n\n");
                log("1. Launch");
                log("2. Verify");
                log("3. Update");
                log("4. Settings");
                log("5. Exit");
                optionhandler();
            }

            void log(string message)
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("[");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("+");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write("] ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write(message+"\n");
            }

            for (int i = 0; i < 1; i++)
            {
                log("Loading.");
                Console.Title = "Loading.";
                Thread.Sleep(500);
                Console.Clear();
                log("Loading..");
                Console.Title = "Loading..";
                Thread.Sleep(500);
                Console.Clear();
                log("Loading...");
                Console.Title = "Loading...";
                Thread.Sleep(500);
                Console.Clear();
            }
            log("Finished Loading!");
            Console.Title = "Finished Loading!";
            Thread.Sleep(2000);
            Console.Clear();
            loadmain();
            Console.ReadLine();
        }
    }
}
