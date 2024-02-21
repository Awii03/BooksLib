using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLib
{
    public class BooksRepository
    {
        private int _nextId = 6;
        private List<Book> _books = new()
        {
         new Book{ Id = 1, Title = "A",Price = 7.95,Publisher="Bo"},
         new Book{ Id = 2, Title = "B",Price = 8.95,Publisher="Jens"},
         new Book{ Id = 3, Title = "C",Price = 9.95,Publisher="Søren"},
        };


        public List<Book> GetBooks()
        {
            return new List<Book>( _books);

        }

        public Book AddBook(Book book)
        {
            book.Id = _nextId++;
            _books.Add(book);
            return book;
        }


        public Book? GetBook(int id)
        { 
            return _books.Find(b =>b.Id == id); 
        }

        public Book? DeleteBook(int id)
        {
            Book? book = _books.Find(book=> book.Id == id);
            if (book != null)
            {
                _books.Remove(book);
            }
            return book;

        }

        public Book? UpdateBook(int id, Book data)
        {
            Book? b= GetBook(id);
            if( b == null ) return null;
            b.Publisher = data.Publisher;
            b.Title = data.Title;
            b.Price= data.Price;
            return b;
             
        }

        public override string ToString()
        {
            return string.Join(";", _books);
        }
        //return string.Join("\m", _books); laver en liste af bøgerne i en lang list nedad




    }

}
