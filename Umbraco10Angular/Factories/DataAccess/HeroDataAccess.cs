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

        public IHero CreateCommonHero(IHero hero, IContent content) 
        {

            string id = Guid.NewGuid().ToString();


            IHero commonHero = CreateHeroFactory.CreateCommonHero();

            commonHero.ncContentTypeAlias = "hero";
            commonHero.PropType = null;
            commonHero.key = id;
            commonHero.heroName = hero.heroName;

            return commonHero;

        }

        public ISuperHero CreateSuperHero(ISuperHero hero, IContent content)
        {
            string id = Guid.NewGuid().ToString();


            ISuperHero superHero = CreateHeroFactory.CreateSuperHero();

            superHero.ncContentTypeAlias = "hero";
            superHero.PropType = null;
            superHero.key = id;
            superHero.heroName = hero.heroName;

           
            return superHero;
        }

        public ILeader CreateHeroLeader(IHero hero, ILeader heroLeader, IContent content)
        {

            string id = Guid.NewGuid().ToString();

            ILeader leader = CreateHeroFactory.CreateLeader();

            leader.ncContentTypeAlias = "hero";
            leader.PropType = null;
            leader.key = id;
            leader.heroName = heroLeader.heroName;
            leader.AssignTask(hero, "save people");
        
            return leader;
        }

    }
}
