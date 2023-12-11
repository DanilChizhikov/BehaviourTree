using System;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourDecisionFactory<TConfig, TEntity>
            where TConfig : IBehaviourDecisionConfig<TEntity>
            where TEntity : IBehaviourEntity
    {
        Type ServicedConfigType { get; }

        IBehaviourDecision<TEntity> Create(IBehaviourDecisionConfig<TEntity> config);
    }
}