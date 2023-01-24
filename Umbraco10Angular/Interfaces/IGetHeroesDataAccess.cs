using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Interfaces
{
    public interface IGetHeroesDataAccess
    {
        //abstraction
        public List<IHero> GetAllHeroes(IContent content);

    }


}
