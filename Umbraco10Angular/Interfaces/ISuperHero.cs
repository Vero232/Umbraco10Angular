using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Interfaces
{
    public interface ISuperHero : IBaseHero
    {
        string superPower { get; set; }
    }
}
