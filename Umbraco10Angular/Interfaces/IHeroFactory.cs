using Umbraco10Angular.Interfaces;


namespace Umbraco10Angular.DataAccess
{
    public interface IHeroFactory
    {
        public IBaseHero CreateCommonHero();

        public ILeader CreateLeader();

        public ISuperHero CreateSuperHero();

    }
}