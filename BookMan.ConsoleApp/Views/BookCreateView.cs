using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.ConsoleApp.Views
{
    internal class BookCreateView
    {
        //public BookCreateView
        public void Render()
        {
            WriteLine("CREATE A NEW BOOK", ConsoleColor.Green);
            var title = InputString("Title: ");
            var author = InputString("Author: ");
            var publisher = InputString("Publisher: ");
            var year = InputInt("Year: ");
            var edition = InputInt("Edition: ");
            var tags = InputString("Tags: ");
            var description = InputString("Description: ");
            var rate = InputInt("Rate: ");
            var reading = InputBool("Reading [y/n]?: ");
            var file = InputString("File: ");


        }
        /// <summary>
        /// Using WriteLine with color
        /// </summary>
        /// <param name="message"></param>
        /// <param name="color"></param>
        public void WriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        /// <summary>
        /// Write method with optional choices
        /// </summary>
        /// <param name="message">message you want to print</param>
        /// <param name="color">color you want to print</param>
        /// <param name="resetColor">Do you want to reset color?</param>
        public void Write(string message, ConsoleColor color, bool resetColor)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            if (resetColor)
                Console.ResetColor();
        }
        /// <summary>
        /// Print the Notification and using ReadLine() method to
        /// transfer the information into bool
        /// </summary>
        /// <param name="label">Notification string</param>
        /// <param name="labelColor">Notification color</param>
        /// <param name="valueColor">User input color</param>
        private bool InputBool(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label}", labelColor, true);
            ConsoleKeyInfo Key = Console.ReadKey();
            Console.WriteLine();
            bool @char = (Key.KeyChar == 'y' || Key.KeyChar == 'Y') ? true : false;
            return @char;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="label"></param>
        /// <param name="labelColor"></param>
        /// <param name="valueColor"></param>
        /// <returns></returns>
        private int InputInt(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            while (true)
            {
                var str = InputString(label, labelColor, valueColor);
                var result = int.TryParse(str, out int i);
                if (result == true)
                {
                    return i;
                }
            }
        }/// <summary>
         /// Print the Notification and using ReadLine() method to
         /// transfer the information into string
         /// </summary>
         /// <param name="label"></param>
         /// <param name="labelColor">Notification color</param>
         /// <param name="valueColor"></param>
         /// <returns></returns>
        private string InputString(string label, ConsoleColor labelColor = ConsoleColor.Magenta, ConsoleColor valueColor = ConsoleColor.White)
        {
            Write($"{label}", labelColor, true);
            Console.ForegroundColor = valueColor;
            string value = Console.ReadLine();
            return value;
        }
    }
}
