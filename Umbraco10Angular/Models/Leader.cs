using System.Text.Json;
using System.Text.Json.Serialization;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    //OCP - Leader Extends BaseHero  
    public class Leader : BaseHero, ILeader
    {
      
        public void AssignTask(IHero hero, string task)
        {
            hero.Task = task;
        }
    }
}
