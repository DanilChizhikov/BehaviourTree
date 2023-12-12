using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourLogicState : IBehaviourState
    {
        IReadOnlyList<IBehaviourAction> Actions { get; }
        IReadOnlyList<IBehaviourTransition> Transitions { get; }
    }
}