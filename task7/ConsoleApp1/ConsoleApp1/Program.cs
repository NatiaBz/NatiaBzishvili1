using System;
using System.Collections.Generic;
using System.Linq;

class Book
{
    // wignis klasis properties
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    // konstruktori
    public Book(string title, string author, int year)
    {
        Title = title;
        Author = author;
        Year = year;
    }
}

class Library
{
    // private veli
    private List<Book> books = new List<Book>();

    // Property, romelic abrunebs cignebis raodenobas
    public int Count
    {
        get { return books.Count; }
    }

    // metodi romelic abrunebs axal wigns bibliotekashi
    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"cigni '{book.Title}' avtoris {book.Author} damatebuli iyo bibliotekashi.");
    }

    // metodi romelic cashlis cigns
    public void RemoveBook(string title)
    {
        // wignis dzebna saxelit
        var bookToRemove = books.FirstOrDefault(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

        // Tu wigni arsebobs waSla
        if (bookToRemove != null)
        {
            books.Remove(bookToRemove);
            Console.WriteLine($"cigni '{title}' washlilia bibliotekidan.");
        }
        else
        {
            // Tu wigni ar moiZebna
            Console.WriteLine($"cigni sakhelit '{title}' ver moiZebna.");
        }
    }

    // metodi romelic moZebnis wigns saxelis mixedvit
    public List<Book> FindBook(string title)
    {
        // vabrunebt cignebs romelshic ar shedis gadmocemuli sityva
        return books.Where(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();
    }

    // metodi romelic yvela cigns bewdavs
    public void PrintBooks()
    {
        // tu biblioteka carielia
        if (books.Count == 0)
        {
            Console.WriteLine("bibliotekashi cignebi ar arsebobs.");
            return;
        }

        // ყველა წიგნის დაბეჭდვა
        Console.WriteLine("\nbibliotekashi arsebuli cignebi:");
        foreach (var book in books)
        {
            Console.WriteLine($"cigni: {book.Title}, avtori: {book.Author}, celi: {book.Year}");
        }
    }
}

class Program
{
    static void Main()
    {
        // bibliotekis klasis opebieqtis sheqmna
        Library library = new Library();

        // cignebis damateba bibliotekashi
        library.AddBook(new Book("1984", "George Orwell", 1949));
        library.AddBook(new Book("The Catcher in the Rye", "J.D. Salinger", 1951));
        library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
        library.AddBook(new Book("1984", "George Orwell", 1949)); // ertnairi saxelis mqone cigni

        // dabchdavs bibliotekashi arsebul wignebs
        library.PrintBooks();

        // dabewdavs raodenobas
        Console.WriteLine($"\nbibliotekashi cignebis raodenoba: {library.Count}");

        // saxelit Zebna cignis "1984"
        string searchTitle = "1984";
        var foundBooks = library.FindBook(searchTitle);
        Console.WriteLine($"\nwignebi saxelit '{searchTitle}':");
        foreach (var book in foundBooks)
        {
            Console.WriteLine($"cigni: {book.Title}, avtori: {book.Author}, celi: {book.Year}");
        }

        // waSale cigni saxeliT "1984"
        library.RemoveBook("1984");

        // dabechdavs cashlis shemdeg darchenil cignebs
        library.PrintBooks();

        // dabechdavs cashlis Semdeg cignebis raodenobas
        Console.WriteLine($"\nbibliotekashi cignebis raodenoba cashlis shemdeg: {library.Count}");
    }
}
