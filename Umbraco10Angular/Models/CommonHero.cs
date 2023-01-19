using System.Text.Json;
using System.Text.Json.Serialization;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    public class CommonHero : BaseHero
    {
        public string strength { get; set; }
        public string department { get; set; }

        public void AssignDepartment(string strength)
        {
            switch (strength)
            {
                case "Fast":
                    department = "Police Department";
                    break;
                case "Strong":
                    department = "Fire Department";
                    break;
                default:
                    department = "None";
                    break;
            }
        }
    }

}
