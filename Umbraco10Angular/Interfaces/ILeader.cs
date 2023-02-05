using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Interfaces
{
    public interface ILeader : IBaseHero
    {
        //void AssignTask();
        void AssignTask(IBaseHero hero, string task);
    }
}
