using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    public class Hero 
    {
        public string key { get; set; }
        public string name { get; set; }
        public string ncContentTypeAlias { get; set; }
        public string PropType { get; set; }
        public string heroName { get; set; }

        //public List<Hero> GetHeroes(IContent content)
        //{
        //    var heroList = content.GetValue("heroList").ToString();
        //    var heroes = JsonSerializer.Deserialize<List<Hero>>(heroList);
        //    return heroes;
        //}




    }
    
}
