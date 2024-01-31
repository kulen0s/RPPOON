using System;
using System.Collections;
using System.Collections.Generic;

namespace zadaca
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} by {Author}";
        }
    }
    class BookShelf : IEnumerable<Book>
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(int index)
        {
            try
            {
                return books[index];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Book not found.");
                return null;
            }
        }
        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book book in books)
            {
                yield return book;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BookShelf shelf = new BookShelf();
            shelf.AddBook(new Book { Title = "Book 1", Author = "Author 1" });
            shelf.AddBook(new Book { Title = "Book 2", Author = "Author 2" });
            shelf.AddBook(new Book { Title = "Book 3", Author = "Author 3" });
            foreach (Book book in shelf)
            {
                Console.WriteLine(book);
            }
        }
    }
}
