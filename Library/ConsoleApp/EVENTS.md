### Rozdział 1 - Delegate

#### Zadanie 1

1. Utwórz delegata o nazwie `Vat`.
1. Delegat powinien przyjmować parametr typu `decimal` o nazwie `amount`.
1. Delegat powinien zwracać liczbę typu `decimal`.
1. Utwórz klasę `Tax` z metodą `AddVat`, polem delegata typu `Vat` o nazwie `PlusVat`.
1. Metoda powinna przyjmować parametr typu decimal o nazwie `amount` i zwracać typ `decimal`.
1. Metoda powinna wywoływać delegata `PlusVat` podając mu parametr `amount` i zwracać wynik delegata.
1. W razie gdy delegat nie wskazuje na żadną funkcję, metoda powinna zwrócić kwotę podaną w parametrze.
1. W metodzie `Main` utwórz obiekt klasy `Tax`.
1. Do delegata obiektu `Tax` przypisz wyrażenie lambda, które doda do 23% do kwoty z parametru.
1. Sprawdź działanie metody `AddVat`, a wynik wyświetl w konsoli.

#### Zadanie 2

1. W klasie `Program` utwórz delegata statycznego typu `Func` z jednym typem zwracanym `int` o nazwie `Summary`.
1. W metodzie `Main` przypisz do delegata cztery wyrażenia lambda, które zwrócą różne wartości.
1. Utwórz zmienną typu `int` o nazwie `sum`, która zsumuje wszystkie wartości zwrócone przez funkcje przypisane do delegata.

#### Zadanie 3

1. W klasie `Program` utwórz delegata statycznego typu `Func` z jednym typem zwracanym i jednym parametrem typu `string`.
1. W metodzie `Main` przypisz do delegata wyrażenie lambda, które przyjmie dowolny ciąg znaków, a zwróci go w odwrotnej kolejności. Na przykład przy parametrze `Amy` zwrócą `ymA`.
1. Sprawdź działanie delegata z dowolnym tekstem, a wynik wyświetl w konsoli.

#### Zadanie 4

1. Utwórz klasę o nazwie `Counter`.
1. W klasie utwórz publiczną właściwość o nazwie `Current` typu `int` oraz prywatne pole tego samego typu o nazwie `_current`, do którego właściwość będzie zapisywać oraz, z którego będzie odczytywać dane.
1. W klasie utwórz delegat o nazwie `NumberChanged` typu `Action` z dwoma parametrami typu `int`.
1. Metoda `set` właściwości `Current` powinna wywołać delegata `NumberChanged` i przekazać do niego wcześniejszą liczbę oraz nowo przypisywaną. Delegat powinien być wywołany po przypisaniu liczby do pola `_current`.
1. Metoda `get` powinna pozostać bez zmian.
1. W metodzie `Main` utwórz obiekt klasy `Counter` o nazwie `counter`, a do delegata tego obiektu przypisz wyrażenie lambda, które będzie wyświetlać w konsoli informacje o zmianie wartość właściwości `Current` w formacie: `Było: 12, Jest: 14`.
1. Zmień kilka razy wartość w obiekcie.

### Rozdział 2 - Function

#### Zadanie 1

1. W metodzie `Main` utwórz funkcję lokalną o nazwie `even`.
1. Funkcja powinna przyjmować parametr typu `int` o nazwie `number` i zwracać typ `string` z informacją czy liczba jest parzysta czy nie.
1. Sprawdź działanie funkcji z kilkoma różnymi parametrami, a wyniki wyświetl na ekranie.

#### Zadanie 2

1. W metodzie `Main` utwórz kolekcję typu `List<string>` o nazwie `names` wraz z przykładowymi danymi:
```
Basia
Kasia
Zosia
Bruce
Victor
```
1. Pobierz imię zaczynające się na literę `Z` używając metody `Single`, która jest częścią biblioteki `Linq`. Metoda pobiera wyrażenie lambda, które sprawdza warunek każdego obiektu w kolekcji w zwraca ten, który zwróci `true`. Pobrane imię wyświetl w konsoli.

---

#### Zadanie 2.1

1. Za pomocą metody `Add` powiększ listę o imię `Zbyszek`.
1. Uruchom program i zobacz rezultaty.

#### Zadanie 2.2

