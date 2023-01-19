using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    public class SuperHero : BaseHero
    {            
        public string superPower { get; set; }
    }

}
