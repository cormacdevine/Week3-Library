class Book
{
    //Properties 
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

    //Constructor for Book object
    public Book(string bookTitle, string bookAuthor, string bookISBN, int bookNoOfPages)
    {
         Title = bookTitle;
         Author = bookAuthor;
         ISBN = bookISBN;
         NoOfPages = bookNoOfPages;
    }

    void DisplayInfo()
    {
        //output the book information to the conosle
        Console.WriteLine("Book information: ");
        Console.WriteLine("--------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"ISBN: {ISBN}");
        Console.WriteLine($"Number of pages: {NoOfPages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //create a new instance of the Book class
        Book book = new Book("C# for beginners", "Bill Gates", "1112347", 200);

        //another instance
        Book book2 = new Book("Visual Studio 2022", "Microsoft", "123", 70);

        //Output book info to the console
        book.DisplayInfo();
        book2.DisplayInfo();
        
    }

}
