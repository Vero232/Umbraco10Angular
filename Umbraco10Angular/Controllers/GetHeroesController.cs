using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco10Angular.DataAccess;
using Umbraco10Angular.Extensions;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Controllers
{
    //~/Umbraco/Api/Hero/GetSomeData
    //  implement a high-level component
    //   HeroController that also implements the interface IHero.
    //    Notice that our high-level component does not implement our low-level component but merely uses it.
    public class GetHeroesController : UmbracoApiController
    {
        private IContentService _contentService;
        //high-level module(GetHeroesController) and low-level module(GetHeroesDataAccess)
        //are dependent on an abstraction(IGetHeroesDataAccess).
        IGetHeroesDataAccess _heroDataAccess;


        public GetHeroesController(IContentService contentService)
        {
            _contentService = contentService;
            _heroDataAccess = GetHeroFactory.GetHeroDataAccessObj();

        }


        public List<IHero> GetAllHeroes()
        {

            var content = _contentService.GetRootContent().FirstOrDefault();

S
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
            return _heroDataAccess.GetAllHeroes(content);

        }

  
    }
}
