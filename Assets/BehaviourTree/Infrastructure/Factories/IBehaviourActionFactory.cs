using System;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourActionFactory<TConfig> where TConfig : IBehaviourActionConfig
    {
        Type ServicedConfigType { get; }

        IBehaviourAction Create(IBehaviourActionConfig config);
    }
}