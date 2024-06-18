using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Dapper
{
    public class Queries
    {
        #region dnBookstore Database

        #region Books
        public const string GetAllBooks = @"SELECT * FROM dnbookstore.books";
        public const string GetBookById = @"SELECT * FROM dnbookstore.books WHERE bookid = @BookId";
        #endregion Books

        #endregion dnBookstore Database
    }
}
