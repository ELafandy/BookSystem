using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace LINQtoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1-Display book title and its ISBN.
            //var Query = SampleData.Books.Select(b => new { b.Isbn, b.Title });
            //foreach (var b in Query)
            //{
            //    Console.WriteLine($"Title : {b.Title} ---- ISBN : {b.Isbn}");
            //}
            #endregion
            #region 2-Display the first 3 books with price more than 25.
            //var Query = SampleData.Books.Where(c => c.Price > 25)
            //             .Select(c => new { c.Title }).Take(3);
            //foreach (var c in Query)
            //{
            //    Console.WriteLine($"Title : {c.Title}");
            //}
            #endregion
            #region 3-Display Book title along with its publisher name. (Using 2 methods).
            ////Linq Query operators
            //var Query1 = SampleData.Books
            //           .Select(b => new { b.Title, b.Publisher });
            //foreach (var b in Query1)
            //{
            //    Console.WriteLine($"Title : {b.Title} ---- Publisher Name : {b.Publisher.Name}");
            //}
            //Console.WriteLine("******************************************************");
            ////linq Quary Expression (Like Sql Schema)
            //var Query2 = from c in SampleData.Books
            //             select (new { c.Title, c.Publisher });
            //foreach (var b in Query2)
            //{
            //    Console.WriteLine($"Title : {b.Title} ---- Publisher Name : {b.Publisher.Name}");
            //}
            #endregion
            #region 4-Find the number of books which cost more than 20.
            //var Query = SampleData.Books.Where(b => b.Price > 20).Count();
            //Console.WriteLine($"Count of books cost more than 20 : {Query}");
            #endregion
            #region 5-Display book title, price and subject name sorted by its subject name ascending and by its price descending.
            //var Query = SampleData.Books
            //            .Select(b => new { b.Title, b.Price, b.Subject }).OrderBy(b => b.Subject.Name).ThenByDescending(b => b.Price);
            //foreach (var item in Query)
            //{
            //    Console.WriteLine($"Title: {item.Title}, Price: {item.Price}, Subject: {item.Subject.Name}");
            //}
            #endregion
            #region 6-Display All subjects with books related to this subject. (Using 2 methods). 
            ////GroupBy
            //var query = from b in SampleData.Books 
            //            group b by b.Subject.Name into g 
            //            select new
            //            {
            //                 SubjectName = g.Key,
            //                 Books = g.ToList()
            //            };
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Subject: {item.SubjectName}");
            //    foreach (var book in item.Books)
            //    {
            //        Console.WriteLine($"\tBook: {book.Title}, Price: {book.Price}");
            //    }
            //}
            //Console.WriteLine("******************************************************************");
            ////subquery
            //var query1 =from s in SampleData.Subjects
            //            select new
            //            {
            //                SubjectName = s.Name,
            //                Books = from b in SampleData.Books
            //                where b.Subject.Name == s.Name
            //                select b
            //            };
            //foreach (var item in query1)
            //{
            //    Console.WriteLine($"Subject: {item.SubjectName}");
            //    foreach (var book in item.Books)
            //    {
            //        Console.WriteLine($"\tBook: {book.Title}, Price: {book.Price}");
            //    }
            //}
            #endregion
            #region 7-Try to display book title & price (from book objects) returned from GetBooks Function.
            //var query = SampleData.GetBooks().OfType<Book>()                
            //            .Select(b => new { b.Title, b.Price });
            //foreach (var book in query)
            //{
            //    Console.WriteLine($"Title: {book.Title}, Price: {book.Price}");
            //}
            #endregion
            #region 8-Display books grouped by publisher & Subject.
            //var query = SampleData.Books
            //             .GroupBy(b => new { Publisher = b.Publisher.Name, Subject = b.Subject.Name })
            //             .Select(g => new
            //             {
            //                g.Key.Publisher,
            //                g.Key.Subject,
            //                Books = g.ToList()
            //             });
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"Publisher: {item.Publisher}, Subject: {item.Subject}");
            //    foreach (var book in item.Books)
            //    {
            //        Console.WriteLine($"\tBook: {book.Title}, Price: {book.Price}");
            //    }
            //}

            #endregion
            #region Bonus
            //Console.Write("Enter publisher name: ");
            //string publisherName = Console.ReadLine();
            //Console.Write("Enter sorting Type (title, price, isbn): ");
            //string sortBy = Console.ReadLine();
            //Console.Write("Enter sorting order (asc or desc): ");
            //string sortOrder = Console.ReadLine();
            //var query = SampleData.Books.Where(b => b.Publisher.Name == publisherName);
            //switch (sortBy.ToLower())
            //{
            //    case "title":
            //        if (sortOrder.ToLower() == "asc")
            //            query = query.OrderBy(b => b.Title);
            //        else
            //            query = query.OrderByDescending(b => b.Title);
            //        break;
            //    case "price":
            //        if (sortOrder.ToLower() == "asc")
            //            query = query.OrderBy(b => b.Price);
            //        else
            //            query = query.OrderByDescending(b => b.Price);
            //        break;
            //    case "isbn":
            //        if (sortOrder.ToLower() == "asc")
            //            query = query.OrderBy(b => b.Isbn);
            //        else
            //            query = query.OrderByDescending(b => b.Isbn);
            //        break;
            //}
            //foreach (var book in query)
            //{
            //    Console.WriteLine($"{book.Title} - {book.Price} - {book.Isbn}");
            //}
            #endregion

        }
}
}
