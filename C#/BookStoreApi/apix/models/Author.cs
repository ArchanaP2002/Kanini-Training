//using BookStoreApi.models;
//using System.Collections.Generic;

//namespace BookStoreApi.Models
//{
//    public class Author
//    {
//        public Author()
//        {
//            BookAuthors = new HashSet<BookAuthors>();
//        }

//        public long Id { get; set; }
//        public string Name { get; set; }
//        public virtual AuthorContact AuthorContact { get; set; }
//        public virtual ICollection<BookAuthors> BookAuthors { get; set; }
//    }
//}

using BookStoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

// Define the classes

public class Author
{
    public long Id { get; set; }
    public string Name { get; set; }
    public List<AuthorContact> AuthorContacts { get; set; }
    public List<BookAuthors> BookAuthors { get; set; }
}
