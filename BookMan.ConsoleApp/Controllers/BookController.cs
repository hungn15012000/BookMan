using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMan.ConsoleApp.Controllers
{
    using Models;
    using Views;
    class BookController
    {

        public void Single(int id)
        {

            Books model = new Books
            {
                Id = 1,
                Author = "Adam Freeman",
                Title = "Expert ASP.NET Web API 2 for MVC Developers (The Expert's Voice in .NET)",
                Publisher = "Apress",
                Year = 2014,
                Tags = "c#, asp.net, mvc",
                Description = "Expert insight and understanding of how to create, customize, and deploy complex, flexible, and robust HTTP web services",
                Rating = 5,
                Reading = true
            };
            BookSingleView view = new BookSingleView(model);
            view.Render();
        }
        public void Create()
        {
            BookCreateView view = new BookCreateView();
            view.Render();
        }
        public void Update(int id)
        {
            var model = new Books();
            BookUpdateView view = new BookUpdateView(model);
            view.Render();
        }
        
    }
}
