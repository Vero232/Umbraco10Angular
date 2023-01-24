using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class GetHeroFactory
    {
        public static IGetHeroesDataAccess GetHeroDataAccessObj()
        {
            //could return another class that use the IGetHeroesDataAccess interface
            return new GetHeroesDataAccess(); 
        }

    }
}
