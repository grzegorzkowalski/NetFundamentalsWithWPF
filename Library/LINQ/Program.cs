using LINQ;

var list = new List<Product>();
list.Add(new Product(1, "Spodnie", 250, ProductType.Clothes));
list.Add(new Product(2, "Buty", 350, ProductType.Clothes));
list.Add(new Product(3, "Telewizor", 1200, ProductType.Electronic));
list.Add(new Product(4, "Tablet", 3500, ProductType.Electronic));
list.Add(new Product(5, "Laptop", 3200, ProductType.Electronic));
list.Add(new Product(6, "Szklanka", 5, ProductType.Unknown));

var expensive = list.Where(x => x.Price > 3000);

foreach (var item in expensive)
{
    Console.WriteLine(item.Name);
}

var electronic = list.Where(s => s.Type == ProductType.Electronic);

foreach (var item in electronic)
{
    Console.WriteLine(item.Name);
}

var three = list.Where(s => s.ID == 3);




/*
 * 1. Pobierz z kolekcji i przypisz do zmiennych o dowolnych nazwach następujące elementy:
    1. Produkty elektroniczne droższe niż 3000zł.
    1. Wszystkie produkty elektroniczne.
    1. Produkt o identyfikatorze 3.
    1. Nazwy produktów elektronicznych.
    1. Wszystkie produkty, które nie są elektroniczne.
    1. Wszystkie produkty, których nazwy zaczynają się na `T`.
    1. Ceny wszystkich produktów.
 */