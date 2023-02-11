using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Interfaces
{
    public interface ILeader : IHero
    {
        //void AssignTask();
        void AssignTask(IHero hero, string task);
    }
}
