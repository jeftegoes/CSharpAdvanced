using System;

namespace Section2Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book
            {
                Isbn = "1111",
                Title = "C# Advanced"
            };
            
            /*
                var list = new List();
                list.Add(10);
                var l = list[10];

                var bookList = new BookList();
                bookList.Add(new Book());
                var b = bookList[10];
            
                var numbers = new GenericList<int>();
                numbers.Add(10);

                var books = new GenericList<Book>();
                books.Add(new Book());

                var dictionary = new GenericDictionary<string, Book>();
                dictionary.Add("1234", new Book());
            */

            var number = new Nullable<int>(5);
            Console.WriteLine("Has value? {0}", number.HasValue);
            Console.WriteLine("Value: {0}", number.GetValueOrDefault());

            var numberNull = new Nullable<int>();
            Console.WriteLine("Has value? {0}", numberNull.HasValue);
            Console.WriteLine("Value: {0}", numberNull.GetValueOrDefault());
        }
    }
}
