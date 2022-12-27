using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class HeroDataAccess : IHero
    {

        public List<Hero> GetAllHeroes(IContent content)
        {
            var heroList = content.GetValue("heroList").ToString();
            var heroes = JsonSerializer.Deserialize<List<Hero>>(heroList);
            return heroes;
        }
    }
}