1. Usuń z pomocą metody `Remove` imiona zaczynające się na `Z`.
1. Uruchom program i zobacz rezultaty.

#### Zadanie 2.3

1. Przy pomocy metody `Clear` usuń wszystkie wartość z listy.
1. Uruchom program i zobacz rezultaty.

#### Zadanie 3

1. W metodzie `Main` utwórz delegata `Func<int, int>` o nazwie `increase`, do którego przypisz wyrażenie lambda, które zwróci podaną w parametrze wartość zwiększoną o dwa.
1. Sprawdź działanie delegata przekazując trzy różne argumenty i wyświetlając je w konsoli.

#### Zadanie 4

1. W metodzie `Main` utwórz delegata typu `Func`.
1. Delegat powinien przyjmować dwa parametry typu `string` i zwracać typ `int`.
1. Do delegata przypisz metodę anonimową, która porówna długości ciągów znaków i zwróci:
    1. `1` jeśli pierwszy ciąg jest dłuższy.
    1. `0` jeśli ciągu są równe.
    1. `-1` jeśli drugi ciąg jest większy.
1. Sprawdź działanie delegata na przykładowych dannych, a wyniki wyświetl w konsoli.

### Rozdział 3 - Event

#### Zadanie 1

1. Utwórz klasę o nazwie `Users`.
1. W klasie utwórz prywatną kolekcję typu `List<string>` o nazwie `_users`.
1. Utwórz metodę `void Add(string login)`, która będzie przyjmować parametr typu `string` o nazwie `login`. Parametr `login` powinien zostać dodany do listy `_users`.
1. W klasie utwórz zdarzenie o nazwie `UserAdded` typu `Action` z jednym parametrem typu `string`.
1. Przerób metodę `Add` w taki sposób, aby po dodaniu użytkownika wywoływała zdarzenie `UserAdded`. Przed wywołaniem sprawdź czy zdarzenie subskrybuje funkcje do wywołania.
1. W metodzie `Main` utwórz obiekt klasy `Users` o nazwie `users` i wyrażenie lambda wyświetlające podany argument w konsoli, który subskrybuje zdarzenie `UserAdded`.
1. Sprawdź działanie metody `Add`.

#### Zadanie 1.1

1. W klasie `Users` utwórz metodę `Remove` a parametrem `string` o nazwie `login`.
1. W klasie `Users` utwórz zdarzenie `UserRemoved` typu `Action` z jednym parametrem typu `string`.
1. Metoda `Remove` powinna usuwać użytkownika o podanym loginie z listy i wywoływać zdarzenie `UserRemoved` przekazując do niego usunięty login.
1. Sprawdź działanie zdarzenia `UserRemoved` subskrybując je tym samym wyrażeniem lambda i  usuwając użytkownika metodą `Remove`.

#### Zadanie 2

1. Utwórz klasę o nazwie `WordBuilder`. Klasa będzie pozwalała tworzyć wyraz litera po literze.
1. W klasie utwórz publiczną właściwość tylko do odczytu typu `StringBuilder` o nazwie `Word`.
1. W klasie utwórz metodę `AddChar`, która będzie posiadała jeden parametr typu `char`.
1. W klasie utwórz zdarzenie typu `Func` o nazwie `CharAdding` z następującymi właściwościami.
    1. Typem zwracanym `bool`, którego wartość będzie informować czy dodać znak do tworzonego wyrazu.
    1. Trzema parametrami do których przekazywane będą następujące informacje.
        1. Aktualnie przechowywany wyraz.
        1. Długość aktualnego wyrazu.
        1. Nowo dodawana litera.
1. Metoda `AddChar` powinna wywoływać zdarzenie `CharAdding`, do którego przekaże odpowiednie parametry, a od wyniku wywołania zdarzenia uzależnia dodanie kolejnego znaku do tworzonego wyrazu.
1. W metodzie `Main` utwórz obiekt klasy `WordBuilder` o nazwie `wordBuilder` i do zdarzenia `CharAdding` przypisz wyrażenie lambda, które będzie dodawało znak do wyrazu jeśli będzie on znakiem alfanumerycznym.
1. Sprawdź metodę `AddChar` wywołując ją kilka razy z następującymi znakami: `aa%$4 AD%`.
1. Utworzony wyraz z właściwość `Word` wyświetl w konsoli.

