using ConsoleApp;
using Persistence;

Console.WriteLine("Podaj login!");
var login = Console.ReadLine();
Console.WriteLine("Podaj hasło!");
var password = Console.ReadLine();

if (login == "Admin" && password == "password")
{
    Console.WriteLine("Access Granted");
}
else
{
    Console.WriteLine("Access Denied");  
}
/*
 14. Przejdz do pliku `Program.cs` w projekcie Library.ConsoleApp
15. Utwórz obiekt klasy `OrdersRepository` przed główną pętlą programu
16. Utwórz obiekt klasy `OrdersService`, wykorzystując przy tym wczesniej utworzony obiekt klasy `OrdersRepository`
17. Wykorzystaj obiekt klasy `OrdersService` aby podpiąc jego metody do zadan:
    - dodaj zamowienie
    - lista zamowien
18. Uruchom aplikację Library.ConsoleApp w trybie debug-u
19. Przetestuj czy dodawanie zamowien działa poprawnie
20. *Zrób zabezpieczenie aby nie dało się dodac do zamówienia ksiazki, której nie ma na w repozytorium
21. *Zrób zabezpieczenie aby do zamowienia nie dało się dodac więcej ksiązek, niz jest w repozytorium.
 */
var repository = new BooksRepository();
var booksService = new BooksService(repository);
var orderRepository = new OrdersRepository();
var orderService = new OrderService(orderRepository);
var command = "";
while(!command.Equals("wyjdz"))
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. dodaj");
    Console.WriteLine("2. usun");
    Console.WriteLine("3. wypisz");
    Console.WriteLine("4. zmien");
    Console.WriteLine("5. dodaj zamowienie");
    Console.WriteLine("6. lista zamowien");
    Console.WriteLine("7. lista zamowien");
    command = Console.ReadLine();
    switch (command)
    {
        case "dodaj":
            booksService.AddBook();
            Console.WriteLine("Press AnyKey");
            Console.ReadKey();
            break;
        case "usun":
            booksService.RemoveBook();          
            Console.WriteLine("Press AnyKey");
            Console.ReadKey();
            break;
        case "wypisz":
            booksService.ListBooks();
            Console.WriteLine("Press AnyKey");
            Console.ReadKey();
            break;
        case "zmien":
            booksService.ChangeState();
            Console.WriteLine("Press AnyKey");
            Console.ReadKey();
            break;
        case "dodaj zamowienie":
            orderService.PlaceOrder();
            Console.WriteLine("Press AnyKey");
            Console.ReadKey();
            break;
        case "lista zamowien":
            orderService.ListAll();
            Console.WriteLine("Press AnyKey");
            Console.ReadKey();
            break;
        default:
            Console.WriteLine("błędne polecenie");
            Console.WriteLine("Press AnyKey");
            Console.ReadKey();
            break;
    }
    Console.Clear();    
}