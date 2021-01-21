using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helper.Lambda
{
    //Lambda Expression is an anonymous method, no access modifier, no name, no return statement
    //syntax for lamda expression:  arg => expression (number => number * number)
    // No Argument: () => ...
    //x => .. (one argument without paraenthis)
    //(x,y,z) => ... for multiple arguments
    public class LambdaExpressions
    {

        public void LambdaExample()
        {
            int factor = 5;
            Func<int, int> square = number => number * factor;
        }

        public void LambdaExample1()
        {
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(book => book.Price < 10);
            foreach(var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
                
            }
        }
    }
}
