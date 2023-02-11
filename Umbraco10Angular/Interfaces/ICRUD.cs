namespace Umbraco10Angular.Interfaces
{
    public interface ICRUD<T>
    {

        void Create(T obj);
        List<T> GetAll();
        void Update(T obj);
        void Delete(int Id);
    }
}

