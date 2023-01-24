using System.Text.Json;
using Umbraco.Cms.Core.Models;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    //Low Level - depending on abstraction(IGetHeroesDataAccess)
    // implement details that will depend on the IGetHeroesDataAccess interface. 
    public class GetHeroesDataAccess : IGetHeroesDataAccess
    {
        
      
        public List<IHero> GetAllHeroes(IContent content)
        {
            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<IHero>>(heroList);


            return heroes;
        }



    }
}
