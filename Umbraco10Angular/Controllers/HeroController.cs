using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.Controllers;

using System.Text.Json;
using Newtonsoft.Json;
using Umbraco10Angular.Models;
using System.Reflection;
using Umbraco.Cms.Core.Models;

namespace Umbraco10Angular.Controllers
{
    //~/Umbraco/Api/Hero/GetSomeData
    public class HeroController : UmbracoApiController
    {
        private IContentService _contentService;

        public HeroController(IContentService contentService)
        {
            _contentService = contentService;
        }

      
        public List<Hero> GetAllHeroes()
        {
            var content = _contentService.GetRootContent().FirstOrDefault();
            var heroList = content.GetValue("heroList").ToString();

            List<Hero>  heroes = JsonConvert.DeserializeObject<List<Hero>>(heroList);
       
            return heroes;
        }

        [HttpPost]
        public IActionResult AddHero(Hero hero)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();
            var heroList = content.GetValue("heroList").ToString();
            List<Hero> heroes = JsonConvert.DeserializeObject<List<Hero>>(heroList);
            //    var parentNode = content.Properties;
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
        


              content.SetValue("heroList", JsonConvert.SerializeObject(heroes));


          //  request.SetValue("hero", JsonConvert.SerializeObject(newhero));

            _contentService.SaveAndPublish(content);
            return Ok();

        }
    }
}