### Rozdział 4 - Exception

#### Zadanie 1

1. W metodzie `Main` wyświetl komunikat proszący o wpisanie wieku o treści `Wpisz Wiek:`.
1. Utwórz zmienną typu `int` o nazwie `age`, która powinna zostać zainicjowana wartością podaną przez użytkownika.
1. Aby skonwertować jeden typ na drugi możesz skorzystać z klasy `Convert`. Jest to klasa statyczna.
1. W konsoli wyświetl wiek pomnożony przez 2.
1. Sprawdź działanie programu.
1. Uruchom ponownie program w zamiast liczby wpisz tekst. Program wyrzuci nieobsługiwany wyjątek i zakończy działanie.
1. Uruchom program w trybie debugowania i zobacz jaki wyjątek jest rzucany.
1. Umieść instrukcję rzucającą wyjątek w bloku `try catch` i obsłuż go.
1. Obsługa wyjątku powinna polegać na wyświetleniu komunikatu z informacją `Wiek Nieprawidłowy.`.
1. Sprawdź działanie programu w trybie debugowania.

#### Zadanie 2

1. W metodzie `Main` utwórz pętlę `while` z warunkiem `true`.
1. W pętli wyświetl komunikat o treści `Wpisz Polecenie:`, pobierz tekst i jeśli:
    1. Jest on równy słowie `exit` opuść pętle i zakończ działanie programu.
    1. Jest on równy słowie `div`.
        1. Pobierz dwie liczby do dwóch zmiennych o nazwach `a` i `b`. Wpisanie liczb poprzedź odpowiednimi komunikatami o treści `Wpisz Pierwszą Liczbę:` i `Wpisz Drugą Liczbę:`.
        1. Zmienne powinny być typu `int`.
        1. Podziel zmienne przez siebie, a wynik wyświetl w konsoli.
        1. Uruchom program zobacz działanie programu kiedy wykonamy dzielenie przez `0`.
        1. Zabezpiecz operację dzielenia blokiem `try catch` przechwytując odpowiedni typ wyjątku. Jaki typ wyjątku rzuca błąd dzielenia przez zero możesz sprawdzić uruchamiając program w trybie debugowania.
        1. Obsługa wyjątku powinna polegać na wyświetleniu komunikatu `Nie Można Dzielić Przez Zero.` i zamknięciu programu.
        
#### Zadanie 2.1

1. Utwórz kolejny blok `catch` z obsługą wyjątku na wypadek nieprawidłowego rzutowanie pobranych wartości na typ `int`.
1. Obsługa wyjątku powinna polegać na wyświetleniu komunikatu o treści `Nieprawidłowy Format Danych.`.

#### Zadanie 3

1. W metodzie `Main` utwórz pętlę `while` z warunkiem `true`.
1. Przed pętlą utwórz kolekcję typu `List<string>` o nazwie `texts`.
1. W pętli wyświetl komunikat `Wpisz Komendę:`, pobierz tekst, w zależności od tekstu program powinien:
    1. `exit` opuścić pętle i zakończyć działanie.
    1. `add` pobrać tekst i dodać go do listy.
    1. `get` pobrać numer indeksu i wyświetlić tekst znajdujący się pod wybranym indeksem.
1. Zabezpiecz program przed podaniem indeksu wychodzącego poza kolekcję przechwytując odpowiedni typ wyjątku.
1. Obsługa wyjątku powinna polegać na wyświetleniu komunikatu `Nieprawidłowy Indeks`.

#### Zadanie 4

1. Utwórz własny wyjątek o nazwie `WrongNameException` wraz z konstruktorem przyjmującym komunikat wyjątku.
1. Utwórz klasę o nazwie `User`, wraz z konstruktorem, który przyjmie jeden argument typu `string` o nazwie `name`. Parametr przypisz do właściwości tylko do odczytu o nazwie `Name`.
1. W konstruktorze sprawdź czy parametr spełnia następujące warunki:
    1. Czy imię i nazwisko składa się z minimum dwóch wyrazów.
    1. Czy imię i nazwisko zaczynają się od dużych liter.
1. Jeśli jeden z warunków nie zostanie spełniony rzuć wyjątek podając odpowiedni komunikat.