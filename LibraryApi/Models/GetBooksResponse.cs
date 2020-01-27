using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Models
{
    public class GetBooksResponse : Collection<BookSummaryItem>
    {
        public string Genre { get; set; }
        public int Count { get; set; }
    }

    public class BookSummaryItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
    }





}
