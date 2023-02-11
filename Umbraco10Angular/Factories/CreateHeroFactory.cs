using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public interface ICreate<T>
    {
        T Create();

    }

    public interface IRead<T>
    {
        T Read();
    }

    public interface IUpdate<T>
    {
        T Update(T obj);
    }



    public interface IDelete<T>
    {
        void Delete(int id);
    }


 
    public interface ICRUD<T>: ICreate<T>, IRead<T>, IUpdate<T>, IDelete<T>
    { }


    public class LeaderFactory : ICRUD<ILeader>
    {
        public ILeader Create()
        {
            return new Leader();
        }

        public void Delete(int id)
        {

        }

        public ILeader Read()
        {
            throw new NotImplementedException();
        }

        public ILeader Update(ILeader obj)
        {
            throw new NotImplementedException();
        }
    }

    public class SuperHeroFactory : ICRUD<ISuperHero>
    {
        public ISuperHero Create()
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ISuperHero Read()
        {
            throw new NotImplementedException();
        }

        public ISuperHero Update(ISuperHero obj)
        {
            throw new NotImplementedException();
        }
    }


}
