

using BookStoreApi.Models;
using System.Collections.Generic;

namespace BookStoreApi.models.repository
{
    public class AuthorRepository
    {
        private readonly List<Author> _authors;

        public AuthorRepository()
        {
            _authors = new List<Author>();
        }

        public List<Author> GetAllAuthors()
        {
            return _authors;
        }

        public Author GetAuthorById(long id)
        {
            return _authors.Find(a => a.Id == id);
        }

        public void CreateAuthor(Author author)
        {
            _authors.Add(author);
        }

        public void UpdateAuthor(Author updatedAuthor)
        {
            int index = _authors.FindIndex(a => a.Id == updatedAuthor.Id);
            if (index != -1)
            {
                _authors[index] = updatedAuthor;
            }
        }

        public void DeleteAuthor(long id)
        {
            _authors.RemoveAll(a => a.Id == id);
        }
    }
}
