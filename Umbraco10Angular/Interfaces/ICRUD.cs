namespace Umbraco10Angular.Interfaces
{
    public interface ICRUD<T>
    {

        void Create(T obj);
        T ReadAll();
        void Update(T obj);
        void Delete(int Id);
    }
}

