using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSingleTableDb
{
    public class BooksWithAuthorName
    {
        public string BookTitle { get; set; }
        public string BookGenre { get; set; }
        public string AuthorName { get; set; }
        public long BookId { get; set; }
    }
}
