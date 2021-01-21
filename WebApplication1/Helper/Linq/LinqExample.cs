using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Helper.Lambda;

namespace WebApplication1.Helper.Linq
{
    public class LinqExample
    {
        public void LinqWhereExample()
        {
            var books = new BookRepository().GetBooks();

            //Linq query Operators
            var cheapBooks = from b in books
                             where b.Price < 20
                             orderby b.Title
                             select b;

            //Linq Extension methods
            var cheapBooks1 = books
                                    .Where(b => b.Price < 10)
                                    .OrderBy(b => b.Title)
                                    .Select(b => b.Title);

            //select single object 
            //single means atleast one object else it will throw error
            var checkbooks = books.SingleOrDefault(b => b.Title == "Asp.net MVC");

            //first object in the collection
            var book = books.First(b => b.Title == "C# Advanced Topics");

            var book1 = books.FirstOrDefault(b => b.Title == "C# Advanced Topics");

            //skip using paging records Skip(2) means skip 2 records and take the remain no
            var bookSkip = books.Skip(2).Take(3); //used for pagination

            // count
            int rcCount = books.Count();

            var maxPrice = books.Max(b => b.Price);
            var minPrice = books.Min(b => b.Price);
            var totalPrice = books.Sum(b => b.Price); //sumbasedonpriceofbook
            var avg = books.Average(b => b.Price);


        }

        public IEnumerable<Book> GetReservations(DateTime from, DateTime to)
        {

            if (from >= DateTime.Now)
                throw new ArgumentException("dateFrom");

            if((from - DateTime.Now).TotalHours < 24)
            {
                throw new InvalidOperationException();
            }

            throw new NotImplementedException();

        }

        private void DownloadFile()
        {
            MemoryStream ms = CreateMemoryFile();

        }

        private MemoryStream CreateMemoryFile(MemoryStream ms)
        {
            byte[] byteArray = ms.ToArray();
            ms.Flush();
            ms.Close();
            //Response.Clear();
        }

        //ctrl + shirft + r => refactoring comment
        // fn input param 3 is good
        // out param is code smel use Tuple
        //use Ternary operator
        // res = (customerorder > 50) ? 0.1f : 0.01f;

        //Example for a is false and b is false

        //if(!a || !b)
        //        return;

        //if(b && (a || c))
        //{ isValid = true}


        //Open Closed Principle Switch Staments Inseated use Polimorphims
        // Open for extension
        // Close for modification

        //To remove duplicate code use DRY principle Dont repeat yourself
        //DRY Dont Repeat Yourself

        //Long Methods is more than > 10 lines of code

        private void visualstudioTipsandTricks()
        {
            //ctrl + tab to go to tab
            // ctrl + F6 go to tab
            //f5 debub and run
            //ctrl+f5 to run app
            //stop debugging  shift + ctrl + f5

            //propfull + tab - shortcut to create getter and setter
            //prop tab - shortcut to create prop
            //equls + tab
            //try
            //tryf - try with finally block
            //for tab
            //forr
            //foreach
            //while
            //do
            //class to create a class
            //ctor to create a constructor

            //for alignment, ctrl + f do format, ctrl + tab, ctril + shift + tab

            //open google search for productivity power tools

            //VisuvalSvn  download from visuvalsvn.com
                //Alt + U, C = Commit
                //Alt + U, U = Update
                //Alt + U, L = Log

            //TFS 
            // Team Foundation Server (on Prermises) 
            // Team Foundation Service (in the cloud)
            // View Team Explorer
                //ctrl + 0 + p (p stands for pending changes, all tfs comments starts with ctrl + 0)
                //ctrl + 0, H (to view team explorer home)
                //ctrl + 0, M (to view my work)
                //ctrl + 0, W (to view Work Items)
                //ctrl + 0, B (to view Build)
                //F5 to refresh

            //ReSharper
                // write more code with less typing
                // improve code quality
                // Easily find files, classes, methods, properties etc

            //Code Inspector
            
            // Live template // create a shortcut for repetative code using resharper





        }
    }

}
