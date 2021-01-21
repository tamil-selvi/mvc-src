using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Helper
{
    public class BookHelper
    {
        public void AddBookList()
        {
            var book = new Book { Title = "C# Advanced", Isbn = "1111" };

            var numberlist = new GenericList<int>();
            numberlist.Add(2);

            //generic list
            var booklist = new GenericList<Book>();  // when we use generic list no casting and boxing
            booklist.Add(book);

            //generic Dictionary
            var dictionary = new GenericDictionay<string, Book>();
            dictionary.Add("1234", new Book());


            //var books = new BookList();
            //books.Add(book);

        }

        public void UtilGenericExample()
        {
            //var number = new Nullable<int>();
            var number = new Nullable<int>(5);
            Console.WriteLine(number.HasValue);
            Console.WriteLine(number.GetValueOrDefault());

        }
    }
}
