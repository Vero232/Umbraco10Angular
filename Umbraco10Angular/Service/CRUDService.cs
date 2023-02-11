using System.Text.Json;
using Umbraco.Cms.Core.Services;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Service
{
    public class CRUDService : ICRUD<CommonHero>
    {
        private IContentService _contentService;


        public CRUDService(IContentService contentService)
        {
            _contentService = contentService;
        }

        public void Create(CommonHero obj)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();


            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<CommonHero>>(heroList);

            heroes.Add(obj);

            content.SetValue("heroList", JsonSerializer.Serialize(heroes));

            _contentService.SaveAndPublish(content);

        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public CommonHero ReadAll()
        {
            throw new NotImplementedException();
        }

        public void Update(CommonHero obj)
        {
            throw new NotImplementedException();
        }
    }
}
