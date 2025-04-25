using System;
using System.Collections.Generic;

class Author
{
    public string Name { get; set; }
    public string Bio { get; set; }
    public DateTime DateOfBirth { get; set; }
}

class Book
{
    public string Title { get; set; }
    public string ISBN { get; set; }
    public string Genre { get; set; }
    public double Price { get; set; }
    public List<Author> Authors { get; set; } = new List<Author>();
}

class Library
{
    public List<Book> Books { get; set; } = new List<Book>();

    public void DisplayBooks()
    {
        foreach (var book in Books)
        {
            Console.WriteLine($"Title: {book.Title}, Genre: {book.Genre}, Price: {book.Price}");
            Console.WriteLine("Authors:");
            foreach (var author in book.Authors)
            {
                Console.WriteLine($" - {author.Name} (Born: {author.DateOfBirth.ToShortDateString()})");
            }
        }
    }

    public double CalculateTotalPrice()
    {
        double total = 0;
        foreach (var book in Books)
        {
            total += book.Price;
        }
        return total;
    }

    static void Main()
    {
        var author1 = new Author { Name = "Author A", Bio = "Writes fiction", DateOfBirth = new DateTime(1980, 1, 1) };
        var author2 = new Author { Name = "Author B", Bio = "Writes sci-fi", DateOfBirth = new DateTime(1975, 5, 20) };

        var book1 = new Book
        {
            Title = "Book One",
            ISBN = "123456",
            Genre = "Fiction",
            Price = 15.99,
            Authors = new List<Author> { author1 }
        };

        var book2 = new Book
        {
            Title = "Book Two",
            ISBN = "789012",
            Genre = "Sci-Fi",
            Price = 25.50,
            Authors = new List<Author> { author2, author1 }
        };

        var library = new Library();
        library.Books.Add(book1);
        library.Books.Add(book2);

        library.DisplayBooks();
        Console.WriteLine("Total cost of all books: " + library.CalculateTotalPrice());
    }
}
