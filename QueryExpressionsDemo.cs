using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class QueryExpressionDemo
    {
        static void Main(string[] args)
        {

            var books = BooksRepository.GetBooks();
            var selbooks = (from b in books
                            where b.Price > 500
                            orderby b.Price descending
                            select new { Title = b.Title, Price = b.Price * 1.18 }
                            ).Take(3);

            foreach (var book in selbooks)
                Console.WriteLine("{0} {1}", book.Title, book.Price);


            var onebook = (from b in books
                           where b.Id == 100
                           select b
                          ).FirstOrDefault();

            if (onebook != null)
                Console.WriteLine(onebook.Title);

        }

        public static bool IsCostlyBook(Book b)
        {
            Console.WriteLine("Processing {0}", b.Title);
            return b.Price > 500;
        }

       
    }
}
