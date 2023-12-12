using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourForkState : BehaviourState
    {
        public IReadOnlyList<BehaviourFork> Forks { get; set; }
    }
}