using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class CreateHeroesDataAccess : ICreateHeroesDataAccess
    {
        //Low Level - depends on abstraction
        // implement details that will depend on the IHero interface. 
        //Doing so achieves the second part of the DIP principle.
  

        public IHero CreateCommonHero(IHero hero, IContent content) 
        {

            string id = Guid.NewGuid().ToString();


            IHero commonHero = CreateHeroFactory.CreateCommonHero();

            commonHero.ContentTypeAlias = "hero";
            commonHero.PropType = null;
            commonHero.Key = id;
            commonHero.HeroName = hero.HeroName;

            return commonHero;

        }

        public ISuperHero CreateSuperHero(ISuperHero hero, IContent content)
        {
            string id = Guid.NewGuid().ToString();


            ISuperHero superHero = CreateHeroFactory.CreateSuperHero();

            superHero.ContentTypeAlias = "hero";
            superHero.PropType = null;
            superHero.Key = id;
            superHero.HeroName = hero.HeroName;

           
            return superHero;
        }

        public ILeader CreateHeroLeader(IHero hero, ILeader heroLeader, IContent content)
        {

            string id = Guid.NewGuid().ToString();

            ILeader leader = CreateHeroFactory.CreateLeader();

            leader.ContentTypeAlias = "hero";
            leader.PropType = null;
            leader.Key = id;
            leader.HeroName = heroLeader.HeroName;
            leader.AssignTask(hero, "save people");
        
            return leader;
        }

    }
}
