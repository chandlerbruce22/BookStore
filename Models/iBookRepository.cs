using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    //Interface for the book class
    public interface iBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}
