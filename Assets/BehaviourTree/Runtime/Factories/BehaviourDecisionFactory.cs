using System;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourDecisionFactory<TDecision, TConfig> : IBehaviourDecisionFactory
            where TDecision : BehaviourDecision<TConfig>
            where TConfig : IBehaviourDecisionConfig
    {
        public Type ServicedType => typeof(TConfig);
        
        public IBehaviourDecision Create(IBehaviourDecisionConfig config)
        {
            if (config is TConfig genericConfig)
            {
                return Create(genericConfig);
            }

            throw new ArgumentOutOfRangeException();
        }

        protected abstract TDecision Create(TConfig config);
    }
}