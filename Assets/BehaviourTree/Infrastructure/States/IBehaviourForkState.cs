using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourForkState : IBehaviourState
    {
        IReadOnlyList<IBehaviourFork> Forks { get; }
    }
}