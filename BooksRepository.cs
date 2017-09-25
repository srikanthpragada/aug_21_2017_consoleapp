using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class BooksRepository
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>() {
               new Book {  Id =1, Title  = "C# Complete Reference", Author = "Herbert Schild", Price  = 500, Subject = "c#"},
               new Book {  Id =2, Title  = "ASP.NET Unleashed", Author = "Stephen Walther", Price  = 760, Subject = "asp"},
               new Book {  Id =3, Title  = "Pro ASP.NET MVC", Author = "Adam Freeman", Price  = 600, Subject = "asp"},
               new Book {  Id =4, Title  = "Angular", Author = "Lee", Price  = 450, Subject = "aj"},
               new Book {  Id =5, Title  = "Programming Entity Framework", Author = "Julia Lerman", Price  = 600, Subject = "ef"}
            };
            return books;
        }
    }
}
