using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{

    public class HeroFactory : IHeroFactory
    {


        public IBaseHero CreateCommonHero()
        {

            return new CommonHero();

        }

        public ILeader CreateLeader()
        {

            return new Leader();

        }

        public ISuperHero CreateSuperHero()
        {

            return new SuperHero();

        }


    }
}
