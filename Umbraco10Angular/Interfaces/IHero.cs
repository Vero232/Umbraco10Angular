using System.Collections.Generic;
using System.Text;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Interfaces
{
    public interface IHero
    {
         string Key { get; set; }
         string Name { get; set; }
         string ContentTypeAlias { get; set; }
         string PropType { get; set; }
         string HeroName { get; set; }
         string Task { get; set; }
    }
}
