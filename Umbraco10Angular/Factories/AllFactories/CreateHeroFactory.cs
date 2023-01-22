using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
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
