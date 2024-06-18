using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Ports
{
    public interface IBookService
    {
        public Task<IEnumerable<Book>> GetAllBooksAsync();
        public Task<Book?> GetBookByIdAsync(Guid bookId);
    }
}
