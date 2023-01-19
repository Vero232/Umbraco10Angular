using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Interfaces
{
    public interface IHero
    {
        //abstraction
        public List<BaseHero> GetAllHeroes(IContent content);

        public List<BaseHero> CreateSuperHero(SuperHero hero, IContent content);

        public List<BaseHero> CreateHero(CommonHero hero, IContent content);
    }
}
