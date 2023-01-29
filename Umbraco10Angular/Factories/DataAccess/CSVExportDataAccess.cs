using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public class CSVExportDataAccess : IHeroExport
    {
        public StringBuilder ExportHeroes(List<IHero> ListOfHeroes)
        {

            var sb = new StringBuilder();
            sb.AppendLine("Heroes Names");
            foreach (var data in ListOfHeroes)
            {
                sb.AppendLine(data.HeroName);
            }


            return sb;
        }
    }
}
