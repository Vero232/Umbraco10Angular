using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Interfaces
{
    public interface IHero 
    {
        public List<Hero> GetAllHeroes(IContent content);

        public List<Hero> CreateSuperHero(Hero hero, IContent content);
    }
}
