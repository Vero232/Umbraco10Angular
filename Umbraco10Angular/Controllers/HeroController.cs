using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.Controllers;
//using Umbraco.Cms.Core.Mapping;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;
using Umbraco10Angular.Service;

namespace Umbraco10Angular.Controllers
{

    public class HeroController : UmbracoApiController
    {

        private ICRUD<Hero> _crudService;


        public HeroController(ICRUD<Hero> crudService)
        {
            _crudService = crudService;
        }



        public void CreateCommonHero(Hero hero)
        {

            _crudService.Create(hero);
        }



        public List<Hero> GetAllHeroes()
        {
            return _crudService.GetAll();

        }
    }
}
