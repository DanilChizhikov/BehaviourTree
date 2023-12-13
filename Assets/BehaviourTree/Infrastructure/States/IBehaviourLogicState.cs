using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourLogicState
    {
        IReadOnlyList<IBehaviourAction> Actions { get; }
        IReadOnlyList<IBehaviourTransition> Transitions { get; }
    }
}