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
    public class HeroesController : UmbracoApiController
    {
        private IContentService _contentService;
        private IHero _heroDataAccess;


        public HeroesController(IContentService contentService, IHero heroesDataAccess)
        {
            _contentService = contentService;
            _heroDataAccess = heroesDataAccess;

         }

        public IBaseHero CreateCommonHero(CommonHero hero)
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

        public ILeader CreateHeroLeader(ILeader leader, IBaseHero hero)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();

            var Hero = _heroDataAccess.CreateHeroLeader(hero, leader, content);
  
            content.SetValue("heroList", JsonSerializer.Serialize(Hero));

            _contentService.SaveAndPublish(content);

            return Hero;

        }
        public List<IBaseHero> GetAllHeroes()
        {

            var content = _contentService.GetRootContent().FirstOrDefault();

            return _heroDataAccess.GetAllHeroes(content);

        }
    }
}
