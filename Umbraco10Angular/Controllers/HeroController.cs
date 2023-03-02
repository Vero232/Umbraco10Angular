using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
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


        public Hero CreateHero(Hero hero, [FromServices] ICRUD<Hero> _crudService)
        {
 

            return hero.Create(_crudService.Create);

        }

        public List<Hero> GetFilteredHeroesByName([FromServices] ICRUD<Hero> _crudService)
        {


            List<Hero> allHeroes = _crudService.GetAll();


            List<Hero> filteredHeroes = allHeroes.FilterHeroByName((name) =>
            {

                return allHeroes.Where(x => x.heroName.Contains(name)).ToList();

            }, "john");


            //List<SuperHero> filteredHeroes1 = allHeroes.FilterHeroByName(Filtered, "john");

            //List<SuperHero> filteredHeroes2 = allHeroes.FilterHeroByName2(Filtered, "john");

            return filteredHeroes;

        }

        public List<SuperHero> GetFilteredSuperHeroes([FromServices] ICRUD<SuperHero> _crudService, string name)
        {


            List<SuperHero> allHeroes = _crudService.GetAll();


            List<SuperHero> filteredHeroes = allHeroes.FilterHeroes(x => x.heroName.Contains(name));
  


            return filteredHeroes;

        }

        public List<T> Get<T>(Func<List<T>> function)
        {
         
            return function();
        }


        public List<SuperHero> GetAllHeroes([FromServices] ICRUD<SuperHero> _crudService)
        {


            var heroes = _crudService.GetAll();


            return heroes;

        }

    }

}
