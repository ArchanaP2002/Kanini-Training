namespace BookStoreApi.Models
{
    //public class BookAuthors
    //{
    //    public long BookId { get; set; }
    //    public virtual Book Book { get; set; }
    //    public long AuthorId { get; set; }
    //    public virtual Author Author { get; set; }
    //}

    public class BookAuthors
    {
        public long BookId { get; set; }
        public long AuthorId { get; set; }
        public Book Book { get; set; }
        public Author Author { get; set; }
    }
}
