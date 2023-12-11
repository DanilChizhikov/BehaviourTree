using System;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourStateProcessor<TState, TEntity>
            where TState : IBehaviourState<TEntity>
            where TEntity : IBehaviourEntity
    {
        Type ServicedStateType { get; }
        
        TState Processing(TState state, TEntity entity);
    }
}