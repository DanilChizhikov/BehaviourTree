using System;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourDecisionFactory<TConfig> where TConfig : IBehaviourDecisionConfig
    {
        Type ServicedConfigType { get; }

        IBehaviourDecision Create(IBehaviourDecisionConfig config);
    }
}