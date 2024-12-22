namespace LordOfTheRings.Components;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime Publication_Date { get; set; }
    public List<string> Characters { get; set; }
    public string Url { get; set; }
}