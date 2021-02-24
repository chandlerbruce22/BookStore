using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
    public class PagingInfo
    {
        //Initialize how many books will be in the list
        public int TotalNumItems { get; set; }
        // How many books I want to appear per page
        public int ItemsPerPage { get; set; }
        // Which page I am currently viewing
        public int CurrentPage { get; set; }
        //Math function to ensure whole integer while determining the total pages
        public int TotalPages => (int)(Math.Ceiling((decimal) TotalNumItems / ItemsPerPage));

    }
}
