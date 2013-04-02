namespace ViperSoft.Saturn.Repository.Interfaces
{
    public interface ICrudRepository<T>
    {
        T GetById(long id);
        void Update(T model);
        void Delete(long id);
        long Create(T model);
    }
}