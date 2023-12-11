using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourForkState<TEntity> : IBehaviourState<TEntity> where TEntity : IBehaviourEntity
    {
        IReadOnlyList<IBehaviourFork<TEntity>> Forks { get; }
    }
}