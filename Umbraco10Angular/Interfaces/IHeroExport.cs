using System.Collections.Generic;
using System.Text;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Interfaces
{
    public interface IHeroExport 
    {
        public StringBuilder ExportHeroes(List<IBaseHero> ListOfHeroes);

    }
}
