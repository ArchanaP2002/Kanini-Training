//using System.Collections.Generic;
//using System.Linq;
//using BookStoreApi.Data;
//using BookStoreApi.models.repository;
//using Microsoft.EntityFrameworkCore;

//namespace BookStoreApi.Models.repository
//{
//    public class AuthorDataManager : IDataRepository<Author, AuthorDto>
//    {
//        private readonly BookStoreContext _bookStoreContext;

//        public AuthorDataManager(BookStoreContext bookStoreContext)
//        {
//            _bookStoreContext = bookStoreContext;
//        }

//        public IEnumerable<Author> GetAll()
//        {
//            return _bookStoreContext.Authors
//                .Include(author => author.AuthorContact)
//                .ToList();
//        }

//        public Author Get(long id)
//        {
//            return _bookStoreContext.Authors
//                .Include(author => author.AuthorContact)
//                .FirstOrDefault(author => author.Id == id);
//        }
//    }
//}

using BookStoreApi.Data;
using BookStoreApi.models.repository;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BookStoreApi.Models.DataManager
{
    public class AuthorDataManager : IDataRepository<Author, AuthorDto>
    {
        private readonly BookStoreContext _bookStoreContext;

        public AuthorDataManager(BookStoreContext bookStoreContext)
        {
            _bookStoreContext = bookStoreContext;
        }

        public IEnumerable<Author> GetAll()
        {
            return _bookStoreContext.Authors
                .Include(author => author.AuthorContact)
                .ToList();
        }

        public Author Get(long id)
        {
            return _bookStoreContext.Authors
                .Include(author => author.AuthorContact)
                .FirstOrDefault(author => author.Id == id);
        }

        public AuthorDto GetDto(long id)
        {
            // Implement the logic to get AuthorDto based on the specified id
            // This method is missing in the original code and needs to be added
            throw new NotImplementedException();
        }

        public void Add(Author entity)
        {
            _bookStoreContext.Authors.Add(entity);
            _bookStoreContext.SaveChanges();
        }

        public void Update(Author entityToUpdate, Author entity)
        {
            entityToUpdate.Name = entity.Name;
            //  entityToUpdate.Age = entity.Age;
            // Update other properties as needed
            _bookStoreContext.SaveChanges();
        }

        public void Delete(Author entity)
        {
            _bookStoreContext.Authors.Remove(entity);
            _bookStoreContext.SaveChanges();
        }
    }
}

