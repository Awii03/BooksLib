using BooksLib;

namespace BookRepositorytest
{
    [TestClass]
    public class BookRepositorytest
    {
        [TestMethod]
        public void GetBookTestMetode()
        {
            //Arrange 
            BooksRepository book = new BooksRepository();

            //Act 
            book.GetBooks();
            List<Book> books = book.GetBooks();
            int expectedresult = books.Count();
            //Assert
            int Actualresult = 3;

            Assert.AreEqual(expectedresult, Actualresult);

        }

        [TestMethod]
        public void CreateBookTestMetode()
        {
            //Arrange
            BooksRepository booksrepository = new BooksRepository();
            Book b = new Book() { Id = 1, Price = 9.95, Publisher = "Bo", Title = "A" };

            //Act
            int count = booksrepository.GetBooks().Count;
            booksrepository.AddBook(b);
            int countafter = booksrepository.GetBooks().Count;
            

            //Assert
            Assert.AreEqual(count+1, countafter);

        }


        [TestMethod]
        public void UpdateBookTestMetode()
        {

            //Arrange 
            BooksRepository booksrepository = new BooksRepository();
            Book b = new Book() { Id = 2, Title = "B", Publisher = "Søren", Price = 8.95 };

            //Act
            Book? update = booksrepository.UpdateBook(1, b);
            
            //Assert
            Assert.IsNotNull(update);
            Assert.AreEqual("Søren", update.Publisher);

            Book? bookNull = booksrepository.UpdateBook(4, b);
            Assert.IsNull(bookNull);

        }

        [TestMethod]
        public void DeleteBookTestMetode()
        {
            //Arrange
            BooksRepository booksrepository = new BooksRepository();
            
            //Act
            Book? b = booksrepository.DeleteBook(2);

            //Assert
            Assert.IsNotNull(b);
            int count = booksrepository.GetBooks().Count;
            booksrepository.DeleteBook(1);
            int countafter = booksrepository.GetBooks().Count;

            Assert.AreEqual(count-1, countafter);


        }

        [TestMethod]
        public void ToStringTest()
        {
            //Arrange
            BooksRepository booksrepository = new BooksRepository();

            //Act
            String s = booksrepository.ToString();

            //Assert
            Assert.AreEqual("A Bo 7,95;B Jens 8,95;C Søren 9,95", s);

        }

        







          






        
    }
}