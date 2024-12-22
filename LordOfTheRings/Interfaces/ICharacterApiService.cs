using LordOfTheRings.Components;

namespace LordOfTheRings.Interfaces;

public interface ICharacterApiService
{
    Task<List<Character>> GetCharacters();
    Task<Character> GetCharacterDetail(int id);
    Task<Realm> GetRealm(string url);
    Task<Species> GetSpecies(string url);
    Task<Race> GetRace(string url);
    Task<Group> GetGroup(string url);
    Task<Language> GetLanguage(string url);
    Task<Film> GetFilm(string url);
    Task<Book> GetBook(string url);
    Task<Character> GetCharacterDetailByUrl(string url);
}