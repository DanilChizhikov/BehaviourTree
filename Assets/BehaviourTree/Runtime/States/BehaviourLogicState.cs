using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourLogicState : BehaviourState, IBehaviourLogicState
    {
        public IReadOnlyList<IBehaviourAction> Actions { get; set; }
        public IReadOnlyList<IBehaviourTransition> Transitions { get; set; }
    }
}