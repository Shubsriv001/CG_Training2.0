using System;
using System.Collections.Generic;
using System.Linq;

public class Book
{
    public int BookId { get; set; }
    public string Name { get; set; }
    public string Publisher { get; set; }
    public double Price { get; set; }

    public Book(int bookId, string name, string publisher, double price)
    {
        BookId = bookId;
        Name = name;
        Publisher = publisher;
        Price = price;
    }

    public void Display()
    {
        Console.WriteLine(
            "ID: " + BookId +
            " | Name: " + Name +
            " | Publisher: " + Publisher +
            " | Price: Rs." + Price);
    }
}

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine("Book added successfully.");
    }

    public void ViewAllBooks()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        foreach (Book book in books)
        {
            book.Display();
        }
    }

    public void UpdateBook(
        int id,
        string name,
        string publisher,
        double price)
    {
        Book book = books.FirstOrDefault(b => b.BookId == id);

        if (book != null)
        {
            book.Name = name;
            book.Publisher = publisher;
            book.Price = price;

            Console.WriteLine("Book updated successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void DeleteBook(int id)
    {
        Book book = books.FirstOrDefault(b => b.BookId == id);

        if (book != null)
        {
            books.Remove(book);
            Console.WriteLine("Book deleted successfully.");
        }
        else
        {
            Console.WriteLine("Book not found.");
        }
    }

    public void SearchByName(string name)
    {
        var result = books
            .Where(b => b.Name.ToLower().Contains(name.ToLower()))
            .ToList();

        if (result.Count == 0)
        {
            Console.WriteLine("No books found.");
            return;
        }

        foreach (Book book in result)
        {
            book.Display();
        }
    }

    public void SearchByPublisher(string publisher)
    {
        var result = books
            .Where(b => b.Publisher.ToLower().Contains(publisher.ToLower()))
            .ToList();

        if (result.Count == 0)
        {
            Console.WriteLine("No books found.");
            return;
        }

        foreach (Book book in result)
        {
            book.Display();
        }
    }

    public void ShowHighestPriceBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        Book book = books.OrderByDescending(b => b.Price).First();

        Console.WriteLine("Highest Priced Book:");
        book.Display();
    }

    public void ShowLowestPriceBook()
    {
        if (books.Count == 0)
        {
            Console.WriteLine("No books available.");
            return;
        }

        Book book = books.OrderBy(b => b.Price).First();

        Console.WriteLine("Lowest Priced Book:");
        book.Display();
    }
}

public class Program
{
    static void Main()
    {
        Library library = new Library();

        dynamic book1 = new
        {
            BookId = 101,
            Name = "C# Programming",
            Publisher = "Microsoft Press",
            Price = 550
        };

        dynamic book2 = new
        {
            BookId = 102,
            Name = "Java Programming",
            Publisher = "Pearson",
            Price = 650
        };

        dynamic book3 = new
        {
            BookId = 103,
            Name = "Python Basics",
            Publisher = "O'Reilly",
            Price = 450
        };

        library.AddBook(new Book(
            book1.BookId,
            book1.Name,
            book1.Publisher,
            book1.Price));

        library.AddBook(new Book(
            book2.BookId,
            book2.Name,
            book2.Publisher,
            book2.Price));

        library.AddBook(new Book(
            book3.BookId,
            book3.Name,
            book3.Publisher,
            book3.Price));

        Console.WriteLine("\n===== ALL BOOKS =====");
        library.ViewAllBooks();

        Console.WriteLine("\n===== SEARCH BY NAME =====");
        library.SearchByName("C#");

        Console.WriteLine("\n===== SEARCH BY PUBLISHER =====");
        library.SearchByPublisher("Pearson");

        Console.WriteLine("\n===== HIGHEST PRICE =====");
        library.ShowHighestPriceBook();

        Console.WriteLine("\n===== LOWEST PRICE =====");
        library.ShowLowestPriceBook();

        Console.WriteLine("\n===== UPDATE BOOK =====");
        library.UpdateBook(
            101,
            "Advanced C# Programming",
            "Microsoft Press",
            750);

        library.ViewAllBooks();

        Console.WriteLine("\n===== DELETE BOOK =====");
        library.DeleteBook(103);

        library.ViewAllBooks();
    }
}
