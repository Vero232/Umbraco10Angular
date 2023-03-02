using System.Text.Json;
using Umbraco.Cms.Core.Services;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.Service
{
    public  class BaseCRUDService<T> : ICRUD<T> where T : class
    {

        public IContentService _contentService;

        public BaseCRUDService()
        {
        }
 

        public  BaseCRUDService(IContentService contentService)
        {
         
            _contentService = contentService;
        }

        public T Create(T obj)
        {
            var content = _contentService.GetRootContent().FirstOrDefault();


            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<T>>(heroList);

            heroes.Add(obj);

            content.SetValue("heroList", JsonSerializer.Serialize(heroes));

            _contentService.SaveAndPublish(content);
            return obj;
        }


        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            var test = new List<T>();


            var content = _contentService.GetRootContent().FirstOrDefault();

            var heroList = content.GetValue("heroList").ToString();

            var heroes = JsonSerializer.Deserialize<List<T>>(heroList);
  
            return heroes;
        }

        public T Update(T obj)
        {
            throw new NotImplementedException();
        }

    }



    //public class CRUDService : ICRUD<Hero>
    //{
     


    //    public void Create(Hero obj)
    //    {
    //        var content = _contentService.GetRootContent().FirstOrDefault();
    //        _contentService.ExtendService();

    //        var heroList = content.GetValue("heroList").ToString();

    //        var heroes = JsonSerializer.Deserialize<List<Hero>>(heroList);

    //        heroes.Add(obj);

    //        content.SetValue("heroList", JsonSerializer.Serialize(heroes));

    //        _contentService.SaveAndPublish(content);

    //    }

    //    public void Delete(int Id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public List<Hero> GetAll()
    //    {
    //        var content = _contentService.GetRootContent().FirstOrDefault();

    //        var heroList = content.GetValue("heroList").ToString();

    //        var heroes = JsonSerializer.Deserialize<List<Hero>>(heroList);

    //        return heroes;
    //    }

    //    public void Update(Hero obj)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
