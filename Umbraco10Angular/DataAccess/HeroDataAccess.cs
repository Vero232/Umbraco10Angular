using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class HeroDataAccess : IHero
    {
       // implement details that will depend on the IHero interface. 
        //Doing so achieves the second part of the DIP principle.
        public List<Hero> GetAllHeroes(IContent content)
        {
            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<Hero>>(heroList);


            return heroes;
        }

        public List<Hero> CreateSuperHero(Hero hero, IContent content)
        {

            var heroList = content.GetValue("heroList").ToString();

            List<Hero> heroes = JsonSerializer.Deserialize<List<Hero>>(heroList);

            string id = Guid.NewGuid().ToString();


            Hero superHero = new SuperHero { 
                ncContentTypeAlias = "hero", 
                PropType = null, 
                key = id, 
                heroName = hero.heroName, 
              //  weight = hero.weight, 
               // heroType = hero.heroType,
            //    strength = hero.strength,
             //   livesSaved = hero.livesSaved,

            };
            
            heroes.Add(superHero);


            return heroes;

        }

    }
}
