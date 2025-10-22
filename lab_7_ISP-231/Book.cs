internal class Book
{
    public string Title;
    public string Author;
    public int Year;
    public bool IsAvailable;

    public Book(string title, string author, int year, bool IsAvailable)
    {
        Title = title;
        Author = author;
        Year = year;
        IsAvailable = true;
    }
    public Book()
    {
        Title = "unknown";
        Author = "unknown";
        Year = 0000;
        IsAvailable = true;
    }
    public void PrintIfo()
    {
        Console.WriteLine($"Название: {Title}, Автор: {Author} Год: {Year}, Доступна: {IsAvailable} ");
    }
}