using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourTransition<TEntity> where TEntity : IBehaviourEntity
    {
        IBehaviourPort<TEntity> TruePort { get; }
        IBehaviourPort<TEntity> FalsePort { get; }
        IReadOnlyList<IBehaviourDecision<TEntity>> Decisions { get; }
    }
}