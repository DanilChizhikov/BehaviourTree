using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourForkConfig<TEntity> where TEntity : IBehaviourEntity
    {
        IBehaviourPortConfig<TEntity> Port { get; }
        int Weight { get; }
        IReadOnlyList<IBehaviourDecisionConfig<TEntity>> Decisions { get; } 
    }
}