using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Databases.Dtos
{
    public record BookDto(
        Guid BookId,
        string Title,
        string Genre,
        DateTime PublishedDate,
        Guid AuthorId,
        decimal Price)
    {
        public Book Adapt()
        {
            return new Book(BookId, Title, Genre, PublishedDate, AuthorId, Price);
        }
    }
}
