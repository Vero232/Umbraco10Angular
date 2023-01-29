using System.Text.Json;
using System.Text.Json.Serialization;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    public abstract class BaseHero : IHero
    {
        [JsonPropertyName("key")] 
        public string Key { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("ncContentTypeAlias")]
        public string ContentTypeAlias { get; set; }
        public string PropType { get;set; }
        [JsonPropertyName("heroName")]
        public string HeroName { get; set; }
        public string Task { get; set; } = "None";
    }
}
