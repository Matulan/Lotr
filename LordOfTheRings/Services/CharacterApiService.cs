using LordOfTheRings.Components;
using LordOfTheRings.Interfaces;

namespace LordOfTheRings.Services;

public class CharacterApiService : ICharacterApiService
{
    private readonly HttpClient _httpClient;

    public CharacterApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public async Task<List<Character>> GetCharacters()
    {
        try
        {
            var response = await _httpClient.GetFromJsonAsync<CharacterResult>("https://lotrapi.co/api/v1/characters");
            return response?.Results ?? new List<Character>(); 
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av karakterer: {ex.Message}");
            return new List<Character>();
        }
    }

    public async Task<Character> GetCharacterDetail(int id)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Character>($"https://lotrapi.co/api/v1/characters/{id}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av karakterdetaljer: {ex.Message}");
            return null;
        }    }

    public async Task<Realm> GetRealm(string url)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Realm>(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av realm: {ex.Message}");
            return null;
        }
    }

    public async Task<Species> GetSpecies(string url)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Species>(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av species: {ex.Message}");
            return null;
        }
    }

    public async Task<Race> GetRace(string url)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Race>(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av species: {ex.Message}");
            return null;
        }
    }

    public async Task<Group> GetGroup(string url)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Group>(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av species: {ex.Message}");
            return null;
        }    }

    public async Task<Language> GetLanguage(string url)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Language>(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av species: {ex.Message}");
            return null;
        }    }

    public async Task<Film> GetFilm(string url)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Film>(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av species: {ex.Message}");
            return null;
        }    }

    public async Task<Book> GetBook(string url)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Book>(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av species: {ex.Message}");
            return null;
        }    }

    public async Task<Character> GetCharacterDetailByUrl(string url)
    {
        try
        {
            return await _httpClient.GetFromJsonAsync<Character>(url);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Feil under henting av karakterdetaljer fra URL: {ex.Message}");
            return null;
        }
    }
}