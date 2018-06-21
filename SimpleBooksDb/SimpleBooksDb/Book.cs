using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this is meant to be the backend. yes it is a crude and simple example
namespace BooksSingleTableDb
{
    public class Book
    {
        public long BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookGenre { get; set; }
        public long Author { get; set; }
    }
}
