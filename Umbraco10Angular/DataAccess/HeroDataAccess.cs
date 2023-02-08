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

        public CommonHero CreateCommonHero(CommonHero hero, IContent content) 
        {

            string id = Guid.NewGuid().ToString();


            CommonHero commonHero = _heroFactory.CreateCommonHero();

            commonHero.ncContentTypeAlias = "hero";
            commonHero.PropType = "";
            commonHero.key = id;
            commonHero.heroName = hero.heroName;
            commonHero.name = hero.heroName;
            

            return commonHero;

        }

        public ISuperHero CreateSuperHero(ISuperHero hero, IContent content)
        {
            string id = Guid.NewGuid().ToString();


            ISuperHero superHero = _heroFactory.CreateSuperHero();

            superHero.ncContentTypeAlias = "hero";
            superHero.PropType = null;
            superHero.key = id;
            superHero.heroName = hero.heroName;


           
            return superHero;
        }

        public ILeader CreateHeroLeader(IBaseHero hero, ILeader heroLeader, IContent content)
        {

            string id = Guid.NewGuid().ToString();

            ILeader leader = _heroFactory.CreateLeader();

            leader.ncContentTypeAlias = "hero";
            leader.PropType = null;
            leader.key = id;
            leader.heroName = heroLeader.heroName;
            leader.AssignTask(hero, "save people");
        
            return leader;
        }


        public List<IBaseHero> GetAllHeroes(IContent content)
        {
            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<BaseHero>>(heroList);

            List<IBaseHero> baseHeroes = new List<IBaseHero>();

            foreach (var item in heroes) 
            {
                baseHeroes.Add(item);
            }

            return baseHeroes;
        }


    }
}
