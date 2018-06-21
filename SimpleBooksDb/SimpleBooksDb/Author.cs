using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this is meant to be the backend. yes it is a crude and simple example
namespace BooksSingleTableDb
{
    public class Author
    {
        public long AuthorId { get; set; }
        public string AuthorName { get; set; }
    }
}
