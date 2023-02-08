using Umbraco10Angular.Interfaces;
using Umbraco10Angular.Models;

namespace Umbraco10Angular.DataAccess
{
    public interface IHeroFactory
    {
        public CommonHero CreateCommonHero();

        public ILeader CreateLeader();

        public ISuperHero CreateSuperHero();

    }
}