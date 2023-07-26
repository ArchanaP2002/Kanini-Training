using BookStoreApi.models;

namespace BookStoreApi.models.repository
{
    //public interface IDataRepository
    //{
    //}

    //public interface IDataRepository<TEntity, TDto>
    //{
    //    IEnumerable<TEntity> GetAll();
    //    TEntity Get(long id);
    //    TDto GetDto(long id);
    //    void Add(TEntity entity);   
    //    void Update(TEntity entityToUpdate, TEntity entity);
    //    void Delete(TEntity entity);
    //}

    public interface IDataRepository<TEntity, TDto>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(long id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
    }
}
