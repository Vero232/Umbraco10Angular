using System.Collections.Generic;
using System.Text;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Interfaces
{
    public interface IHero
    {
         string key { get; set; }
         string name { get; set; }
         string ncContentTypeAlias { get; set; }
         string PropType { get; set; }
         string heroName { get; set; }
         string Task { get; set; }
    }
}
