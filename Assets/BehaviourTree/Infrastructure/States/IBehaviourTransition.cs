using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourTransition
    {
        IBehaviourPort TruePort { get; }
        IBehaviourPort FalsePort { get; }
        IReadOnlyList<IBehaviourDecision> Decisions { get; }
    }
}