using System.Collections.Generic;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourForkState : BehaviourState, IBehaviourForkState
    {
        public IReadOnlyList<IBehaviourFork> Forks { get; set; }
    }
}