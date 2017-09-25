using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class QueryOperatorsDemo
    {
        static void Main(string[] args)
        {

            var books = BooksRepository.GetBooks();
            var selbooks = books.Where(b => b.Price > 400)
                                .OrderByDescending(b => b.Price)
                                .Select(b => new { Title = b.Title, Price = b.Price * 1.18 })
                                .Skip(2)
                                .Take(2);

            //foreach (var book in selbooks)
            //    Console.WriteLine("{0} {1}", book.Title, book.Price);


            var maxprice = books.Max(b => b.Price);

            var costlybooks = books.Where(b => b.Price == maxprice);


            //foreach (var book in costlybooks)
            //    Console.WriteLine("{0} {1}", book.Title, book.Price);

            var mybooks = books.Where(IsCostlyBook).Take(2);

            //foreach (var book in mybooks)
            //    Console.WriteLine("\n{0} {1}\n", book.Title, book.Price);


            var allbooks = books.Where(IsCostlyBook).ToList();


            var onebook = books.Where(b => b.Id == 100).FirstOrDefault();

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
