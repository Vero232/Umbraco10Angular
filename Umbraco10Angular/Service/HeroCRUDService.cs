using Umbraco.Cms.Core.Services;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;
using Umbraco10Angular.Service;

namespace Umbraco10Angular
{
    public class HeroCRUDService<T> : BaseCRUDService<T> where T : class
    {

        public HeroCRUDService(IContentService contentService)
        {

            _contentService = contentService;
        }
    }
}
