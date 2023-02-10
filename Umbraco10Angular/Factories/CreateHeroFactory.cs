using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public interface ICreate<T>
    {
        T Create();
        
    }

    public interface ICRUD<T>: ICreate<T>
    { }

    public class CreateHeroFactory: ICRUD<IBaseHero>
    {
        public IBaseHero Create()
        {
            return new CommonHero();
        }

    }

    public class LeaderFactory: ICRUD<ILeader>
    {
        public ILeader Create()
        {
            return new Leader();
        }
    }

    public class SuperHeroFactory: ICRUD<ISuperHero>
    {
        public ISuperHero Create()
        {
            return new SuperHero();
        }
    }


}
