using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourForkConfig
    {
        IBehaviourPortConfig Port { get; }
        int Weight { get; }
        IReadOnlyList<IBehaviourDecisionConfig> Decisions { get; }
    }
}