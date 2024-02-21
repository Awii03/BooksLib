using System.Transactions;

namespace BooksLib
{
    public class Book:  Object
    {

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Publisher { get; set; }
        public double? Price { get; set; }
        public override string ToString() =>
            $"{Title} {Publisher} {Price}";


        public void ValidateTitle()
        {
            if (Title is null)
            {
                throw new ArgumentNullException("Title is null");
            }
            if (Title.Length == 0)
            {
                throw new ArgumentException("title is empty");
            }

        }

        public void ValidatePrice()
        {

            if (Price <= 10)
            {
                throw new ArgumentOutOfRangeException("Price is or or less");
            }


        }
    }
}