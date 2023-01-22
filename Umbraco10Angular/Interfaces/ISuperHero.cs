using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    public interface ISuperHero : IHero
    {
        string superPower { get; set; }
    }
}
