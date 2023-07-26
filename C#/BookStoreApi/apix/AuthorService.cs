////using System.Collections.Generic;
////using System.Linq;
////using Microsoft.EntityFrameworkCore;
////using BookStoreApi.Data;
////using BookStoreApi.Models;

////namespace BookStoreApi.Services
////{
////    public class AuthorService
////    {
////        private readonly BookStoreContext _context;

////        public AuthorService(BookStoreContext context)
////        {
////            _context = context;
////        }

////        public List<Author> GetAllAuthors()
////        {
////            return _context.Authors.ToList();
////        }

////        public Author GetAuthorById(long id)
////        {
////            return _context.Authors.Find(id);
////        }

////        public Author CreateAuthor(Author author)
////        {
////            _context.Authors.Add(author);
////            _context.SaveChanges();
////            return author;
////        }

////        public Author UpdateAuthor(long id, Author author)
////        {
////            var existingAuthor = _context.Authors.Find(id);
////            if (existingAuthor == null)
////                return null;

////            existingAuthor.Name = author.Name;
////            _context.SaveChanges();
////            return existingAuthor;
////        }

////        public bool DeleteAuthor(long id)
////        {
////            var author = _context.Authors.Find(id);
////            if (author == null)
////                return false;

////            _context.Authors.Remove(author);
////            _context.SaveChanges();
////            return true;
////        }

////        public List<Book> GetBooksByAuthorId(long authorId)
////        {
////            return _context.BookAuthors
////                .Where(ba => ba.AuthorId == authorId)
////                .Select(ba => ba.Book)
////                .ToList();
////        }
////    }
////}

//using System.Collections.Generic;
//using System.Linq;
//using Microsoft.EntityFrameworkCore;
//using BookStoreApi.Data;
//using BookStoreApi.Models;

//namespace BookStoreApi 
//{
//    public class AuthorService
//    {
//        private readonly BookStoreContext _context;

//        public AuthorService(BookStoreContext context)
//        {
//            _context = context;
//        }

//        public List<Author> GetAllAuthors()
//        {
//            return _context.Authors
//                .Include(author => author.AuthorContact)
//                .ToList();
//        }

//        public Author GetAuthorById(long id)
//        {
//            return _context.Authors
//                .Include(author => author.AuthorContact)
//                .FirstOrDefault(author => author.Id == id);
//        }

//        public void CreateAuthor(Author author)
//        {
//            _context.Authors.Add(author);
//            _context.SaveChanges();
//        }

//        public void UpdateAuthor(Author updatedAuthor)
//        {
//            _context.Authors.Update(updatedAuthor);
//            _context.SaveChanges();
//        }

//        public void DeleteAuthor(long id)
//        {
//            var author = _context.Authors.Find(id);
//            if (author != null)
//            {
//                _context.Authors.Remove(author);
//                _context.SaveChanges();
//            }
//        }
//    }
//}


using BookStoreApi.Data;
using BookStoreApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreApi
{
    public class AuthorService
    {
        private readonly BookStoreContext _context;

        public AuthorService(BookStoreContext context)
        {
            _context = context;
        }

        public List<Author> GetAllAuthors()
        {
            return _context.Authors
                .Include(author => author.AuthorContact)
                .ToList();
        }

        public Author GetAuthorById(long id)
        {
            return _context.Authors
                .Include(author => author.AuthorContact)
                .FirstOrDefault(author => author.Id == id);
        }

        public void CreateAuthor(Author author)
        {
            _context.Authors.Add(author);
            _context.SaveChanges();
        }

        public void UpdateAuthor(Author updatedAuthor)
        {
            _context.Authors.Update(updatedAuthor);
            _context.SaveChanges();
        }

        public void DeleteAuthor(long id)
        {
            var author = _context.Authors.Find(id);
            if (author != null)
            {
                _context.Authors.Remove(author);
                _context.SaveChanges();
            }
        }
    }
}
