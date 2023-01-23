using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class HeroFactory
    {
        public static CreateHeroDataAccess GetHeroDataAccessObj()
        {
           // The returned HeroDataAccess class is our low-level component.
            return new CreateHeroDataAccess();
        }

   


    }
}
