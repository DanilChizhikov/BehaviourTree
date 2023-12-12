using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourFork
    {
        IBehaviourPort Port { get; }
        int Weight { get; }
        IReadOnlyList<IBehaviourDecision> Decisions { get; }
    }
}