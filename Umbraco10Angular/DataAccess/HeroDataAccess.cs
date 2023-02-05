using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class HeroDataAccess : IHero
    {
        private IHeroFactory _heroFactory;
        public HeroDataAccess(IHeroFactory heroFactory) 
        {

            _heroFactory = heroFactory;  
        }

        public IBaseHero CreateCommonHero(IBaseHero hero, IContent content) 
        {

            string id = Guid.NewGuid().ToString();


            IBaseHero commonHero = _heroFactory.CreateCommonHero();

            commonHero.ContentTypeAlias = "hero";
            commonHero.PropType = null;
            commonHero.Key = id;
            commonHero.HeroName = hero.HeroName;

            return commonHero;

        }

        public ISuperHero CreateSuperHero(ISuperHero hero, IContent content)
        {
            string id = Guid.NewGuid().ToString();


            ISuperHero superHero = _heroFactory.CreateSuperHero();

            superHero.ContentTypeAlias = "hero";
            superHero.PropType = null;
            superHero.Key = id;
            superHero.HeroName = hero.HeroName;


           
            return superHero;
        }

        public ILeader CreateHeroLeader(IBaseHero hero, ILeader heroLeader, IContent content)
        {

            string id = Guid.NewGuid().ToString();

            ILeader leader = _heroFactory.CreateLeader();

            leader.ContentTypeAlias = "hero";
            leader.PropType = null;
            leader.Key = id;
            leader.HeroName = heroLeader.HeroName;
            leader.AssignTask(hero, "save people");
        
            return leader;
        }


        public List<IBaseHero> GetAllHeroes(IContent content)
        {
            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<IBaseHero>>(heroList);


            return heroes;
        }
    }
}
