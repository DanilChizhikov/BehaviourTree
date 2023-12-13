using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourTransitionConfig
    {
        IBehaviourPortConfig TruePort { get; }
        IBehaviourPortConfig FalsePort { get; }
        IReadOnlyList<IBehaviourDecisionConfig> Decisions { get; }
    }
}