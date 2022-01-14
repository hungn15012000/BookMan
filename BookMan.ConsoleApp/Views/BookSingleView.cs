using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.ConsoleApp.Views
{
    using Models;
    internal class BookSingleView
    {
        protected Books Model;
        /// <summary>
        /// This is a constructor of a Book, which views the information of the Book
        /// </summary>
        /// <param name="model">Each book will be selected specially</param>
        public BookSingleView(Books model)
        {
            Model = model;
        }
        public void Render()
        {
            if (Model == null)
            {
                WriteLine("NO BOOK BEING FOUND, SORRY!", ConsoleColor.Red);
                return;
            }
            WriteLine("BOOK DETAIL INFOMATION", ConsoleColor.Green);
            Console.WriteLine($"Author:      {Model.Author}");
            Console.WriteLine($"Title        {Model.Title}");
            Console.WriteLine($"Publisher    {Model.Publisher}");
            Console.WriteLine($"Year         {Model.Year}");
            Console.WriteLine($"Editon       {Model.Edition}");
            Console.WriteLine($"Isbn         {Model.Isbn}");
            Console.WriteLine($"Tags         {Model.Tags}");
            Console.WriteLine($"Description  {Model.Description}");
            Console.WriteLine($"Rating       {Model.Rating}");
            Console.WriteLine($"Reading      {Model.Reading}");
            Console.WriteLine($"File         {Model.File}");
            Console.WriteLine($"File Name    {Model.FileName}");
        }
        protected void WriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }


    }
}

