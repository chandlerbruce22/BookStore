using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Infrastructure;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookStore.Pages
{
    public class BuyModel : PageModel
    {
        private iBookRepository repository;
        public BuyModel (iBookRepository repo, Cart cartService)
        {
            repository = repo;
            Cart = cartService;
        }
        // Variables of cart, returnurl and onget.

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet (string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        // Action of adding a book to the cart.
        public IActionResult OnPost(long bookId, string returnUrl)
        {
            Book book = repository.Books
                .FirstOrDefault(p => p.BookId == bookId);
            Cart.AddItem(book, 1);
            return RedirectToPage(new { returnUrl = returnUrl });
        }

        //Action of removing a book from the cart.
        public IActionResult OnPostRemove(long bookId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Book.BookId == bookId).Book);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
