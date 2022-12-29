using System.Text.Json;
using System.Text.Json.Serialization;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    //public abstract - removed abstract class cause cannot convert json to abstract class
    public class Hero 
    {

        public string key { get; set; }
        public string name { get; set; }
        public string ncContentTypeAlias { get; set; }
        public string PropType { get; set; }
        public string heroName { get; set; }
        public int weight { get; set; }
        public int strength { get; set; }
        public string heroType { get; set; }
        public int livesSaved { get; set; }
        //public abstract int CalcHeroBravery();

        public int CalculatePower()
        {

            return weight * strength;
        }


    }
    
}
