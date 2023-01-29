using System.Text.Json;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.Controllers;
//using Umbraco.Cms.Core.Mapping;
using Umbraco10Angular.DataAccess;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Controllers
{
    //~/Umbraco/Api/CreateHeroes/CreateSuperHero
    //  implement a high-level component
    //   HeroController that also implements the interface IHero.
    //    Notice that our high-level component does not implement our low-level component but merely uses it.
    public class CreateHeroesController : UmbracoApiController
    {
        private IContentService _contentService;
        ICreateHeroesDataAccess _heroDataAccess;


        public CreateHeroesController(IContentService contentService)
        {
            _contentService = contentService;
            _heroDataAccess = CreateHeroesAccessFactory.GetHeroDataAccessObj();
         }

        public IHero CreateCommonHero(CommonHero hero)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();

            var Hero = _heroDataAccess.CreateCommonHero(hero, content);

            content.SetValue("heroList", JsonSerializer.Serialize(Hero));

            _contentService.SaveAndPublish(content);

            return Hero;

        }

        public ISuperHero CreateSuperHero(ISuperHero hero)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();

            var Hero = _heroDataAccess.CreateSuperHero(hero, content);

            content.SetValue("heroList", JsonSerializer.Serialize(Hero));

            _contentService.SaveAndPublish(content);

            return Hero;

        }

        public ILeader CreateHeroLeader(ILeader leader, IHero hero)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();

            var Hero = _heroDataAccess.CreateHeroLeader(hero, leader, content);
            //ISuperHero SuperHero = CreateHeroFactory.CreateSuperHero();

            //SuperHero.ncContentTypeAlias = "hero";
            //SuperHero.PropType = null;
            //SuperHero.key = "2";
            //SuperHero.heroName = "John";
            //SuperHero.superPower = "fly";
            //SuperHero.task = "";

            //ILeader leader1 = CreateHeroFactory.CreateLeader();

            //leader1.ncContentTypeAlias = "hero";
            //leader1.PropType = null;
            //leader1.key = "2";
            //leader1.heroName = "John";
            //leader1.AssignTask(SuperHero, "save people");

            //var Hero = _heroDataAccess.CreateHeroLeader(SuperHero, leader1, content);

            //OCP Test
            List<BaseHero> HEROES = new List<BaseHero>
            {
                new SuperHero {  },
                new CommonHero { },
                new Leader { },
               // new TestHero {  } // This will break TestHero does not derive from BaseHero
            };

            //LSP Test
            BaseHero commonHero = new CommonHero();
            

            content.SetValue("heroList", JsonSerializer.Serialize(Hero));

            _contentService.SaveAndPublish(content);

            return Hero;

        }
    }
}
