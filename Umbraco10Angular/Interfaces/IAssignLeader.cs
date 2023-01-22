using Umbraco10Angular.Interfaces;

namespace Umbraco10Angular.Models
{
    public interface IAssignLeader
    {
        ILeader  Leader { get; set; }

        void AssignLeader(ILeader leader);
    }
}
