using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BooksLib.Tests
{
    [TestClass()]
    public class BookTests
    {
        [TestMethod()]
        public void ToStringTest()
        {

        }

        [TestMethod()]
        public void ValidatetitleTest()
        {
            Book book = new Book()
            {
                Id = 1,
                Title = "Mine store tanker",
                Publisher = "Mig selv",
                Price = 10
            };
            book.ValidateTitle();


            Book bookNullTitle = new()
            {
                Id = 1,
                Title = null,
                Publisher = "Mig selv",
                Price = 10
            };
            Assert.ThrowsException<ArgumentNullException>(() => bookNullTitle.ValidateTitle());



        }



       
    }


    
}