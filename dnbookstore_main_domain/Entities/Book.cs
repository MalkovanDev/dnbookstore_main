using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public record Book(
        Guid BookId,
        string Title,
        string Genre,
        DateTime PublishedDate,
        Guid AuthorId,
        decimal Price);
}
