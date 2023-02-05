using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public interface ICreate<T>
    {
        T Create();
    }

    public interface IFactory<T>: ICreate<T>
    { }

    public class CreateHeroFactory: IFactory<IBaseHero>
    {
        public IBaseHero Create()
        {
            return new CommonHero();
        }


    }

    public class LeaderFactory: IFactory<ILeader>
    {
        public ILeader Create()
        {
            return new Leader();
        }
    }

    public class SuperHeroFactory: IFactory<ISuperHero>
    {
        public ISuperHero Create()
        {
            return new SuperHero();
        }
    }


}
