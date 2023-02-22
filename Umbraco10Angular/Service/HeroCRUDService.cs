using Umbraco.Cms.Core.Services;
using Umbraco10Angular.Models;
using Umbraco10Angular.Service;

namespace Umbraco10Angular
{
    public class HeroCRUDService : BaseCRUDService<Hero>
    {

        public HeroCRUDService(IContentService contentService)
        {

            _contentService = contentService;
        }
    }
}
