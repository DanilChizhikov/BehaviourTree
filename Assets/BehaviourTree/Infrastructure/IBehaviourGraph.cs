using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourGraph
    {
        IBehaviourState EnterState { get; }
        IReadOnlyList<IBehaviourState> States { get; }
    }
}