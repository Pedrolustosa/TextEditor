using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What do you want to do ?");
            Console.WriteLine("1 - Open files");
            Console.WriteLine("2 - Create new file");
            Console.WriteLine("0 - Exit");

            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {

        }
        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Enter your text (ESC) to exit");
            Console.WriteLine("------------------");
            string text = "";

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {

            }
        }
    }
}
