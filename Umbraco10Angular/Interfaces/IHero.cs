using System.Collections.Generic;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Interfaces
{
    public interface IHero
    {
        //abstraction
        public string key { get; set; }

        public string name { get; set; }

        public string ncContentTypeAlias { get; set; }
        public string PropType { get; set; }
        public string heroName { get; set; }
        public string Task { get; set; }
    }


}
