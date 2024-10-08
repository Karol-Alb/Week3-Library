class Book
{
    string Title;
    string Author;
    string ISBN;

    void DisplayInfo()
    {
        // Output the book information to the console
        Console.WriteLine("Book information");
        Console.WriteLine("----------------");
        Console.WriteLine($"book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBn: {ISBN}");
        Console.WriteLine();
    }

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

        // Output book info to the console
        book.DisplayInfo();
        book2.DisplayInfo();

    }
}
