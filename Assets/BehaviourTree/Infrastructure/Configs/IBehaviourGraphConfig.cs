using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourGraphConfig
    {
        IBehaviourStateConfig EnterState { get; }
        IReadOnlyList<IBehaviourStateConfig> States { get; }
    }
}
