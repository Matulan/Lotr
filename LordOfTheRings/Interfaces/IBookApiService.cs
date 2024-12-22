using LordOfTheRings.Components;

namespace LordOfTheRings.Interfaces;

public interface IBookApiService
{
        Task<List<Book>> GetBooks();
        Task<Book> GetBookDetail(int id);
}