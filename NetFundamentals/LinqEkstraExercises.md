### Linq

1. W projekcie utwórz klasę:
```csharp
public class User
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }

    public User(int i, string n, int a)
    {
        ID = i;
        Name = n;
        Age = a;
    }
}
```
1. W metodzie `Main` utwórz listę obiektów klasy `User` o nazwie `list`.
1. Lista powinna zawierać następujące elementy.
```csharp
var list = new List<User>();
list.Add(new User(1, "Bruce", 40));
list.Add(new User(2, "Clark", 34));
list.Add(new User(3, "Kara", 22));
list.Add(new User(4, "Hal", 34));
list.Add(new User(5, "Johnathan", 40));
```
1. Pobierz z kolekcji i przypisz do zmiennych o dowolnych nazwach następujące elementy:
    1. Pierwszego użytkownika, który ma 34 lata.
    1. Użytkownika o identyfikatorze 3.
    1. Użytkowników, który mają ponad 30 lat.
    1. Użytkowników, który mają ponad 50 lat.
    1. Listę imion wszystkich użytkowników.
    1. Dwóch użytkowników, zaczynając od 3.
    1. Użytkowników, który mają 34 i 40 lat.

#### Zadanie 2

1. W projekcie utwórz klasę i typ enum:
```csharp
public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public ProductType Type { get; set; }

    public Product(int id, string name, decimal price, ProductType productType)
    {
        ID = id;
        Name = name;
        Price = price;
        Type = productType;
    }
}

public enum ProductType
{
    Unknown,
    Electronic,
    Clothes
}
```
1. W metodzie `Main` utwórz listę obiektów klasy `Product` o nazwie `list`.
1. Lista powinna zawierać następujące elementy.
```csharp
var list = new List<Product>();
list.Add(new Product(1, "Spodnie", 250, ProductType.Clothes));
list.Add(new Product(2, "Buty", 350, ProductType.Clothes));
list.Add(new Product(3, "Telewizor", 1200, ProductType.Electronic));
list.Add(new Product(4, "Tablet", 3500, ProductType.Electronic));
list.Add(new Product(5, "Laptop", 3200, ProductType.Electronic));
list.Add(new Product(6, "Szklanka", 5, ProductType.Unknown));
```
1. Pobierz z kolekcji i przypisz do zmiennych o dowolnych nazwach następujące elementy:
    1. Produkty elektroniczne droższe niż 3000zł.
    1. Wszystkie produkty elektroniczne.
    1. Produkt o identyfikatorze 3.
    1. Nazwy produktów elektronicznych.
    1. Wszystkie produkty, które nie są elektroniczne.
    1. Wszystkie produkty, których nazwy zaczynają się na `T`.
    1. Ceny wszystkich produktów.