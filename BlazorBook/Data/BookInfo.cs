using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBook.Data
{
    public class BookInfo
    {
        public string Title { get; set; }
        public DateTime PublictionDate { get; set; }
        public string Author { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
    }
}
