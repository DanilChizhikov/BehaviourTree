using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourTransitionConfig<TEntity> where TEntity : IBehaviourEntity
    {
        IBehaviourPortConfig<TEntity> TruePort { get; }
        IBehaviourPortConfig<TEntity> FalsePort { get; }
        IReadOnlyList<IBehaviourDecisionConfig<TEntity>> Decisions { get; }
    }
}