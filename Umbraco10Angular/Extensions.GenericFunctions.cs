using System.Linq;
using System.Linq.Expressions;
using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;
using static Umbraco10Angular.Delegates.FilterDelegates;


namespace Umbraco10Angular
{
    public static partial class Extensions
    {
        public static T Create<T>(this T hero, Func<T, T> function)
        {
         
            return function(hero);
        }

        public static List<T> FilterHeroByName<T>(this List<T> heroList, Func<string, List<T>> filter, string heroName) where T : IHero
        {
            var items = filter?.Invoke(heroName);

            return items;

        }

        public static List<T> FilterHeroes<T>(this List<T> heroList, Func<T, bool> filter) where T : IHero
        {
      
            var filteredHeroes = heroList.Where(filter).ToList();

            return filteredHeroes;

        }

        public static List<T> FilterHeroByName2<T>(this List<T> heroList, HeroFilterDelegate<T> filter, string heroName) where T : IHero
        {
            var items = filter?.Invoke(heroName);
            return items;
        }
    }
}
