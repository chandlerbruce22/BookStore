using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class EFBookRepository : iBookRepository
    {
        //Context is initialized and sent to IQueryable Book
        private BookDbContext _context;

        public EFBookRepository (BookDbContext context)
        {
            _context = context;
        }

        public IQueryable<Book> Books => _context.Books;
    }
}
