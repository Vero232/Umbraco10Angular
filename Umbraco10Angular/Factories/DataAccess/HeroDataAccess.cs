using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class HeroDataAccess : IHeroFeatures
    {
        //Low Level - depends on abstraction
       // implement details that will depend on the IHero interface. 
        //Doing so achieves the second part of the DIP principle.
        public List<IHero> GetAllHeroes(IContent content)
        {
            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<IHero>>(heroList);


            return heroes;
        }

        public IHero CreateCommonHero(IHero hero, IContent content) {


            var heroList = content.GetValue("heroList").ToString();

            List<IHero> heroes = JsonSerializer.Deserialize<List<IHero>>(heroList);

            string id = Guid.NewGuid().ToString();


            IHero commonHero = CreateHeroFactory.CreateCommonHero();
 
            commonHero.ncContentTypeAlias = "hero";
            commonHero.PropType = null;
            commonHero.key = id;
            commonHero.heroName = hero.heroName;


            heroes.Add(commonHero);


            return commonHero;

        }

    }
}
