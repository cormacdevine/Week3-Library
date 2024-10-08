class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfPages;

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
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "1322845";
        book.NoOfPages = 200;

        Book book2 = new Book();
        book2.Title = "C# Methods and classes";
        book2.Author = "Microsoft";
        book2.ISBN = "1148567";
        book2.NoOfPages = 50;

        //Output book info to the console
        book.DisplayInfo();
        book2.DisplayInfo();

    }

}
