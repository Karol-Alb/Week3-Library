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

        // Output the book information to the console
        Console.WriteLine($"book title; {book.Title}");
        Console.WriteLine($"Book author: {book.Author}");
        Console.WriteLine($"Book ISBn: {book.ISBN}");
    }
}
