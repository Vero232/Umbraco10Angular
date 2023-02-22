namespace Umbraco10Angular
{
    public static partial class Extensions
    {
        public static T Create<T>(this T hero, Func<T, T> function, T hero2)
        {

            return function(hero2);
        }
    }
}
