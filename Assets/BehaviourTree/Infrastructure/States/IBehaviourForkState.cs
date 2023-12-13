using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourForkState
    {
        IReadOnlyList<IBehaviourFork> Forks { get; }
    }
}