using System;

namespace BookMan.ConsoleApp
{
    using Controllers;
    internal class Program
    {
        static void Main(string[] args)
        {
            BookController controller = new BookController();
            while (true)
            {
                Console.Write("Request> ");
                string Request = Console.ReadLine();
                switch (Request.ToLower())
                {
                    case "single":
                        controller.Single(1);
                        break;
                    case "create":
                        controller.Create();
                        break;
                    default:
                        Console.WriteLine("UNKNOWN COMMAND!!!");
                        break;

                }
            }
        }
    }
}
