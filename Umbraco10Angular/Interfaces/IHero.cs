using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Interfaces
{
    public interface IHero
    {
        //abstraction
        public List<BaseHero> GetAllHeroes(IContent content);

        public List<SuperHero> CreateSuperHero(SuperHero hero, IContent content);

        public List<CommonHero> CreateHero(CommonHero hero, IContent content);
    }
}
