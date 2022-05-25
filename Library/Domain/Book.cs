namespace Domain
{
    public class Book : BaseModel
    {
        public string Title { get; }
        public string Author { get; }
        public int PublicationYear { get; }
        public string ISBN { get; }

        public int ProductsAvailable { get; private set; }
        public decimal Price { get; }

        public Book() { }

        public Book(string title, string author, int publicationYear, string isbn, int productsAvailable, decimal price)
        {
 
                if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(author)
                    && !string.IsNullOrWhiteSpace(isbn))
                {
                    Title = title;
                    Author = author;
                    ISBN = isbn;
                }
                else
            {
                //throw new Exception() 
            }

            PublicationYear = publicationYear;
            ProductsAvailable = productsAvailable;
            Price = price;
        }

        public override string ToString()
        {
            return $"Title: {Title} Author: {Author} ProductsAvailable: {ProductsAvailable}";
        }

        public void ChangeProductsAvailableNumber(int change)
        {
            this.ProductsAvailable += change;
        }
    }
}