﻿using Microsoft.AspNetCore.Mvc;
//using Umbraco.Cms.Core.Mapping;
using System.Text;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Web.Common.Controllers;
using Umbraco10Angular.DataAccess;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Controllers
{
    //~/Umbraco/Api/Hero/GetSomeData
    public class CSVExportController : UmbracoApiController
    {
        private IContentService _contentService;
        private IHero _heroDataAcess;
        private IHeroExport _heroExportDataAccess;

        public CSVExportController(IContentService contentService, IHero heroDataAcess, IHeroExport heroExportDataAccess)
        {
            _contentService = contentService;
            _heroDataAcess = heroDataAcess;
            _heroExportDataAccess = heroExportDataAccess;
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
