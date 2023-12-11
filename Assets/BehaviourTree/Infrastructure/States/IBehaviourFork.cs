using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourFork<TEntity> where TEntity : IBehaviourEntity
    {
        IBehaviourPort<TEntity> Port { get; }
        int Weight { get; }
        IReadOnlyList<IBehaviourDecision<TEntity>> Decisions { get; }
    }
}