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

using System.Xml;
using System.Data;
using System.Text;
using Umbraco10Angular.DataAccess;

namespace Umbraco10Angular.Controllers
{
    //~/Umbraco/Api/Hero/GetSomeData
    public class CSVExportController : UmbracoApiController
    {
        private IContentService _contentService;
        HeroDataAccess _heroDataAcess;
        HeroExportDataAccess _heroExportDataAccess;

        public CSVExportController(IContentService contentService)
        {
            _contentService = contentService;
            _heroDataAcess = DataAccessFactory.GetHeroDataAccessObj();
            _heroExportDataAccess = DataAccessFactory.ExportHeroesObj();
        }


        public FileResult ExportHeroes()
        {

            var content = _contentService.GetRootContent().FirstOrDefault();

            var ListOfHeroes = _heroDataAcess.GetAllHeroes(content);
            var heroesString = _heroExportDataAccess.ExportHeroes(ListOfHeroes);


            return File(new UTF8Encoding().GetBytes(heroesString.ToString()), "text/csv", "exportHeroes.csv");
        }
    }
}
