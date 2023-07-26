//namespace BookStoreApi.models
//{


//    public partial class Book
//    {
//        public Book()
//        {
//            BookAuthors = new HashSet<BookAuthors>();
//        }
//        public long Id { get; set; }
//        public string Title { get; set; }
//        public long CategoryId { get; set; }
//        public long PublisherId { get; set; }
//        public virtual BookCategory Category { get; set; }
//        public virtual Publisher Publisher { get; set; }
//        public virtual ICollection<BookAuthors> BookAuthors { get; set; }
//    }
//}


using BookStoreApi.models;
using System.Collections.Generic;

namespace BookStoreApi.Models
{
    //public class Book
    //{
    //    public Book()
    //    {
    //        BookAuthors = new HashSet<BookAuthors>();
    //    }

    //    public long Id { get; set; }
    //    public string Title { get; set; }
    //    public string Isbn { get; set; }
    //    public int PublicationYear { get; set; }
    //    public virtual Publisher Publisher { get; set; }
    //    public virtual ICollection<BookAuthors> BookAuthors { get; set; }
    //}

    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public long CategoryId { get; set; }
        public long PublisherId { get; set; }
        public BookCategory Category { get; set; }
        public Publisher Publisher { get; set; }
        public List<BookAuthors> BookAuthors { get; set; }
    }
}
