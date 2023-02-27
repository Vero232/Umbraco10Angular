namespace Umbraco10Angular.Interfaces
{

    public interface ICreate<T>
    {
        T Create(T obj);

    }

    public interface IRead<T>
    {
        List<T> GetAll();
    }

    public interface IUpdate<T>
    {
        T Update(T obj);
    }



    public interface IDelete<T>
    {
        void Delete(int id);
    }



    public interface ICRUD<T> : ICreate<T>, IRead<T>, IUpdate<T>, IDelete<T>
    {

    }

}

