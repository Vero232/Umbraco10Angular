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

        public IContentService _contentService;
        public ICRUD<Hero> _heroService;


        public HeroController(IContentService contentService, ICRUD<Hero> heroService)
        {
            _contentService = contentService;
            _heroService = heroService;
        }


        public CommonHero CreateCommonHero(CommonHero obj)
        {
            var service = new BaseCRUDService<CommonHero>();

            return Create(service.Create, obj);
        }

        public T Create<T>(Func<T, T> function, T hero)
        {
            return function(hero);
        }

        //using extension method
        public Hero CreateHero(Hero obj)
        {
            var service = new BaseCRUDService<Hero>();

            return obj.Create(service.Create);

        }

        public List<Hero> GetFilteredHeroes()
        {


            var service = new BaseCRUDService<Hero>();
            var allHeroes = service.GetAll();
     
            var filteredHeroes = allHeroes.FilterHeroByName((name) =>
            {

                return allHeroes.Where(x => x.heroName.Contains(name)).ToList();

            }, "john");

            var filteredHeroes1 = allHeroes.FilterHeroByName(Filtered, "john");

            var filteredHeroes2 = allHeroes.FilterHeroByName2(Filtered, "john");

            return filteredHeroes;

        }

        public List<Hero> Filtered(string name)
        {
            var service = new BaseCRUDService<Hero>();
            var allHeroes = service.GetAll();

            return allHeroes.Where(x => x.heroName.Contains(name)).ToList();

        }

        public List<T> Get<T>(Func<List<T>> function)
        {
         
            return function();
        }



     

        public List<Hero> GetAllHeroes1()
        {

            //var AllHeroes = new BaseCRUDService<Hero>().GetAll();
            var heroes = new BaseCRUDService<Hero>(_contentService).GetAll();
     
            return heroes;

        }

    }

}
