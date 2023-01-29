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

    public class HeroFactory: IFactory<IHero>
    {
        public IHero Create()
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
    
    public class CreateHeroFactory
    {
    

        public static IHero CreateCommonHero()
        {

            return new CommonHero();

        }

        public static ILeader CreateLeader()
        {

            return new Leader();

        }

        public static ISuperHero CreateSuperHero()
        {

            return new SuperHero();

        }


    }
}
