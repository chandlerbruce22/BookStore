﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Data used to originally populate the database.
//Displays all books that are listed wtihin Professors Hilton's favorites.

namespace BookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated (IApplicationBuilder application)
        {
            BookDbContext context = application.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<BookDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.Books.Any())
            {
                context.Books.AddRange(
                    new Book
                    {
                        Title = "Les Miserables",
                        AuthorFirst = "Victor",
                        AuthorLast = "Hugo",
                        Publisher = "Signet",
                        ISBN = "978-0451419439",
                        Classification = "Fiction",
                        Category = "Classic",
                        PageNumber = 1488,
                        Price = 9.95
                    },

                    new Book
                    {
                        Title = "Team of Rivals",
                        AuthorFirst = "Doris Kearns",
                        AuthorLast = "Goodwin",
                        Publisher = "Simon & Schuster",
                        ISBN = "978-0743270755",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        PageNumber = 944,
                        Price = 14.58
                    },

                    new Book
                    {
                        Title = "The Snowball",
                        AuthorFirst = "Alice",
                        AuthorLast = "Schroder",
                        Publisher = "Bantam",
                        ISBN = "978-0553384611",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        PageNumber = 832,
                        Price = 21.54
                    },

                    new Book
                    {
                        Title = "American Ulysses",
                        AuthorFirst = "Ronald C.",
                        AuthorLast = "White",
                        Publisher = "Random House",
                        ISBN = "978-0812981254",
                        Classification = "Non-Fiction",
                        Category = "Biography",
                        PageNumber = 864,
                        Price = 11.61
                    },

                    new Book
                    {
                        Title = "Unbroken",
                        AuthorFirst = "Laura",
                        AuthorLast = "Hillenbrand",
                        Publisher = "Random House",
                        ISBN = "978-0812974492",
                        Classification = "Non-Fiction",
                        Category = "Historical",
                        PageNumber = 528,
                        Price = 13.33
                    },

                    new Book
                    {
                        Title = "The Great Train Robbery",
                        AuthorFirst = "Michael",
                        AuthorLast = "Crichton",
                        Publisher = "Vintage",
                        ISBN = "978-0804191281",
                        Classification = "Fiction",
                        Category = "Historical Fiction",
                        PageNumber = 288,
                        Price = 15.95
                    },

                    new Book
                    {
                        Title = "Deep Work",
                        AuthorFirst = "Cal",
                        AuthorLast = "Newport",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455586691",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        PageNumber = 304,
                        Price = 14.99
                    },

                    new Book
                    {
                        Title = "It's Your Ship",
                        AuthorFirst = "Michael",
                        AuthorLast = "Abrashoff",
                        Publisher = "Grand Central Publishing",
                        ISBN = "978-1455523023",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        PageNumber = 240,
                        Price = 21.66
                    },

                    new Book
                    {
                        Title = "The Virgin Way",
                        AuthorFirst = "Richard",
                        AuthorLast = "Branson",
                        Publisher = "Portfolio",
                        ISBN = "978-1591847984",
                        Classification = "Non-Fiction",
                        Category = "Business",
                        PageNumber = 400,
                        Price = 29.16
                    },

                    new Book
                    {
                        Title = "Sycamore Row",
                        AuthorFirst = "John",
                        AuthorLast = "Grisham",
                        Publisher = "Bantam",
                        ISBN = "978-1591847984",
                        Classification = "Fiction",
                        Category = "Thrillers",
                        PageNumber = 642,
                        Price = 15.03
                    },

                    new Book
                    {
                        Title = "American Sniper",
                        AuthorFirst = "Chris",
                        AuthorLast = "Kyle",
                        Publisher = "William Morrow and Company",
                        ISBN = "978-0062082350",
                        Classification = "Non-Fiction",
                        Category = "Historical Fiction",
                        PageNumber = 400,
                        Price = 9.31
                    },

                    new Book
                    {
                        Title = "Grit",
                        AuthorFirst = "Angela",
                        AuthorLast = "Duckworth",
                        Publisher = "Scribner Book",
                        ISBN = "978-1501111105",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        PageNumber = 352,
                        Price = 19.04
                    },

                    new Book
                    {
                        Title = "Never Split the Difference",
                        AuthorFirst = "Chris",
                        AuthorLast = "Voss",
                        Publisher = "Harper Business",
                        ISBN = "978-0062407801",
                        Classification = "Non-Fiction",
                        Category = "Self-Help",
                        PageNumber = 288,
                        Price = 18.69
                    }

                );

                context.SaveChanges();
            }

        }
    }
}
