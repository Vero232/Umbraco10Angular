using Umbraco10Angular.Factories.DataAccess;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class GetHeroFactory
    {
        //can be use if you have the same interface with different implementation
        public static IGetHeroesDataAccess GetHeroDataAccessObj()
        {
            //could return another class that use the IGetHeroesDataAccess interface
            return new GetHeroesDataAccess(); 
        }

        public static IGetHeroesDataAccess Sample()
        {

            return new Sample();
        }

    }
}
