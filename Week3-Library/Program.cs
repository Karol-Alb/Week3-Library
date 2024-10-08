class Book
{
    // Properties
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    // Constructor for Book object
    // add a new instance of the book class 
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
        Title = bookTitle;
        Author = bookAuthor;
        ISBN = bookISBN;
        NoOfPages = bookNoOfPages;
    }

    void DisplayInfo()
    {
        // Output the book information to the console
        Console.WriteLine("Book information");
        Console.WriteLine("----------------");
        Console.WriteLine($"book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBn: {ISBN}");
        Console.WriteLine($"Book NoOfPages: {NoOfPages}"); 
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        // Create a new instance for the book class
        Book book = new Book("C# for beginners", "Bill Gates", "1234566", 200);

        // another isntance?
        // title = "Visual studio 2022"
        // ISBN "123"
        // No Of Pages

        Book book1 = new Book("Visual Studio 2022", "Microsoft", "123", 70);

        // Output book info to the console
        book.DisplayInfo();
        book1.DisplayInfo();

    }
}
