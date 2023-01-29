using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Factories.DataAccess
{
    public class Sample : IGetHeroesDataAccess
    {
        public List<IHero> GetAllHeroes(IContent content)
        {
            throw new NotImplementedException();
        }
    }
}
