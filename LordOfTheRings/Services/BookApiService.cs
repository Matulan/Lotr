using LordOfTheRings.Components;
using LordOfTheRings.Interfaces;

namespace LordOfTheRings.Services;


public class BookApiService : IBookApiService
{
    private readonly HttpClient _httpClient;

    public BookApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Book>> GetBooks()
    {
        try
        {
            var response = await _httpClient.GetFromJsonAsync<BookResult>("https://lotrapi.co/api/v1/books");
            return response?.Results ?? new List<Book>();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av bøker: {ex.Message}");
            return new List<Book>();
        }
    }

    public async Task<Book> GetBookDetail(int id)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Book>($"https://lotrapi.co/api/v1/books/{id}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av bokdetaljer: {ex.Message}");
            return null;
        }
    }
}