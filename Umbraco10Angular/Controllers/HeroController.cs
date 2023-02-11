using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco10Angular.DataAccess;
//using Umbraco.Cms.Core.Mapping;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;
using Umbraco10Angular.Service;

namespace Umbraco10Angular.Controllers
{

    public class HeroController : UmbracoApiController
    {
        private IContentService _contentService;
        private IHero _heroDataAccess;


        public HeroController(IContentService contentService, IHero heroesDataAccess)
        {
            _contentService = contentService;
            _heroDataAccess = heroesDataAccess;

        }



        public void CreateCommonHero(CommonHero hero)
        {

            var CRUDService = new CRUDService(_contentService);

            CRUDService.Create(hero);
        }



        public List<IBaseHero> GetAllHeroes()
        {

            var content = _contentService.GetRootContent().FirstOrDefault();

            var heroes = _heroDataAccess.GetAllHeroes(content);

            return heroes;

        }
    }
}
