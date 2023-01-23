using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Interfaces
{
    public interface IHeroFeatures
    {
        //abstraction
        public List<IHero> GetAllHeroes(IContent content);

        public IHero CreateCommonHero(IHero hero, IContent content);


        public ILeader CreateHeroLeader(IHero hero, ILeader heroLeader, IContent content);

        public ISuperHero CreateSuperHero(ISuperHero hero, IContent content);
    }


}
