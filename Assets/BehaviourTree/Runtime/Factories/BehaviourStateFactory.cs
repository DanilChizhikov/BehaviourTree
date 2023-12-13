using System;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourStateFactory<TState, TConfig> : IBehaviourStateFactory
            where TState : BehaviourState
            where TConfig : IBehaviourStateConfig
    {
        public Type ServicedType => typeof(TConfig);
        
        public IBehaviourState Create(IBehaviourStateConfig config)
        {
            if (config is TConfig genericConfig)
            {
                return Create(genericConfig);
            }

            throw new ArgumentOutOfRangeException();
        }

        protected abstract TState Create(TConfig config);
    }
}