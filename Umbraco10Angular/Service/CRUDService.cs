using System.Text.Json;
using Umbraco.Cms.Core.Services;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Service
{
    public class CRUDService : ICRUD<Hero>
    {
        private IContentService _contentService;


        public CRUDService(IContentService contentService)
        {
            _contentService = contentService;
        }

        public CRUDService()
        {
        }

        public void Create(Hero obj)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();


            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<Hero>>(heroList);

            heroes.Add(obj);

            content.SetValue("heroList", JsonSerializer.Serialize(heroes));

            _contentService.SaveAndPublish(content);

        }

        public void Delete(int Id)
        {
        
        }

        public List<Hero> GetAll()
        {
            var content = _contentService.GetRootContent().FirstOrDefault();

            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<Hero>>(heroList);

            return heroes;


        }

        public void Update(Hero obj)
        {
            throw new NotImplementedException();
        }


    }
}
