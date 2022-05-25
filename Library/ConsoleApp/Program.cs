using ConsoleApp;
using Persistence;

Console.WriteLine("Podaj login!");
var login = Console.ReadLine();
Console.WriteLine("Podaj hasło!");
var password = Console.ReadLine();

Authorization(login, password);
var repository = new BooksRepository();
var booksService = new BooksService(repository);
var orderRepository = new OrdersRepository();
var orderService = new OrderService(orderRepository);
var procesor = new Procesor();
procesor.RegisterNewAction(new Command("dodaj", "dodaj książkę"), new Handler(() => booksService.AddBook()));
procesor.RegisterNewAction(new Command("usun", "usun książkę"), new Handler(() => booksService.RemoveBook()));
procesor.RegisterNewAction(new Command("wypisz", "wypisz książkę"), new Handler(() => booksService.ListBooks()));
procesor.RegisterNewAction(new Command("zmien", "zmien stan"), new Handler(() => booksService.ChangeState()));
procesor.RegisterNewAction(new Command("dodaj zamowienie", "dodaj zamowienie"), new Handler(() => orderService.PlaceOrder()));
procesor.RegisterNewAction(new Command("lista zamowien", "lista zamowien"), new Handler(() => orderService.ListAll()));
procesor.RegisterNewAction(new Command("wyjdz", "wyjdz"), new Handler(() => Environment.Exit(0)));
var command = "";
while(!command.Equals("wyjdz"))
{
    NewMenuDisplay(procesor, command);
    command = Console.ReadLine();
}

static void DisplayMenu()
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. dodaj");
    Console.WriteLine("2. usun");
    Console.WriteLine("3. wypisz");
    Console.WriteLine("4. zmien");
    Console.WriteLine("5. dodaj zamowienie");
    Console.WriteLine("6. lista zamowien");
    Console.WriteLine("7. lista zamowien");
}

static void Authorization(string login, string password)
{
    if (login == "Admin" && password == "password")
    {
        Console.WriteLine("Access Granted");
    }
    else
    {
        Console.WriteLine("Access Denied");
    }
}

static void NewMenuDisplay(Procesor procesor, string? command)
{
    while (!command.Equals("wyjdz"))
    {
        Console.WriteLine(procesor.GetAllCommandsWithDescription());
        command = Console.ReadLine();
        procesor.HandlerCommand(command);
        Console.Clear();
    }
}

static void OldMenuDisplay(BooksService booksService, OrderService orderService, string? command)
{
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
}