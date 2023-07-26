////using Microsoft.AspNetCore.Mvc;
////using BookStoreApi.Models;
////using BookStoreApi.models.repository;


////namespace BookStoreApi.Controllers
////{
////    [Route("api/authors")]
////    [ApiController]
////    public class AuthorsController : ControllerBase
////    {
////        private readonly IDataRepository<Author, AuthorDto> _dataRepository;

////        public AuthorsController(IDataRepository<Author, AuthorDto> dataRepository)
////        {
////            _dataRepository = dataRepository;
////        }

////        // GET: api/authors
////        [HttpGet]
////        public IActionResult Get()
////        {
////            var authors = _dataRepository.GetAll();
////            return Ok(authors);
////        }

////        // GET: api/authors/5
////        [HttpGet("{id}", Name = "GetAuthor")]
////        public IActionResult Get(int id)
////        {
////            var author = _dataRepository.Get(id);
////            if (author == null)
////            {
////                return NotFound("Author not found.");
////            }

////            return Ok(author);
////        }

////        // POST: api/authors
////        [HttpPost]
////        public IActionResult Post([FromBody] Author author)
////        {
////            if (author == null)
////            {
////                return BadRequest("Author is null.");
////            }

////            if (!ModelState.IsValid)
////            {
////                return BadRequest(ModelState);
////            }

////            _dataRepository.Add(author);
////            return CreatedAtRoute("GetAuthor", new { id = author.Id }, author);
////        }

////        // PUT: api/authors/5
////        [HttpPut("{id}")]
////        public IActionResult Put(int id, [FromBody] Author author)
////        {
////            if (author == null)
////            {
////                return BadRequest("Author is null.");
////            }

////            var authorToUpdate = _dataRepository.Get(id);
////            if (authorToUpdate == null)
////            {
////                return NotFound("Author not found.");
////            }

////            if (!ModelState.IsValid)
////            {
////                return BadRequest(ModelState);
////            }

////            _dataRepository.Update(authorToUpdate, author);
////            return NoContent();
////        }

////        // DELETE: api/authors/5
////        [HttpDelete("{id}")]
////        public IActionResult Delete(int id)
////        {


//using System.Collections.Generic;
//using Microsoft.AspNetCore.Mvc;
//using BookStoreApi.Models;
//using BookStoreApi.Models.DataManager;
//using BookStoreApi.models.repository;

//namespace BookStoreApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AuthorsController : ControllerBase
//    {
//        private readonly IDataRepository<Author, AuthorDto> _authorDataManager;

//        public AuthorsController(IDataRepository<Author, AuthorDto> authorDataManager)
//        {
//            _authorDataManager = authorDataManager;
//        }

//        // GET: api/authors
//        [HttpGet]
//        public IActionResult GetAll()
//        {
//            var authors = _authorDataManager.GetAllEntities();
//            return Ok(authors);
//        }

//        // GET: api/authors/{id}
//        [HttpGet("{id}")]
//        public IActionResult Get(int id)
//        {
//            var author = _authorDataManager.GetEntity(id);
//            if (author == null)
//            {
//                return NotFound();
//            }
//            return Ok(author);
//        }

//        // POST: api/authors
//        [HttpPost]
//        public IActionResult Create(AuthorDto authorDto)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            var author = authorDto.ToEntity();
//            _authorDataManager.AddEntity(author);
//            return CreatedAtAction(nameof(Get), new { id = author.Id }, author);
//        }

//        // PUT: api/authors/{id}
//        [HttpPut("{id}")]
//        public IActionResult Update(int id, AuthorDto authorDto)
//        {
//            if (!ModelState.IsValid)
//            {
//                return BadRequest(ModelState);
//            }
//            var existingAuthor = _authorDataManager.GetEntity(id);
//            if (existingAuthor == null)
//            {
//                return NotFound();
//            }
//            var updatedAuthor = authorDto.ToEntity();
//            existingAuthor.UpdateFromDto(updatedAuthor);
//            _authorDataManager.UpdateEntity(existingAuthor);
//            return NoContent();
//        }

//        // DELETE: api/authors/{id}
//        [HttpDelete("{id}")]
//        public IActionResult Delete(int id)
//        {
//            var author = _authorDataManager.GetEntity(id);
//            if (author == null)
//            {
//                return NotFound();
//            }
//            _authorDataManager.DeleteEntity(author);
//            return NoContent();
//        }
//    }
//}
using BookStoreApi;
using BookStoreApi.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BookStoreApi.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService _authorService;

        public AuthorController(AuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public ActionResult<List<Author>> GetAllAuthors()
        {
            var authors = _authorService.GetAllAuthors();
            return Ok(authors);
        }

        [HttpGet("{id}")]
        public ActionResult<Author> GetAuthorById(long id)
        {
            var author = _authorService.GetAuthorById(id);
            if (author == null)
            {
                return NotFound();
            }
            return Ok(author);
        }

        [HttpPost]
        public ActionResult<Author> CreateAuthor(Author author)
        {
            _authorService.CreateAuthor(author);
            return CreatedAtAction(nameof(GetAuthorById), new { id = author.Id }, author);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(long id, Author updatedAuthor)
        {
            if (id != updatedAuthor.Id)
            {
                return BadRequest();
            }

            _authorService.UpdateAuthor(updatedAuthor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(long id)
        {
            _authorService.DeleteAuthor(id);
            return NoContent();
        }
    }
}
