using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Cart
    {
        public List<CartLine> Lines {get; set;} = new List<CartLine>();

        //Adding an item to the cart.
        public virtual void AddItem(Book book, int quantity)
        {
            CartLine line = Lines.Where(b => b.Book.BookId == book.BookId).FirstOrDefault();

            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Book = book,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        //Removing a book from the cart.
        public virtual void RemoveLine(Book book) =>
            Lines.RemoveAll(x => x.Book.BookId == book.BookId);

        //Clearing a cart completely
        public virtual void Clear() => Lines.Clear();

        // Totalling the amount of every item in the cart.
        public decimal ComputeTotalSum()
        {
            return (decimal)Lines.Sum(e => e.Book.Price * e.Quantity);
        }

        // What items we will keep track of in someone's shopping cart.
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Book Book { get; set; }
            public int Quantity { get; set; }
        }
    }
}
