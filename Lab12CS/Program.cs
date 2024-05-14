using System;

// а) Интерфейс "Издательство"
interface IPublisher
{
    string BookName { get; set; }
    string Author { get; set; }
}

// б) Интерфейс-наследник "Книга"
interface IBook : IPublisher
{
    DateTime PublicationDate { get; set; }
    int PageCount { get; set; }
}

// в) Класс, реализующий интерфейс "Книга"
class Book : IBook
{
    public string BookName { get; set; }
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }
    public int PageCount { get; set; }
}

// г) Интерфейс "Пользователь"
interface IUser
{
    string Login { get; set; }
    string Password { get; set; }
}

// д) Класс, реализующий интерфейс "Пользователь"
class User : IUser
{
    public string Login { get; set; }
    public string Password { get; set; }
}

// е) Класс, реализующий интерфейсы "Товар" и "Пользователь"
class ProductUser : IBook, IUser
{
    public string BookName { get; set; }
    public string Author { get; set; }
    public DateTime PublicationDate { get; set; }
    public int PageCount { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }

    public void BuyBook()
    {
        Console.WriteLine($"{Login} купил книгу '{BookName}' от {Author}.");
    }
}

class Program
{
    static void Main()
    {
        // Создание экземпляров класса "Книга"
        Book book1 = new Book
        {
            BookName = "Книга 1",
            Author = "Автор 1",
            PublicationDate = new DateTime(2022, 5, 1),
            PageCount = 200
        };

        Book book2 = new Book
        {
            BookName = "Книга 2",
            Author = "Автор 2",
            PublicationDate = new DateTime(2023, 3, 15),
            PageCount = 300
        };

        // Создание экземпляров класса "Пользователь"
        User user1 = new User
        {
            Login = "user1",
            Password = "password1"
        };

        User user2 = new User
        {
            Login = "user2",
            Password = "password2"
        };

        // Создание экземпляра класса, реализующего интерфейсы "Товар" и "Пользователь"
        ProductUser productUser = new ProductUser
        {
            BookName = "Книга 3",
            Author = "Автор 3",
            PublicationDate = new DateTime(2024, 1, 1),
            PageCount = 400,
            Login = "client",
            Password = "password3"
        };

        // Вызов метода "BuyBook"
        productUser.BuyBook();
    }
}
