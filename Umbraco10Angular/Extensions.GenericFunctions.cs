using Umbraco10Angular.Models;
using static Umbraco10Angular.Delegates.FilterDelegates;
using static Umbraco10Angular.Models.Hero;

namespace Umbraco10Angular
{
    public static partial class Extensions
    {
        public static T Create<T>(this T hero, Func<T, T> function)
        {
         
            return function(hero);
        }

        public static List<T> FilterHeroByName<T>(this List<T> heroList, Func<string, List<T>> filter, string heroName)
        {
            var items = filter?.Invoke(heroName);
            return items;

        }

    
        public static List<T> FilterHeroByName2<T>(this List<T> heroList, HeroFilterDelegate<T> filter, string heroName)
        {
            var items = filter?.Invoke(heroName);
            return items;
        }
    }
}
