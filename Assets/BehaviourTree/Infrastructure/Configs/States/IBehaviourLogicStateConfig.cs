using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourLogicStateConfig
    {
        IReadOnlyList<IBehaviourActionConfig> Actions { get; }
        IReadOnlyList<IBehaviourTransitionConfig> Transitions { get; }
    }
}