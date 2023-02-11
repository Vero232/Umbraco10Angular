using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Interfaces
{
    public interface ISuperHero : IHero
    {
        string superPower { get; set; }
    }
}
