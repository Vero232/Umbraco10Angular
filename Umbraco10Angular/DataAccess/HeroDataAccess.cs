using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class HeroDataAccess : IHero
    {
        //Low Level - depends on abstraction
       // implement details that will depend on the IHero interface. 
        //Doing so achieves the second part of the DIP principle.
        public List<BaseHero> GetAllHeroes(IContent content)
        {
            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<BaseHero>>(heroList);


            return heroes;
        }

        public List<BaseHero> CreateHero(CommonHero hero, IContent content) {


            var heroList = content.GetValue("heroList").ToString();

            List<BaseHero> heroes = JsonSerializer.Deserialize<List<BaseHero>>(heroList);

            string id = Guid.NewGuid().ToString();


            BaseHero commonHero = new SuperHero
            {
                ncContentTypeAlias = "hero",
                PropType = null,
                key = id,
                heroName = hero.heroName,
               

            };

            heroes.Add(commonHero);


            return heroes;

        }
        public List<BaseHero> CreateSuperHero(SuperHero hero, IContent content)
        {

            var heroList = content.GetValue("heroList").ToString();

            List<BaseHero> heroes = JsonSerializer.Deserialize<List<BaseHero>>(heroList);

            string id = Guid.NewGuid().ToString();


            BaseHero superHero = new SuperHero { 
                ncContentTypeAlias = "hero", 
                PropType = null, 
                key = id, 
                heroName = hero.heroName,
                superPower = hero.superPower

            };

            heroes.Add(superHero);


            return heroes;

        }

    }
}
