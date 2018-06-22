using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSingleTableDb
{
    /// <summary>
    /// This is the class for the BooksWithAuthor view, the view joins the books and authors tables
    /// </summary>
    public class BooksWithAuthorName
    {
        /// <summary>
        /// This is for the bookTitle column in the books table
        /// </summary>
        public string BookTitle { get; set; }

        /// <summary>
        /// This is for the bookTitle column in the books table
        /// </summary>
        public string BookGenre { get; set; }

        /// <summary>
        /// This is for the authorName column in the authors table
        /// </summary>
        public string AuthorName { get; set; }

        /// <summary>
        /// This is for the bookId column in the books table
        /// </summary>
        public long BookId { get; set; }
    }
}
