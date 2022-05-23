using Domain;
using Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class BooksService
    {
        private BooksRepository _repository;
        internal BooksService(BooksRepository repository)
        {
            _repository = repository;
        }
        internal void AddBook()
        {
            Console.WriteLine("Podaj tytuł książki");
            string title = Console.ReadLine();
            Console.WriteLine("Podaj autora");
            string author = Console.ReadLine();
            Console.WriteLine("Podaj datę publikacji");
            int publicationYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj numer isbn");
            string isbn = Console.ReadLine();
            Console.WriteLine("Podaj ile książek jest na stanie");
            int productsAvailable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj cenę");
            decimal price = Convert.ToDecimal(Console.ReadLine());
            var book = new Book(title, author, publicationYear, isbn, productsAvailable, price);
            _repository.Insert(book);
            Console.WriteLine("proba dodania ksiazki");
        }

        internal void RemoveBook()
        {
            Console.WriteLine("Podaj tytuł książki");
            var title = Console.ReadLine();
            _repository.RemoveByTitle(title);
        }

        internal void ListBooks()
        {
            var list = _repository.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item.Title);
            }
            Console.WriteLine("Tutaj pojawi sie lista ksiazek");
        }

        internal void ChangeState()
        {
            Console.WriteLine("Podaj tytuł książki");
            var title = Console.ReadLine();
            Console.WriteLine("Podaj stan magazynowy");
            var state = Convert.ToInt32(Console.ReadLine());
        }
    }
}
