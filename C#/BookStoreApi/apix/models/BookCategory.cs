namespace BookStoreApi.Models
{
    //public class BookCategory
    //{
    //    public long Id { get; set; }
    //    public string Name { get; set; }
    //}

    public class BookCategory
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
