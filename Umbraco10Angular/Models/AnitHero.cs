using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    public class AntiHero : Hero 
    {


        public int selfishness { get; set; }

       // public override int CalcHeroBravery()
        public int CalcHeroBravery()
        {

            return strength - selfishness;
        }

    }
    
}
