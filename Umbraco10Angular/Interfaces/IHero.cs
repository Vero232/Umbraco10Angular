using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Interfaces
{
    public interface IHero
    {
        //abstraction
 
        public IBaseHero CreateCommonHero(IBaseHero hero, IContent content);

        public ILeader CreateHeroLeader(IBaseHero hero, ILeader heroLeader, IContent content);

        public ISuperHero CreateSuperHero(ISuperHero hero, IContent content);

        public List<IBaseHero> GetAllHeroes(IContent content);
    }


}
