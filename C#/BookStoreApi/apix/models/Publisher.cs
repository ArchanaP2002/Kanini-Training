using BookStoreApi.Models;
using System.Collections.Generic;

namespace BookStoreApi.Models
{
    //    public class Publisher
    //    {
    //        public Publisher()
    //        {
    //            Books = new HashSet<Book>();
    //        }

    //        public long Id { get; set; }
    //        public string Name { get; set; }
    //        public virtual ICollection<Book> Books { get; set; }
    //    }

    public class Publisher
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
