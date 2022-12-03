using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.Controllers;

using System.Text.Json;

using Umbraco10Angular.Models;
using System.Reflection;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Mapping;

namespace Umbraco10Angular.Controllers
{
    //~/Umbraco/Api/Hero/GetSomeData
    public class HeroController : UmbracoApiController
    {
        private IContentService _contentService;
        private UmbracoMapper _mapper;

        public HeroController(IContentService contentService, UmbracoMapper mapper)
        {
            _contentService = contentService;
            _mapper = mapper;
        }


        public List<Hero> GetAllHeroes()
        {
            var content = _contentService.GetRootContent().ToList().FirstOrDefault();
            var heroList = content.GetValue("heroList").ToString();
           // _mapper.Map<>
          //  List<Hero>  heroes = JsonConvert.DeserializeObject<List<Hero>>(heroList);
            var heroes = JsonSerializer.Deserialize<List<Hero>>(heroList);
            return heroes;
        }

        [HttpPost]
        public IActionResult AddHero(Hero hero)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();
            var heroList = content.GetValue("heroList").ToString();
            List<Hero> heroes = JsonSerializer.Deserialize<List<Hero>>(heroList);

            //  var parentId = content.GetUdi();

            //IContent request = _contentService.CreateContent("new node", parentId, "hero", -1);
            string id = Guid.NewGuid().ToString();
            heroes.Add(new Hero {  ncContentTypeAlias="hero",PropType = null,key = id, heroName = hero.heroName });
            
            //var newhero = new List<Dictionary<string, string>>();
            //newhero.Add(new Dictionary<string, string>() {
              
                
            //    {"ncContentTypeAlias","hero"},
            //    {"PropType",null },
            //    {"heroName", hero.heroName }

            // });
        


              content.SetValue("heroList", JsonSerializer.Serialize(heroes));


          //  request.SetValue("hero", JsonConvert.SerializeObject(newhero));

            _contentService.SaveAndPublish(content);
            return Ok();

        }
    }
}
