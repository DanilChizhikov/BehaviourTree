using System;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourActionFactory<TConfig, TEntity>
            where TConfig : IBehaviourActionConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        Type ServicedConfigType { get; }

        IBehaviourAction<TEntity> Create(IBehaviourActionConfig<TEntity> config);
    }
}