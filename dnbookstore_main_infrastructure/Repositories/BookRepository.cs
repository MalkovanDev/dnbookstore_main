using Dapper;
using Domain.Entities;
using Infrastructure.Dapper;
using Infrastructure.Databases.Dtos;
using Infrastructure.Databases.Interfaces;
using Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly IDatabaseContext _dnBookstoreDbContext;
        private readonly IDapperWrapper _dapperWrapper;

        public BookRepository(IDatabaseContext dnBookstoreDbContext, IDapperWrapper dapperWrapper)
        {
            _dnBookstoreDbContext = dnBookstoreDbContext;
            _dapperWrapper = dapperWrapper;
        }

        public async Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            using (var connection = _dnBookstoreDbContext.CreateConnection())
            {
                return (await _dapperWrapper
                    .QueryAsync<BookDto>(connection, Queries.GetAllBooks))
                    .Select(b => b.Adapt());
            }
        }

        public async Task<Book?> GetBookByIdAsync(Guid bookId)
        {
            using (var connection = _dnBookstoreDbContext.CreateConnection())
            {
                var bookDto = await _dapperWrapper.QueryFirstOrDefaultAsync<BookDto>(connection, Queries.GetBookById, new { BookId = bookId });

                return bookDto?.Adapt();
            }
        }
    }
}
