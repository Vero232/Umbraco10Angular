using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    public class SuperHero : Hero
    {
        //public override int CalcHeroBravery()
        public int CalcHeroBravery()
        {
            
            return livesSaved + strength;
        }


    }

}
