using System;
using MbsCore.BehaviourTree.Infrastructure;

namespace MbsCore.BehaviourTree.Runtime
{
    public abstract class BehaviourActionFactory<TAction, TConfig> : IBehaviourActionFactory
            where TAction : BehaviourAction<TConfig>
            where TConfig : IBehaviourActionConfig
    {
        public Type ServicedType => typeof(TConfig);
        
        public IBehaviourAction Create(IBehaviourActionConfig config)
        {
            if (config is TConfig genericConfig)
            {
                return Create(genericConfig);
            }

            throw new ArgumentOutOfRangeException();
        }

        protected abstract TAction Create(TConfig config);
    }
}