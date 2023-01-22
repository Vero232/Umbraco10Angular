using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class HeroFactory
    {
        public static HeroDataAccess GetHeroDataAccessObj()
        {
           // The returned HeroDataAccess class is our low-level component.
            return new HeroDataAccess();
        }

   


    }
}
