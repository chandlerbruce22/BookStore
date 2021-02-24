using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    //Model for database. Required and key values specified.
    public class Book
    {
        // Required and the primary key for each object.
        [Key]
        [Required]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        //Split author first and last up to help normalize the data and make it easier to query out of.
        public string AuthorFirst { get; set; }
        [Required]
        public string AuthorLast { get; set; }
        [Required]
        public string Publisher { get; set; }
        // ISBN Modeling. Requires a 13 character IBSN for the book to properly display.
        [Required]
        [RegularExpression(@"[0-9]*[-| ][0 - 9]*[-| ] [0-9]*[-| ][0 - 9]*[-| ] [0-9]*", ErrorMessage = "Not a valid ISBN")]
        public string ISBN { get; set; }
        //Split classification and category up to help normalize the data
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        // Pages for each book in the store.
        [Required]
        public int PageNumber { get; set; }
        // Decimals allowed for price formatting.
        [Required]
        public Double Price { get; set; }
    }
}
