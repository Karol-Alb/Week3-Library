class Book
{
    string Title;
    string Author;
    string ISBN;

    static void Main(string[] args)
    {
        // Create a new instance for the book class
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "12356677";

        Book book2 = new Book();
        book2.Title = "C# methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "1234566";

        // Output the book information to the console
        Console.WriteLine($"book title: {book.Title}");
        Console.WriteLine($"Book author: {book.Author}");
        Console.WriteLine($"Book ISBn: {book.ISBN}");

        // Output second book information
        Console.WriteLine($"booke title: {book2.Title}");
        Console.WriteLine($"book author: {book2.Author}");
        Console.WriteLine($"book ISBN: {book2.ISBN}");



    }
}
