using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourLogicState : BehaviourState
    {
        public IReadOnlyList<IBehaviourAction> Actions { get; set; }
        public IReadOnlyList<BehaviourTransition> Transitions { get; set; }
    }
}