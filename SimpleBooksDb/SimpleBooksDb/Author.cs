using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSingleTableDb
{
    /// <summary>
    /// This is the class for the author table 
    /// </summary>
    public class Author
    {
        /// <summary>
        /// This is for the authorId column in the authors table
        /// </summary>
        public long AuthorId { get; set; }

        /// <summary>
        /// This is for the authorName column in the authors table
        /// </summary>
        public string AuthorName { get; set; }
    }
}
