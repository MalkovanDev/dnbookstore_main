using Domain.Entities;

namespace Infrastructure.Repositories.Interfaces
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooksAsync();
        Task<Book?> GetBookByIdAsync(Guid bookId);
    }
}