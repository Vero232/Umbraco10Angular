using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    public interface ILeader : IHero
    {
        //void AssignTask();
        void AssignTask(IHero hero, string task);
    }
}
