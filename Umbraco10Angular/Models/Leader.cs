using System.Text.Json;
using System.Text.Json.Serialization;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    public class Leader : BaseHero, ILeader
    {
        public string key { get; set; }
        public string name { get; set; }
        public string ncContentTypeAlias { get; set; }
        public string PropType { get;set; }
        public string heroName { get; set; }


        public void AssignTask()
        {
          
        }
        //public void AssignTask(IHero hero)
        //{
        //    hero.task = "Save People";
        //}
    }
}
