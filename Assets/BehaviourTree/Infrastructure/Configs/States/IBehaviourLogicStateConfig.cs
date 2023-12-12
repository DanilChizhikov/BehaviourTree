using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourLogicStateConfig : IBehaviourStateConfig
    {
        IReadOnlyList<IBehaviourActionConfig> Actions { get; }
        IReadOnlyList<IBehaviourTransitionConfig> Transitions { get; }
    }
}