using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Collections.Generic;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco.Cms.Core.Events;
using System.Text.Json;

using Umbraco10Angular.Models;
using System.Reflection;
using Umbraco.Cms.Core.Models;
//using Umbraco.Cms.Core.Mapping;
using System.Runtime.Serialization;

using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Mapping;
using Umbraco10Angular.DataAccess;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Controllers
{
    //~/Umbraco/Api/Hero/GetSomeData
    //  implement a high-level component
    //   HeroController that also implements the interface IHero.
    //    Notice that our high-level component does not implement our low-level component but merely uses it.
    public class HeroController : UmbracoApiController
    {
        private IContentService _contentService;
        IHeroFeatures _heroDataAccess;


        public HeroController(IContentService contentService)
        {
            _contentService = contentService;
            _heroDataAccess = HeroFactory.GetHeroDataAccessObj();

        }


        public List<IHero> GetAllHeroes()
        {

            var content = _contentService.GetRootContent().FirstOrDefault();

            return _heroDataAccess.GetAllHeroes(content);
        }


        public IHero CreateCommonHero(CommonHero hero)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();

            var Hero = _heroDataAccess.CreateCommonHero(hero, content);

            content.SetValue("heroList", JsonSerializer.Serialize(Hero));

            _contentService.SaveAndPublish(content);

            return Hero;

        }

    }
}
