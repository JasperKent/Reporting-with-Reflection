using System;
using System.Collections.Generic;

namespace ReportingReflection
{
    public enum Rating { Rubbish, Poor, Average, Good, Excellent}

    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public DateTime DateOfPublication { get; set; }
        public Rating Rating { get; set; }
    }

    public static class BookData
    {
        public static IEnumerable<Book> Books = new Book[]
        {
           new () {Title  = "Goldfinger", Author="Ian Fleming", DateOfPublication = new DateTime(1959, 3, 23), Rating = Rating.Excellent},
           new () {Title  = "Dr No", Author="Ian Fleming", DateOfPublication = new DateTime(1958, 3, 31), Rating = Rating.Good},
           new () {Title  = "Live and Let Die", Author="Ian Fleming", DateOfPublication = new DateTime(1954, 4, 5), Rating = Rating.Average},
           new () {Title  = "Emma", Author="Jane Austen", DateOfPublication = new DateTime(1815, 12, 23), Rating = Rating.Good},
           new () {Title  = "Persuasion", Author="Jane Austen", DateOfPublication = new DateTime(1818, 1, 1), Rating = Rating.Excellent},
           new () {Title  = "Great Expectations", Author="Charles Dickens", DateOfPublication = new DateTime(1861, 1, 1), Rating = Rating.Excellent},
           new () {Title  = "Oliver Twist", Author="Charles Dickens", DateOfPublication = new DateTime(1838, 1, 1), Rating = Rating.Average}
        };
    }
}
