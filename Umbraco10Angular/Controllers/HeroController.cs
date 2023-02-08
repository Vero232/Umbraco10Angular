using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.Controllers;
//using Umbraco.Cms.Core.Mapping;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Controllers
{
    //~/Umbraco/Api/CreateHeroes/CreateSuperHero
    //  implement a high-level component
    //   HeroController that also implements the interface IHero.
    //    Notice that our high-level component does not implement our low-level component but merely uses it.
  
    public class HeroController : UmbracoApiController
    {
        private IContentService _contentService;
        private IHero _heroDataAccess;


        public HeroController(IContentService contentService, IHero heroesDataAccess)
        {
            _contentService = contentService;
            _heroDataAccess = heroesDataAccess;

        }

        //Newtonsoft.Json.JsonSerializationException: 'Cannot deserialize the current JSON object (e.g. {"name":"value"}) into type 'System.Collections.Generic.List`1[Umbraco.Cms.Core.PropertyEditors.NestedContentPropertyEditor+NestedContentValues+NestedContentRowValue]' because the type requires a JSON array (e.g. [1,2,3]) to deserialize correctly.
        //To fix this error either change the JSON to a JSON array(e.g. [1, 2, 3]) or change the deserialized type so that it is a normal.NET type (e.g.not a primitive type like integer, not a collection type like an array or List<T>) that can be deserialized from a JSON object. JsonObjectAttribute can also be added to the type to force it to deserialize from a JSON object.
        //Path 'Key', line 1, position 7.'


        public CommonHero CreateCommonHero(CommonHero hero)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();

            var Hero = _heroDataAccess.CreateCommonHero(hero, content);

            var heroList = content.GetValue("heroList").ToString();
            var heroes = JsonSerializer.Deserialize<List<CommonHero>>(heroList);
            heroes.Add(Hero);
            content.SetValue("heroList", JsonSerializer.Serialize(heroes));

            _contentService.SaveAndPublish(content);

            return Hero;

        }



        [HttpGet]
        public List<IBaseHero> GetAllHeroes()
        {

            var content = _contentService.GetRootContent().FirstOrDefault();

            var heroes = _heroDataAccess.GetAllHeroes(content);

            return heroes;

        }
    }
}
