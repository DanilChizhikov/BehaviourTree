using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourLogicState<TEntity> : IBehaviourState<TEntity>
            where TEntity : IBehaviourEntity
    {
        IReadOnlyList<IBehaviourAction<TEntity>> Actions { get; }
        IReadOnlyList<IBehaviourTransition<TEntity>> Transitions { get; }
    }
}