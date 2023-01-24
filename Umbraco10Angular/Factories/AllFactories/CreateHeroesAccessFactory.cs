using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class CreateHeroesAccessFactory
    {

        public static ICreateHeroesDataAccess GetHeroDataAccessObj()
        {
            // The returned HeroDataAccess class is our low-level component.
            return new CreateHeroesDataAccess();
        }


    }
}
