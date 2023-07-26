namespace BookStoreApi.Models
{
    //    public class AuthorContact
    //    {
    //        public long Id { get; set; }
    //        public string Email { get; set; }
    //        public string Phone { get; set; }
    //        public long AuthorId { get; set; }
    //        public virtual Author Author { get; set; }
    //    }

    public class AuthorContact
    {
        public long AuthorId { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public Author Author { get; set; }
    }
}
