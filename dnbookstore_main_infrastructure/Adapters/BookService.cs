using Domain.Entities;
using Domain.Ports;
using Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Adapters
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Task<IEnumerable<Book>> GetAllBooksAsync()
        {
            return _bookRepository.GetAllBooksAsync();
        }

        public Task<Book?> GetBookByIdAsync(Guid bookId)
        {
            return _bookRepository.GetBookByIdAsync(bookId);
        }
    }
}
