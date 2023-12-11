using System.Collections.Generic;

namespace MbsCore.BehaviourTree.Infrastructure
{
    public interface IBehaviourGraph<TEntity> where TEntity : IBehaviourEntity
    {
        IBehaviourState<TEntity> EnterState { get; }
        IReadOnlyList<IBehaviourState<TEntity>> States { get; }
    }
}